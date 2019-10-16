using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LeanDevExpress.BUS
{
    class BUS_Oder
    {
        DAL.DAL_Oder dalOder;
        public BUS_Oder()
        {
            dalOder = new DAL.DAL_Oder();
        }

        public DataTable getAllProductOder(DTO.DTO_Oder Oder)
        {
            return dalOder.getAllProductOder(Oder);
        }
        public DataTable getAllOder(DTO.DTO_Oder Oder)
        {
            return dalOder.getAllOder(Oder);
        }

        public bool insertOder(DTO.DTO_Oder Oder)
        {
            return dalOder.insertOder(Oder);
        }

        public bool updateOder(DTO.DTO_Oder Oder)
        {
            return dalOder.updateOder(Oder);
        }

        public bool deleteOder(DTO.DTO_Oder Oder)
        {
            return dalOder.deleteOder(Oder);
        }
    }
}
