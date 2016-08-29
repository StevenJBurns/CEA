using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ZAR.WinForms
	{
	public class SingleInstanceApp : WindowsFormsApplicationBase
		{
		public SingleInstanceApp()
            {
            this.IsSingleInstance = true;
            }

        protected override void OnCreateMainForm()
            {
            this.MainForm = new FormMain();
            }

        [STAThread]
        static void Main(string[] args)
            {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SingleInstanceApp app = new SingleInstanceApp();
            app.Run(args);
            }
		}
	}

