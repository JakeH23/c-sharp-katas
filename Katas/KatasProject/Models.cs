using System;
using System.Collections.Generic;

namespace Katas.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>();
    }

    public class Agent
    {
        public string Name { get; set; }
    }

    public class Note
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
    }

    public class Customer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int HeightCM { get; set; }
    }

    public class Artwork
    {
        public string Desctiption { get; set; }
        public string Artist { get; set; }
        public DateTime submissionTimestamp { get; set; }
    }

    public class Animal
    {
        public string Name { get; set; }
    }

    public class Dog : Animal
    {
        public int Tricks { get; set; }
    }

    public class Cat : Animal
    {
        public int PurrLoudness { get; set; }
    }

    public class Diglett
    {
        public int Level { get; set; }
    }

    public class DugTrio : Diglett
    {

    }

    public class Villager
    {
        public string Name { get; set; }
    }

    public class Hero : Villager
    {
        public string BattleCry { get => $"We will have victory or my name isn't {Name}!"; }
    }

    public class Mage : Villager
    {
        public string BattleCry { get => $"I am {Name} and I cast Fireball!"; }
    }

    public class Druid : Villager
    {
        public string BattleCry { get => $"I, {Name}, call upon the forces of nature!"; }
    }

    
}
