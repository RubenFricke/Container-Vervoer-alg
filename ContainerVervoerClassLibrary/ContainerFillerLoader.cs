using ContainerVervoerClassLibrary.Interfaces;
using System.Collections.Generic;
using ContainerVervoerClassLibrary.Sorters;

namespace ContainerVervoerClassLibrary
{
    class ContainerFillerLoader
    {
        private List<IContainerSorter> loaders = new List<IContainerSorter>();

        public List<IContainerSorter> LoadAllLoaders()
        {
            loaders.Add(new CooledContainerSorter());
            loaders.Add(new StandardContainerSorter());
            loaders.Add(new ValuableContainerSorter());
            return loaders;
        }
    }
}
