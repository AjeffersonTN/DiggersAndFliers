using System;

namespace DiggersAndFliers
{
    public class Mice :MoveOnGroundContainer, IMoveAndLiveOnGround
    {
        public string Name {get; set;}
        public int GroundSpeed {get; set;}
        public string Species {get; set;}
    }
}