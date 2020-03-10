using System;

namespace ComPort.Models
{
    public class FaktResult
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Team { get; set; }
        public DateTime Date { get; set; }

        public double Weight { get; set; }
        public double WeightF { get; set; }
        public double WeightF_P { get; set; }
        public double WeightB { get; set; }
        public double WeightB_P { get; set; }
        public double DistanceExis { get; set; }
        public double Required { get; set; }
        public double WeightGruz { get; set; }
        public double DistanceGruz { get; set; }
    }
}
