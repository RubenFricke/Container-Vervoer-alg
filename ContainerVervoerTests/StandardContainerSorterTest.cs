using System;
using System.Collections.Generic;
using ContainerVervoerClassLibrary;
using ContainerVervoerClassLibrary.Models;
using NUnit.Framework;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerTests
{
    public class StandardContainerSorterTest
    {
        [Test]
        public void CorrectInput_SortsStandardContainersCorrectly()
        {
            // Arrange
            int shipLenght = 3;
            int shipWidth = 3;
            int shipHeight = 1;

            Ship ship = new Ship(shipLenght, shipWidth, shipHeight);
            Container container = new Container(20000, Type.Standard);

            List<Container> unsortedContainers = new List<Container>();

            for (int i = 0; i < shipLenght * shipWidth * shipHeight; i++)
            {
                unsortedContainers.Add(container);
            }

            ShipFiller filler = new ShipFiller(ship);

            Container[,,] expectedOutput = new Container[shipLenght, shipWidth, shipHeight];
            for (int i = 0; i < 9; i++)
            {
                expectedOutput[i % 3, i / 3, 0] = container;
            }

            // Act
            var output = filler.SortContainers(unsortedContainers);

            // Assert
            Assert.AreEqual(expectedOutput, output);
        }

        [Test]
        public void InvalidWeight_ThrowsArgumentException()
        {
            // Arrange
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

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => filler.SortContainers(unsortedCooledContainers));
        }
    }
}