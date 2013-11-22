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
   public class SERAddHomeContent
    {

       DALAddHomeContent DALHome = new DALAddHomeContent();

       public DataTable SERV_Ref_Home_Content_Select()
        {
            return DALHome.DAL_Ref_Home_Content_SelectAll();
        }

       public string SERV_Ref_Home_Content_Insert(DECVariables.ClsAddHomeContent DECHome)
        {
            return DALHome.DAL_Ref_Home_Content_Insert(DECHome);
        }

       public string SERV_Ref_Home_Content_Update_Main(DECVariables.ClsAddHomeContent DECHome)
        {
            return DALHome.DAL_Ref_Home_Content_Update_Main(DECHome);
        }

       public string SERV_Ref_Home_Content_Delete(DECVariables.ClsAddHomeContent DECHome)
        {
            return DALHome.DAL_Ref_Home_Content_Delete(DECHome);
        }


    }
}
