using System;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;

namespace Ara.MeritViewer
  {
  public class EmpireColorConverter : IValueConverter
    {
    private Color empireColor;

    public Color EmpireColor
      {
      get { return empireColor; }
      set { empireColor = value; }
      }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
      switch ((Ara.MeritViewer.Empires)value)
        {
        case Ara.MeritViewer.Empires.NC:
          empireColor =  new Color(){A=255, R=000, B=128, G=000};
          break;
        case Ara.MeritViewer.Empires.TR:
          empireColor =  new Color(){A=255, R=128, B=000, G=000};
          break;
        case Ara.MeritViewer.Empires.VS:
          empireColor = new Color() {A=255, R=128, B=128, G=000};
          break;
        default:
          empireColor = new Color() {A=255, R=128, B=128, G=128};
          break;
        }

      return empireColor;
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        { throw new NotImplementedException(); }
    }
  }