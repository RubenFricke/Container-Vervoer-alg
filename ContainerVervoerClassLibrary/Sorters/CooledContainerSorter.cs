using ContainerVervoerClassLibrary.Interfaces;
using ContainerVervoerClassLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerClassLibrary
{
    public class CooledContainerSorter : IContainerSorter
    {
        public void SortContainers(List<Container> containers, Ship ship)
        {
            var cooledContainers = containers
                .Where(c => c.Type == Type.Cooled)
                .OrderByDescending(c => c.Weight)
                .ToList();

            int height = 0;

            foreach (var cooledContainer in cooledContainers)
            {
                int width = ship.GetNextPlace(0, height, cooledContainer);
                while (width == -1)
                {
                    height++;
                    width = ship.GetNextPlace(0, height, cooledContainer);
                }

                ship.Containers[0, width, height] = cooledContainer;
            }
        }
    }
}
