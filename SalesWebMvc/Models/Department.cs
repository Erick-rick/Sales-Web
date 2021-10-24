using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //Associação de departamento para selles (1 pode possuir varios vendedores)
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name) // não é incluido coleções
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller) 
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final) 
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }


}
