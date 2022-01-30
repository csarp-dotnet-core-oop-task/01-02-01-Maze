using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyak_01_02_01_Maze.Tests
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
                Assert.Fail("Player osztály konstruktora kivételt dob!\n"+e.Message);
            }
        }

        [TestMethod()]
        public void ToConsoleTest()
        {
            string expected = "";
            string actual = "somthing";
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                expected = "Játékos Jani:(0;0)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                actual = sw.ToString();
               
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!\n" + e.Message);
            }
            Assert.AreEqual(expected, actual, "A Plyayer->ToConsole függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void MoveSouthTest()
        {
            string expected = "";
            string actual = "somthing";
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(0;-1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveSouth();
                p.ToConsole();

                actual = sw.ToString();                
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!\n" + e.Message);
            }
            Assert.AreEqual(expected, actual, "A Plyayer->MoveSouth függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void MoveNorthTest()
        {
            string expected = "";
            string actual = "somthing";
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                 expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(0;1)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveNorth();
                p.ToConsole();

                 actual = sw.ToString();
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!\n" + e.Message);
            }
            Assert.AreEqual(expected, actual, "A Plyayer->MoveNorth függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void MoveWestTest()
        {
            string expected = "";
            string actual = "somthing";
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(-1;0)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveWest();       
                p.ToConsole();

                actual = sw.ToString();
               
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!\n" + e.Message);
            }
            Assert.AreEqual(expected, actual, "A Plyayer->MoveWest függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void MoveEastTest()
        {
            string expected = "";
            string actual = "somthing";
            try
            {
                Player p = new Player("Játékos Jani", 0, 0);
                 expected = "Játékos Jani:(0;0)\r\nJátékos Jani:(1;0)\r\n";

                StringWriter sw = new StringWriter();
                Console.SetOut(sw);
                p.ToConsole();
                p.MoveEast();
                p.ToConsole();

                actual = sw.ToString();
                
            }
            catch (Exception e)
            {
                Assert.Fail("Player osztály kivételt dob!\n" + e.Message);
            }
            Assert.AreEqual(expected, actual, "A Plyayer->MoveEast függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}