namespace Lab_3_task_3
{
    public class Road
    {
        public double Length { get; }
        public double Width { get; }
        public int Lanes { get; }
        public int TrafficLevel { get; }

        public Road(double length, double width, int lanes, int trafficLevel)
        {
            Length = length;
            Width = width;
            Lanes = lanes;
            TrafficLevel = trafficLevel;
        }
    }
}