namespace Abbyy.AnalysisService.Test
{
	partial class AnalysisForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this._sourceFilePathEdit = new System.Windows.Forms.TextBox();
			this._selectSourceFileButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this._timeoutEdit = new System.Windows.Forms.TextBox();
			this._openResultButton = new System.Windows.Forms.Button();
			this._checkResultTimer = new System.Windows.Forms.Timer(this.components);
			this._analyseButton = new System.Windows.Forms.Button();
			this._analysisMarkupLangsCombo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this._analysisLangsCombo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._sourceTextEdit = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Исходный файл:";
			// 
			// _sourceFilePathEdit
			// 
			this._sourceFilePathEdit.Location = new System.Drawing.Point(15, 25);
			this._sourceFilePathEdit.Name = "_sourceFilePathEdit";
			this._sourceFilePathEdit.Size = new System.Drawing.Size(250, 20);
			this._sourceFilePathEdit.TabIndex = 1;
			this._sourceFilePathEdit.TextChanged += new System.EventHandler(this.sourceFilePathEdit_TextChanged);
			// 
			// _selectSourceFileButton
			// 
			this._selectSourceFileButton.Location = new System.Drawing.Point(271, 23);
			this._selectSourceFileButton.Name = "_selectSourceFileButton";
			this._selectSourceFileButton.Size = new System.Drawing.Size(76, 23);
			this._selectSourceFileButton.TabIndex = 2;
			this._selectSourceFileButton.Text = "Выбрать";
			this._selectSourceFileButton.UseVisualStyleBackColor = true;
			this._selectSourceFileButton.Click += new System.EventHandler(this.selectSourceFile_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Таймаут (в секундах):";
			// 
			// _timeoutEdit
			// 
			this._timeoutEdit.Location = new System.Drawing.Point(129, 126);
			this._timeoutEdit.Name = "_timeoutEdit";
			this._timeoutEdit.Size = new System.Drawing.Size(154, 20);
			this._timeoutEdit.TabIndex = 6;
			this._timeoutEdit.TabStop = false;
			this._timeoutEdit.Text = "100";
			// 
			// _openResultButton
			// 
			this._openResultButton.Location = new System.Drawing.Point(207, 210);
			this._openResultButton.Name = "_openResultButton";
			this._openResultButton.Size = new System.Drawing.Size(140, 23);
			this._openResultButton.TabIndex = 17;
			this._openResultButton.Text = "Открыть результат";
			this._openResultButton.UseVisualStyleBackColor = true;
			this._openResultButton.Click += new System.EventHandler(this.openResult_Click);
			// 
			// _checkResultTimer
			// 
			this._checkResultTimer.Interval = 1000;
			this._checkResultTimer.Tick += new System.EventHandler(this.checkResultTimer_Tick);
			// 
			// _analyseButton
			// 
			this._analyseButton.Location = new System.Drawing.Point(12, 212);
			this._analyseButton.Name = "_analyseButton";
			this._analyseButton.Size = new System.Drawing.Size(129, 23);
			this._analyseButton.TabIndex = 16;
			this._analyseButton.Text = "Проанализировать";
			this._analyseButton.UseVisualStyleBackColor = true;
			this._analyseButton.Click += new System.EventHandler(this.analyseButton_Click);
			// 
			// _analysisMarkupLangsCombo
			// 
			this._analysisMarkupLangsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._analysisMarkupLangsCombo.FormattingEnabled = true;
			this._analysisMarkupLangsCombo.Location = new System.Drawing.Point(108, 183);
			this._analysisMarkupLangsCombo.Name = "_analysisMarkupLangsCombo";
			this._analysisMarkupLangsCombo.Size = new System.Drawing.Size(239, 21);
			this._analysisMarkupLangsCombo.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Язык разметки:";
			// 
			// _analysisLangsCombo
			// 
			this._analysisLangsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._analysisLangsCombo.FormattingEnabled = true;
			this._analysisLangsCombo.Location = new System.Drawing.Point(108, 156);
			this._analysisLangsCombo.Name = "_analysisLangsCombo";
			this._analysisLangsCombo.Size = new System.Drawing.Size(239, 21);
			this._analysisLangsCombo.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 159);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Язык документа:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Исходный текст:";
			// 
			// _sourceTextEdit
			// 
			this._sourceTextEdit.AcceptsReturn = true;
			this._sourceTextEdit.Location = new System.Drawing.Point(15, 67);
			this._sourceTextEdit.Multiline = true;
			this._sourceTextEdit.Name = "_sourceTextEdit";
			this._sourceTextEdit.Size = new System.Drawing.Size(332, 53);
			this._sourceTextEdit.TabIndex = 4;
			this._sourceTextEdit.TextChanged += new System.EventHandler(this.sourceTextEdit_TextChanged);
			// 
			// AnalysisForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 247);
			this.Controls.Add(this._analyseButton);
			this.Controls.Add(this._sourceTextEdit);
			this.Controls.Add(this._analysisMarkupLangsCombo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this._analysisLangsCombo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this._openResultButton);
			this.Controls.Add(this._timeoutEdit);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._selectSourceFileButton);
			this.Controls.Add(this._sourceFilePathEdit);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AnalysisForm";
			this.Text = "ABBYY Analysis Service Test";
			this.Load += new System.EventHandler(this.translationForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _sourceFilePathEdit;
		private System.Windows.Forms.Button _selectSourceFileButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _timeoutEdit;
		private System.Windows.Forms.Button _openResultButton;
		private System.Windows.Forms.Timer _checkResultTimer;
		private System.Windows.Forms.ComboBox _analysisLangsCombo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox _analysisMarkupLangsCombo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button _analyseButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _sourceTextEdit;
	}
}

