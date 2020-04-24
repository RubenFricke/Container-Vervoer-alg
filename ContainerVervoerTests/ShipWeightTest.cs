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

        [Test]
        public void CalculateMaxWeight_ReturnsCorrectWeight()
        {
            // Arrange
            int shipLenght = 3;
            int shipWidht = 4;
            int shipHeight = 20;

            Ship ship = new Ship(shipLenght, shipWidht, shipHeight);
            
            // Act
            int maxWeight = ship.MaximumWeight;

            // Assert
            Assert.AreEqual(1800000,maxWeight);
        }

        [Test]
        public void CalculateMinWeight_ReturnsCorrectWeight()
        {
            // Arrange
            int shipLenght = 3;
            int shipWidht = 4;
            int shipHeight = 20;

            Ship ship = new Ship(shipLenght, shipWidht, shipHeight);

            // Act
            int minWeight = ship.MinimumWeight;

            // Assert
            Assert.AreEqual(900000, minWeight);
        }
    }
}