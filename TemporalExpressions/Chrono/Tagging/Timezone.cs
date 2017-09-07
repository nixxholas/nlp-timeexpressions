using System;
namespace TemporalExpressions.Chrono
{
    public class Timezone : Tag<string>
    {
        public Timezone(string value) : base(value)
        {
        }

        public override string ToString()
        {
            return "timezone";
        }
    }
}
