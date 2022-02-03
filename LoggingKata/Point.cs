namespace LoggingKata
{
    public struct Point
    {
        public Point(double latitude, double longitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}