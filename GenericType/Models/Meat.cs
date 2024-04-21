using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType.Models
{
    public class Meat : Food
    {
        public Type MeatType { get; set; }
    }
    public enum Type
    {
        Beef,
        Chicken,
        Fish
    }
}
