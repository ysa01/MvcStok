using MvcStok.BLL.Repository.Base;
using MvcStok.DAL;


namespace MvcStok.BLL.Repository.Entity
{
    public class CategoryRepository : BaseRepository<TBLKATEGORILER>
    {
        public void CategoryUpdate(TBLKATEGORILER p1)
        {
            var bul = Find(p1.KATEGORIID);
            bul.KATEGORIAD = p1.KATEGORIAD;
            Save();
        }
      //public TBLKATEGORILER GetCategory(int CategoryID)
      //  {
            

      //  }
    }
}
