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
   public class SERAddAttractions
    {

       DALAddAttractions DALAtt = new DALAddAttractions();

       public DataTable SERV_Ref_Settings_SelectAll()
       {
           return DALAtt.DAL_Ref_Settings_SelectAll();
       }

       public DataTable SERV_Ref_Attraction_SelectAll()
        {
            return DALAtt.DAL_Ref_Attraction_SelectAll();
        }

       public DataTable SERV_Ref_Attraction_Selected(DECVariables.ClsAddAttractions DECAtt)
        {
            return DALAtt.DAL_Ref_Attraction_Selected(DECAtt);
        }

       public DataTable SERV_Ref_Attraction_Wise_Guest_Selected(DECVariables.ClsAddAttractions DECAtt)
        {
            return DALAtt.DAL_Ref_Attraction_Wise_Guest_Selected(DECAtt);
        }


       public string SERV_Ref_Attraction_Insert_Main(DECVariables.ClsAddAttractions DECAtt, List<DECVariables.ClsAddAttractions> list2)
        {
            return DALAtt.DAL_Ref_Attraction_Insert_Main(DECAtt, list2);
        }

       public string SERV_Ref_Attraction_Update_Main(DECVariables.ClsAddAttractions DECAtt, List<DECVariables.ClsAddAttractions> list2)
        {
            return DALAtt.DAL_Ref_Attraction_Update_Main(DECAtt, list2);
        }

       public string SERV_Ref_Attraction_Delete(DECVariables.ClsAddAttractions DECAtt)
        {
            return DALAtt.DAL_Ref_Attraction_Delete(DECAtt);
        }

    }
}
