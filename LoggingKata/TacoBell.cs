using System;
namespace LoggingKata
{
    public class TacoBell : ITrackable
    {
        public TacoBell(string name, Point point)
        {
            Name = name;
            Location = point;
        }

        public string Name { get; set; }
        public Point Location { get; set; }
    }
}
