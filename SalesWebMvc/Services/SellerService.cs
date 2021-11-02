using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context; //readonly - para previnir que a dependencia não possa ser alterada
        
        public SellerService (SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() //Operação sincrona- a aplicação fica bloqueada até a ação termina
        {
            return _context.Seller.ToList();

        }

        public void Insert (Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
