using System;
using System.Collections.Generic;

namespace DiggersAndFliers{
    public class AnimalLover
    {
        public string Name { get; set; }

        /*created listed for each type of digger and lier to hold them if necessary. Also created a list for each container to hold various animals during cleaning */
        public List<Ant> Ants { get; set; } = new List<Ant>();
        public List<BettaFish> BettaFishs { get; set; } = new List<BettaFish>();
        public List<CopperheadSnake> CopperheadSnakes { get; set; } = new List<CopperheadSnake>();
        public List<Earthworm> Earthworms { get; set; } = new List<Earthworm>();
        public List<Finch> Finches { get; set; } = new List<Finch>();
        public List<Gerbil> Gerbils { get; set; } = new List<Gerbil>();
        public List<Mice> Mices { get; set; } = new List<Mice>();
        public List<Parakeet> Parakeets { get; set; } = new List<Parakeet>();
        public List<Terrapin> Terrapins { get; set; } = new List<Terrapin>();
        public List<TimberRattlesnake> TimberRattlesnakes { get; set; } = new List<TimberRattlesnake>();


        //create Animal Lover
        // AnimalLover AntoniosAnimals = new AnimalLover
        // {
        //     Name = "Antonio"
        // };


        //created public list method to bring like animals togther...create public list method that contains the list

    }
}
