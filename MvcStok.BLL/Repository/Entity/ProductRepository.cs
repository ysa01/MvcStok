using MvcStok.BLL.Repository.Base;
using MvcStok.DAL;

namespace MvcStok.BLL.Repository.Entity
{
    public class ProductRepository : BaseRepository<TBLURUNLER>
    {
        public void Guncelle(TBLURUNLER p1)
        {
            var bul = Find(p1.URUNID);
            bul.URUNADI = p1.URUNADI;
            bul.URUNKATEGORI = p1.URUNKATEGORI;
            bul.MARKA = p1.MARKA;
            bul.STOK = p1.STOK;
            bul.FIYAT = p1.FIYAT;
            Save();
        }
        //public int List<TBLKATEGORILER>(int CategoryID)
        //{
        //    //TBLKATEGORILER kat = new TBLKATEGORILER()
        //    //{
        //    //    KATEGORIID = CategoryID
        //    //};
            
        //}
    }
}
