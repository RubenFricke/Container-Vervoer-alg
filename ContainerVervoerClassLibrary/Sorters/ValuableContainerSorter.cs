using System;
using ContainerVervoerClassLibrary.Interfaces;
using ContainerVervoerClassLibrary.Models;
using System.Collections.Generic;
using System.Linq;
using Container = ContainerVervoerClassLibrary.Models.Container;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerClassLibrary.Sorters
{
    class ValuableContainerSorter : IContainerSorter
    {
        public void SortContainers(List<Container> containers, Ship ship)
        {
            var valuableContainers = containers
                .Where(c => c.Type == Type.Valuable)
                .OrderByDescending(c => c.Weight);

            int height = 0;
            int length = 0;
            bool skipNextRow = false;

            foreach (var valuableContainer in valuableContainers)
            {
                int width = ship.GetNextPlace(length, height, valuableContainer);
                while (width == -1)
                {
                    if (length == ship.Dimensions.Length - 1)
                    {
                        length = 0;
                        height += 1;
                    }
                    else
                    {
                        if (skipNextRow == true && length != ship.Dimensions.Length - 2)
                        {
                            length += 2;
                        }
                        else
                        {
                            length += 1;
                        }
                    }

                    width = ship.GetNextPlace(length, height, valuableContainer);
                }

                //last row
                if (length == ship.Dimensions.Length - 1)
                {
                    if (skipNextRow == false)
                    {
                        ship.Containers[length, width, height] = valuableContainer;
                    }
                    else
                    {
                        if (ship.Containers[length-1, width, height].Type != Type.Valuable)
                        {
                            ship.Containers[length, width, height] = valuableContainer;
                        }
                        else
                        {
                            int widthFromOtherSide = ship.GetNextPlace(length, height, valuableContainer);
                            if (ship.Containers[length - 1, widthFromOtherSide, height].Type != Type.Valuable)
                            {
                                ship.Containers[length, width, height] = valuableContainer;
                            }
                            else
                            {
                                throw new ArgumentException($"There is not enough space for the {valuableContainer.Type} containers");
                            }
                        }
                    }
                }
                else
                {
                    if (ship.Containers[length - 1, width, height] != null)
                    {
                        skipNextRow = true;
                    }
                    else
                    {
                        skipNextRow = false;
                    }

                    ship.Containers[length, width, height] = valuableContainer;
                }


            }















            //foreach (var valuableContainer in valuableContainers)
            //{
            //    int width = ship.GetNextPlace(length, height, valuableContainer);
            //    //als er niks gevonden is....
            //    while (width == -1)
            //    {
            //        //als selectie in laatste rij staat ga dan naar volgende verdieping
            //        if (length >= ship.Dimensions.Length - 1)
            //        {
            //            length = 0;
            //            height++;
            //        }
            //        //als we niet in de laatste rij zijn, dan moeten we naar de volgende lengte gaan
            //        else
            //        {
            //            //als we skiprow op true hebben gezet, sla dan de volgende rij over
            //            //behalve als we naar de laatste rij moeten gaan
            //            if (skipNextRow == true && length != ship.Dimensions.Length - 2)
            //            {
            //                length += 2;
            //            }
            //            //dus als we naar de laatste rij gaan, of skip row is false,
            //            //ga dan één rij naar benden.
            //            else
            //            {
            //                length += 1;
            //            }
            //        }

            //        //zoek vervolgens in deze nieuwe rij een nieuwe plaats
            //        width = ship.GetNextPlace(length, height, valuableContainer);

            //        //als er een lege vrije plek is gevonden
            //        //als we ons bevinden is de laatste rij:
            //        if (length >= ship.Dimensions.Length - 1)
            //        {
            //            //als er op de vrijeplek géén container voor staat die valuable is
            //            //dan mag de container er worden neergezet

            //            //note: als lengte 1 is, kan dit voor probleme nzorgen omdat lengte - 1 niet bestaat?
            //            if (ship.Containers[length - 1, width, height].Type != Type.Valuable)
            //            {
            //                ship.Containers[length, width, height] = valuableContainer;
            //            }
            //            else
            //            {
            //                int widthOtherSide = ship.GetNextPlace(length, height, valuableContainer);
            //                if (ship.Containers[length - 1, widthOtherSide, height].Type != Type.Valuable)
            //                {
            //                    ship.Containers[length, widthOtherSide, height] = valuableContainer;
            //                }

            //            }
            //        }
            //        //als we ons niet bevinden in de laatste rij:
            //        else
            //        {
            //            //als er een container achter staat, dan moet skiprow op true worden
            //            //gezet zodat de volgende keer de rij overslagen wordt
            //            if (ship.Containers[Math.Max(0, length - 1), width, height] != null)
            //            {
            //                skipNextRow = true;
            //            }
                        
            //            //plaats de container op de plek
            //            ship.Containers[length, width, height] = valuableContainer;
            //        }


            //        if ((length >= ship.Dimensions.Length - 1 && skipNextRow==false)
            //        /*|| (length >= ship.Dimensions.Length -2 && skipNextRow==true)*/)
            //        {
            //            length = 0;
            //            height++;
            //        }
            //        else
            //        {
            //            if (skipNextRow == true && length != ship.Dimensions.Length-1)
            //            {
            //                length += 2;
            //            }
            //            else if(skipNextRow == false)
            //            {
            //                length++;
            //            }

            //            skipNextRow = false;
            //        }

            //        width = ship.GetNextPlace(length, height, valuableContainer);
            //    }

            //    if (length + 1 >= ship.Dimensions.Length)
            //    {
            //        if (ship.Containers[length - 1, width, height].Type != Type.Valuable)
            //        {
            //            ship.Containers[length, width, height] = valuableContainer;
            //        }
            //        else
            //        {
            //            int otherside = ship.GetNextPlace(length, height, valuableContainer);
            //            if (ship.Containers[length - 1, otherside, height].Type != Type.Valuable)
            //            {
            //                ship.Containers[length, otherside, height] = valuableContainer;
            //                continue;
            //            }
            //            else
            //            {
            //                length++;
            //            }

            //        }
            //    }

            //    if (ship.Containers[Math.Max(0, length-1),width,height] != null)
            //    {
            //        skipNextRow = true;
            //    }

            //    ship.Containers[length, width, height] = valuableContainer;
            //}
        }
    }
}
