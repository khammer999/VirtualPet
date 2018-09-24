using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {   /// fields

        private string petName ="null";
        private string species = "null";
        private int hunger = 10;
        private int thirst = 10;
        private int waste = 10;
        private int boredom = 10;
        private int sickness = 0;
        private int play = 0;

        // properties

        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public string Species
        {
            get { return this.species; }
            set { this.species = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        public int Sickness
        {
            get { return this.sickness; }
            set { this.sickness = value; }
        }

        public int Play
        {
            get { return this.play; }
            set { this.play = value; }
        }


        // Constructors

        public VirtualPet()
        {
            //default
        }

        public VirtualPet(string species)
        {
            this.PetName = petName;
            this.Species = species;
        }

        public VirtualPet(string petName, string species)
        {
            this.PetName = petName;
            this.Species = species;
        }

        //  Methods

        public void Food()
        {
            this.Hunger--;
            this.Sickness++;

        }
        public void Food(int food)
        {
            this.Hunger = food;
            this.Thirst =food;
        }

        public void Water()
        {
            this.Thirst++;
            this.sickness++;

        }
        public void Water(int water)
        {
            this.Thirst = water;

        }

        public void PlayTime()
        {
            this.Boredom--;
            this.Play++;
        }

        public void PlayTime(int play)
        {
            this.Boredom = play;
            this.Play = play;
        }


        public void Tick() // inserts the spoiler factor sets internal fields using random
        {
           
            Random spoiler = new Random();
            int spoilerFactor =  spoiler.Next(1,51);
            this.Food(spoilerFactor+3);
            this.Water(spoilerFactor-1);
            this.PlayTime(spoilerFactor+2);

            Console.Write("You've been Ticked");

        }












    }
}
