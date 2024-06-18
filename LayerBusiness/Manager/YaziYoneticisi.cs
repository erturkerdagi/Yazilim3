using LayerBusiness.Interface;
using LayerDataAccess;
using LayerEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerBusiness.Manager
{
    public class YaziYoneticisi : IYaziServis
    {
        IYaziDAL db;
        public YaziYoneticisi(IYaziDAL YaziDAL)
        {
            db = YaziDAL;
        }
        public void YaziEkle(Yazi Yazi)
        {
            db.Ekle(Yazi);
        }
        public Yazi YaziGetir(int id)
        {
            return db.Getir(id);
        }
        public Yazi YaziGetir(Yazi Yazi)
        {
            return db.Getir(Yazi);
        }
        public void YaziGuncelle(Yazi Yazi)
        {
            db.Guncelle(Yazi);
        }
        public List<Yazi> YaziGetir()
        {
            return db.TumunuGetir();
        }
        public void YaziSil(Yazi Yazi)
        {
            db.Sil(Yazi);
        }
    }
}
