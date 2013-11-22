using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
   public class DALRequests
    {

       public DataTable DAL_Trn_Request_Master_Select_All()
       {
           return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Trn_Request_Master_Select_All);
       }

       public DataTable DAL_Trn_Request_Master_Select_All_Confirmed()
       {
           return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Trn_Request_Master_Select_All_Confirmed);
       }

       public DataTable DAL_Trn_Request_Master_Selected(DECVariables.ClsRequest DECReq)
       {
           Dictionary<string, object> Parameters = new Dictionary<string, object>();
           Parameters.Add(DataParameter.ClsRequestProess.Request_Id, DECReq.Request_Id);

           return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Trn_Request_Master_Selected, Parameters);
       }


       public DataTable DAL_Trn_Request_Wise_Comments_Select_Request_wise(DECVariables.ClsRequest DECReq)
       {
           Dictionary<string, object> Parameters = new Dictionary<string, object>();
           Parameters.Add(DataParameter.ClsRequestProess.Request_Id, DECReq.Request_Id);

           return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Trn_Request_Wise_Comments_Select_Request_wise, Parameters);
       }


       public string DAL_Trn_Request_Master_Insert_Main(DECVariables.ClsRequest DECreq)
       {
           Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

           Dictionary<string, object> Parameters = new Dictionary<string, object>();

           Parameters.Add(DataParameter.ClsRequestProess.Requester_First_Name, DECreq.Requester_First_Name);
           Parameters.Add(DataParameter.ClsRequestProess.Requester_Last_Name, DECreq.Requester_Last_Name);
           Parameters.Add(DataParameter.ClsRequestProess.EMail, DECreq.EMail);
           Parameters.Add(DataParameter.ClsRequestProess.Contact01, DECreq.Contact01);
           Parameters.Add(DataParameter.ClsRequestProess.Contact02, DECreq.Contact02);
           Parameters.Add(DataParameter.ClsRequestProess.Fax, DECreq.Fax);
           Parameters.Add(DataParameter.ClsRequestProess.Country, DECreq.Country);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_From, DECreq.Guest_From);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_To, DECreq.Guest_To);
           Parameters.Add(DataParameter.ClsRequestProess.Adults, DECreq.Adults);
           Parameters.Add(DataParameter.ClsRequestProess.Children, DECreq.Children);
           Parameters.Add(DataParameter.ClsRequestProess.Request_Date, DECreq.Request_Date);
           Parameters.Add(DataParameter.ClsRequestProess.Progress_Status, DECreq.Progress_Status);
           Parameters.Add(DataParameter.ClsRequestProess.IsConfirmed, DECreq.IsConfirmed);
           Parameters.Add(DataParameter.ClsRequestProess.IsCancelled, DECreq.IsCancelled);
           Parameters.Add(DataParameter.ClsRequestProess.IsCompleated, DECreq.IsCompleated);
           Parameters.Add(DataParameter.ClsRequestProess.Amount, DECreq.Amount);
           Parameters.Add(DataParameter.ClsRequestProess.Breakfast, DECreq.Breakfast);
           Parameters.Add(DataParameter.ClsRequestProess.Promo_Id, DECreq.Promo_Id);
           Parameters.Add(DataParameter.ClsRequestProess.Promo_Amount, DECreq.Promo_Amount);
           Parameters.Add(DataParameter.ClsRequestProess.Vat, DECreq.Vat);
           Parameters.Add(DataParameter.ClsRequestProess.Net_Amount, DECreq.Net_Amount);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_Id, DECreq.Guest_Id);

           TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Trn_Request_Master_Insert);


           Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

           Parameters2.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters2.Add(DataParameter.ClsRequestProess.Comments, DECreq.Comments);

           TractParameters.Add(Parameters2, DataStoredProcedure.InsertSPs.Trn_Request_Wise_Comments_Insert_Main);
           
           string s = DatabaseConnection.insertTransaction(TractParameters);
           return s;
       }


       public string DAL_Trn_Request_Master_Update(DECVariables.ClsRequest DECreq)
       {
           Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

           Dictionary<string, object> Parameters = new Dictionary<string, object>();

           Parameters.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters.Add(DataParameter.ClsRequestProess.Requester_First_Name, DECreq.Requester_First_Name);
           Parameters.Add(DataParameter.ClsRequestProess.Requester_Last_Name, DECreq.Requester_Last_Name);
           Parameters.Add(DataParameter.ClsRequestProess.EMail, DECreq.EMail);
           Parameters.Add(DataParameter.ClsRequestProess.Contact01, DECreq.Contact01);
           Parameters.Add(DataParameter.ClsRequestProess.Contact02, DECreq.Contact02);
           Parameters.Add(DataParameter.ClsRequestProess.Fax, DECreq.Fax);
           Parameters.Add(DataParameter.ClsRequestProess.Country, DECreq.Country);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_From, DECreq.Guest_From);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_To, DECreq.Guest_To);
           Parameters.Add(DataParameter.ClsRequestProess.Adults, DECreq.Adults);
           Parameters.Add(DataParameter.ClsRequestProess.Children, DECreq.Children);
           
       
           TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Trn_Request_Master_Update);


           Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

           Parameters2.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters2.Add(DataParameter.ClsRequestProess.Comments, DECreq.Comments);

           TractParameters.Add(Parameters2, DataStoredProcedure.InsertSPs.Trn_Request_Wise_Comments_Insert_Main);

           string s = DatabaseConnection.insertTransaction(TractParameters);
           return s;
       }

       public string DAL_Trn_Request_Compleated_Insert_Main(DECVariables.ClsRequest DECreq)
       {
           Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

           Dictionary<string, object> Parameters = new Dictionary<string, object>();

           Parameters.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters.Add(DataParameter.ClsRequestProess.Requester_First_Name, DECreq.Requester_First_Name);
           Parameters.Add(DataParameter.ClsRequestProess.Requester_Last_Name, DECreq.Requester_Last_Name);
           Parameters.Add(DataParameter.ClsRequestProess.EMail, DECreq.EMail);
           Parameters.Add(DataParameter.ClsRequestProess.Contact01, DECreq.Contact01);
           Parameters.Add(DataParameter.ClsRequestProess.Contact02, DECreq.Contact02);
           Parameters.Add(DataParameter.ClsRequestProess.Fax, DECreq.Fax);
           Parameters.Add(DataParameter.ClsRequestProess.Country, DECreq.Country);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_From, DECreq.Guest_From);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_To, DECreq.Guest_To);
           Parameters.Add(DataParameter.ClsRequestProess.Adults, DECreq.Adults);
           Parameters.Add(DataParameter.ClsRequestProess.Children, DECreq.Children);
           Parameters.Add(DataParameter.ClsRequestProess.Request_Date, DECreq.Request_Date);
           Parameters.Add(DataParameter.ClsRequestProess.Amount, DECreq.Amount);
           Parameters.Add(DataParameter.ClsRequestProess.Breakfast, DECreq.Breakfast);
           Parameters.Add(DataParameter.ClsRequestProess.Promo_Id, DECreq.Promo_Id);
           Parameters.Add(DataParameter.ClsRequestProess.Promo_Amount, DECreq.Promo_Amount);
           Parameters.Add(DataParameter.ClsRequestProess.Vat, DECreq.Vat);
           Parameters.Add(DataParameter.ClsRequestProess.Net_Amount, DECreq.Net_Amount);
           Parameters.Add(DataParameter.ClsRequestProess.Guest_Id, DECreq.Guest_Id);
           Parameters.Add(DataParameter.ClsRequestProess.Confirmed_Date, DECreq.Confirmed_Date);
           

           TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Trn_Request_Compleated_Insert);


           Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

           Parameters2.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);

           TractParameters.Add(Parameters2, DataStoredProcedure.DeleteSPs.Trn_Request_Master_Delete);

           Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

           Parameters3.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters3.Add(DataParameter.ClsRequestProess.Comments, DECreq.Comments);

           TractParameters.Add(Parameters3, DataStoredProcedure.InsertSPs.Trn_Request_Wise_Comments_Insert_Main);

           string s = DatabaseConnection.insertTransaction(TractParameters);
           return s;
       }

       public string DAL_Trn_Request_Master_Confirmed_Update(DECVariables.ClsRequest DECreq)
       {
           Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

           Dictionary<string, object> Parameters = new Dictionary<string, object>();

           Parameters.Add(DataParameter.ClsRequestProess.IsConfirmed, DECreq.IsConfirmed);
           Parameters.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);

           TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Trn_Request_Master_Confirmed_Update);

           Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

           Parameters2.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters2.Add(DataParameter.ClsRequestProess.Comments, DECreq.Comments);

           TractParameters.Add(Parameters2, DataStoredProcedure.InsertSPs.Trn_Request_Wise_Comments_Insert_Main);

           string s = DatabaseConnection.insertTransaction(TractParameters);
           return s;
       }


       public string DAL_Trn_Request_Master_Cancel_Update(DECVariables.ClsRequest DECreq)
       {
           Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

           Dictionary<string, object> Parameters = new Dictionary<string, object>();

           Parameters.Add(DataParameter.ClsRequestProess.IsCancelled, DECreq.IsCancelled);
           Parameters.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);

           TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Trn_Request_Master_Cancel_Update);


           Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

           Parameters2.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters2.Add(DataParameter.ClsRequestProess.Comments, DECreq.Comments);

           TractParameters.Add(Parameters2, DataStoredProcedure.InsertSPs.Trn_Request_Wise_Comments_Insert_Main);

           string s = DatabaseConnection.insertTransaction(TractParameters);
           return s;
       }

       public string DAL_Trn_Request_Wise_Comments_Insert_Main(DECVariables.ClsRequest DECreq)
       {
           Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

           Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

           Parameters2.Add(DataParameter.ClsRequestProess.Request_Id, DECreq.Request_Id);
           Parameters2.Add(DataParameter.ClsRequestProess.Comments, DECreq.Comments);

           TractParameters.Add(Parameters2, DataStoredProcedure.InsertSPs.Trn_Request_Wise_Comments_Insert_Main);

           string s = DatabaseConnection.insertTransaction(TractParameters);
           return s;
       }


    }
}
