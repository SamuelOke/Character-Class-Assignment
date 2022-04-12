using System;

namespace Character_Class_Assignment
{
    public class Character
    {
        string Name;
        string Phrase1;
        string Phrase2;
        int Level = 0;

        public Character(string name, string phrase1, string phrase2)
        {
            Name = name;
            Phrase1 = phrase1;
            Phrase2 = phrase2;
        }

        public void speak(int phraseNum)
        {
            if (phraseNum == 1)
            {
                Console.WriteLine(Phrase1);
            }
            else if (phraseNum == 2)
            {
                Console.WriteLine(Phrase2);
            }
            else
            {
                Console.WriteLine("No Phrase Found.");
            }
        }

        public void stats()
        {
            string name = Name;
            string phrase1 = Phrase1;
            string phrase2 = Phrase2;
            int level = Level;
            Console.WriteLine("Character Stats");
            Console.WriteLine(" ");
            Console.WriteLine("======================="); // Create a fight menu
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Level:" + level);
            Console.WriteLine("Catchphrase 1: " + phrase1);
            Console.WriteLine("Catchphrase 2: " + phrase2);
            Console.WriteLine("=======================");
        }

            public void setLevel(int newLevel)
            {
            Level = newLevel;
            string name = Name;
            Console.WriteLine(name + "'s level is now " + newLevel + ".");
            }

        static void Main(string[] args)
        {
            Character MichaelHong = new Character("Michael Hong", "I love Mai Sakurajima so much mudae please give me her already!", "Darkness is kinda sus but the show is good I swear!");
            Character MrVeldkamp = new Character("Colin Veldkamp", "Sam get off that phone and finish up sorting!", "I think I'll have to make a phone call.");
            MichaelHong.stats();
            Console.WriteLine(" ");
            MrVeldkamp.stats();
            Console.WriteLine(" ");
            MichaelHong.speak(1);
            Console.WriteLine(" ");
            MrVeldkamp.speak(2);
            Console.WriteLine(" ");
            MrVeldkamp.setLevel(2);
            MichaelHong.setLevel(69);

        }
    }
}
    