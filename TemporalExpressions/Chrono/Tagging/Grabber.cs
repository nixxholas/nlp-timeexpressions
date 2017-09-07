﻿using System;
namespace TemporalExpressions.Chrono
{
    public class Grabber : Tag<Grabber.Type>
    {
        public enum Type
        {
            This,
            Next,
            Last
        }

        public Grabber(Type value) : base(value)
        {
        }
    }
}
