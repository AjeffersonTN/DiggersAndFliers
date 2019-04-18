using System;

namespace DiggersAndFliers
{
    public class Gerbil : MoveOnGroundContainer, IMoveAndLiveOnGround
    {
        public string Name {get; set;}
        public int GroundSpeed {get; set;}
        public string Species {get; set;}
    }
}