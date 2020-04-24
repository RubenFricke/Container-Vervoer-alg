using System;
using System.Collections.Generic;
using ContainerVervoerClassLibrary;
using ContainerVervoerClassLibrary.Models;
using NUnit.Framework;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerTests
{
    public class BalanceTest
    {
        [Test]
        public void BalanceExceedsMaximum_ThrowsArgumentException()
        {
            // Arrange
            int shipLength = 1;
            int shipWidth = 2;
            int shipHeight = 1;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container c15000 = new Container(15000, Type.Standard);
            Container c30000 = new Container(30000, Type.Standard);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(c15000);
            unsortedStandardContainers.Add(c30000);

            ShipFiller filler = new ShipFiller(ship);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => filler.SortContainers(unsortedStandardContainers));
        }

        [Test]
        public void CorrectBalance_DoesNotThrowException()
        {
            // Arrange
            int shipLength = 2;
            int shipWidth = 1;
            int shipHeight = 1;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container container = new Container(15000, Type.Standard);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(container);
            unsortedStandardContainers.Add(container);

            ShipFiller filler = new ShipFiller(ship);

            // Act
            // Assert
            Assert.DoesNotThrow(() => filler.SortContainers(unsortedStandardContainers));
        }
    }
}