using System;
using System.Collections.Generic;
using System.Linq;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerClassLibrary.Models
{
    public class Ship
    {
        private bool findNextPlaceFromLeft = false;

        public Ship(int length, int width, int heigth)
        {
            Dimensions = new Dimensions(length, width, heigth);
            Containers = new Container[length, width, heigth];
            MaximumWeight = calculateMaximumWeight();
            MinimumWeight = calculateMinimumWeight();
        }

        public Dimensions Dimensions { get; set; }
        public Container[,,] Containers { get; set; }
        public int MinimumWeight { get; private set; }
        public int MaximumWeight { get; private set; }

        public double Balance
        {
            get { return calculateBalance(); }
        }

        private int calculateMaximumWeight()
        {
            int maximumWeightBottomRow = Dimensions.Length * Dimensions.Width * Container.MaxWeight;
            int maximumWeightAboveBottomRow = Math.Min(
                Dimensions.Length * Dimensions.Width * Container.MaxWeight * Dimensions.Heigth - 1,
                Dimensions.Length * Dimensions.Width * Container.MaxWeightAbove);
            int maximumWeight = maximumWeightAboveBottomRow + maximumWeightBottomRow;
            return maximumWeight;
        }

        private int calculateMinimumWeight()
        {
            int minimumWeight = Convert.ToInt32(Math.Ceiling((double) MaximumWeight / 2));
            return minimumWeight;
        }

        private int calculateSpaceForCooledContainers()
        {
            int totalCooledContainers = Dimensions.Width * Dimensions.Heigth;
            return totalCooledContainers;
        }

        private double calculateBalance()
        {
            int weightLeft = 0, weigthRight = 0, weightTotal = 0;

            for (int length = 0; length < Dimensions.Length; length++)
            {
                for (int height = 0; height < Dimensions.Heigth; height++)
                {
                    for (int width = 0; width < Dimensions.Width; width++)
                    {
                        if (Containers[length, width, height] != null)
                        {
                            if (width < Dimensions.Width / 2)
                            {
                                weightLeft += Containers[length, width, height].Weight;
                            }else if(width >= Dimensions.Width && Dimensions.Width % 2 == 0 || width > Dimensions.Width / 2)
                            {
                                weigthRight += Containers[length, width, height].Weight;
                            }

                            weightTotal += Containers[length, width, height].Weight;
                        }
                    }
                }
            }

            float balance = (float)(weightLeft - weigthRight) / weightTotal * 100;
            return balance;
        }

        public int GetNextPlace(int length, int heigth, Container container)
        {
            findNextPlaceFromLeft = !findNextPlaceFromLeft;
            if(heigth >= Dimensions.Heigth)
                throw new ArgumentException($"There is not enough space for the {container.Type} containers");
            if (findNextPlaceFromLeft)
            {
                for (int x = 0; x < Dimensions.Width; x++)
                {
                    if (Containers[length, x, heigth] == null && CanWeightPlaceHere(length, x, heigth, container))
                    {
                        return x;
                    }
                }
            }
            else
            {
                for (int x = Dimensions.Width - 1; x >= 0; x--)
                {
                    if (Containers[length, x, heigth] == null && CanWeightPlaceHere(length, x, heigth, container))
                    {
                        return x;
                    }
                }
            }
            findNextPlaceFromLeft = !findNextPlaceFromLeft;
            return -1;
        }

        private bool CanWeightPlaceHere(int length, int width, int heigth, Container container)
        {
            List<Container> containersBelow = new List<Container>();
            for (int h = 1; h < heigth; h++)
            {
                containersBelow.Add(Containers[length, width, h]);
            }

            return heigth==0 ||
                   containersBelow.Sum(c => c.Weight) + container.Weight <= Container.MaxWeightAbove && 
                   containersBelow.FirstOrDefault(c => c.Type == Type.Valuable) == null;
        }
    }
}
