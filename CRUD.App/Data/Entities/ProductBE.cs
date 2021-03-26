using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.App.Data.Entities
{
    [Table(name: "tproducts")]
    public class ProductBE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "prdid", Order = 1)]
        public int Id { get; set; }
        [Column(name: "prdname", Order = 2)]
        public string Name { get; set; }
        [Column(name: "prddescription", Order = 3)]
        public string Description { get; set; }
        [Column(name: "prdstock", Order = 4)]
        public int Stock { get; set; }
        [Column(name: "prdprice", Order = 5)]
        public decimal UnitPrice { get; set; }
        [Column(name: "prdcategory", Order = 6)]
        public string Category { get; set; }
    }
}
