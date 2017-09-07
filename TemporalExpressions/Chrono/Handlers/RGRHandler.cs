using System;
using System.Collections.Generic;

namespace TemporalExpressions.Chrono.Handlers
{
    public class RGRHandler : IHandler
    {
        public Span Handle(IList<Token> tokens, Options options)
        {
            var ddTokens = tokens.DealiasAndDisambiguateTimes(options);
            return ddTokens.GetAnchor(options);
        }
    }
}
