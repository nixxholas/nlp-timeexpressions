using System;
using System.Collections.Generic;

namespace TemporalExpressions.Chrono.Handlers
{
    public interface IHandler
    {
        Span Handle(IList<Token> tokens, Options options);
    }
}
