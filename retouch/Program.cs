using System;

using log4net;
using log4net.Config;

namespace retouch
{
	public class Program
	{
		private const string LOG4NET_XML = "log4net.xml";
		private static readonly ILog log = LogManager.GetLogger(typeof(Program));
		
		public static void Main(string[] args)
		{
			//BasicConfigurator.Configure();
			XmlConfigurator.Configure(new System.IO.FileInfo(LOG4NET_XML));
			
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			log.Info("Logger is working.");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int Add(int a, int b)
		{
			return a + b;
		}
	}
}