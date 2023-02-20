using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Globalization;

namespace CEA.Application
  {
  public class ImagePathConverter : IValueConverter
    {
    private string pngURL;

    public string PngURL
      {
      get { return pngURL; }
      set { pngURL = value; }
      }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
      pngURL = "Images/" + ((string)value);

      return new BitmapImage(new Uri(pngURL, UriKind.Relative));
      }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      { throw new NotImplementedException(); }
    }
  }