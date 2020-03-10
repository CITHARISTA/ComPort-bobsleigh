using System;

namespace ComPort.Models
{
    public class Sportsman
    {
        public DateTime DateTime { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Team { get; set; }
        public double Weight { get; set; }
        public double WeightOnLeg { get; set; }
        public double WeightOnBody { get; set; }
        public int Height { get; set; }
    }
}
