using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaKontrahentów.Tools
{
    internal class ContractorsManager
    {
        public ListViewItem GetViewItem(Kontrahenci kontrahent)
        {
            ListViewItem item = new ListViewItem(kontrahent.Nazwa);
            item.SubItems.Add(kontrahent.Nip);
            item.Tag = kontrahent;
            return item;
        }
        public void Add(Kontrahenci kontrahent)
        {
            DBEntities dbEntities = new DBEntities();
            dbEntities.Kontrahenci.Add(kontrahent);
            dbEntities.SaveChanges();

            
        }

        public void Update(Kontrahenci kontrahent)
        {
            DBEntities dbEntities = new DBEntities();
            Kontrahenci updatedContracotr = dbEntities.Kontrahenci.FirstOrDefault(x => x.Id == kontrahent.Id);
            
            updatedContracotr.Nazwa = kontrahent.Nazwa;
            updatedContracotr.Nip = kontrahent.Nip;
            updatedContracotr.IdTypu = kontrahent.IdTypu;
            updatedContracotr.OpisFirmy = kontrahent.OpisFirmy;
            updatedContracotr.Aktywny = kontrahent.Aktywny;

            dbEntities.SaveChanges();
        }

        public void Delete(int id)
        {
            DBEntities dbEntities = new DBEntities();
            var contractorToDelete = dbEntities.Kontrahenci.FirstOrDefault(x => x.Id == id);
            dbEntities.Kontrahenci.Remove(contractorToDelete);
            dbEntities.SaveChanges();
        }
    }
}
