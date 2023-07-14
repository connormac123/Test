using System;

namespace RetroShooter.Upgrade
{
    public class Upgrade
    {
        public string Type { get; set; }
        public int Value { get; set; }
        public int X { get; set;}
        public int Y { get; set;} 

        public Upgrade(string type, int value)
        {
            Type = type;
            Value = value;
        }
    }
}
