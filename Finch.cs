using System;

namespace DiggersAndFliers{
    public class Finch : FlyContainer, IFlying
    {
        public string Name {get; set;}
        public int FlyHeight {get; set;}
        public string Species {get; set;}

    }
}