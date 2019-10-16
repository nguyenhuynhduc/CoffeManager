using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LeanDevExpress.BUS
{
    class BUS_Table
    {
        DAL.DAL_Table dalTable;

        

        public BUS_Table()
        {
            dalTable = new DAL.DAL_Table();
        }
        public DataTable getLastTable()
        {
            return dalTable.getLastTable();
        }

        public DataTable getAlltable()
        {
            return dalTable.getAlltable(); 
        }
        public bool insertTable(DTO.DTO_Table table)
        {
            return dalTable.inserttable(table);
        }
        public bool updateTable(DTO.DTO_Table table)
        {
            return dalTable.updatetable(table);
        }
        public bool deleteTable(DTO.DTO_Table table)
        {
            return dalTable.deletetable(table);
        }
    }
}
