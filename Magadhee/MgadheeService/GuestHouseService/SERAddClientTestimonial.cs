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
   public class SERAddClientTestimonial
    {

       DALAddClientTestimonial DALCust = new DALAddClientTestimonial();

       public DataTable SERV_Ref_Client_Testimonials_SelectAll()
        {
            return DALCust.DAL_Ref_Client_Testimonials_SelectAll();
        }

       public DataTable SERV_Ref_Client_Testimonials_Selected(DECVariables.ClsCust_Test DECCust)
        {
            return DALCust.DAL_Ref_Client_Testimonials_Selected(DECCust);
        }

       public DataTable SERV_Ref_Client_Testimonials_Wise_Guest_Selected(DECVariables.ClsCust_Test DECCust)
        {
            return DALCust.DAL_Ref_Client_Testimonials_Wise_Guest_Selected(DECCust);
        }


       public string SERV_Ref_Client_Testimonials_Insert_Main(DECVariables.ClsCust_Test DECCust, List<DECVariables.ClsCust_Test> list2)
        {
            return DALCust.DAL_Ref_Client_Testimonials_Insert_Main(DECCust, list2);
        }

       public string SERV_Ref_Client_Testimonials_Update_Main(DECVariables.ClsCust_Test DECCust, List<DECVariables.ClsCust_Test> list2)
        {
            return DALCust.DAL_Ref_Client_Testimonials_Update_Main(DECCust, list2);
        }

       public string SERV_Ref_Client_Testimonials_Delete(DECVariables.ClsCust_Test DECCust)
        {
            return DALCust.DAL_Ref_Client_Testimonials_Delete(DECCust);
        }

    }
}
