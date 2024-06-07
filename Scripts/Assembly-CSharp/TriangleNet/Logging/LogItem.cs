using System;

namespace TriangleNet.Logging
{
	public class LogItem : ILogItem
	{
		private DateTime time;

		private LogLevel level;

		private string message;

		private string info;

		public DateTime Time => default(DateTime);

		public LogLevel Level => default(LogLevel);

		public string Message => null;

		public string Info => null;

		public LogItem(LogLevel level, string message)
		{
		}

		public LogItem(LogLevel level, string message, string info)
		{
		}
	}
}
