using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Baglantı adresinin tanımlandığı class

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //veritabanını baglama
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5HVC58C\\SQLEXPRESS;database=CoreBlogDb;integrated security=true;");
        }
    }
}
