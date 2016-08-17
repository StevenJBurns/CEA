using System;
using System.Windows.Forms;
using CEA.WindowsForms.UI;

namespace CEA.WindowsForms
  {
  static class CEA
    {
    /// <summary>/// The main entry point for the application./// </summary>
    [STAThread]
    static void Main()
      {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormMain());
      }
    }
 }
