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
   public class SERRequests
    {
       DALRequests DReq = new DALRequests();



       public DataTable SERV_Trn_Request_Master_Selected(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Master_Selected(DECReq);
       }

       public DataTable SERV_Trn_Request_Wise_Comments_Select_Request_wise(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Wise_Comments_Select_Request_wise(DECReq);
       }

       public DataTable SERV_Trn_Request_Master_Select_All()
       {
           return DReq.DAL_Trn_Request_Master_Select_All();
       }

       public DataTable SERV_Trn_Request_Master_Select_All_Confirmed()
       {
           return DReq.DAL_Trn_Request_Master_Select_All_Confirmed();
       }

       public string SERV_Ref_Attraction_Insert_Main(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Master_Insert_Main(DECReq);
       }

       public string SERV_Trn_Request_Master_Confirmed_Update(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Master_Confirmed_Update(DECReq);
       }

       public string SERV_Trn_Request_Master_Cancel_Update(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Master_Cancel_Update(DECReq);
       }

       public string SERV_Trn_Request_Wise_Comments_Insert_Main(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Wise_Comments_Insert_Main(DECReq);
       }

       public string SERV_Trn_Request_Master_Update(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Master_Update(DECReq);
       }

       public string SERV_Trn_Request_Compleated_Insert_Main(DECVariables.ClsRequest DECReq)
       {
           return DReq.DAL_Trn_Request_Compleated_Insert_Main(DECReq);
       }
       
       
    }
}
