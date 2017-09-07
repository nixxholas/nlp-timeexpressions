using System;
namespace TemporalExpressions.Chrono
{
	public abstract class Tag<T> : ITag
	{
		public DateTime? Now { get; set; }
		public T Value { get; protected set; }
		public object RawValue
		{
			get { return Value; }
		}

		protected Tag(T value)
		{
			Value = value;
		}

	}
}
