using System;
namespace TemporalExpressions.Chrono.Tagging.Repeaters
{
    public class IllegalStateException : Exception
    {
        public IllegalStateException(string message) 
            : base(message)
        {
            
        }
    }
}
