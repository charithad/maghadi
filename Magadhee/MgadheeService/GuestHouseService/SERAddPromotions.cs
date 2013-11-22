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
   public class SERAddPromotions
    {

       DALAddPromotions DALAtt = new DALAddPromotions();

       public DataTable SERV_Ref_Promotions_Select_All()
        {
            return DALAtt.DAL_Ref_Promotions_Select_All();
        }

        public DataTable SERV_Ref_Promotions_Selected(DECVariables.ClsPromotions DECAtt)
        {
            return DALAtt.DAL_Ref_Promotions_Selected(DECAtt);
        }

        public DataTable SERV_Ref_Promotions_Wise_Guest_Selected(DECVariables.ClsPromotions DECAtt)
        {
            return DALAtt.DAL_Ref_Promotions_Wise_Guest_Selected(DECAtt);
        }


        public string SERV_Ref_Promotions_Insert_Main(DECVariables.ClsPromotions DECAtt, List<DECVariables.ClsPromotions> list2)
        {
            return DALAtt.DAL_Ref_Promotions_Insert_Main(DECAtt, list2);
        }

        public string SERV_Ref_Promotions_Update_Main(DECVariables.ClsPromotions DECAtt, List<DECVariables.ClsPromotions> list2)
        {
            return DALAtt.DAL_Ref_Promotions_Update_Main(DECAtt, list2);
        }

        public string SERV_Ref_Promotions_Delete(DECVariables.ClsPromotions DECAtt)
        {
            return DALAtt.DAL_Ref_Promotions_Delete(DECAtt);
        }

    }
}
