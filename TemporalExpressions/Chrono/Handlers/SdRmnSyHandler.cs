﻿using System.Linq;
using System.Collections.Generic;

namespace TemporalExpressions.Chrono.Handlers
{
    public class SdRmnSyHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var monthDayYear = new List<Token> { tokens[1], tokens[0], tokens[2] };
            monthDayYear.AddRange(tokens.Skip(3).ToList());
            return new RmnSdSyHandler().Handle(monthDayYear, options);
        }
    }
}
