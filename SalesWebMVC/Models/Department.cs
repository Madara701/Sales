using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Saller> Sallers { get; set; }  = new List<Saller>();

        public Department() {
        }

        public Department(int id, string name) {
            Id = id;
            Name = name;
        }

        public void AddSaller(Saller saller) {

            Sallers.Add(saller);

        }

        public double TotalSales(DateTime initial, DateTime final) {

            return Sallers.Sum(x => x.TotalSales(initial,final));

        }
    }
}
