using ContainerVervoerClassLibrary;
using ContainerVervoerClassLibrary.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EasyCooledSorterTest()
        {
            int shipLength = 2;
            int shipWidth = 1;
            int shipHeight = 2;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container c4000 = new Container(4000, Type.Cooled);
            Container c5000 = new Container(5000, Type.Cooled);

            List<Container> unsortedCooledContainers = new List<Container>();
            unsortedCooledContainers.Add(c4000);
            unsortedCooledContainers.Add(c5000);

            Container[,,] expectedOutput = new Container[shipLength, shipWidth, shipHeight];
            expectedOutput[0, 0, 0] = c5000;
            expectedOutput[0, 0, 1] = c4000;

            ShipFiller filler = new ShipFiller(ship);
            var output = filler.SortContainers(unsortedCooledContainers);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void SurplusOfCooledContainers()
        {
            int shipLength = 1;
            int shipWidth = 1;
            int shipHeight = 1;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container c5000 = new Container(5000, Type.Cooled);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(c5000);
            unsortedStandardContainers.Add(c5000);

            ShipFiller filler = new ShipFiller(ship);

            try
            {
                var output = filler.SortContainers(unsortedStandardContainers);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "There is not enough space for the Cooled containers");
            }
        }

        [Test]
        public void EasyStandardSorterTest()
        {
            int shipLength = 2;
            int shipWidth = 2;
            int shipHeight = 2;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container c5000 = new Container(5000, Type.Standard);
            Container c8000 = new Container(weight: 8000, Type.Standard);
            Container c12000 = new Container(12000, Type.Standard);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(c5000);
            unsortedStandardContainers.Add(c5000);
            unsortedStandardContainers.Add(c8000);
            unsortedStandardContainers.Add(c8000);
            unsortedStandardContainers.Add(c12000);
            unsortedStandardContainers.Add(c12000);
            unsortedStandardContainers.Add(c12000);
            unsortedStandardContainers.Add(c12000);

            Container[,,] expectedOutput = new Container[2, 2, 2]
            {
                {
                    {
                        c12000, c8000
                    },
                    {
                        c12000, c8000
                    }
                },
                {
                    {
                        c12000, c5000
                    },
                    {
                        c12000, c5000
                    }
                }
            };

            ShipFiller filler = new ShipFiller(ship);
            var output = filler.SortContainers(unsortedStandardContainers);

            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void SurplusOfStandardContainers()
        {
            int shipLength = 1;
            int shipWidth = 1;
            int shipHeight = 1;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container c5000 = new Container(5000, Type.Standard);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(c5000);
            unsortedStandardContainers.Add(c5000);

            ShipFiller filler = new ShipFiller(ship);

            try
            {
                var output = filler.SortContainers(unsortedStandardContainers);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "There is not enough space for the Standard containers");
            }
        }

        [Test]
        public void BalanceExceedsMaximumTest()
        {
            int shipLengt = 1;
            int shipWidth = 2;
            int shipHeight = 1;

            Ship ship = new Ship(shipLengt, shipWidth, shipHeight);
            Container c4000 = new Container(4000, Type.Standard);
            Container c30000 = new Container(30000, Type.Standard);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(c4000);
            unsortedStandardContainers.Add(c30000);

            ShipFiller filler = new ShipFiller(ship);

            try
            {
                var output = filler.SortContainers(unsortedStandardContainers);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, "Balance is over 20%!");
            }
        }

        [Test]
        public void EasyCoolableValuableStandardContainersTest()
        {
            int shipLength = 3;
            int shipWidth = 3;
            int shipHeight = 1;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container cs = new Container(10000, Type.Standard);
            Container cc = new Container(10000, Type.Cooled);
            Container cv = new Container(10000, Type.Valuable);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(cc);
            unsortedStandardContainers.Add(cc);
            unsortedStandardContainers.Add(cs);
            unsortedStandardContainers.Add(cs);
            unsortedStandardContainers.Add(cv);
            unsortedStandardContainers.Add(cv);
            unsortedStandardContainers.Add(cv);

            Container[,,] expectedOutput = new Container[3,3,1]
            {
                {
                    {
                        cc
                    },
                    {
                        cs
                    },
                    {
                        cc
                    }
                },
                {
                    {
                        cv
                    },
                    {
                        cv
                    },
                    {
                        cs
                    }
                },
                {
                    {
                        cv
                    },
                    {
                        null
                    },
                    {
                        null
                    }
                }
            };

            ShipFiller filler = new ShipFiller(ship);
            var output = filler.SortContainers(unsortedStandardContainers);

            Assert.AreEqual(expectedOutput, output);
        }
    }
}