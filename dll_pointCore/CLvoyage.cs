namespace dll_pointCore;

public class CLvoyage
{
    private List<CLpoint> _points;
    
    public List<CLpoint> Points
    {
        get => _points;
    }
    
    public CLvoyage()
    {
        _points = new List<CLpoint>();
    }
    
    public CLvoyage(List<CLpoint> points)
    {
        _points = points;
    }
    
    /// <summary>
    /// Permit to add a CLpoint (voyage)
    /// </summary>
    /// <param name="point"></param>
    public void addPoint(CLpoint point)
    {
        _points.Add(point);
    }
    
    /// <summary>
    /// Permit to remove a CLpoint (voyage)
    /// </summary>
    /// <param name="point"></param>
    public void delPoint(CLpoint point)
    {
        _points.Remove(point);
    }
    public void delPoint(int id)
    {
        _points.RemoveAt(id);
    }

    
    /// <summary>
    /// calculate and return the distance of a collection of CLpoint
    /// </summary>
    /// <returns></returns>
    public double distanceVoyage()
    {
        double distance = 0;
        for (int i = 0; i < _points.Count - 1; i++)
        {
            double x = _points[i+1].X - _points[i].X;
            double y = _points[i + 1].Y - _points[i].Y;

            double paramX = x * x;
            double paramY = y * y;

            distance += System.Math.Sqrt(paramX + paramY);
        }
        return distance;
    }

    public void pointMove(int id)
    {
        this.Points[id].X = Points[id].X + 1;
        this.Points[id].Y = Points[id].Y + 1;
    }
}