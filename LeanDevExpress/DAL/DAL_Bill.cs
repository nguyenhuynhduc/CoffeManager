using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;




namespace LeanDevExpress.DAL
{
    class DAL_Bill
    {
       
        public DAL_Bill()
        {
            
        }
        public DataTable getBillYearMonthDay(int Year, int Month, int Day)
        {
            
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblBills
                        
                           where t1.dateTime.Year == Year && t1.dateTime.Month == Month && t1.dateTime.Day == Day
                           select t1;

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idBill", typeof(string));
                MyDataTable.Columns.Add("cost", typeof(string));
               
                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idBill"] = element.idBill;

                    row["cost"] = element.cost;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }

        }
        public DataTable getBillYearMonth(int Year, int Month)
        {

            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblBills

                           where t1.dateTime.Year == Year && t1.dateTime.Month == Month 
                           select t1;

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idBill", typeof(string));
                MyDataTable.Columns.Add("cost", typeof(string));

                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idBill"] = element.idBill;

                    row["cost"] = element.cost;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        
        }

        public DataTable getBillYear(int Year)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblBills

                           where t1.dateTime.Year == Year
                           select t1;

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idBill", typeof(string));
                MyDataTable.Columns.Add("cost", typeof(string));

                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idBill"] = element.idBill;

                    row["cost"] = element.cost;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
        }


        public DataTable getLastBill()
        {
     
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblBills
                           orderby t1.idBill
                           select t1 ;

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idBill", typeof(string));
                MyDataTable.Columns.Add("cost", typeof(string));

                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idBill"] = element.idBill;

                    row["cost"] = element.cost;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                    break;
                }

                return MyDataTable;
            }
        }
        public DataTable getAllBill()
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from t1 in db.tblBills
                           select t1;

                DataTable MyDataTable = new DataTable();

                MyDataTable.Columns.Add("idBill", typeof(string));
                MyDataTable.Columns.Add("cost", typeof(string));

                MyDataTable.Columns.Add("dateTime", typeof(string));
                foreach (var element in data)
                {
                    var row = MyDataTable.NewRow();
                    row["idBill"] = element.idBill;

                    row["cost"] = element.cost;

                    row["dateTime"] = element.dateTime;
                    MyDataTable.Rows.Add(row);
                }

                return MyDataTable;
            }
           
        }

        public bool insertBill(DTO.DTO_Bill bill)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                tblBill newBill = new tblBill();

                newBill.idBill = bill.idBill;
                newBill.cost = bill.cost;
                newBill.dateTime = bill.dateTime;
                db.tblBills.InsertOnSubmit(newBill);
                db.SubmitChanges();
                return true;
            }

        }
    }
}
