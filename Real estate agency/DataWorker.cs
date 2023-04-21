using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_estate_agency
{
    public static class DataWorker
    {
        public static Client GetClient(int ID)
        {
            Client client = null;
            using (Real_estate_agencyEntities5 db = new Real_estate_agencyEntities5()) { client = db.Client.FirstOrDefault(c => c.ID == ID); }
            return client;
        }
        public static Apartment GetKvatir(int ID)
        {
            Apartment client = null;
            using (Real_estate_agencyEntities5 db = new Real_estate_agencyEntities5()) { client = db.Apartment.FirstOrDefault(c => c.ID == ID); }
            return client;
        }
    }
}
