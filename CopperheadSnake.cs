using System;

namespace DiggersAndFliers{
    public class CopperheadSnake : MoveOnGroundContainer, IMoveAndLiveOnGround
    {
        public string Name {get; set;}
        public string Species {get; set;}
        public int GroundSpeed {get; set;}
    }
}