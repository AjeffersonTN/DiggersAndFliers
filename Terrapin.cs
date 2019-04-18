using System;

namespace DiggersAndFliers{
    public class Terrapin : MoveOnGroundContainer, IMoveAndLiveOnGround
    {
        public string Name {get; set;}
        public int SwimSpeed {get; set;}
        public string Species {get; set;}
        public int GroundSpeed {get; set;}

    }
}