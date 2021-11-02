﻿using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context; //readonly - para previnir que a dependencia não possa ser alterada

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll() //Operação sincrona- a aplicação fica bloqueada até a ação termina
        {
            return _context.Department.OrderBy(x => x.Name).ToList();

        }
    }
}
