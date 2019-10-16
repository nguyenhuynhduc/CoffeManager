using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LeanDevExpress.DAL
{
    class DAL_Table
    {
      
        public DAL_Table()
        {
           
        }
       
        public DataTable getLastTable()
        {
          using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = (from c in db.tblTables orderby c.idTable descending select c);

                DataTable MyDataTable = new DataTable();
                MyDataTable.Columns.Add("idTable", typeof(string));
                MyDataTable.Columns.Add("name", typeof(string));

                foreach (var en in data)
                {
                    var row = MyDataTable.NewRow();
                    row["name"] = en.name;
                    row["idTable"] = en.idTable;
                    MyDataTable.Rows.Add(row);

                    break;
                }
                return MyDataTable;
            }
        }

        public DataTable getAlltable()
        { 
             using  (DataClasses1DataContext db = new DataClasses1DataContext())
             {
             var data = from c in db.tblTables select c;
            
             DataTable MyDataTable = new DataTable();

             MyDataTable.Columns.Add("idTable", typeof(string));
             MyDataTable.Columns.Add("name", typeof(string));

             foreach (var element in data)
             {
                 var row = MyDataTable.NewRow();
                 row["name"] = element.name;
                 row["idTable"] = element.idTable;
                 MyDataTable.Rows.Add(row);
             }

             return MyDataTable;
             }
        }

        public bool inserttable(DTO.DTO_Table table)
        {

            DataTable dt = getLastTable();

            int name = Convert.ToInt16(dt.Rows[0]["name"])+1;
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                tblTable table1 = new tblTable();
                table1.name = name;
                table1.status = "action";
                db.tblTables.InsertOnSubmit(table1);
                db.SubmitChanges();
                return true;
            }
           
        }
        public bool updatetable(DTO.DTO_Table table)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
               var update = db.tblTables.Where(p => p.idTable.Equals(table.idTable)).SingleOrDefault();
               update.name = table.name;
                db.SubmitChanges();
                return true;
            }

        }
        public bool deletetable(DTO.DTO_Table table)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var delete = db.tblTables.Where(p => p.idTable.Equals(table.idTable)).SingleOrDefault();

                db.tblTables.DeleteOnSubmit(delete);
                db.SubmitChanges();
                return true;
            }
        }
    }
    
}
