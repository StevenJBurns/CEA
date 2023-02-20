using System;

namespace CEA.Application
{
  class ApplicationEntry
  {
    [STAThread]
    static void Main()
    {
      ApplicationCEA app;
      ApplicationSingleInstance app = new ApplicationSingleInstance();

      app = new ApplicationCEA();
      app.Run(args);
    }
  }
}
