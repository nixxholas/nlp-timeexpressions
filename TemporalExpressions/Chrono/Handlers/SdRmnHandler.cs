using System.Linq;
using System.Collections.Generic;
using TemporalExpressions.Chrono.Tagging.Repeaters;

namespace TemporalExpressions.Chrono.Handlers
{
	public class SdRmnHandler : IHandler
	{
		public Span Handle(IList<Token> tokens, Options options)
		{
			var month = tokens[1].GetTag<RepeaterMonthName>();
			var day = tokens[0].GetTag<ScalarDay>().Value;
			if (Time.IsMonthOverflow(options.Clock().Year, (int)month.Value, day))
			{
				return null;
			}
			return Utils.HandleMD(month, day, tokens.Skip(2).ToList(), options);
		}
	}
}
