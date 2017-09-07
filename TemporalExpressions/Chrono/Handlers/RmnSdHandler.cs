using System.Linq;
using System.Collections.Generic;
using TemporalExpressions.Chrono.Tagging.Repeaters;

namespace TemporalExpressions.Chrono.Handlers
{
    public class RmnSdHandler : IHandler
    {        
        public Span Handle(IList<Token> tokens, Options options)
        {
            var month = tokens[0].GetTag<RepeaterMonthName>();
            var day = (int)tokens[1].GetTag<ScalarDay>().Value;

            var now = options.Clock();
            if (Time.IsMonthOverflow(now.Year, (int)month.Value, day))
            {
                return null;
            }
            return Utils.HandleMD(month, day, tokens.Skip(2).ToList(), options);
        }
    }
}
