using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LeanDevExpress.DAL
{
    class DAL_DetailBill
    {
      

        public DAL_DetailBill()
        { 
        }
        public DataTable getAllDetailBill(DTO.DTO_DetailBill deTailBill)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblDetailBills
                           join t2 in db.tblProducts on t1.idProduct equals t2.idProduct
                           where t1.idBill == deTailBill.idBill
                           select new
                           {
                               t1.idBill,
                               t1.idDetailBill,
                               t1.amount,
                               t2.nameProduct,
                               t2.price
                           };

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idBill", typeof(string));
                MyDataTable.Columns.Add("idDetailBill", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("price", typeof(string));

                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idBill"] = element.idBill;
                    row["idDetailBill"] = element.idDetailBill;
                    row["amount"] = element.amount;
                    row["nameProduct"] = element.nameProduct;
                    row["price"] = element.price;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        }

        public DataTable getDetailBill()
        {
          
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblDetailBills
                           join t2 in db.tblProducts on t1.idProduct equals t2.idProduct
                           join t3 in db.tblBills on t1.idBill equals t3.idBill
                           select new
                           {
                               t1.idProduct,
                               t2.nameProduct,
                               t3.dateTime,
                               t1.amount,
                               
                               
                           };

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idProduct"] = element.idProduct;
                   
                    row["amount"] = element.amount;
                    row["nameProduct"] = element.nameProduct;
                   
                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        }

        public DataTable getDetailBillYear(int year)
        {
            
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblDetailBills
                           join t2 in db.tblProducts on t1.idProduct equals t2.idProduct
                           join t3 in db.tblBills on t1.idBill equals t3.idBill
                           where t3.dateTime.Year==year
                           select new
                           {
                               t1.idProduct,
                               t2.nameProduct,
                               t3.dateTime,
                               t1.amount,


                           };

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idProduct"] = element.idProduct;

                    row["amount"] = element.amount;
                    row["nameProduct"] = element.nameProduct;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        }



        public DataTable getDetailBillYearMonth(int year,int month)
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblDetailBills
                           join t2 in db.tblProducts on t1.idProduct equals t2.idProduct
                           join t3 in db.tblBills on t1.idBill equals t3.idBill
                           where t3.dateTime.Year == year && t3.dateTime.Month==month
                           select new
                           {
                               t1.idProduct,
                               t2.nameProduct,
                               t3.dateTime,
                               t1.amount,


                           };

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idProduct"] = element.idProduct;

                    row["amount"] = element.amount;
                    row["nameProduct"] = element.nameProduct;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        }

        public DataTable getDetailBillYearMonthDay(int year, int month,int day)
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblDetailBills
                           join t2 in db.tblProducts on t1.idProduct equals t2.idProduct
                           join t3 in db.tblBills on t1.idBill equals t3.idBill
                           where t3.dateTime.Year == year && t3.dateTime.Month==month && t3.dateTime.Day==day
                           select new
                           {
                               t1.idProduct,
                               t2.nameProduct,
                               t3.dateTime,
                               t1.amount,


                           };

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idProduct", typeof(string));
                MyDataTable.Columns.Add("amount", typeof(string));
                MyDataTable.Columns.Add("nameProduct", typeof(string));
                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idProduct"] = element.idProduct;

                    row["amount"] = element.amount;
                    row["nameProduct"] = element.nameProduct;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        }



        public bool insertDetailBill(DTO.DTO_DetailBill detailBill)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                tblDetailBill newDetailBill = new tblDetailBill();

                newDetailBill.idProduct = detailBill.idProduct;
                newDetailBill.amount = detailBill.amount;
                newDetailBill.idBill = detailBill.idBill;
                db.tblDetailBills.InsertOnSubmit(newDetailBill);
                db.SubmitChanges();
                return true;
            }
           
        }
       
    }
}
