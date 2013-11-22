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
   public class SERAddLocations
    {

       DALAddLocations DALAtt = new DALAddLocations();

       public DataTable SERV_Ref_Location_SelectAll()
        {
            return DALAtt.DAL_Ref_Location_SelectAll();
        }

       public DataTable SERV_Ref_Location_Selected(DECVariables.ClsLocation DECAtt)
        {
            return DALAtt.DAL_Ref_Location_Selected(DECAtt);
        }

        public DataTable SERV_Ref_Location_Wise_Guest_House_Selected(DECVariables.ClsLocation DECAtt)
        {
            return DALAtt.DAL_Ref_Location_Wise_Guest_House_Selected(DECAtt);
        }


        public string SERV_Ref_Location_Insert_Main(DECVariables.ClsLocation DECAtt, List<DECVariables.ClsLocation> list2)
        {
            return DALAtt.DAL_Ref_Location_Insert_Main(DECAtt, list2);
        }

        public string SERV_Ref_Location_Update_Main(DECVariables.ClsLocation DECAtt, List<DECVariables.ClsLocation> list2)
        {
            return DALAtt.DAL_Ref_Location_Update_Main(DECAtt, list2);
        }

        public string SERV_Ref_Location_Delete(DECVariables.ClsLocation DECAtt)
        {
            return DALAtt.DAL_Ref_Location_Delete(DECAtt);
        }

    }
}
