using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5._2
{
    public partial class Product : UserControl
    {
        public Image ProductImage
        {
            get { return pic_ProductImage.Image; }
            set { pic_ProductImage.Image = value; } 
        }

        public float Price
        {
            get { return Convert.ToSingle(lbl_Price.Text
                .Substring(0, lbl_Price.Text.Length - 1)); }

            set { lbl_Price.Text = value.ToString() + '₼'; }
        }

        public int Quantity
        {
            get { return Convert.ToInt32(cBox_Count.Text.Split(' ')[0]); }
            set { cBox_Count.Text = value.ToString() + " pcs"; }
        }

        public decimal BuyQuantity
        {
            get { return num_BuyQuantity.Value; }
            set { num_BuyQuantity.Value = value; }
        }


        public Item GetItem()
            => new Item(pic_ProductImage.Image,
                Convert
                    .ToInt32(cBox_Count.Text.Split(' ')[0]),
                Convert
                    .ToInt32(num_BuyQuantity.Value),
                Convert
                    .ToSingle(lbl_Price.Text
                    .Substring(0, lbl_Price.Text.Length - 1))
                );

        public void SetItem(Item item)
        {
            pic_ProductImage.Image = item.ProductImage;
            num_BuyQuantity.Value = item.BuyQuantity;
            cBox_Count.Text = item.StockQuantity.ToString() + " pcs";
            lbl_Price.Text = item.Price.ToString() + '₼';
        }

        public Product()
        {
            InitializeComponent();
            oldValue = num_BuyQuantity.Value;
        }

        private void cBox_Count_CheckedChanged(object sender, EventArgs e)
            => pnl_Product.Enabled = cBox_Count.Checked;



        decimal oldValue = default;

        private void num_BuyQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (oldValue == num_BuyQuantity.Value) 
                return;

            
            var parts = cBox_Count.Text.Split(' ');
            if (num_BuyQuantity.Value > oldValue)
            {

                if (parts[0] == "0" ) 
                    { num_BuyQuantity.Value--; return; }
                parts[0] = (Convert.ToInt32(parts[0]) - 1).ToString();
            }
            else
                parts[0] = (Convert.ToInt32(parts[0]) + 1).ToString();

            oldValue = num_BuyQuantity.Value;
            cBox_Count.Text = String.Join(' ' ,parts);

        }

        private void lbl_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void cBox_Count_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
