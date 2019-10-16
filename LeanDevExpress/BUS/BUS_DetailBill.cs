using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LeanDevExpress.BUS
{
    class BUS_DetailBill
    {
        DAL.DAL_DetailBill dalBill;
        public BUS_DetailBill()
        {
            dalBill = new DAL.DAL_DetailBill();
        }
        public DataTable getAllDetailBill(DTO.DTO_DetailBill bill)
        {
            return dalBill.getAllDetailBill(bill);
        }
        public bool insertDetailBill(DTO.DTO_DetailBill bill)
        {
            return dalBill.insertDetailBill(bill);
        }
        public DataTable getDetailBill()
        {
            return dalBill.getDetailBill();
        }

        public DataTable getDetailBillYear(int year)
        {
            return dalBill.getDetailBillYear(year);
        }

        public DataTable getDetailBillYearMonth(int year, int month)
        {
            return dalBill.getDetailBillYearMonth(year, month);
        }

        public DataTable getDetailBillYearMonthDay(int year, int month, int day)
        {
            return dalBill.getDetailBillYearMonthDay(year, month,day);
        }
    }
}
