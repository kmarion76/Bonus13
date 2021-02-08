using System;


namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameCharacters = new GameCharacter[5];


            gameCharacters[0] = new Warrior("Kevin", 100, 100, "Bazooka");
            gameCharacters[1] = new Warrior("Jasmine", 100, 100, "Crossbow");
            gameCharacters[2] = new Wizard("Joe", 100, 100, 100, 90);
            gameCharacters[3] = new Wizard("Kristy", 100, 100, 100, 10);
            gameCharacters[4] = new Wizard("Jason", 100, 100, 100, 14);

            foreach (var character in gameCharacters)
            {
                character.Play();
            }
        


        }
    }
}

