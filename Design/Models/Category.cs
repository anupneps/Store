using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{

    public class Category
    {
        public int Id { get; init; }
        public string Name { get; set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return ($"Id: {Id}, Name: {Name}");
        }
    }
}
