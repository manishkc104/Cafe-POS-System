using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Cafe_Management_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //To exit the application
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //To load the value when the form opens
            txtLatte.Enabled = false;
            txtEspresso.Enabled= false;
            txtIcedLatte.Enabled = false;
            txtVale.Enabled = false;
            txtCappuccino.Enabled = false;
            txtAfrican.Enabled = false;
            txtAmerican.Enabled = false;
            txtIcedCappucino.Enabled = false;
            txtCoffeeCake.Enabled = false;
            txtRedVelvet.Enabled = false;
            txtBlackForest.Enabled = false;
            txtBoston.Enabled = false;
            txtLagos.Enabled = false;
            txtKilburn.Enabled = false;
            txtCarlton.Enabled = false;
            txtQueen.Enabled = false;
            lblCostDrinks.Text = "0";
            lblCostCakes.Text = "0";
            lblServiceCharge.Text = "1.75";

            chkLatte.Checked = false;
            CchkEspresso.Checked = false;
            chkIcedLatte.Checked = false;
            chkValeCoffee.Checked = false;
            chkCappuccino.Checked = false;
            chkAfricanCoffee.Checked = false;
            chkAmericanCoffee.Checked = false;
            chkIcedCappuccino.Checked = false;
            chkCoffeeCake.Checked = false;
            chkRedVelvetCake.Checked = false;
            chkBlackForestCake.Checked = false;
            chkBostonCreamCake.Checked = false;
            chkLagosChocolateCake.Checked = false;
            chkKilburnChocolateCake.Checked = false;
            chkCarltonHillChocolateCake.Checked = false;
            chkQueensParkChocolateCake.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset code
            txtLatte.Text = "0";
            txtEspresso.Text = "0";
            txtIcedLatte.Text = "0";
            txtVale.Text = "0";
            txtCappuccino.Text = "0";
            txtAfrican.Text = "0";
            txtAmerican.Text = "0";
            txtIcedCappucino.Text = "0";
            txtCoffeeCake.Text = "0";
            txtRedVelvet.Text = "0";
            txtBlackForest.Text = "0";
            txtBoston.Text = "0";
            txtLagos.Text = "0";
            txtKilburn.Text = "0";
            txtCarlton.Text = "0";
            txtQueen.Text = "0";
            lblCostDrinks.Text = "0";
            lblCostCakes.Text = "0";
            lblServiceCharge.Text = "1.75";
            lblSubTotal.Text = "0";
            lblTotal.Text = "0";
            lblTax.Text = "0";


            //Reset for checkbox 
            chkLatte.Checked = false;
            CchkEspresso.Checked = false;
            chkIcedLatte.Checked = false;
            chkValeCoffee.Checked = false;
            chkCappuccino.Checked = false;
            chkAfricanCoffee.Checked = false;
            chkAmericanCoffee.Checked = false;
            chkIcedCappuccino.Checked = false;
            chkCoffeeCake.Checked = false;
            chkRedVelvetCake.Checked = false;
            chkBlackForestCake.Checked = false;
            chkBostonCreamCake.Checked = false;
            chkLagosChocolateCake.Checked = false;
            chkKilburnChocolateCake.Checked = false;
            chkCarltonHillChocolateCake.Checked = false;
            chkQueensParkChocolateCake.Checked = false;
        }
        private void chkLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLatte.Checked==true)
            {
                txtLatte.Enabled = true;
            }
            if (chkLatte.Checked == false)
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (CchkEspresso.Checked == true)
            {
                txtEspresso.Enabled = true;
            }
            if (CchkEspresso.Checked == false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
        }

        private void chkIcedLatte_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == true)
            {
                txtIcedLatte.Enabled = true;
            }
            if (chkIcedLatte.Checked == false)
            {
                txtIcedLatte.Enabled = false;
                chkIcedLatte.Text = "0";
                txtIcedLatte.Text = "0";
            }
        }

        private void chkValeCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkValeCoffee.Checked == true)
            {
                txtVale.Enabled = true;
            }
            if (chkValeCoffee.Checked == false)
            {
                txtVale.Enabled = false;
                txtVale.Text = "0";
            }
        }

        private void chkCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                txtCappuccino.Enabled = true;
            }
            if (chkCappuccino.Checked == false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
        }

        private void chkAfricanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAfricanCoffee.Checked == true)
            {
                txtAfrican.Enabled = true;
            }
            if (chkAfricanCoffee.Checked == false)
            {
                txtAfrican.Enabled = false;
                txtAfrican.Text = "0";
            }
        }

        private void chkAmericanCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmericanCoffee.Checked == true)
            {
                txtAmerican.Enabled = true;
            }
            if (chkAmericanCoffee.Checked == false)
            {
                txtAmerican.Enabled = false;
                txtAmerican.Text = "0";
            }
        }

        private void chkIcedCappuccino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcedCappuccino.Checked == true)
            {
                txtIcedCappucino.Enabled = true;
            }
            if (chkIcedCappuccino.Checked == false)
            {
                txtIcedCappucino.Enabled = false;
                txtIcedCappucino.Text = "0";
            }
        }

        private void chkCoffeeCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffeeCake.Checked == true)
            {
                txtCoffeeCake.Enabled = true;
            }
            if (chkCoffeeCake.Checked == false)
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
        }

        private void chkRedVelvetCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRedVelvetCake.Checked == true)
            {
                txtRedVelvet.Enabled = true;
            }
            if (chkRedVelvetCake.Checked == false)
            {
                txtRedVelvet.Enabled = false;
                txtRedVelvet.Text = "0";
            }
        }

        private void chkBlackForestCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBlackForestCake.Checked == true)
            {
                txtBlackForest.Enabled = true;
            }
            if (chkBlackForestCake.Checked == false)
            {
                txtBlackForest.Enabled = false;
                txtBlackForest.Text = "0";
            }
        }

        private void chkBostonCreamCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBostonCreamCake.Checked == true)
            {
                txtBoston.Enabled = true;
            }
            if (chkBostonCreamCake.Checked == false)
            {
                txtBoston.Enabled = false;
                txtBoston.Text = "0";
            }
        }

        private void chkLagosChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLagosChocolateCake.Checked == true)
            {
                txtLagos.Enabled = true;
            }
            if (chkLagosChocolateCake.Checked == false)
            {
                txtLagos.Enabled = false;
                txtLagos.Text = "0";
            }
        }

        private void chkKilburnChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKilburnChocolateCake.Checked == true)
            {
                txtKilburn.Enabled = true;
            }
            if (chkKilburnChocolateCake.Checked == false)
            {
                txtKilburn.Enabled = false;
                chkKilburnChocolateCake.Text = "0";
                txtKilburn.Text = "0";
            }
        }

        private void chkCarltonHillChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCarltonHillChocolateCake.Checked == true)
            {
                txtCarlton.Enabled = true;
            }
            if (chkCarltonHillChocolateCake.Checked == false)
            {
                txtCarlton.Enabled = false;
                txtCarlton.Text = "0";
            }
        }

        private void chkQueensParkChocolateCake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQueensParkChocolateCake.Checked == true)
            {
                txtQueen.Enabled = true;
            }
            if (chkQueensParkChocolateCake.Checked == false)
            {
                txtQueen.Enabled = false;
                txtQueen.Text = "0";
            }
        }
        private void txtLatte_Click(object sender, EventArgs e)
        {
            txtLatte.Text = "";
            txtLatte.Focus();
        }

        private void txtEspresso_Click(object sender, EventArgs e)
        {
            txtEspresso.Text = "";
            txtEspresso.Focus();
        }

        private void txtIcedLatte_Click(object sender, EventArgs e)
        {
            txtIcedLatte.Text = "";
            txtIcedLatte.Focus();
        }

        private void txtVale_Click(object sender, EventArgs e)
        {
            txtVale.Text = "";
            txtVale.Focus();
        }

        private void txtCappuccino_Click(object sender, EventArgs e)
        {
            txtCappuccino.Text = "";
            txtCappuccino.Focus();
        }

        private void txtAfrican_Click(object sender, EventArgs e)
        {
            txtAfrican.Text = "";
            txtAfrican.Focus();
        }

        private void txtAmerican_Click(object sender, EventArgs e)
        {
            txtAmerican.Text = "";
            txtAmerican.Focus();
        }

        private void txtIcedCappucino_Click(object sender, EventArgs e)
        {
            txtIcedCappucino.Text = "";
            txtIcedCappucino.Focus();
        }

        private void txtCoffeeCake_Click(object sender, EventArgs e)
        {
            txtCoffeeCake.Text = "";
            txtCoffeeCake.Focus();
        }

        private void txtRedVelvet_Click(object sender, EventArgs e)
        {
            txtRedVelvet.Text = "";
            txtRedVelvet.Focus();
        }

        private void txtBlackForest_Click(object sender, EventArgs e)
        {
            txtBlackForest.Text = "";
            txtBlackForest.Focus();
        }

        private void txtBoston_Click(object sender, EventArgs e)
        {
            txtBoston.Text = "";
            txtBoston.Focus();
        }

        private void txtLagos_Click(object sender, EventArgs e)
        {
            txtLagos.Text = "";
            txtLagos.Focus();
        }

        private void txtKilburn_Click(object sender, EventArgs e)
        {
            txtKilburn.Text = "";
            txtKilburn.Focus();
        }

        private void txtCarlton_Click(object sender, EventArgs e)
        {
            txtCarlton.Text = "";
            txtCarlton.Focus();
        }

        private void txtQueen_Click(object sender, EventArgs e)
        {
            txtQueen.Text = "";
            txtQueen.Focus();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //giving the command about what to print 
            e.Graphics.DrawString(rtfReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            //Button click print dialg is shown
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtfReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //This Code open up the file 
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                rtfReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
            }
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //This code will save  the text files 
            SaveFileDialog savefile = new SaveFileDialog();

            savefile.FileName = "Notepad Text";
            savefile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (savefile.ShowDialog()==DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))
                sw.WriteLine(rtfReceipt.Text);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            //Making the reciept
            rtfReceipt.Clear();
            rtfReceipt.AppendText(Environment.NewLine);
            rtfReceipt.AppendText("\t\t\t" + "Just Do Cafe" + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Latte \t\t" + txtLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Espresso \t\t\t\t\t" + txtEspresso.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Latte \t\t\t\t\t" + txtIcedLatte.Text + Environment.NewLine);
            rtfReceipt.AppendText("Vale Coffee \t\t" + txtVale.Text + Environment.NewLine);
            rtfReceipt.AppendText("Capuccino \t\t\t\t\t" + txtCappuccino.Text + Environment.NewLine);
            rtfReceipt.AppendText("African Coffee \t\t" + txtAfrican.Text + Environment.NewLine);
            rtfReceipt.AppendText("American Coffee \t\t\t\t" + txtAmerican.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Cappucino \t\t" + txtIcedCappucino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Coffee Cake \t\t" + txtCoffeeCake.Text + Environment.NewLine);
            rtfReceipt.AppendText("Red Velvet Cake \t\t\t\t" + txtRedVelvet.Text + Environment.NewLine);
            rtfReceipt.AppendText("Black Forest Cake \t\t\t\t\t" + txtBlackForest.Text + Environment.NewLine);
            rtfReceipt.AppendText("Iced Cappucino \t\t\t\t\t\t" + txtIcedCappucino.Text + Environment.NewLine);
            rtfReceipt.AppendText("Boston Cream Cake \t\t\t\t\t" + txtBoston.Text + Environment.NewLine);
            rtfReceipt.AppendText("Lagos Chocolate Cake \t\t\t\t\t" + txtLagos.Text + Environment.NewLine);
            rtfReceipt.AppendText("Kill Burn Chocolate Cake \t\t\t\t" + txtKilburn.Text + Environment.NewLine);
            rtfReceipt.AppendText("Carlton Hill Cake \t\t\t\t" + txtCarlton.Text + Environment.NewLine);
            rtfReceipt.AppendText("Queen Park Chocolate Cake \t\t\t\t" + txtQueen.Text + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);
            rtfReceipt.AppendText("Tax \t\t\t" + lblTax.Text + Environment.NewLine);
            rtfReceipt.AppendText("Sub Total \t\t\t" + lblSubTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("Total \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtfReceipt.AppendText("-----------------------------------------------" + Environment.NewLine);       
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (chkIcedLatte.Checked == false)
            {
                txtIcedLatte.Enabled = false;
                chkIcedLatte.Text = "0";
                txtIcedLatte.Text = "0";
            }
            if (chkLatte.Checked == false)
            {
                txtLatte.Enabled = false;
                txtLatte.Text = "0";
            }
            if (CchkEspresso.Checked == false)
            {
                txtEspresso.Enabled = false;
                txtEspresso.Text = "0";
            }
            if (chkValeCoffee.Checked == false)
            {
                txtVale.Enabled = false;
                txtVale.Text = "0";
            }
            if (chkCappuccino.Checked == false)
            {
                txtCappuccino.Enabled = false;
                txtCappuccino.Text = "0";
            }
            if (chkAfricanCoffee.Checked == false)
            {
                txtAfrican.Enabled = false;
                txtAfrican.Text = "0";
            }
            if (chkAmericanCoffee.Checked == false)
            {
                txtAmerican.Enabled = false;
                txtAmerican.Text = "0";
            }
            if (chkIcedCappuccino.Checked == false)
            {
                txtIcedCappucino.Enabled = false;
                txtIcedCappucino.Text = "0";
            }
            if (chkCoffeeCake.Checked == false)
            {
                txtCoffeeCake.Enabled = false;
                txtCoffeeCake.Text = "0";
            }
            if (chkRedVelvetCake.Checked == false)
            {
                txtRedVelvet.Enabled = false;
                txtRedVelvet.Text = "0";
            }
            if (chkBlackForestCake.Checked == false)
            {
                txtBlackForest.Enabled = false;
                txtBlackForest.Text = "0";
            }
            if (chkBostonCreamCake.Checked == false)
            {
                txtBoston.Enabled = false;
                txtBoston.Text = "0";
            }
            if (chkLagosChocolateCake.Checked == false)
            {
                txtLagos.Enabled = false;
                txtLagos.Text = "0";
            }
            if (chkKilburnChocolateCake.Checked == false)
            {
                txtKilburn.Enabled = false;
                chkKilburnChocolateCake.Text = "0";
                txtKilburn.Text = "0";
            }
            if (chkCarltonHillChocolateCake.Checked == false)
            {
                txtCarlton.Enabled = false;
                txtCarlton.Text = "0";
            }
            if (chkQueensParkChocolateCake.Checked == false)
            {
                txtQueen.Enabled = false;
                txtQueen.Text = "0";
            }

            double tax;
            tax = 0.45;

            double latte, chkEspresso, icedLatte, valeCoffee, cappuccino, africanCoffee, americanCoffee, icedCappuccino;
            latte = 120;
            chkEspresso = 130;
            icedLatte = 150;
            valeCoffee = 200;
            cappuccino = 180;
            africanCoffee = 170;
            americanCoffee = 190;
            icedCappuccino = 210;

           

            double latte_cof = Convert.ToDouble(txtLatte.Text);
            double chkEspresso_cof = Convert.ToDouble(txtEspresso.Text);
            double icedLatte_cof = Convert.ToDouble(txtIcedLatte.Text);
            double valeCoffee_cof = Convert.ToDouble(txtVale.Text);
            double cappuccino_cof = Convert.ToDouble(txtCappuccino.Text);
            double africanCoffee_cof = Convert.ToDouble(txtAfrican.Text);
            double americanCoffee_cof = Convert.ToDouble(txtAmerican.Text);
            double icedCappuccino_cof = Convert.ToDouble(txtIcedCappucino.Text);

          

           double coffeeCake, redVelvetCake, blackForestCake, bostonCreamCake, lagosChocolateCake, killburnChocolateCake, carltonHillChocolateCake, queensParkChocolateCake;

            coffeeCake = 300;
            redVelvetCake = 350;
            blackForestCake = 400;
            bostonCreamCake = 450;
            lagosChocolateCake = 300;
            killburnChocolateCake = 200;
            carltonHillChocolateCake = 700;
            queensParkChocolateCake = 800;


            double coffeeCake_cak = Convert.ToDouble(txtCoffeeCake.Text);
            double redVelvetCake_cak = Convert.ToDouble(txtRedVelvet.Text);
            double blackForestCake_cak = Convert.ToDouble(txtBlackForest.Text);
            double bostonCreamCake_cak = Convert.ToDouble(txtBoston.Text);
            double lagosChocolateCake_cak = Convert.ToDouble(txtLagos.Text);
            double killburnChocolateCake_cak = Convert.ToDouble(txtKilburn.Text);
            double carltonHillChocolateCake_cak = Convert.ToDouble(txtCarlton.Text);
            double queensParkChocolateCake_cak = Convert.ToDouble(txtQueen.Text);

            Cafe cafe = new Cafe(latte_cof, chkEspresso_cof, icedLatte_cof, valeCoffee_cof, cappuccino_cof, africanCoffee_cof, americanCoffee_cof, icedCappuccino_cof, coffeeCake_cak, redVelvetCake_cak, blackForestCake_cak, bostonCreamCake_cak, lagosChocolateCake_cak, killburnChocolateCake_cak, carltonHillChocolateCake_cak, queensParkChocolateCake_cak);

            double cost_of_drinks = (latte_cof * latte) + (chkEspresso_cof * chkEspresso) + (icedLatte_cof * icedLatte) + (valeCoffee_cof * valeCoffee)
              + (cappuccino_cof * cappuccino) + (africanCoffee_cof * africanCoffee) + (americanCoffee_cof * americanCoffee) + (icedCappuccino_cof * icedCappuccino);

            lblCostDrinks.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cake = (coffeeCake_cak * coffeeCake) + (redVelvetCake_cak * redVelvetCake) + (blackForestCake_cak * blackForestCake) + (bostonCreamCake_cak * bostonCreamCake)
              + (lagosChocolateCake_cak * lagosChocolateCake) + (killburnChocolateCake_cak * killburnChocolateCake) + (carltonHillChocolateCake_cak * carltonHillChocolateCake) + (queensParkChocolateCake_cak * queensParkChocolateCake);

            lblCostCakes.Text = Convert.ToString(cost_of_cake);

            double Service_Charge = Convert.ToDouble(lblServiceCharge.Text);

            lblSubTotal.Text = Convert.ToString(cost_of_drinks + cost_of_cake + Service_Charge);
            lblTax.Text = Convert.ToString(((cost_of_cake+ cost_of_cake + Service_Charge) * tax)/100);
            double Tax = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(cost_of_cake + cost_of_drinks + Tax + Service_Charge);


        }
    }
}