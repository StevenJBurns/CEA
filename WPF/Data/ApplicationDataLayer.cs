using System.Xml;
using System.Xml.Linq;
using System.Reflection;

namespace Ara.MeritViewer.Data
	{
	internal static class ApplicationDataLayer
		{
		private static XElement dataXML;
		public static XElement DataXML
			{
			get
				{
				return dataXML;
				}
			}
		
		static ApplicationDataLayer()
			{
			XmlReader xr = XmlReader.Create(Assembly.GetExecutingAssembly().GetManifestResourceStream("Ara.MeritViewer.Data.MeritViewerData.xml"));
			dataXML = XElement.Load(xr);
			}

		}
	
	}
