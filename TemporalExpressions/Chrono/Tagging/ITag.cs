using System;
namespace TemporalExpressions.Chrono
{
    public interface ITag
    {
        DateTime? Now { get; set; }
        object RawValue { get; }
    }
}
