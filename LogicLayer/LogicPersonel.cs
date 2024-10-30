using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;


namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelList();
        }
        public static int LLPersonelCount(EntityPersonel entity) 
        {
            if (entity.Ad != "" && entity.Soyad != "" && entity.Maas >=3500 && entity.Gorev != "" )
            {
                return DALPersonel.PersonelEkle(entity);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLPersonelSil(int per)
        {
            if (per >= 1)
            {
                return DALPersonel.PersonelSil(per);
            }
            else
            {
                return false;
            }

        }

        public static bool LLPersonelGuncelle(EntityPersonel ent)
        {
            return DALPersonel.PersonelGuncelle(ent);
        }
    }
}
