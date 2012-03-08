// Copyright (С) ABBYY (BIT Software), 1993 - 2012. All rights reserved.
// Автор: Мацкевич Степан
// Описание: Тест ComprenoSoap-сервиса.

using System;
using System.Windows.Forms;

namespace Abbyy.AnalysisService.Test
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static int Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AnalysisForm());
			return 0;
		}
	}
}
