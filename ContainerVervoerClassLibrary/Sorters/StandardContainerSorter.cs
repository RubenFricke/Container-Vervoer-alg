using System.Collections.Generic;
using System.Linq;
using ContainerVervoerClassLibrary.Interfaces;
using ContainerVervoerClassLibrary.Models;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerClassLibrary.Sorters
{
    class StandardContainerSorter : IContainerSorter
    {
        public void SortContainers(List<Container> containers, Ship ship)
        {
            var standardContainers = containers
                .Where(c => c.Type == Type.Standard)
                .OrderByDescending(c => c.Weight)
                .ToList();

            int height = 0, length = 0;

            foreach (var standardContainer in standardContainers)
            {
                int width = ship.GetNextPlace(length, height, standardContainer);
                while (width == -1)
                {
                    if (length >= ship.Dimensions.Length - 1)
                    {
                        length = 0;
                        height++;
                    }
                    else
                    {
                        length++;
                    }

                    width = ship.GetNextPlace(length, height, standardContainer);
                }

                ship.Containers[length, width, height] = standardContainer;
            }
        }
    }
}
