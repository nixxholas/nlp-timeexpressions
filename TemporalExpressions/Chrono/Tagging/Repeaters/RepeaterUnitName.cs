using System;
namespace TemporalExpressions.Chrono.Tagging.Repeaters
{
    public abstract class RepeaterUnitName : Repeater<UnitName>
    {
        protected RepeaterUnitName(UnitName value) : base(value)
        {
        }
    }
}
