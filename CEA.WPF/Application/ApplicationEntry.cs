using System;
using System.Reflection;
using CEA.WPF.Window;

namespace CEA.WPF;

static class ApplicationEntry
  {
  static private ApplicationSingleInstance app;
  static private WindowMain mainWindow;

  [STAThread]
  static void Main()
    {
    app = new ApplicationSingleInstance();
    mainWindow = new WindowMain
      {
      Title = "CEA v" + Assembly.GetExecutingAssembly().GetName().Version.ToString()
      // DataContext = CEA.WPF.Data.ApplicationDataLayer.DataXML;
      };
    
    app.Run(mainWindow);
    }
  }
