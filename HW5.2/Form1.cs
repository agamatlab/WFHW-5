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

            var jsonString = JsonSerializer.Serialize(items);
            File.WriteAllText("products.json", jsonString);
        }

        void LoadProgressFromFile()
        {
            var text = File.ReadAllText("products.json");
            List<Item> items = JsonSerializer.Deserialize<List<Item>>(text) 
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

        private void tBox_MoneyAmount_TextChanged(object sender, EventArgs e)
        {
            lbl_MoneyLeft.Text = tBox_MoneyAmount.Text;
        }

        private void ChangeMoneyAmount(object sender, EventArgs e)
        {
            if(sender is Guna.UI2.WinForms.Guna2CircleButton btn)
            {
                var value = Convert.ToDecimal(btn.Tag);


                if (tgl_MoneySwitch.Checked)
                    tBox_MoneyAmount.Text = 
                        (Convert.ToDecimal(tBox_MoneyAmount.Text) + value).ToString();
                else
                {
                    decimal calculatedValue = 
                        (Convert.ToDecimal(tBox_MoneyAmount.Text) - value);

                    if(calculatedValue < 0)
                        calculatedValue = 0;
                    tBox_MoneyAmount.Text = calculatedValue.ToString();
                }

            }
        }

        private void product_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = default;
            foreach (var item in pnl_Products.Controls)
                if(item is Product product)
                    if(product.cBox_Count.Checked)
                        amount += product.BuyQuantity * (decimal)product.Price;

            lbl_MoneyLeft.Text = (Convert.ToDecimal(lbl_MoneyLeft.Text) + amount).ToString();
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            //SaveProgressToFile();
            Environment.Exit(0);

        }
    }
}