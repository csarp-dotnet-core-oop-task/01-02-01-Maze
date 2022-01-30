using System;

namespace gyak_01_02_01_Maze
{
    public class Player
    {
        /// <summary>
        /// Játékos neve
        /// </summary>
        private string name;
        /// <summary>
        /// Játékos x koordinátája
        /// </summary>
        private int x;
        /// <summary>
        /// Játékos y koordinátája
        /// </summary>
        private int y;

        /// <summary>
        /// konstruktor
        /// </summary>
        /// <param name="name">Játékos neve</param>
        /// <param name="x">Játékos x koordinátája</param>
        /// <param name="x">Játélos y koordiátája</param>
        public Player(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Mozgás lefele
        /// </summary>
        public void MoveSouth()
        {
            y = y - 1;
        }

        /// <summary>
        /// Mozgás felfele
        /// </summary>
        public void MoveNorth()
        {
            y = y + 1;
        }

        /// <summary>
        /// Mozgás balra metódusa
        /// </summary>
        public void MoveWest()
        {
            x = x - 1;
        }


        /// <summary>
        /// Mozgás jobbra metódusa
        /// </summary>
        public void MoveEast()
        {
            x = x + 1;
        }

        /// <summary>
        /// Adatok kiírása a képernyőre
        /// </summary>
        /// 
        public void ToConsole()
        {
            Console.WriteLine(name + ":(" + x + ";" + y + ")");
        }
    }


    class Program
    {
        
            static void Main(string[] args)
        {
            Player john = new Player("Játékos Jani", 2, 1);
            Player ester = new Player("Elveszett Eszter", -1, 2);

            john.ToConsole();
            john.MoveSouth();
            john.MoveWest();
            john.MoveWest();
            john.ToConsole();

            ester.ToConsole();
            ester.MoveEast();
            ester.MoveSouth();
            ester.MoveSouth();
            ester.ToConsole();

        }
    }
}
