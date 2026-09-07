using System;
using System.Windows.Forms;

namespace Act4_Villacin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a food item.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a drink item.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            if (comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select food quantity.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select drink quantity.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!radioButton1.Checked &&
                !radioButton2.Checked &&
                !radioButton3.Checked)
            {
                MessageBox.Show(
                    "Please select an order type.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            double payment;

            if (!double.TryParse(textBox3.Text, out payment))
            {
                MessageBox.Show(
                    "Please enter a valid payment.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (payment < 0)
            {
                MessageBox.Show(
                    "Payment cannot be negative.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            double foodPrice = 0;
            double drinkPrice = 0;

            // FOOD PRICE
            switch (comboBox1.Text)
            {
                case "Burger":
                    foodPrice = 85;
                    break;

                case "Chicken Sandwich":
                    foodPrice = 75;
                    break;

                case "Spaghetti":
                    foodPrice = 95;
                    break;

                case "French Fries":
                    foodPrice = 50;
                    break;
            }

            // DRINK PRICE
            switch (comboBox2.Text)
            {
                case "Soft Drink":
                    drinkPrice = 35;
                    break;

                case "Iced Tea":
                    drinkPrice = 40;
                    break;

                case "Coffee":
                    drinkPrice = 45;
                    break;

                case "Bottled Water":
                    drinkPrice = 25;
                    break;
            }

            int foodQty = Convert.ToInt32(comboBox3.Text);
            int drinkQty = Convert.ToInt32(comboBox4.Text);

            double foodTotal = foodPrice * foodQty;
            double drinkTotal = drinkPrice * drinkQty;

            double subtotal = foodTotal + drinkTotal;

            double discount = 0;

            if (subtotal >= 500)
            {
                discount = subtotal * 0.10;
            }

            if (checkBox1.Checked)
            {
                discount = discount + (subtotal * 0.20);
            }

            double extraCharge = 0;

            if (radioButton1.Checked)
            {
                extraCharge = 0;
            }

            else if (radioButton2.Checked)
            {
                extraCharge = 20;
            }


            else if (radioButton3.Checked)
            {
                if (subtotal >= 1000)
                {
                    extraCharge = 0;
                }
                else
                {
                    extraCharge = 50;
                }
            }


            double total = subtotal - discount + extraCharge;

            if (payment < total)
            {
                MessageBox.Show(
                    "Insufficient Payment!",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            double change = payment - total;


            textBox1.Text = foodTotal.ToString("0.00");
            textBox2.Text = drinkTotal.ToString("0.00");

            textBox4.Text = subtotal.ToString("0.00");
            textBox5.Text = discount.ToString("0.00");
            textBox6.Text = extraCharge.ToString("0.00");

            textBox7.Text = total.ToString("0.00");
            textBox8.Text = change.ToString("0.00");



            textBox9.Text = comboBox1.Text;
            textBox10.Text = comboBox2.Text;


            textBox11.Text = foodQty.ToString();
            textBox12.Text = drinkQty.ToString();


            textBox13.Text = foodTotal.ToString("0.00");
            textBox14.Text = drinkTotal.ToString("0.00");


            textBox15.Text = subtotal.ToString("0.00");
            textBox16.Text = discount.ToString("0.00");
            textBox17.Text = extraCharge.ToString("0.00");

            textBox18.Text = total.ToString("0.00");
            textBox19.Text = payment.ToString("0.00");
            textBox20.Text = change.ToString("0.00");

            MessageBox.Show(
                "Order calculated successfully!",
                "BOYAX CAFE",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;


            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;


            checkBox1.Checked = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();

            comboBox1.Focus();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }
    }
}