// Copyright (С) ABBYY (BIT Software), 1993 - 2012. All rights reserved.
// Автор: Мацкевич Степан
// Описание: Окно теста.

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Abbyy.AnalysisService.Test.AnalysisService;

namespace Abbyy.AnalysisService.Test
{
	internal sealed partial class AnalysisForm : Form
	{
		public AnalysisForm()
		{
			InitializeComponent();
		}

		private void translationForm_Load(object sender, EventArgs g)
		{
			_openResultButton.Enabled = false;
			try
			{
				loadComprenoApi();
			}
			catch (Exception e)
			{
				MessageBox.Show("Error in creating ComprenoSoap wrapper: " + e.Message);
				Close();
				return;
			}
			try
			{
				loadAnalysisLanguages();
				loadAnalysisMarkupLanguages();
			}
			catch (ApplicationException e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void sourceFilePathEdit_TextChanged(object sender, EventArgs e)
		{
			// Текст разрешаем вводить только, если не выбран файл
			_sourceTextEdit.Enabled = _sourceFilePathEdit.TextLength == 0;
		}

		private void sourceTextEdit_TextChanged(object sender, EventArgs e)
		{
			// Файл разрешаем выбрать только при отсутствии текста
			_sourceFilePathEdit.Enabled = _sourceTextEdit.TextLength == 0;
		}

		// Создание COM-объекта, выполняющего перевод
		private void loadComprenoApi()
		{
			_client = new AnalysisServiceClient();
		}

		private void loadAnalysisLanguages()
		{
			string[] languages = null;
			ComprenoErrorInfo errorInfo = _client.Languages(out languages);
			if (errorInfo.Code != ComprenoErrorCode.Success)
				throw new ApplicationException("Error in Languages method: " + errorInfo.Message);

			_analysisLangsCombo.Items.Add(_autoDetectItem); // Отдельно Автоподбор
			foreach (string language in languages)
				_analysisLangsCombo.Items.Add(language);
			_analysisLangsCombo.SelectedIndex = 0;
		}

		private void loadAnalysisMarkupLanguages()
		{
			string[] languages = null;
			ComprenoErrorInfo errorInfo = _client.MarkupLanguages(out languages);
			if (errorInfo.Code != ComprenoErrorCode.Success)
				throw new ApplicationException("Error in MarkupLanguages method: " + errorInfo.Message);

			foreach (string language in languages)
				_analysisMarkupLangsCombo.Items.Add(language);
			_analysisMarkupLangsCombo.SelectedIndex = 0;
		}

		private void selectSourceFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			// Фильтр можно расширить
			dialog.Filter = "*.txt|*.txt|*.doc|*.doc|*.rtf|*.rtf|All files|*.*";
			dialog.ShowDialog();
			_sourceFilePathEdit.Text = dialog.FileName;
		}

		private void analyseButton_Click(object sender, EventArgs e)
		{
			_openResultButton.Enabled = false;
			_analyseButton.Enabled = false;
			try
			{
				createTask();
				sendSource();
				setAnalysisTaskParams();
				startTaskProcessing();
			}
			catch (ApplicationException exception)
			{
				_currentTaskId = "";
				_analyseButton.Enabled = true;
				MessageBox.Show(exception.Message);
			}
		}

		// Создать задачу и сделать ее текущей
		private void createTask()
		{
			// Создадим задание
			ComprenoErrorInfo errorInfo = _client.CreateTask(out _currentTaskId, null);
			if (errorInfo.Code != ComprenoErrorCode.Success)
				throw new ApplicationException("Error in CreateTask method: " + errorInfo.Message);
		}

		// Отправить исходный текст
		private void sendSource()
		{
			bool isFileSelected = _sourceFilePathEdit.Enabled && _sourceFilePathEdit.TextLength > 0;
			FileContainer source = new FileContainer();
			// Прочтем файл, либо возьмем содержимое edit-бокса
			source.Extension = isFileSelected ? Path.GetExtension(_sourceFilePathEdit.Text) : ".txt";
			if (isFileSelected)
				source.Contents = File.ReadAllBytes(_sourceFilePathEdit.Text);
			else
			{
				List<byte> bytes = new List<byte>(System.Text.Encoding.Unicode.GetPreamble());
				bytes.AddRange(System.Text.Encoding.Unicode.GetBytes(_sourceTextEdit.Text));
				source.Contents = bytes.ToArray();
			}
			ComprenoErrorInfo errorInfo = _client.SetTaskSource(_currentTaskId, source);
			if (errorInfo.Code != ComprenoErrorCode.Success)
				throw new ApplicationException("Error in SetTastSource method: " + errorInfo.Message);
		}

		// Установить параметры анализа
		private void setAnalysisTaskParams()
		{
			string sourceLanguage = _analysisLangsCombo.SelectedItem.ToString();
			if (sourceLanguage == _autoDetectItem)
				sourceLanguage = "";
			string markupLanguage = _analysisMarkupLangsCombo.SelectedItem.ToString();
			string[] xmlParameters = { "All" };
			ComprenoErrorInfo errorInfo = _client.SetTaskParams(_currentTaskId, sourceLanguage,
				markupLanguage, xmlParameters);
			if (errorInfo.Code != ComprenoErrorCode.Success)
				throw new ApplicationException("Error in SetTaskParams method: " + errorInfo.Message);
		}

		// Запустить обработку
		private void startTaskProcessing()
		{
			ComprenoErrorInfo errorInfo = _client.ProcessTask(_currentTaskId, Convert.ToInt32(_timeoutEdit.Text) * 1000);
			if (errorInfo.Code != ComprenoErrorCode.Success)
				throw new ApplicationException("Error in ProcessTask method: " + errorInfo.Message);

			// Будем проверять результат каждую секунду
			_checkResultTimer.Enabled = true;
		}

		private void checkResultTimer_Tick(object sender, EventArgs e)
		{
			TaskState taskState = TaskState.NotLoaded;
			int percent = 0;
			string errorDescription;
			ComprenoErrorInfo errorInfo = _client.GetTaskState(out taskState, out percent, out errorDescription,
				_currentTaskId);
			if (errorInfo.Code != ComprenoErrorCode.Success)
			{
				MessageBox.Show("Error in GetTaskState method: " + errorInfo.Message);
				_checkResultTimer.Enabled = false;
				_analyseButton.Enabled = true;
				return;
			}
			if (taskState == TaskState.ProcessingSuccessfull || taskState == TaskState.ProcessingFailed)
				onTaskComplete(taskState, errorDescription);
		}
		
		// Обработчик события "Задание выполнено"
		private void onTaskComplete(TaskState taskState, string errorDescription)
		{
			_checkResultTimer.Enabled = false;
			_openResultButton.Enabled = taskState == TaskState.ProcessingSuccessfull;
			MessageBox.Show(taskState == TaskState.ProcessingSuccessfull ? "Task completed successfully." :
				"An error occured while processing: " + errorDescription);
			_analyseButton.Enabled = true;
		}

		private void openResult_Click(object sender, EventArgs g)
		{
			FileContainer result;
			ComprenoErrorInfo errorInfo = _client.GetTaskResult(out result, _currentTaskId);
			if (errorInfo.Code != ComprenoErrorCode.Success)
			{
				MessageBox.Show("Error in GetTaskResult method: " + errorInfo.Message);
				return;
			}

			// Создадим временный файл
			string path = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetTempFileName()) + result.Extension);
			File.WriteAllBytes(path, result.Contents);

			System.Diagnostics.Process proc = new System.Diagnostics.Process();
			proc.EnableRaisingEvents = false;
			proc.StartInfo.FileName = "iexplore";
			proc.StartInfo.Arguments = path;
			proc.Start();
		}

		// ----------------------------------------------------------------------------------------------

		private const string _autoDetectItem = "AutoDetect";
		private AnalysisServiceClient _client = null; // Soap-клиент
		private string _currentTaskId; // Id текущего задания
	}
}
