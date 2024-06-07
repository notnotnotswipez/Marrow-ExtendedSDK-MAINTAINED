using System.Collections.Generic;

namespace TriangleNet.Logging
{
	public interface ILog<T> where T : ILogItem
	{
		IList<T> Data { get; }

		LogLevel Level { get; }

		void Add(T item);

		void Clear();

		void Info(string message);

		void Error(string message, string info);

		void Warning(string message, string info);
	}
}
