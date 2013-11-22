using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
   public class DALAddHomeContent
    {

       public DataTable DAL_Ref_Home_Content_SelectAll()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Home_Content_Select);
        }



        public string DAL_Ref_Home_Content_Insert(DECVariables.ClsAddHomeContent DECGuest)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsHomeContent.Header, DECGuest.Header);
            Parameters.Add(DataParameter.ClsHomeContent.Home_Content, DECGuest.Home_Content);
            Parameters.Add(DataParameter.ClsHomeContent.Word_1, DECGuest.Word_1);
            Parameters.Add(DataParameter.ClsHomeContent.Word_2, DECGuest.Word_2);
            Parameters.Add(DataParameter.ClsHomeContent.Word_3, DECGuest.Word_3);



            TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Ref_Home_Content_Insert);


            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


        public string DAL_Ref_Home_Content_Update_Main(DECVariables.ClsAddHomeContent DECGuest)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsHomeContent.Header, DECGuest.Header);
            Parameters.Add(DataParameter.ClsHomeContent.Home_Content, DECGuest.Home_Content);
            Parameters.Add(DataParameter.ClsHomeContent.Word_1, DECGuest.Word_1);
            Parameters.Add(DataParameter.ClsHomeContent.Word_2, DECGuest.Word_2);
            Parameters.Add(DataParameter.ClsHomeContent.Word_3, DECGuest.Word_3);

            TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Ref_Home_Content_Update);



            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

        public string DAL_Ref_Home_Content_Delete(DECVariables.ClsAddHomeContent DECGuest)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Delete

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsHomeContent.Home_Content_Id, DECGuest.Home_Content_Id);

            TractParameters.Add(Parameters, DataStoredProcedure.DeleteSPs.Ref_Home_Content_Delete);


            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


    }
}
