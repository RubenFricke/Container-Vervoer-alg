using System;
using Type = ContainerVervoerClassLibrary.Enums.Type;

namespace ContainerVervoerClassLibrary.Models
{
    public class Container
    {
        public const int MaxWeight = 30000;
        public const int MinWeight = 4000;

        public Container(int weight, Type type)
        {
            if(weight > MaxWeight || weight < MinWeight)
                throw new ArgumentException("Weight must be between 4000 and 30000kg");
            Weight = weight;
            Type = type;
        }

        public int Weight { get; set; }
        public Type Type { get; set; }

        public override string ToString()
        {
            return $"Weight: {Weight}kg, Type: {Type}";
        }
    }
}
