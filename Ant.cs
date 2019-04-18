using System;

namespace DiggersAndFliers{
    public class Ant : DigandLiveContainer, IDigandLiveInGround
    {
        public string Name {get; set;}
        public int DigDepth {get; set;}
        public string Species {get; set;}
        public int GroundSpeed {get; set;}
    }
}