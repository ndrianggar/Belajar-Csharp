using System;
using System.Collections.Generic;
//untuk menambahkan [anotaion]
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBookStoreWebAPI.Models
{
    public partial class Author
    {
        [Required(ErrorMessage = "{0} harus diisi.")]
        public int AuthorID { set; get; }
        [Required(ErrorMessage = "{0} harus diisi.")]
        [StringLength(256, ErrorMessage = "{0} tidak boleh lebih {1} karakter")]

        public String Name { get; set; }
        [Required(ErrorMessage = "{0} harus diisi. ")]
        [StringLength(256, ErrorMessage = "{0} tidak boleh lebih {1} Karakter.")]


        [RegularExpression(@" ^([a - zA - Z0 - 9_\.\-]) +\@(([a - zA - Z0 - 9\-]) +\.)+([a - zA - Z0 - 9]{2,4})+$", ErrorMessage = "{0}tidak valid.")]
        public String Email { set; get; }
    }
}
