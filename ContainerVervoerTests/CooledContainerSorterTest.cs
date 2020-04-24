using System;
using System.Collections.Generic;
using ContainerVervoerClassLibrary;
using ContainerVervoerClassLibrary.Models;
using NUnit.Framework;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerTests
{
    public class CooledContainerSorterTest
    {
        [Test]
        public void CorrectInput_SortsCooledContainers()
        {
            // Arrange
            int shipLength = 1;
            int shipWidth = 2;
            int shipHeight = 1;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container container = new Container(15000, Type.Cooled);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(container);
            unsortedStandardContainers.Add(container);

            ShipFiller filler = new ShipFiller(ship);

            // Act
            var output = filler.SortContainers(unsortedStandardContainers);

            // Assert
            Assert.That(output[0,0,0], Is.EqualTo(container));
            Assert.That(output[0,1,0], Is.EqualTo(container));
        }

        [Test]
        public void NotEnoughSpaceForContainers_ThrowsArgumentException()
        {
            // Arrange
            int shipLength = 2;
            int shipWidth = 1;
            int shipHeight = 1;

            Ship ship = new Ship(shipLength, shipWidth, shipHeight);
            Container container = new Container(15000, Type.Cooled);

            List<Container> unsortedStandardContainers = new List<Container>();
            unsortedStandardContainers.Add(container);
            unsortedStandardContainers.Add(container);

            ShipFiller filler = new ShipFiller(ship);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => filler.SortContainers(unsortedStandardContainers));
        }
    }
}