using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreSeminerWeb.Models
{
    // Hazirladigimiz custom Model Binder yapisini asagidaki gibi tanimliyoruz
    // Boylece bu model in parametrelere bind edilmesinden yazdigimiz model binder sorumlu
    [ModelBinder(typeof(Binders.ProductModelBinder))]
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Urun Adi")]
        public string ProductName { get; set; }
        [Display(Name = "Paketleme")]
        public string QuantityPerUnit { get; set; }
        [Display(Name = "Fiyat")]
        public decimal? UnitPrice { get; set; }
        [Display(Name = "Stok Miktari")]
        public short? UnitsInStock { get; set; }
        [Display(Name = "Siparis Miktari")]
        public short? UnitsOnOrder { get; set; }
        [Display(Name = "Min.Adet")]
        public short? ReorderLevel { get; set; }
        [Display(Name = "Uretimde")]
        public bool Discontinued { get; set; }
    }

}
