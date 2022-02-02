using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace CoreBookStoreWebAPI.Models
{
    public partial class Book
    {
        [Required(ErrorMessage = "{0} harus diisi.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} tidak boleh lebih {1} dan tidak boleh kurang dari {2} karakter.")]
        public int ISBN { set; get; }


        [Required(ErrorMessage = "{0} harus diisi.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} harus angka")]
        public int CategoryID { set; get; }

        [Required(ErrorMessage = "{0} harus diisi.")]
        public String Title { set; get; }

        public String Photo { set; get; }

        public DateTime PublishDate { set; get; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} harus angka")]
        public double Price { set; get; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "{0} harus angka")]
        public int Quantity { set; get; }
    }
}
