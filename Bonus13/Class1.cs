using Bonus13;
using System;

using System.Text;

namespace Bonus13
{
    public class GameCharacter
    {
        public GameCharacter(string Name, int strength, int intelligence)
        {
            _name = Name;
            _strength = strength;
            _intelligece = intelligence;
        }

        public string _name { get; set; }
        public int _strength { get; }
        public int _intelligece { get; }

        public GameCharacter(){}


        public  virtual void Play()
        {
            Console.WriteLine(_name, _strength, _intelligece);
        }
    }
         
        
    

    public class MagicUsingCharacter : GameCharacter
    {
        public MagicUsingCharacter(string Name, int strength, int intelligence, int magicalEnergy) : base(Name, strength, intelligence)
        {
        _magicalEnergy = magicalEnergy;

        }
        
        public int _magicalEnergy { get; }

        public override void Play()
        {
            Console.WriteLine(_name, _strength, _intelligece, _magicalEnergy);
            base.Play();


        }

    }

    public class Wizard : MagicUsingCharacter
    {
        public Wizard(string Name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(Name, strength, intelligence, magicalEnergy)
        {
        _spellNumber = spellNumber;
        }

        public int _spellNumber { get; }

        public override void Play()
        {
            Console.WriteLine("Name: " + _name + ", Strength: " + _strength + ", Intelligence: " + _intelligece + ", Magical Energy: " +  _magicalEnergy + ", Spell Number: " +  _spellNumber);
            Console.WriteLine(" ");
        }
    }

    public class Warrior : GameCharacter
    {
        public Warrior(string Name, int strength, int intelligence, string weaponType) : base(Name, strength, intelligence)
        {
            _weaponType = weaponType;
        }

        public Warrior(){}
        

        public string _weaponType;
        public override void Play()
        {
            Console.WriteLine("Name: " + _name + ", Strength: " +  _strength +  ", Intelligence: " + _intelligece + ", Weapon Type: " + _weaponType);
            Console.WriteLine(" ");
        }
    }
}

