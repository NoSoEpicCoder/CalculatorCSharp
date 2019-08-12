using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {

        double total1 = 0;
        double total2 = 0;
        string theOperator = "";

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void BtnOne_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnOne.Text;
        }

        private void BtnTwo_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnTwo.Text;
        }

        private void BtnThree_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnThree.Text;
        }

        private void BtnFour_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnFour.Text;
        }

        private void BtnFive_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnFive.Text;
        }

        private void BtnSix_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnSix.Text;
        }

        private void BtnSeven_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnSeven.Text;
        }

        private void BtnEight_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnEight.Text;
        }

        private void BtnNine_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnNine.Text;
        }

        private void BtnZero_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnZero.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e) {
            txtDisplay.Clear();
        }

        private void BtnPlus_Click(object sender, EventArgs e) {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "+";
        }

        private void BtnMinus_Click(object sender, EventArgs e) {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "-";
        }

        private void BtnDivide_Click(object sender, EventArgs e) {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "/";
        }

        private void BtnMultiply_Click(object sender, EventArgs e) {
            total1 += double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            theOperator = "*";
        }

        private void BtnEquals_Click(object sender, EventArgs e) {

            switch(theOperator) {
                case "+":
                    total2 = total1 + double.Parse(txtDisplay.Text);
                    break;
                case "-":
                    total2 = total1 - double.Parse(txtDisplay.Text);
                    break;
                case "/":
                    total2 = total1 / double.Parse(txtDisplay.Text);
                    break;
                case "*":
                    total2 = total1 * double.Parse(txtDisplay.Text);
                    break;
                default:
                    total2 = double.Parse("ERROR");
                    break;
            }

            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        private void BtnDecimal_Click(object sender, EventArgs e) {
            txtDisplay.Text += btnDecimal.Text;
        }
    }
}
