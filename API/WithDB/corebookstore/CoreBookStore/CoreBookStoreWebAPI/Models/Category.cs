using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CoreBookStoreWebAPI.Models
{
    public partial class Category
    {
        [Required(ErrorMessage = "{0} harus diisi.")]
        public int CategoryID { set; get; }

        [Required(ErrorMessage = "{0} harus diisi")]
        [StringLength(256, ErrorMessage ="{0}   tidak boleh lebih dari {1} karakter ")]
    
        public String Name { get; set; }
    }
}
