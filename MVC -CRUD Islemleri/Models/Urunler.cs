namespace MVC__CRUD_Islemleri.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Urunler")]
    public partial class Urunler
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50),Display(Name ="Ürün Ad")]
        public string UrunAd { get; set; }
        [Display(Name ="Ürün Fiyat")]
        public decimal UrunFiyat { get; set; }

        [Display(Name ="Ürün Stok")]
        public int UrunStok { get; set; }
    }
}
