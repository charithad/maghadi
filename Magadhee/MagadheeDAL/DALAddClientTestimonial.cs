using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
   public class DALAddClientTestimonial
    {


       public DataTable DAL_Ref_Client_Testimonials_SelectAll()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Client_Testimonials_SelectAll);
        }

       public DataTable DAL_Ref_Client_Testimonials_Selected(DECVariables.ClsCust_Test DECClin)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClin.Client_Test_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Client_Testimonials_Selected, Parameters);
        }

       public DataTable DAL_Ref_Client_Testimonials_Wise_Guest_Selected(DECVariables.ClsCust_Test DECClin)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClin.Client_Test_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Client_Testimonials_Wise_Guest_Selected, Parameters);
        }



       public string DAL_Ref_Client_Testimonials_Insert_Main(DECVariables.ClsCust_Test DECClin, List<DECVariables.ClsCust_Test> list2)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();


            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsCust_Test.Client_Name, DECClin.Client_Name);
            Parameters.Add(DataParameter.ClsCust_Test.Client_Content, DECClin.Client_Content);
            Parameters.Add(DataParameter.ClsCust_Test.Client_Date, DECClin.Client_Date);
            Parameters.Add(DataParameter.ClsCust_Test.IsHighlighted, DECClin.IsHighlighted);


            TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Ref_Client_Testimonials_Insert);
            // Sp_REF_City_Wise_Genre_Insert
            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();
            foreach (DECVariables.ClsCust_Test DECClinList in list2)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClinList.Client_Test_Id);
                Parameters4.Add(DataParameter.ClsCust_Test.Guest_Id, DECClinList.Guest_Code);


                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Client_Testimonials_Wise_Guest_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


       public string DAL_Ref_Client_Testimonials_Update_Main(DECVariables.ClsCust_Test DECClin, List<DECVariables.ClsCust_Test> list3)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Update

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClin.Client_Test_Id);
            Parameters.Add(DataParameter.ClsCust_Test.Client_Content, DECClin.Client_Content);
            Parameters.Add(DataParameter.ClsCust_Test.Client_Name, DECClin.Client_Name);
            Parameters.Add(DataParameter.ClsCust_Test.Client_Date, DECClin.Client_Date);
            Parameters.Add(DataParameter.ClsCust_Test.IsHighlighted, DECClin.IsHighlighted);


            TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Ref_Client_Testimonials_Update);

            // Sp_REF_TO_Master_Insert

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClin.Client_Test_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Client_Testimonials_Wise_Guest_Delete);

            //Sp_REF_City_Wise_Genre_Insert

            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();
            foreach (DECVariables.ClsCust_Test DECClinList in list3)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClinList.Client_Test_Id);
                Parameters4.Add(DataParameter.ClsCust_Test.Guest_Id, DECClinList.Guest_Code);


                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Client_Testimonials_Wise_Guest_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

       public string DAL_Ref_Client_Testimonials_Delete(DECVariables.ClsCust_Test DECClin)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Delete

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClin.Client_Test_Id);

            TractParameters.Add(Parameters, DataStoredProcedure.DeleteSPs.Ref_Client_Testimonials_Delete);

            // Sp_REF_City_Wise_Genre_Delete

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsCust_Test.Client_Test_Id, DECClin.Client_Test_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Client_Testimonials_Wise_Guest_Delete);

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


    }
}
