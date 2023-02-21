namespace LocationProximityExample;

public class Marker : Label
{
    private MarkerMediator mediator;

    private Point mouseDownLocation;

    internal void SetMediator(MarkerMediator mediator)
    {
        this.mediator = mediator;
    }

    public Marker()
    {
        this.Text = "{Drag Me}";
        this.TextAlign = ContentAlignment.MiddleCenter;
        this.AutoSize = true;
        this.MouseDown += Marker_MouseDown;
        this.MouseMove += Marker_MouseMove;
    }

    private void Marker_MouseDown(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            this.mouseDownLocation = e.Location;
        }
    }

    private void Marker_MouseMove(object? sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            this.Text = this.Location.ToString();
            this.Left = e.X + this.Left - this.mouseDownLocation.X;
            this.Top = e.Y + this.Top - this.mouseDownLocation.Y;
            this.mediator.Send(this.Location, this);
        }
    }

    public void ReceiveLocation(Point location)
    {
        var distance = CalculateDistance(location);
            
        switch (distance)
        {
            case < 100 when this.BackColor != Color.Red:
                this.BackColor = Color.Red;
                break;
            case >= 100 when this.BackColor != Color.Green:
                this.BackColor = Color.Green;
                break;
        }

        double CalculateDistance(Point point) =>
            Math.Sqrt(Math.Pow(point.X - this.Location.X, 2) + Math.Pow(point.Y - this.Location.Y, 2));
    }
}