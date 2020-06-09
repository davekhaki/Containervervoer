using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Models
{
    public class Row
    {
        public List<Container> Containers { get; } = new List<Container>();

        public int Weight { get; private set; }
        public int Height { get; }

        public Row(int height)
        {
            Height = height;
        }
        private bool CheckWeight(int weight)
        {
            // 150000 because containers can weigh 30 and have 120 more ontop
            if (!(Weight + weight <= 150000)) return false; 
            else Weight = Weight + weight;
            return true;
        }

        public bool TryToAddContainer(Container model)
        {
            // if weight isnt compatible, return false
            if (!CheckWeight(model.Weight)) return false;

            //if a valuable is already in the row, return false 
            if (model.Type == Container.ContainerType.Valuable && Containers.Find(c => c.GetType() == typeof(Container.ContainerType.valuable))) return false; 

            //adds the given container to the list for this row
            Containers.Add(model);
            return true;
        }
    }
}
