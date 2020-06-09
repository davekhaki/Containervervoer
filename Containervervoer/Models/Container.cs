using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Models
{
    public class Container
    {
        public enum ContainerType
        {
            Normal,
            Valuable,
            Cooled
        }

        public ContainerType Type;
        public int Weight { set; get; }

        public Container(ContainerType type, int weight)
        {
            Weight = weight;
            Type = type;
        }

        public override string ToString()
        {
            return $"Type: {Type}, Weight: {Weight}.";
        }
    }
}
