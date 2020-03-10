using System;

namespace ComPort.Models
{
    public class Result
    {

        public DateTime DateTime { get; set; }

        public string Name { get; set; }
        public string Pilot { get; set; }
        public string Razgon1 { get; set; }
        public string Razgon2 { get; set; }
        public string Razgon3 { get; set; }

        public double RequiredLoad { get; set; }
        public double WeightLoad { get; set; }
        public double PosLoad { get; set; }
        public double RP { get; set; }
        public double FP { get; set; }
        public double Weight { get; set; }
    }
}
