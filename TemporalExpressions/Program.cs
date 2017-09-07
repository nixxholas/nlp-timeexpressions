using System;
using TemporalExpressions.Chrono;

namespace TemporalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "";
            Parser ChronoParser = new Parser();

            Console.WriteLine("Hello World!");

			while (true)
			{
				sentence = Console.ReadLine();

				if (sentence != null && sentence != "")
				{
                    if (sentence.Equals("quit")) {
                        break;
                    }
					Span span = ChronoParser.Parse(sentence);

                    Console.WriteLine("Time in computing: ");
					Console.WriteLine(span);
				}
            }
        }
    }
}
