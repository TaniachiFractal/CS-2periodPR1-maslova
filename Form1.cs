using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;

namespace _2semPR1_maslova
{
    // Main Form class
    public partial class ShopForm : Form
    {
        static public int itemCount = 0;
        static public double finSum = 0;
        static public double finDiscount = 0;
        static public double fin = 0;


        public ShopForm()
        {
            InitializeComponent();
        }

        // This thing is too long to write each time.
        readonly object enNL = Environment.NewLine;

        // Add the product names to the name combo box
        private void ShopForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(Paths.productListPath);
                string @iterator;
                while ((@iterator = sr.ReadLine()) != null)
                {
                    if (@iterator != string.Empty)
                    {
                        tbName_ComboB.Items.Add(@iterator);
                    }
                }
                sr.Close();

                tbName_ComboB.Text = tbName_ComboB.Items[0].ToString();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ошибка чтения списка названий товаров \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            tbReceipt.Text = "Дата продажи: " + DateTime.Now + enNL + enNL;
            Paths.InitReceiptPath();

        }

        // Add the product to the list
        private void BtAdd_Click(object sender, EventArgs e)
        {

            string newName = string.Empty;
            double newPrice = 0;
            long newCount = 0;
            double newDiscount = 0;
            
            bool doneAdd = true;
            try
            {
                newName = tbName_ComboB.Text;
                newPrice = double.Parse(tbPrice.Text);
                newCount = long.Parse(tbCount_NumUD.Text);
                newDiscount = double.Parse(tbDiscount.Text);    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка во введённых данных \n\n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doneAdd = false;
            }

            if (newDiscount > 100)
            {
                MessageBox.Show("Ошибка во введённых данных: Слишком большая скидка \n\n", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                doneAdd = false;
            }

            if (doneAdd)
            {
                itemCount++;

                double newCost = newPrice * newCount;
                double newMoneyDiscount = newDiscount / 100 * newCost;
                double newNDS = 0.15 * newCost;
                double newFinalCost = newCost - newMoneyDiscount + newNDS;

                tbReceipt.Text += "--- " + itemCount.ToString() + " ---" + enNL;
                tbReceipt.Text += "Товар: " + newName + enNL;
                tbReceipt.Text += "Цена: " + newPrice.ToString("0.00") + " руб." + enNL;
                tbReceipt.Text += "Количество: " + newCount.ToString() + " шт." + enNL;
                tbReceipt.Text += "Стоимость: " + newCost.ToString("0.00") + " руб." + enNL;
                tbReceipt.Text += "Скидка: " + newMoneyDiscount.ToString("0.00") + " руб." + enNL;
                tbReceipt.Text += "НДС (15%): " + newNDS.ToString("0.00") + " руб." + enNL;
                tbReceipt.Text += "К оплате за товар: " + newFinalCost.ToString("0.00") + " руб." + enNL + enNL;

                finSum += newCost + newCost*0.15;
                finDiscount += newMoneyDiscount;
                fin = finSum - finDiscount;

                tbSumDiscount.Text = finDiscount.ToString("0.00") + " руб.";
                tbSumProduct.Text = finSum.ToString("0.00") + " руб.";
                tbToPay.Text = fin.ToString("0.00") + " руб.";

                tbName_ComboB.Text = tbName_ComboB.Items[0].ToString();
                tbPrice.Text = string.Empty;
                tbDiscount.Text = string.Empty;
                tbCount_NumUD.Text = 1.ToString();

                btClear.Enabled = true;
            }



        }

        // Exit the app.
        private void BtExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Reset Receipt
        private void BtClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Точно очистить корзину? Это действие нельзя будет отменить. \n", "ВНИМАНИЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                tbReceipt.Text = "Дата продажи: " + DateTime.Now + enNL + enNL;
                Paths.InitReceiptPath();

                tbSumDiscount.Text = string.Empty;
                tbSumProduct.Text = string.Empty;
                tbToPay.Text = string.Empty;

                itemCount = 0;
                finSum = 0;
                finDiscount = 0;
                fin = 0;
            }

            btClear.Enabled = false;    
        }

        // Prevent wrong input
        private void TbPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',') 
            {
                if (tbPrice.Text.IndexOf(",") != -1) 
                {
                    e.Handled = true;
                }
            }

            if (tbPrice.Text.IndexOf(",") != -1)
            {
                    if (char.IsDigit(e.KeyChar))
                    {
                        string[] splitArray = tbPrice.Text.Split(',');
                        if (splitArray[1].Length > 1)
                        {
                            e.Handled = true;
                        }
                    }
                
            }
        }
        // Prevent wrong input
        private void TbCount_NumUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Prevent wrong input
        private void TbDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (tbDiscount.Text.IndexOf(",") != -1)
                {
                    e.Handled = true;
                }
            }

            if (tbDiscount.Text.IndexOf(",") != -1)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    string[] splitArray = tbDiscount.Text.Split(',');
                    if (splitArray[1].Length > 1)
                    {
                        e.Handled = true;
                    }
                }
            }

            
        }

        // Prevent discount higher than 100%
        private void TbDiscount_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tbDiscount.Text, out double value) && value > 100)
            {
                tbDiscount.Text = "100";
            }
        }
        private void ShopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FormClose())
            {
                e.Cancel = true;
            }
        }
         
        // Ask to close Form and write file
        private bool FormClose()
        {
            DialogResult result = MessageBox.Show("Выйти из приложения и записать чек в файл? \n", "ВНИМАНИЕ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                FileInfo f1 = new FileInfo(Paths.receiptPath);
                try
                {
                    StreamWriter sw = f1.CreateText();
                    sw.Write(tbReceipt.Text + 
                        "\n------------------\n" +
                        "Сумма покупок с учётом НДС: " + tbSumProduct.Text + "\n" +
                        "Сумма скидок: " + tbSumDiscount.Text + "\n" +
                        "К оплате: " + tbToPay.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка записи чека \n" + ex.ToString(), "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return true;
            }
            return false;
        }



    }
    // Global variables - path strings
    public class Paths
    {
        static public readonly string mainPath = Directory.GetCurrentDirectory();
        static public readonly string productListPath = mainPath + @"\productList.txt";
        static public string receiptPath = string.Empty;
        static public void InitReceiptPath()
        {
            receiptPath = mainPath + @"\receipt" + " " + DateTimeNoFormat() + ".txt";
        }
        
        static private string DateTimeNoFormat()
        {
            string badDate = DateTime.Now.ToString();
            string[] splitArr = badDate.Split('.');
            string goodDate = splitArr[0] + splitArr[1] + splitArr[2];
            splitArr = goodDate.Split(':');
            goodDate = splitArr[0] + splitArr[1] + splitArr[2];
            return goodDate;
        }

    }

    // The main class that handles product info
    class Product
    {
        string name;
        double price;
        long count;
        double discount;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public long Count { get => count; set => count = value; }
        public double Discount { get => discount; set => discount = value; }

        // Main constructor
        public Product(string name, double price, long count, double discount)
        {
            this.Name = name; this.Price = price; this.Count = count; this.Discount = discount;
        }
    }
}
