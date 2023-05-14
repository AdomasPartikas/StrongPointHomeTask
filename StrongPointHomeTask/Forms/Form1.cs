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
using System.Linq;
using StrongPointHomeTask.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StrongPointHomeTask
{
    public partial class MainForm : Form
    {
        public static Item Delegate = new Item();

        public MainForm()
        {
            InitializeComponent();
        }

        public DataList SortById(DataList data)
        {
            var sortedDataList = data.Items.OrderBy(x => x.Id);
            data.Items = sortedDataList.ToList();

            return data;
        }
        public DataList SortByName(DataList data)
        {
            var sortedDataList = data.Items.OrderBy(x => x.Pavadinimas); //Su linq parasytas 'RusiuokPagal' 
            data.Items = sortedDataList.ToList(); //Susidedam viska kaip susirusiavom

            return data;
        }
        public void FillList(DataList dataList)
        {
            lenteleListView.Items.Clear(); //Istrinam visa lentele

            if (dataList != null && dataList.Items != null) //Patikrinam jog isties yra duomenu kuriuos galim ideti i lentele
            {
                foreach (var row in dataList.Items) //Kekvienam saraso elementuo skiriam eilute
                {
                    var newRow = new ListViewItem(row.Id.ToString());
                    newRow.SubItems.Add(row.Pavadinimas);
                    newRow.SubItems.Add(row.Kiekis.ToString());
                    newRow.SubItems.Add(row.Kaina.ToString());

                    lenteleListView.Items.Add(newRow);
                }
            }

            GC.Collect();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Isijungus programai, visu pirma istraukiam duomenis is json failo
            var configJson = new ConfigJson();
            configJson.GetDataAsync().GetAwaiter().GetResult(); //Naudojam async, todel paprasom palaukti

            FillList(ConfigJson.dataTable); //Uzpildom lentele
        }
        private void sortBtn_Click(object sender, EventArgs e)
        {
            //Paspaudus mygtuka "Rusiuoti" iskvieciamas sis EventHandler
            if(sortBtn.Text == "Rušiuoti (Pav.)")//Jei mygtuko pavadinimas sitoks
            {
                sortBtn.Text = "Rušiuoti (Id)"; //Tada pakeiciam i kitoki
                FillList(SortByName(ConfigJson.dataTable));//Ir iskvieciam funkcija "Rusiuok pagal varda"
                //Taip darydamas vis keisis vardas ir bus iskvieciamas vis kitas rusiavimas
            }
            else
            {
                sortBtn.Text = "Rušiuoti (Pav.)";
                FillList(SortById(ConfigJson.dataTable));
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            //Paspaudus "Prideti" mygtuka iskvieciam si EventHandler
            if (Application.OpenForms["AddItemFrm"] == null) //Ieskom ar jau tokiu pavadinimu forma buvo atidaryta
            {
                //Taip darom del kompiuterio resursu, nereikia atidaryti to kas atidarytas
                AddItemFrm s = new AddItemFrm();//Jei tokia forma dar nebuvo sukurta tai ja sukuriam ir atidarom
                s.Show();
            }
            else
            {
                var s = Application.OpenForms["AddItemFrm"]; //Jei tokia forma buvo sukurta tai susirandam ja atmintyje ir priskiriam prie kintamojo
                s.Show();
            }
            this.Enabled = false; //Padarom jog pagrindines formos butu neimanoma valdyti kol atidaryta kita
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (lenteleListView.SelectedItems.Count == 0) //Jei nebuvo pazymeta jokiu eiluciu, tai isjungiam funkcija
                return;
            foreach(ListViewItem row in lenteleListView.SelectedItems)//Jei buvo pazymeta bent viena, einam per visas eilutes kurios buvo pazymetos
            {
                var id = row.SubItems[0].Text; //Kiekvienos eilutes id issitraukiam
                lenteleListView.Items.Remove(row); //Gan lengvokai istrinam eilute is "ListView"
                //Taciau paspaudus rusiuoti si eilute griztu, tai mums reikia dar istrinti ja is pagrindinio saraso
                for (int i = 0; i < ConfigJson.dataTable.Items.Count; i++) //Keliaujam per visa sarasa
                {
                    if (id.ToString() == ConfigJson.dataTable.Items[i].Id.ToString()) //Kai sarase randam id kuris atitinka pazymetos eilutes
                    {
                        ConfigJson.dataTable.Items.RemoveAt(i); //Istrinam
                        break;
                    }
                }
            }
            FillList(ConfigJson.dataTable); //Atnaujinam lentele
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (lenteleListView.SelectedItems.Count == 0)//Jei nebuvo pazymeta jokiu eiluciu, tai isjungiam funkcija
                return;
            foreach (ListViewItem row in lenteleListView.SelectedItems)//Jei buvo pazymeta bent viena, einam per visas eilutes kurios buvo pazymetos
            {
                Delegate.Id = Convert.ToInt32(row.SubItems[0].Text);
                Delegate.Pavadinimas = row.SubItems[1].Text.ToString();
                Delegate.Kiekis = Convert.ToInt32(row.SubItems[2].Text);
                Delegate.Kaina = Convert.ToDouble(row.SubItems[3].Text);
                //Pasiemam visus eilutes duomenis ir duodam kintamajam prie kurio tures prieeiga kita klase.
                //Formos sukurimo patikra kartojasi
                if (Application.OpenForms["EditItemForm"] == null)
                {
                    EditItemForm s = new EditItemForm();
                    s.Show();
                }
                else
                {
                    var s = Application.OpenForms["EditItemForm"];
                    s.Show();
                }
                this.Enabled = false;
            }

            FillList(ConfigJson.dataTable); //Atnaujinam lentele
        }
        private void searchTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) //Jei search dezuteje budami paspaudete "Enter", bus tas pats kaip paspausti mygtuka "Ieskoti"
            {
                searchBtn_Click(sender, e);
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataList filteredDataList = new DataList(); //Susikuriam kur laikysime savo filtruota lentele
            filteredDataList.Items = new List<Item>(); //Butinai inicializuojame sarasa

            if(!string.IsNullOrWhiteSpace(searchTxtBox.Text))//Paklausiam ar paieskos dezute tuscia (space irgi skaitosi kaip tuscia)
            {
                //Jei netuscia tikriname koks tai bus filtravimas
                searchIndicatorLbl.Visible = false; //Vartotojui ispejamoji zinute nebereikalinga, tad ja isjungiame

                if(Regex.IsMatch(searchTxtBox.Text,@"^\d*$")) //Patikrinam ar tekstas paieskos lauke yra tik skaiciai
                {
                    //Jei taip vadinasi cia ID
                    var id = searchTxtBox.Text;

                    for (int i = 0; i < ConfigJson.dataTable.Items.Count; i++)
                    {
                        if (id == ConfigJson.dataTable.Items[i].Id.ToString())
                        {
                            //Keliaujam per sarasa, susirandam kas atitinka ID
                            //Ir tada isidedam i filtruota lentele
                            Item item = new Item();
                            item.Id = ConfigJson.dataTable.Items[i].Id;
                            item.Pavadinimas = ConfigJson.dataTable.Items[i].Pavadinimas;
                            item.Kiekis = ConfigJson.dataTable.Items[i].Kiekis;
                            item.Kaina = ConfigJson.dataTable.Items[i].Kaina;

                            filteredDataList.Items.Add(item);
                            break;
                        }
                    }
                }
                else
                {
                    //Jei ne, tuomet laikysime tai kaip pavadinima
                    var name = searchTxtBox.Text;

                    for (int i = 0; i < ConfigJson.dataTable.Items.Count; i++)
                    {
                        //Visuose pavadinimuose ieskome paieskos eiluteje irasytu zodziu, jei randame, juos isvedame
                        if (ConfigJson.dataTable.Items[i].Pavadinimas.ToString().Contains(name))
                        {
                            Item item = new Item();
                            item.Id = ConfigJson.dataTable.Items[i].Id;
                            item.Pavadinimas = ConfigJson.dataTable.Items[i].Pavadinimas;
                            item.Kiekis = ConfigJson.dataTable.Items[i].Kiekis;
                            item.Kaina = ConfigJson.dataTable.Items[i].Kaina;

                            filteredDataList.Items.Add(item);
                        }
                    }
                }

                FillList(filteredDataList);
            }
            else
            {
                FillList(ConfigJson.dataTable);
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Jei bet kokiu atveju forma uzsidarineja, visa lentele issirasome i json dokumenta
            var config = new ConfigJson();
            config.StoreDataAsync().GetAwaiter().GetResult();
        }
        private void MainForm_EnabledChanged(object sender, EventArgs e)
        {
            //Jei formos "Ijungtas" statusas keitinejasi, tai atnaujiman lentele
            //Taip darom del pridejimo ir redagavimo, kadangi sios funkcijos veikia skirtingose formose
            FillList(ConfigJson.dataTable);
        }
        private void helpChckBox_CheckedChanged(object sender, EventArgs e)
        {
            //Jei Pagalbos dezute buvo ijungta tai ijungiame visus teksto laukelius
            //Ir vice versa
            if(helpChckBox.Checked)
            {
                searchHelpLbl.Visible = true;
                addHelpLbl.Visible = true;
                editHelpLbl.Visible = true;
                sortHelpLbl.Visible = true;
            }
            else
            {
                searchHelpLbl.Visible = false;
                addHelpLbl.Visible = false;
                editHelpLbl.Visible = false;
                sortHelpLbl.Visible = false;
            }
        }
    }
}
