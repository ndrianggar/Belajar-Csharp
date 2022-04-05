using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication_.Net_Framework.Data
{
    public class WebApplication_Net_FrameworkContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication_Net_FrameworkContext() : base("name=WebApplication_Net_FrameworkContext")
        {
        }

        public System.Data.Entity.DbSet<WebApplication_.Net_Framework.Models.Anggota> Anggotas { get; set; }
    }
}
