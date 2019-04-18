using System;

namespace DiggersAndFliers
{
    public class BettaFish : SwimContainer, ISwim
    {
        public string Name {get; set;}
        public int SwimSpeed {get; set;}
        public string Species {get; set;}
    }
}