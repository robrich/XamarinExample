using System;

namespace XamarinPlayground.Lib
{
	public static class TypeHelpers
	{

		public static int? ToIntOrNull(this string source)
		{
			int results = 0;
			if (!int.TryParse(source, out results))
			{
				return null;
			}
			return results;
		}

		public static long? ToLongOrNull(this string source)
		{
			long results = 0;
			if (!long.TryParse(source, out results))
			{
				return null;
			}
			return results;
		}

		public static DateTime? ToDateTimeOrNull(this string source)
		{
			DateTime results;
			if (!DateTime.TryParse(source, out results))
			{
				return null;
			}
			return results;
		}

		public static double? ToDoubleOrNull(this string source)
		{
			double results;
			if (!double.TryParse(source, out results))
			{
				return null;
			}
			return results;
		}

		public static bool? ToBoolOrNull(this string source)
		{
			bool results;
			if (!bool.TryParse(source, out results))
			{
				return null;
			}
			return results;
		}

		public static string ToStringOrNull(this string source)
		{
			string results = null;
			if (!string.IsNullOrEmpty(source))
			{
				results = source;
			}
			return results;
		}

		public static Guid? ToGuidOrNull(this string source)
		{
			Guid results;
			if (!Guid.TryParse((source ?? "").Replace(@"""", ""), out results))
			{
				return null;
			}
			return results;
		}

	}
}
