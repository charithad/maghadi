using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
    public class DALAddAttractions
    {

        public DataTable DAL_Ref_Settings_SelectAll()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Settings_SelectAll);
        }


        public DataTable DAL_Ref_Attraction_SelectAll()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Attraction_SelectAll);
        }

        public DataTable DAL_Ref_Attraction_Selected(DECVariables.ClsAddAttractions DECAtt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddAttraction.Atraction_Id, DECAtt.Atraction_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Attraction_Selected, Parameters);
        }

        public DataTable DAL_Ref_Attraction_Wise_Guest_Selected(DECVariables.ClsAddAttractions DECAtt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddAttraction.Attraction_Id, DECAtt.Atraction_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Attraction_Wise_Guest_Selected, Parameters);
        }



        public string DAL_Ref_Attraction_Insert_Main(DECVariables.ClsAddAttractions DECAtt, List<DECVariables.ClsAddAttractions> list2)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddAttraction.Heading, DECAtt.Heading);
            Parameters.Add(DataParameter.ClsAddAttraction.Description, DECAtt.Description);
            
            

            TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Ref_Attraction_Insert);
            // Sp_REF_City_Wise_Genre_Insert
            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();
            foreach (DECVariables.ClsAddAttractions DECAttList in list2)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsAddAttraction.Attraction_Id, DECAttList.Atraction_Id);
                Parameters4.Add(DataParameter.ClsAddAttraction.Guest_Id, DECAttList.Guest_Code);


                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Attraction_Wise_Guest_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


        public string DAL_Ref_Attraction_Update_Main(DECVariables.ClsAddAttractions DECAtt, List<DECVariables.ClsAddAttractions> list3)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Update

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddAttraction.Atraction_Id,DECAtt.Atraction_Id);
            Parameters.Add(DataParameter.ClsAddAttraction.Description, DECAtt.Description);
            Parameters.Add(DataParameter.ClsAddAttraction.Heading, DECAtt.Heading);
            

            TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Ref_Attraction_Update);

            // Sp_REF_TO_Master_Insert

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsAddAttraction.Atraction_Id, DECAtt.Atraction_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Attraction_Wise_Guest_Delete);

            //Sp_REF_City_Wise_Genre_Insert

            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();
            foreach (DECVariables.ClsAddAttractions DECAttrList in list3)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsAddAttraction.Attraction_Id, DECAttrList.Atraction_Id);
                Parameters4.Add(DataParameter.ClsAddAttraction.Guest_Id, DECAttrList.Guest_Code);


                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Attraction_Wise_Guest_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

        public string DAL_Ref_Attraction_Delete(DECVariables.ClsAddAttractions DECAttr)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Delete

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddAttraction.Atraction_Id, DECAttr.Atraction_Id);

            TractParameters.Add(Parameters, DataStoredProcedure.DeleteSPs.Ref_Attraction_Delete);

            // Sp_REF_City_Wise_Genre_Delete

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsAddAttraction.Atraction_Id, DECAttr.Atraction_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Attraction_Wise_Guest_Delete);

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

    }
}
