using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Join_Inner_Join_of_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier("abc", "abc@mail.com","02197600722", "Reg 1" ),
                new Supplier("bca", "bca@mail.com","02197600722", "Reg 2" ),
                new Supplier("cba", "cba@mail.com","02197600722", "Reg 3" ),
                new Supplier("dcd", "dcd@mail.com","02197600722", "Reg 4" ),
                new Supplier("cdd", "cdd@mail.com","02197600722", "Reg 5" ),
                new Supplier("rte", "rte@mail.com","02197600722", "Reg 6" ),
               
            };

            List<Buyyer> buyyers = new List<Buyyer>()
            {
                new Buyyer("fds", "fds@mail.com","02197600722", "Reg 1" ),
                new Buyyer("hrd", "hrd@mail.com","02197600722", "Reg 2" ),
                new Buyyer("ewe", "ewe@mail.com","02197600722", "Reg 3" ),
                new Buyyer("dfd", "dfd@mail.com","02197600722", "Reg 4" ),
                new Buyyer("dfa", "dfa@mail.com","02197600722", "Reg 5" ),
                new Buyyer("rer", "rer@mail.com","02197600722", "Reg 6" ),
            };


            var innerJoin = suppliers.Join(buyyers,
                s => s.District, b => b.District,
                (s, b) => new
                {
                    SuplierName = s.SuplierName,
                    BuyyerName = b.BuyyerName,
                    District = s.District,
                });

            foreach (var item in innerJoin)
            {
                Console.WriteLine($"District: {item.District}, Supplier: {item.SuplierName}, Buyyer: {item.BuyyerName}");
            }

            var compositeJoin = suppliers.Join(buyyers,
                s => new { s.District, s.EmailSupplier },
                b => new {b.District, b.EmailBuyyer},
                (s,b) => new
                {
                    supplierName = s.SuplierName,
                    buyyerNmae = b.BuyyerName,
                    ds = s.District
                }

                );

             
         
                
              
            foreach (var item in compositeJoin)
            {

            }
        }


    }
    internal class Supplier
    {
        private string suplierName;
        private string emailSupplier;
        private string telpSupplier;
        private string district;

        public Supplier(string suplierName, string emailSupplier, string telpSupplier, string district)
        {

            this.SuplierName = suplierName;
            this.EmailSupplier = emailSupplier;
            this.TelpSupplier = telpSupplier;
            this.District = district;
        }


        public string SuplierName
        {
            get
            {
                return this.suplierName;
            }
            set
            {
                this.suplierName = value;
            }
        }

        public string EmailSupplier
        {
            get
            {
                return this.emailSupplier;
            }

            set
            {
                this.emailSupplier = value;
            }
        }

        public string TelpSupplier
        {
            get
            {
                return this.telpSupplier;
            }

            set
            {
                this.telpSupplier = value;
            }
        }

        public string District
        {
            get
            {
                return this.district;
            }

            set
            {
                this.district = value;
            }
        }
    }

    internal class Buyyer
    {
        private string buyyerName;
        private string emailBuyyer;
        private string telpBuyyer;
        private string district;


        public Buyyer(string buyyerName, string emailBuyyer, string telpBuyyer, string district)
        {

            this.BuyyerName = buyyerName;
            this.EmailBuyyer = emailBuyyer;
            this.TelpBuyyer = telpBuyyer;
            this.District = district;
        }

        public string BuyyerName
        {
            get
            {
                return this.buyyerName;
            }
            set
            {
                this.buyyerName = value;
            }
        }

        public string EmailBuyyer
        {
            get
            {
                return this.emailBuyyer;
            }

            set
            {
                this.emailBuyyer = value;
            }
        }

        public string TelpBuyyer
        {
            get
            {
                return this.telpBuyyer;
            }

            set => this.telpBuyyer = value;
        }
      
        public string District
        {
            get
            {
                return this.district;
            }

            set
            {
                this.district = value;
            }

        }
    }
}

