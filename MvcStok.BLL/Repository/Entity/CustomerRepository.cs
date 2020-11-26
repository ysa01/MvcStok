using MvcStok.BLL.Repository.Base;
using MvcStok.DAL;

namespace MvcStok.BLL.Repository.Entity
{
    public class CustomerRepository : BaseRepository<TBLMUSTERILER>
    {
        public void CustomerUpdate(TBLMUSTERILER cus)
        {
            var bul = Find(cus.MUSTERIID);
            bul.MUSTERIADI = cus.MUSTERIADI;
            bul.MUSTERISOYADI = cus.MUSTERISOYADI;
            Save();
        }
    }
}
