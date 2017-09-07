using System;
using System.Collections.Generic;

namespace TemporalExpressions.Chrono.Scanners
{
    public class SeparatorScanner : ITokenScanner
    {
        static readonly dynamic[] Patterns = new dynamic[]
            {
                new { Pattern = @"^,$".Compile(), Tag = new SeparatorComma() },
                new { Pattern = @"^and$".Compile(), Tag = new SeparatorComma() },
                new { Pattern = @"^(at|@)$".Compile(), Tag = new SeparatorAt() },
                new { Pattern = @"^in$".Compile(), Tag = new SeparatorIn() },
                new { Pattern = @"^/$".Compile(), Tag = new SeparatorDate(Separator.Type.Slash) },
                new { Pattern = @"^-$".Compile(), Tag = new SeparatorDate(Separator.Type.Dash) },
				new { Pattern = @"^on$".Compile(), Tag = new SeparatorOn() },
                //new { Pattern = @"^from$".Compile(), Tag = new SeparatorFrom() },
            };

        public IList<Token> Scan(IList<Token> tokens, Options options)
        {
            tokens.ForEach(ApplyTags);
            return tokens;
        }

        static void ApplyTags(Token token)
        {
            foreach (var pattern in Patterns)
            {
                if (pattern.Pattern.IsMatch(token.Value))
                {
                    token.Tag(pattern.Tag);
                }
            }
        }
    }
}
