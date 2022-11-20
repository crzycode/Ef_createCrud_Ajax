using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ef_createCrud_Ajax.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("connection")
        {

        }
        public DataContext Create()
        {
            return new DataContext();
        }
        public DbSet<Products> products { get; set; }
    }
}