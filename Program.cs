using System;
using System.Collections.Generic;

namespace DiggersAndFliers
{
    class Program
    {
        static void Main(string[] args)
        {
            Earthworm LongEarthWorm = new Earthworm();
            Ant StrongAnt = new Ant();

           List<DigandLiveContainer> DigandLiveContainersList = new List<DigandLiveContainer>(){
               LongEarthWorm,
               StrongAnt,
           };
           foreach (DigandLiveContainer animal in DigandLiveContainersList)
           {
               Console.WriteLine("I am in the IN-ground container");
           }

            CopperheadSnake BadSnake = new CopperheadSnake();
            Gerbil LoveGerbil = new Gerbil();
            Mice UglyMice = new Mice();
            Terrapin MyTerrapin = new Terrapin();
            TimberRattlesnake OhThisSnake = new TimberRattlesnake();

           List<MoveOnGroundContainer> MoveOnGroundContainerList = new List<MoveOnGroundContainer>(){
               BadSnake,
               LoveGerbil,
               UglyMice,
               MyTerrapin,
               OhThisSnake,
           };
           foreach (MoveOnGroundContainer animal in MoveOnGroundContainerList)
           {
               Console.WriteLine("I am running around the ground container");
           }
            BettaFish LonelyFish = new BettaFish();

           List<SwimContainer> SwimContainerList = new List<SwimContainer>(){
               LonelyFish,

           };
           foreach (SwimContainer animal in SwimContainerList)
           {
               Console.WriteLine("I am stuck in the swim container");
           }

            Parakeet FlyHigh = new Parakeet();
            Finch FlyFinchFly = new Finch();

           List<FlyContainer> FlyContainerList = new List<FlyContainer>(){
               FlyHigh,
               FlyFinchFly,

           };
           foreach (FlyContainer animal in FlyContainerList)
           {
               Console.WriteLine("I am flying around this cage");
           }

        }
    }
}
/*     List<IMothersDay> mothersdayFlowers = new List<IMothersDay>(){
                pinkRose,
                yellowSunflower
            }; */