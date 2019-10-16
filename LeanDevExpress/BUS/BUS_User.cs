using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeanDevExpress.BUS
{
    class BUS_User
    {
        DAL.DAL_User dalUser;
        public BUS_User()
        {
            dalUser = new DAL.DAL_User();
        }

        public int getLogin(DTO.DTO_User user)
        {
            return dalUser.getLogin(user);
        }
    }
}
