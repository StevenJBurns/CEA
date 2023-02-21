using System;

namespace CEA.Application
{
  class ApplicationEntry
  {
    [STAThread]
    public static void Main(String[] args)
    {
      ApplicationSingleInstance app = new ApplicationSingleInstance();
      app.Run(args);
    }
  }
}
