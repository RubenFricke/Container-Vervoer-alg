using System;
using ContainerVervoerClassLibrary.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ContainerVervoerClassLibrary.Models;

namespace ContainerVervoerClassLibrary
{
    public class ShipFiller
    {
        private readonly Ship ship;
        private readonly List<IContainerSorter> containerSorters = new List<IContainerSorter>();

        public ShipFiller(Ship ship)
        {
            this.ship = ship;
            var loader = new ContainerFillerLoader();
            
            containerSorters.AddRange(loader.LoadAllLoaders());
        }

        public Container[,,] SortContainers(List<Container> unsortedContainers)
        {
            int totalContainerWeight = unsortedContainers.Sum(c => c.Weight);
            if (totalContainerWeight > ship.MaximumWeight)
            {
                throw new ArgumentException($"Ship weight is over maximum weight({ship.MaximumWeight})");

            }
            else if (totalContainerWeight < ship.MinimumWeight)
            {
                throw new ArgumentException($"Ship weight is over minimum weight({ship.MinimumWeight})");
            }

            foreach (var containerSorter in containerSorters)
            {
                containerSorter.SortContainers(unsortedContainers, ship);
            }
            if(Math.Abs(ship.Balance) > 20)
                throw new ArgumentException("Balance is over 20%!");
            
            return ship.Containers;
        }
    }
}
