using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LeanDevExpress.DAL
{
    class DAL_User
    {
     

        public DAL_User()
        {
            
        }
       
        public int getLogin( DTO.DTO_User user)
        {
            using (DataClasses1DataContext db = new DataClasses1DataContext())
            {
                var data = from c in db.tblUsers where c.username == user.username && c.password == user.password  select c;
                int i = 0;
                foreach (var e in data)
                {
                     i = 1;
                }

                if (i == 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
           
        }
    }

}
