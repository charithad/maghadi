using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using MagadheeDAL;
using MagadheeDEC.GuestHouseDec;

namespace MgadheeService.GuestHouseService
{


    public class SERUsers
    {

        DALUse Duse = new DALUse();

        public DataTable SERV_Ref_Users_Select_All()
        {
            return Duse.DAL_Ref_Users_Select_All();
        }

        public DataTable SERV_Ref_Users_Selected(DECVariables.ClsUse Du)
        {
            return Duse.DAL_Ref_Users_Selected(Du);
        }

        public DataTable SERV_Ref_Users_Selected_Users(DECVariables.ClsUse Du)
        {
            return Duse.DAL_Ref_Users_Selected_Users(Du);
        }


        public string SERV_Ref_Users_Insert(DECVariables.ClsUse Du)
        {
            return Duse.DAL_Ref_Users_Insert(Du);
        }

        public string SERV_Ref_Users_Delete(DECVariables.ClsUse Du)
        {
            return Duse.DAL_Ref_Users_Delete(Du);
        }
    }
}
