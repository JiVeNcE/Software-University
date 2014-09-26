public struct Location
{
    public double latitude;
    public double longitude;
    private Planet planet;

    public Location(double latitude, double longitude, Planet planet)
        : this()
    {
        this.Planet = planet;
        this.Latitude = latitude;
        this.Longtitude = longitude;
    }

    public double Latitude
    {
        get { return this.latitude; }
        set { this.latitude = value; } 
    }
    public double Longtitude
    {
        get { return this.longitude; }
        set { this.longitude = value; } 
    }
    public Planet Planet
    {
        get { return this.planet; }
        set { this.planet = value; } 
    }

    public override string ToString()
    {
        string galacticGps = string.Format(
        "{0}, {1} - {2}", this.Latitude, this.Longtitude, this.Planet
        );
        return galacticGps;
    }
}