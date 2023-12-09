public class Activity
{
    private DateTime _date;
    private double _duration;
    private string _activity;
    private double _data;
    public Activity(DateTime date, double duration, string activity, double data)
    {
        _date = date;
        _duration = duration;
        _activity = activity;
        _data = data;
    }
    // public double GetData()
    // {
    //     return _data;
    // }
    public string GetActivity()
    {
        return _activity;
    }
    public double GetDuation()
    {
        return _duration;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    { // miles per hour or kilometers per hour
        return 0;
    }
    public virtual double GetPace()
    { // minutes per mile or minutes per kilometer
        return 0;
    }
    public string GetSummary()
    { // produce a string with all the summary information.
        return $"{_date} {GetActivity()} ({_duration}): Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }   // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
}
public class Running : Activity
{
    private double _distance;
    public Running(DateTime date, double duration, string activity, double data) : base(date, duration, activity, data)
    {
        _distance = data;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / GetDuation() * 60;
    }
    public override double GetPace()
    {
        return Math.Round(_distance / GetDuation(), 2);
    }
}
public class Bicycles : Activity
{
    private double _speed; // miles per hour or kilometers per hour
    public Bicycles(DateTime date, double duration, string activity, double data) : base(date, duration, activity, data)
    {
        _speed = data;
    }
    public override double GetDistance()
    {
        return GetPace() * GetDuation();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return Math.Round(_speed / 60, 2);
    }
}
public class Swimming : Activity
{
    private double _numberOfLaps; // minutes per mile or minutes per kilometer
    public Swimming(DateTime date, double duration, string activity, double data) : base(date, duration, activity, data)
    {
        _numberOfLaps = data;
    }
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetDuation() * 60;
    }
    public override double GetPace()
    {
        return Math.Round(GetDistance() / GetDuation(), 2);
    }
}