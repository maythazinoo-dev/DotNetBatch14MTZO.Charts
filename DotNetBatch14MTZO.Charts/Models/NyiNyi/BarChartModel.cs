namespace DotNetBatch14MTZO.Charts.Models.NyiNyi
{
    public class BarChartModel
    {
        public BarChartSeriModel[] Series { get; set; }
    }

    public class BarChartSeriModel
    {
        public string Name { get; set; }
        public BarChartData[] Data { get; set; }
    }

    public class BarChartData
    {
        public string X { get; set; }  
        public int Y { get; set; }     
        public Goal[] Goals { get; set; } 
    }

    public class Goal
    {
        public string Name { get; set; }  
        public int Value { get; set; }    
        public int StrokeWidth { get; set; }  
        public int StrokeHeight { get; set; } 
        public string StrokeColor { get; set; }
        public string StrokeLineCap { get; set; } 
        public int StrokeDashArray { get; set; } 
    }
}
