using System;
using System.Windows;
using System.Reflection;
using CEA.WPF.Window;
using CEA.Application;

namespace CEA.WPF;

class ApplicationSingleInstance : System.Windows.Application
  {
  public ApplicationSingleInstance()
    {
    }

  protected override void OnStartup(StartupEventArgs eventArgs)
    {
    }

/*  protected override void OnStartupNextInstance(StartupEventArgs e)
    {
    app.MainWindow.Activate();

    if (app.MainWindow.WindowState == WindowState.Minimized)
      app.MainWindow.WindowState = WindowState.Normal;
    }*/
  }
