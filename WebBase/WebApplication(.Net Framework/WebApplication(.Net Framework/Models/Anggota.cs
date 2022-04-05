using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_.Net_Framework.Models
{
    public class Anggota
    {
        public int AnggotaId { get; set; }
        
        [Display(Name="Nama Anggota")]
        public string NamaAnggota { get; set; }

        [Display(Name = "Umur")]
        public int Umur { get; set; }

        [Display(Name = "Alamat")]
        public string Alamat { get; set; }
        
        [Display(Name = "No Telp")]
        public string NoTelp { get; set; }
    }
}