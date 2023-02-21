namespace LocationProximityExample
{
    public class MarkerMediator
    {
        private List<Marker> markers = new();

        public Marker CreateMarker()
        {
            var m = new Marker();
            m.SetMediator(this);
            this.markers.Add(m);
            return m;
        }

        public void Send(Point location, Marker marker)
        {
            foreach (var m in this.markers.Where(w => w!=marker))
            {
                m.ReceiveLocation(location);
            }
        }
    }
}
