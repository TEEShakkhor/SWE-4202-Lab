using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_22._22._2022_
{
    internal class Animal
    {
        public string Name, Habitat, Sound;
        public int Height, Weight,birthyear;

        public Animal(string name, string habitat, string sound, int height, int weight)
        {
            this.Name = name;
            this.Habitat = habitat;
            this.Sound = sound;
            this.Height = height;
            this.Weight = weight;
        }
        public Animal()
        {

        }
        public int get_age()
        {
            return 2021 - birthyear;
        }
        public string get_name()
        {
            return this.Name;
        }
        public string get_habitat()
        { 
            return this.Habitat; 
        }
        public string vocalize()
        {
            return this.Sound;
        }
        public int get_height()
        {
            return this.Height;
        }
        public int get_weight()
        {
            return this.Weight;
        }
        public void get_information()
        {
            string information = this.Name + '\t' + this.Habitat + '\t' + this.Sound + '\t' + this.Height + '\t' + this.Weight;
        }

    }
}
