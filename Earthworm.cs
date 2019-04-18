using System;

namespace DiggersAndFliers
{
    public class Earthworm : DigandLiveContainer, IDigandLiveInGround
    {
        public int DigDepth { get; set; }
        public string Species { get; set; }
        public string Name { get; set; }

    }
}