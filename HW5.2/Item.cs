using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._2
{
    public class Item
    {
        public Item() { }
        
        public Item(Image productImage, int stockQuantity, int buyQuantity, float price)
        {
            ProductImage = productImage;
            StockQuantity = stockQuantity;
            BuyQuantity = buyQuantity;
            Price = price;
        }

        
        public Image ProductImage { get; set; }
        public int StockQuantity{ get; set; }
        public int BuyQuantity{ get; set; }
        public float Price{ get; set; }
    }
}
