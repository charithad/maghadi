using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
   public class DALAddLocations
    {

       public DataTable DAL_Ref_Location_SelectAll()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Location_SelectAll);
        }

       public DataTable DAL_Ref_Location_Selected(DECVariables.ClsLocation DECAtt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddLocation.Location_Id, DECAtt.Location_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Location_Selected, Parameters);
        }

       public DataTable DAL_Ref_Location_Wise_Guest_House_Selected(DECVariables.ClsLocation DECAtt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddLocation.location_Id, DECAtt.Location_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Location_Wise_Guest_House_Selected, Parameters);
        }



       public string DAL_Ref_Location_Insert_Main(DECVariables.ClsLocation DECAtt, List<DECVariables.ClsLocation> list2)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddLocation.Location_Name, DECAtt.Location_Name);
            Parameters.Add(DataParameter.ClsAddLocation.Description, DECAtt.Description);
            


            TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Ref_Location_Insert);
            // Sp_REF_City_Wise_Genre_Insert
            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();

            foreach (DECVariables.ClsLocation DECAttList in list2)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsAddLocation.location_Id, DECAttList.Location_Id);
                Parameters4.Add(DataParameter.ClsAddLocation.Guest_Id, DECAttList.Guest_Id);

                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Location_Wise_Guest_House_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


       public string DAL_Ref_Location_Update_Main(DECVariables.ClsLocation DECAtt, List<DECVariables.ClsLocation> list3)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Update

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddLocation.Location_Id, DECAtt.Location_Id);
            Parameters.Add(DataParameter.ClsAddLocation.Location_Name, DECAtt.Location_Name);
            Parameters.Add(DataParameter.ClsAddLocation.Description, DECAtt.Description);


            TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Ref_Attraction_Update);

            // Sp_REF_TO_Master_Insert

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsAddLocation.location_Id, DECAtt.Location_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Location_Wise_Guest_House_Delete);

            //Sp_REF_City_Wise_Genre_Insert

            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();
            foreach (DECVariables.ClsLocation DECAttrList in list3)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsAddLocation.location_Id, DECAttrList.Location_Id);
                Parameters4.Add(DataParameter.ClsAddLocation.Guest_Id, DECAttrList.Guest_Id);

                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Location_Wise_Guest_House_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

       public string DAL_Ref_Location_Delete(DECVariables.ClsLocation DECAttr)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Delete

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddLocation.Location_Id, DECAttr.Location_Id);

            TractParameters.Add(Parameters, DataStoredProcedure.DeleteSPs.Ref_Location_Delete);

            // Sp_REF_City_Wise_Genre_Delete

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsAddLocation.location_Id, DECAttr.Location_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Location_Wise_Guest_House_Delete);

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


    }
}
