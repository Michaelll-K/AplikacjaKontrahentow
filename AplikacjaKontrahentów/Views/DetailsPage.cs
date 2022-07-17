using AplikacjaKontrahentów.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKontrahentów.Views
{
    public partial class DetailsPage : Form
    {
        Kontrahenci kontrahent;
        Mode mode;
        MainPage mainP;

        public DetailsPage(MainPage mainP, Kontrahenci kontrahent, Mode mode)
        {
            InitializeComponent();
            this.kontrahent = kontrahent;
            this.mode = mode;
            this.mainP = mainP;
        }
        public DetailsPage(MainPage mainP, Mode mode)
        {
            InitializeComponent();
            this.mode = mode;
            this.mainP = mainP;
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {
            cbbType.Items.Clear();
            DBEntities dBEntities = new DBEntities();
            TypyKontrahentów[] types = dBEntities.TypyKontrahentów.ToArray();

            foreach (var type in types)
            {
                cbbType.Items.Add(type.Nazwa);
            }

            if (mode == Mode.Edit)
            {
                lblTitle.Text = "Edytuj";

                txtName.Text = kontrahent.Nazwa;
                txtNIP.Text = kontrahent.Nip;
                cbbType.SelectedIndex = kontrahent.IdTypu - 1;
                txtDescription.Text = kontrahent.OpisFirmy;
                ckbActive.Checked = kontrahent.Aktywny;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ContractorsManager cm = new ContractorsManager();

            if (new BoxedValues()
                .CheckIfCorrect(
                txtName.Text,
                txtNIP.Text,
                cbbType.SelectedIndex,
                txtDescription.Text))
            {
                Kontrahenci newContractor = new Kontrahenci
                {
                    Nazwa = txtName.Text,
                    Nip = txtNIP.Text,
                    IdTypu = cbbType.SelectedIndex + 1,
                    OpisFirmy = txtDescription.Text,
                    Aktywny = ckbActive.Checked
                };

                if (mode == Mode.Add)
                {
                    cm.Add(newContractor);
                }
                else if (mode == Mode.Edit)
                {
                    newContractor.Id = kontrahent.Id;
                    cm.Update(newContractor);
                }

                Close();
                mainP.ShowRefresh();
            }
            else
            {
                MessageBox.Show("Niepoprawne wartości", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
