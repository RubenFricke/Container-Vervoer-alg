using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ContainerVervoerClassLibrary.Models;

namespace ContainerVervoerClassLibrary.Interfaces
{
    interface IContainerSorter
    {
        void SortContainers(List<Container> containers, Ship ship);
    }
}
