namespace dll_pointCore;

public class CLpoint
{
    private double _x;
    private double _y;
    private static int _idCounter = 0;
    private int _id;

    public double X
    {
        get => _x;
        set => _x = (value >= 0) ? value : 0; 
    }
    public double Y
    {
        get => _y;
        set => _y = (value >=0) ? value : 0;
    }
    public int ID
    {
        get => _id;
    }

    public CLpoint()
    {
        _x = 0;
        _y = 0;
        _id = _idCounter++;
    }
    public CLpoint(double x, double y)
    {
        this._x = x;
        this._y = y;
        _id = _idCounter++;
    }

    /// <summary>
    /// Permits to initialize the counter
    /// </summary>
    private void ini_point()
    {
        _idCounter = 0;
    }
}