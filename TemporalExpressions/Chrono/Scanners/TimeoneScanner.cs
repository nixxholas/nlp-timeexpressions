using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TemporalExpressions.Chrono.Scanners
{
	public class TimezoneScanner : ITokenScanner
	{
		static readonly Regex[] Patterns = new Regex[]
			{
				@"[PMCE][DS]T|UTC".Compile(),
				@"(tzminus)?\d{2}:?\d{2}".Compile(),
			};

		public IList<Token> Scan(IList<Token> tokens, Options options)
		{
			tokens.ForEach(ApplyTags);
			return tokens;
		}

		static void ApplyTags(Token token)
		{
			Patterns.ForEach(pattern =>
				{
					var match = pattern.Match(token.Value);
					if (match.Success)
					{
						token.Tag(new Timezone(match.Value));
					}
				});
		}

		public override string ToString()
		{
			return "timezone";
		}
	}
}
