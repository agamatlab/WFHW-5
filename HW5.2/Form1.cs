using Newtonsoft.Json;
using System.Text.Json;

namespace HW5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //LoadProgressFromFile();
        }

        void SaveProgressToFile()
        {
            List<Item> items = new List<Item>();
            foreach (var control in pnl_Products.Controls)
                if (control is Product product)
                    items.Add(product.GetItem());

            var jsonString = JsonConvert.SerializeObject(items);
            File.WriteAllText("products.json", jsonString);
        }

        void LoadProgressFromFile()
        {
            var stringData = File.ReadAllText("products.json");
            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(stringData)
                ?? new List<Item>();
            
            if (items.Count == 0) return;

            var numerator = items.GetEnumerator();

            foreach (var control in pnl_Products.Controls)
                if (control is Product product)
                {
                    product.SetItem(numerator.Current);
                    numerator.MoveNext();
                }
        }

        private void tgl_MoneySwitch_CheckedChanged(object sender, EventArgs e)
            => lbl_MoneyState.Text = tgl_MoneySwitch.Checked ? "ADD" : "REMOVE";



        private void ChangeMoneyAmount(object sender, EventArgs e)
        {
            if(sender is Guna.UI2.WinForms.Guna2CircleButton btn)
            {
                var value = Convert.ToDecimal(btn.Tag);
                decimal currentValue = Convert.ToDecimal(tBox_MoneyAmount.Text);
                decimal leftMoney = Convert.ToDecimal(lbl_MoneyLeft.Text
                    .Substring(0, lbl_MoneyLeft.Text.Length - 1));

                if (tgl_MoneySwitch.Checked)
                {
                    tBox_MoneyAmount.Text = 
                        (currentValue + value).ToString();
                    lbl_MoneyLeft.Text = (leftMoney + value).ToString() + '₼';

                }
                else
                {
                    decimal calculatedValue = 
                        currentValue - value;

                    decimal calculatedLeftMoney =
                        leftMoney - value;

                    if (calculatedValue < 0 || value < 0 || calculatedLeftMoney < 0)
                    {
                        MessageBox.Show("Insufficent Amount...");
                        return;
                    }
                    tBox_MoneyAmount.Text = calculatedValue.ToString();
                    lbl_MoneyLeft.Text = calculatedLeftMoney.ToString() + '₼';
                }



            }
        }


        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            //SaveProgressToFile();
            Environment.Exit(0);

        }

        private bool _breakEvent = false;
        private void product_ItemQuantityChanged(object sender, ItemQuantityChangedEventArgs e)
        {
            if(_breakEvent)
            {
                _breakEvent = false;
                return;
            }

            Product? product = sender as Product;
            if (product != null)
            {
                decimal currentLeftMoney =
                    Convert.ToDecimal(lbl_MoneyLeft.Text.Substring(0, lbl_MoneyLeft.Text.Length - 1))
                    + (decimal)product.Price * (e.Increment ? 1 : -1);

                if(currentLeftMoney < 0)
                {
                    MessageBox.Show("Insufficent Balance"); 
                    _breakEvent = true;
                    product.BuyQuantity--;
                    return;
                }

                lbl_MoneyLeft.Text = currentLeftMoney.ToString() + '₼';
            }
            //decimal amount = default;
            //foreach (var item in pnl_Products.Controls)
            //    if(item is Product product)
            //        if(product.cBox_Count.Checked)
            //            amount += product.BuyQuantity * (decimal)product.Price;

            //lbl_MoneyLeft.Text = (Convert.ToDecimal(lbl_MoneyLeft.Text) + amount).ToString();
        }
    }
}