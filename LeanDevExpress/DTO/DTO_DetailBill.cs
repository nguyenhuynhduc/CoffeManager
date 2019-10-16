using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanDevExpress.DTO
{
    class DTO_DetailBill
    {
        public int idDetailBill { set; get; }
        public int idBill { set; get; }
        public int idProduct { set; get; }
        public int amount { set; get; }
    }
}
