using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LeanDevExpress.DAL
{
    class DAL_Oder
    {
        
        
        public DAL_Oder()
        {
          
        }
        public DataTable getAllProductOder(DTO.DTO_Oder Oder)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblOders
                           join t2 in db.tblProducts on t1.idProduct equals t2.idProduct
                           where t1.idTable == Oder.idTable && t1.idProduct == Oder.idProduct
                           select new { t1.idOrder,
                               t1.idProduct,
                               t1.idTable
                               ,t1.amount
                               ,t2.nameProduct
                               ,t2.price
                           };

                DataTable MyDataTable = new DataTable();
                MyDataTable.Columns.Add("idOrder", typeof(string));
                MyDataTable.Columns.Add("idTable", typeof(string));
                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));
                MyDataTable.Columns.Add("price", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idOrder"] = element.idOrder;
                    row["idTable"] = element.idTable;
                    row["idProduct"] = element.idProduct;
                    row["nameProduct"] = element.nameProduct;
                    row["amount"] = element.amount;
                    row["price"] = element.price;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }







        }
        public DataTable getAllOder(DTO.DTO_Oder Oder)
        {
            
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblOders
                           join t2 in db.tblProducts on t1.idProduct equals t2.idProduct
                           where t1.idTable == Oder.idTable
                           select new
                           {
                               t1.idOrder,
                               t1.idProduct,
                               t1.idTable
                               ,
                               t1.amount
                               ,
                               t2.nameProduct
                               ,
                               t2.price
                           };

                DataTable MyDataTable = new DataTable();
                MyDataTable.Columns.Add("idOrder", typeof(string));
                MyDataTable.Columns.Add("idTable", typeof(string));
                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));
                MyDataTable.Columns.Add("price", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idOrder"] = element.idOrder;
                    row["idTable"] = element.idTable;
                    row["idProduct"] = element.idProduct;
                    row["nameProduct"] = element.nameProduct;
                    row["amount"] = element.amount;
                    row["price"] = element.price;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
           
        }

        public bool insertOder(DTO.DTO_Oder Oder)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                tblOder newOder = new tblOder();
                newOder.idTable = Oder.idTable;
                newOder.idProduct = Oder.idProduct;
                newOder.amount = Oder.amount;
                db.tblOders.InsertOnSubmit(newOder);
                db.SubmitChanges();
                return true;
            }
           
        }
        public bool updateOder(DTO.DTO_Oder Oder)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var update = db.tblOders.Where(p => p.idOrder.Equals(Oder.idOrder)).SingleOrDefault();
                update.idProduct = Oder.idProduct;
                update.idTable = Oder.idTable;
                update.amount = Oder.amount;
                db.SubmitChanges();
                return true;
            }

        }
        public bool deleteOder(DTO.DTO_Oder Oder)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var delete = db.tblOders.Where(p => p.idOrder.Equals(Oder.idOrder)).SingleOrDefault();

                db.tblOders.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }

        }
    }
}
