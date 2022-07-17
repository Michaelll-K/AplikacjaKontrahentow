using AplikacjaKontrahentów.Tools;
using AplikacjaKontrahentów.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKontrahentów
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        DetailsPage dPage;

        public void ShowRefresh()
        {
            lvContractors.Items.Clear();

            DBEntities dBEntities = new DBEntities();
            Kontrahenci[] kontrahenci = dBEntities.Kontrahenci.ToArray();


            foreach (var kontrahent in kontrahenci)
            {
                ContractorsManager manager = new ContractorsManager();
                var item = manager.GetViewItem(kontrahent);
                lvContractors.Items.Add(item);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            ShowRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dPage = new DetailsPage(this, Mode.Add);
            dPage.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvContractors.SelectedItems.Count != 0)
            {
                Kontrahenci selected = (Kontrahenci)lvContractors.SelectedItems[0].Tag;
                dPage = new DetailsPage(this, selected, Mode.Edit);
                dPage.Show();
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvContractors.SelectedItems.Count != 0)
            {
                ContractorsManager cm = new ContractorsManager();
                Kontrahenci selected = (Kontrahenci)lvContractors.SelectedItems[0].Tag;
                cm.Delete(selected.Id);
                ShowRefresh();
            }
        }

    }
}
