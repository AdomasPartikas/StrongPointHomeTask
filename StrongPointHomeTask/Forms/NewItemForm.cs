using StrongPointHomeTask.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StrongPointHomeTask.Forms
{
    public partial class AddItemFrm : Form
    {
        public AddItemFrm()
        {
            InitializeComponent();
            //Del pridejimo konfliktu, patikriname ar sarasas i kuri kelsim nauja elementa yra tuscias
            //Jei jis isties yra tuscias padesime jam iniciliazuoti
            //Taciau jei jis nera tuscias tada susirasim jo didziausia ID pridesim 1 ir turesim nepanaudota ID
            //Isties automatiska
            if (ConfigJson.dataTable != null)
                if (ConfigJson.dataTable.Items.Count > 0)
                    idTxtBox.Text = (ConfigJson.dataTable.Items.Max(x => x.Id) + 1).ToString();
                else
                    idTxtBox.Text = "1";
            else
            {
                idTxtBox.Text = "1";
                ConfigJson.dataTable = new DataList();
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Atsaukti mygtuko paspaudimo EventHandler
            //Susirandam pagrindine funkcija ir ja ijungiam, o sia forma paslepiam
            var mainForm = Application.OpenForms["MainForm"];
            mainForm.Enabled = true;
            this.Hide();
        }
        private void AddItemFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Jei forma uzsidarineja, atliksim sia funkcija
            cancelBtn_Click((object) sender, e);
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            bool proceed = true;//Ar tesime su paciu redagavimu ar neredaguosim del klaidu
            if (string.IsNullOrWhiteSpace(nameTxtBox.Text))//Jei pavadinimo laukas tuscias tai iskelsim kaip klaida
            {
                nameIndicatorLbl.Visible = true;
                proceed = false;
            }
            else
            {
                nameIndicatorLbl.Visible = false;
            }
            if(!string.IsNullOrWhiteSpace(quantityTxtBox.Text))//Jei pavadinimo laukas tuscias tai iskelsim kaip klaida
            {
                if(!Regex.IsMatch(quantityTxtBox.Text, @"^\d*$"))//Jei kiekio laukas sudarytas is kazko kas nera skaiciai tai iskelsim klaida
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
            if(!string.IsNullOrEmpty(priceTxtBox.Text))
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

            if(proceed)//Jei klaida nebuvo iskelta, reiskias duomenys buvo suvesti teisingai
            {
                //Susikursim nauja objekta kuris laikys musu nauja informacija, taipogi informacija susidesim i objekta
                Item item = new Item();
                item.Id = Convert.ToInt32(idTxtBox.Text);
                item.Pavadinimas = nameTxtBox.Text;
                item.Kiekis = Convert.ToInt32(quantityTxtBox.Text);
                item.Kaina = Convert.ToDouble(priceTxtBox.Text);

                ConfigJson.dataTable.Items.Add(item);//Objekta idesim i musu sarasa

                //Isjungsim visas perspejimo zinutes ir istrinsim visus laukelius
                //Taciau neuzdarysim formos, galbut prideti dar nores
                nameIndicatorLbl.Visible = false;
                quantityIndicatorLbl.Visible = false;
                priceIndicatorLbl.Visible = false;
                indicationLbl.Visible = false;
                idTxtBox.Text = (Convert.ToInt32(idTxtBox.Text) + 1).ToString();
                nameTxtBox.Text = "";
                quantityTxtBox.Text = "";
                priceTxtBox.Text = "";
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
