using System;
using System.Windows;
using System.Reflection;
using Microsoft.VisualBasic.ApplicationServices;

namespace Ara.MeritViewer
  {
  class ApplicationSingleInstance : WindowsFormsApplicationBase
    {
    private Application app;

    public ApplicationSingleInstance()
      { this.IsSingleInstance = true; }

    protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
      {
      app = new Application();

      Ara.MeritViewer.View.WindowMain appwinmain = new Ara.MeritViewer.View.WindowMain();

      appwinmain.Title = "MeritViewer v" + Assembly.GetExecutingAssembly().GetName().Version.ToString();
      //appwinmain.DataContext = Ara.MeritViewer.Data.ApplicationDataLayer.DataXML;

      app.Run(appwinmain);
      return false;
      }

    protected override void OnStartupNextInstance(StartupNextInstanceEventArgs e)
      {
      app.MainWindow.Activate();

      if (app.MainWindow.WindowState == WindowState.Minimized)
        app.MainWindow.WindowState = WindowState.Normal;
      }
    }
  }
