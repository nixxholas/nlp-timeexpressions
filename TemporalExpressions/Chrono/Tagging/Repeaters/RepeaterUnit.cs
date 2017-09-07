using System;
namespace TemporalExpressions.Chrono.Tagging.Repeaters
{
    public abstract class RepeaterUnit : Repeater<UnitName>
    {
        protected RepeaterUnit(UnitName type)
            : base(type)
        {
        }
    }
}
