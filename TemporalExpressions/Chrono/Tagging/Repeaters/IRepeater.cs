using System;
namespace TemporalExpressions.Chrono.Tagging.Repeaters
{
    public interface IRepeater : ITag
    {
        /// <summary>
        /// Returns the width (in seconds or months) of this repeatable.
        /// </summary>
        int GetWidth();

        Span GetNextSpan(Pointer.Type pointer);
        Span GetCurrentSpan(Pointer.Type pointer);
        Span GetOffset(Span span, int amount, Pointer.Type pointer);
    }
}
