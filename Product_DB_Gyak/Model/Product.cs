using System.ComponentModel.DataAnnotations;

namespace Product_DB_Gyak.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        public decimal Price { get; set; }
        public int SockQuantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastModified { get; set;} = DateTime.Now;
        public bool IsActive { get; set; }
        public bool ShowData { get; set; } = true;
    }
}
