using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using StrongPointHomeTask.Functions;

namespace StrongPointHomeTask.Forms
{
    public partial class EditItemForm : Form
    {
        public EditItemForm()
        {
            InitializeComponent();
            //Kai forma inicializuojasi, isirasome visus duomenis i teksto laukus
            //Taip darome del malonesnios redagacijos
            idTxtBox.Text = MainForm.Delegate.Id.ToString();
            nameTxtBox.Text = MainForm.Delegate.Pavadinimas.ToString();
            quantityTxtBox.Text = MainForm.Delegate.Kiekis.ToString();
            priceTxtBox.Text = MainForm.Delegate.Kaina.ToString();
        }
        private void EditItemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Jei forma uzsidarineja, atliksim sia funkcija
            cancelBtn_Click(sender, e);
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Atsaukti mygtuko paspaudimo EventHandler
            //Susirandam pagrindine funkcija ir ja ijungiam, o sia forma paslepiam
            var mainForm = Application.OpenForms["MainForm"];
            mainForm.Enabled = true;
            this.Hide();
        }
        private void editItemBtn_Click(object sender, EventArgs e)
        {
            bool proceed = true; //Ar tesime su paciu redagavimu ar neredaguosim del klaidu
            if (string.IsNullOrWhiteSpace(nameTxtBox.Text))//Jei pavadinimo laukas tuscias tai iskelsim kaip klaida
            {
                nameIndicatorLbl.Visible = true;
                proceed = false;
            }
            else
            {
                nameIndicatorLbl.Visible = false;
            }
            if (!string.IsNullOrWhiteSpace(quantityTxtBox.Text))//Jei kiekio laukas tuscias tai iskelsim kaip klaida
            {
                if (!Regex.IsMatch(quantityTxtBox.Text, @"^\d*$"))//Jei kiekio laukas sudarytas is kazko kas nera skaiciai tai iskelsim klaida
                {
                    proceed = false;
                    quantityIndicatorLbl.Visible = true;
                }
                else
                {
                    quantityIndicatorLbl.Visible = false;
                }
            }
            else
            {
                proceed = false;
                quantityIndicatorLbl.Visible = true;
            }
            if (!string.IsNullOrEmpty(priceTxtBox.Text))
            {
                if (!Regex.IsMatch(priceTxtBox.Text, @"^\d*\.\d{2}$"))//Jei kainos laukas sudarytas is kazko kas nera kaina su centais tai iskelsim klaida
                {
                    proceed = false;
                    priceIndicatorLbl.Visible = true;
                }
                else
                {
                    priceIndicatorLbl.Visible = false;
                }
            }
            else
            {
                proceed = false;
                priceIndicatorLbl.Visible = true;
            }

            if (proceed)//Jei klaida nebuvo iskelta, reiskias duomenys buvo suvesti teisingai
            {
                for (int i = 0; i < ConfigJson.dataTable.Items.Count; i++)
                {
                    if (idTxtBox.Text == ConfigJson.dataTable.Items[i].Id.ToString())//Mums reikes surasti kam priklauso musu turima eilute, ir tada ta saraso elementa modifikuoti
                    {
                        ConfigJson.dataTable.Items[i].Pavadinimas = nameTxtBox.Text;
                        ConfigJson.dataTable.Items[i].Kiekis = Convert.ToInt32(quantityTxtBox.Text);
                        ConfigJson.dataTable.Items[i].Kaina = Convert.ToDouble(priceTxtBox.Text);
                        break;
                    }
                }

                cancelBtn_Click(sender, e); //Isjungiama forma
            }
            else//Jei buvo klaida iskelta, tai ijungsim ispejimo zinute
            {
                indicationLbl.Visible = true;
            }
        }
        private void helpChckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Jei Pagalbos dezute buvo ijungta tai ijungiame visus teksto laukelius
            //Ir vice versa
            if (helpChckBox.Checked)
            {
                idHelpLbl.Visible = true;
                nameHelpLbl.Visible = true;
                quantityHelpLbl.Visible = true;
                priceHelp.Visible = true;
            }
            else
            {
                idHelpLbl.Visible = false;
                nameHelpLbl.Visible = false;
                quantityHelpLbl.Visible = false;
                priceHelp.Visible = false;
            }
        }
    }

}
