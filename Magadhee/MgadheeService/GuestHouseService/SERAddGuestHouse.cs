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
   public class SERAddGuestHouse
    {

       DALAddGuestHouse DALGuest = new DALAddGuestHouse();

       public DataTable SERV_Ref_Guest_SelectAll()
        {
            return DALGuest.DAL_Ref_Guest_SelectAll();
        }

        public DataTable SERV_Ref_Guest_Selected(DECVariables.ClsAddGuestHouse DECGuest)
        {
            return DALGuest.DAL_Ref_Guest_Selected(DECGuest);
        }


        public string SERV_Ref_Guest_Insert_Main(DECVariables.ClsAddGuestHouse DECGuest)
        {
            return DALGuest.DAL_Ref_Guest_Insert_Main(DECGuest);
        }

        public string SERV_DAL_Ref_Guest_Update_Main_Main(DECVariables.ClsAddGuestHouse DECGuest)
        {
            return DALGuest.DAL_Ref_Guest_Update_Main(DECGuest);
        }

        public string SERV_Ref_Guest_Delete(DECVariables.ClsAddGuestHouse DECGuest)
        {
            return DALGuest.DAL_Ref_Guest_Delete(DECGuest);
        }

       //Joints for Guest-House
        public DataTable SERV_Joint_Ref_Guesthouse_Wise_Attraction_Select(DECVariables.ClsAddGuestHouse DECGuest)
        {
            return DALGuest.DAL_Joint_Ref_Guesthouse_Wise_Attraction_Select(DECGuest);
        }
        public DataTable SERV_Joint_Ref_Guesthouse_Wise_Promotion_Select(DECVariables.ClsAddGuestHouse DECGuest)
        {
            return DALGuest.DAL_Joint_Ref_Guesthouse_Wise_Promotion_Select(DECGuest);
        }
       
    }
}
