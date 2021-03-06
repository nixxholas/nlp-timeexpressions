﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace TemporalExpressions.Chrono.Handlers
{
    public class ORGRHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var outerSpan = tokens.Skip(2).Take(2).GetAnchor(options);
            return Utils.HandleORR(tokens.Take(2).ToList(), outerSpan, options);
        }
    }
}
