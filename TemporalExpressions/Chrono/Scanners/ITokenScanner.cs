using System;
using System.Collections.Generic;

namespace TemporalExpressions.Chrono.Scanners
{
    public interface ITokenScanner
    {
        IList<Token> Scan(IList<Token> tokens, Options options);
    }
}
