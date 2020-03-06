﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCFirstApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
       
        public int Age { get; set; }


    }

    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        {
            Database.SetInitializer<EmpDBContext>(null);

        }
        public DbSet<Employee> Employees { get; set; }
    }
}