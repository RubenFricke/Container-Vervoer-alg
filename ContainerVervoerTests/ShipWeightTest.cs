using ContainerVervoerClassLibrary;
using ContainerVervoerClassLibrary.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerTests
{
    public class ShipWeightTest
    {
        [Test]
        public void WeightIsLessThan50Percent_ThrowsArgumentException()
        {
            // Arrange
            int shipLenght = 3;
            int shipWidth = 3;
            int shipHeight = 1;

            Ship ship = new Ship(shipLenght,shipWidth,shipHeight);
            Container container = new Container(5000, Type.Standard);

            List<Container> unsortedContainers = new List<Container>();

            for (int i = 0; i < shipLenght*shipWidth*shipHeight; i++)
            {
                unsortedContainers.Add(container);
            }

            ShipFiller filler = new ShipFiller(ship);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => filler.SortContainers(unsortedContainers));
        }
    }
}