using System;

namespace ComPort.Models
{
    public class Bean
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Team { get; set; }

        public DateTime DateTime { get; set; }

        public double DistanceExis { get; set; }

        public double Weight { get; set; }
        public double FrontRight { get; set; }
        public double FrontLeft { get; set; }
        public double RearRight { get; set; }
        public double RearLeft { get; set; }
        public double FrontLoad { get; set; }
        public double FrontLoadPercent { get; set; }
        public double RearLoad { get; set; }
        public double RearLoadPercent { get; set; }
    }
}
