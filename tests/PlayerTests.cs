using Microsoft.VisualStudio.TestTools.UnitTesting;
using _01_02_01_Maze;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_01_Maze.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void PlayerTest()
        {
            try
            {
                Player p = new Player("János", 0, 0);
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály konstruktora kivételt dob!");
            }
        }

        [TestMethod()]
        public void ToConsoleTest()
        {
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                string expected = "Játékos Jani:(0;0)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                string actual = sw.ToString();

                Assert.AreEqual(expected, actual, "A Plyayer->ToConsole függvény nem a megfelelő szöveget írja a képernyőre!");
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!");
            }
        }

        [TestMethod()]
        public void MoveSouthTest()
        {
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                string expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(0;-1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveSouth();
                p.ToConsole();

                string actual = sw.ToString();
                Assert.AreEqual(expected, actual, "A Plyayer->MoveSouth függvény nem a megfelelő szöveget írja a képernyőre!");
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!");
            }
        }

        [TestMethod()]
        public void MoveNorthTest()
        {
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                string expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(0;1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveNorth();
                p.ToConsole();

                string actual = sw.ToString();
                Assert.AreEqual(expected, actual, "A Plyayer->MoveNorth függvény nem a megfelelő szöveget írja a képernyőre!");
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!");
            }
        }

        [TestMethod()]
        public void MoveWestTest()
        {
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                string expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(-1;0)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveWest();
                p.ToConsole();

                string actual = sw.ToString();
                Assert.AreEqual(expected, actual, "A Plyayer->MoveWest függvény nem a megfelelő szöveget írja a képernyőre!");
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!");
            }
        }

        [TestMethod()]
        public void MoveEastTest()
        {
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                string expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(1;0)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveEast();
                p.ToConsole();

                string actual = sw.ToString();
                Assert.AreEqual(expected, actual, "A Plyayer->MoveEast függvény nem a megfelelő szöveget írja a képernyőre!");
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!");
            }
        }

    }
}