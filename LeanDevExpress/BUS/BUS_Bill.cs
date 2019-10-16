using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LeanDevExpress.BUS
{
    class BUS_Bill
    {
        DAL.DAL_Bill dalBill;
       
        public BUS_Bill()
        {
            dalBill = new DAL.DAL_Bill();
        }
        public DataTable getBillYearMonthDay(int Year, int Month, int Day)
        {
            return dalBill.getBillYearMonthDay(Year, Month, Day);
        }
        public DataTable getBillYear(int Year)
        {
            return dalBill.getBillYear(Year);
        }
        public DataTable getBillYearMonth(int Year,int Month)
        {
            return dalBill.getBillYearMonth(Year,Month);
        }
        public DataTable getLastBill()
        {
           return dalBill.getLastBill();
        }
        public DataTable getAllBill()
        {
            return dalBill.getAllBill();
        }
        public bool insertBill(DTO.DTO_Bill bill)
        {
            return dalBill.insertBill(bill);
        }
    }
}
