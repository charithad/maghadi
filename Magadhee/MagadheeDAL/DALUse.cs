using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
    public class DALUse
    {

        public DataTable DAL_Ref_Users_Select_All()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Users_Select_All);
        }

        public DataTable DAL_Ref_Users_Selected(DECVariables.ClsUse Du)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.Use.UserName, Du.UserName);
            Parameters.Add(DataParameter.Use.Password, Du.Password);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Users_Selected, Parameters);
        }



        public DataTable DAL_Ref_Users_Selected_Users(DECVariables.ClsUse Du)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.Use.UserName, Du.UserName);
            
            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Users_Selected_Users, Parameters);
        }

        public string DAL_Ref_Users_Insert(DECVariables.ClsUse Du)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

            Parameters2.Add(DataParameter.Use.UserName, Du.UserName);
            Parameters2.Add(DataParameter.Use.Password, Du.Password);

            TractParameters.Add(Parameters2, DataStoredProcedure.InsertSPs.Ref_Users_Insert);

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

        public string DAL_Ref_Users_Delete(DECVariables.ClsUse Du)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            Dictionary<string, object> Parameters2 = new Dictionary<string, object>();

            Parameters2.Add(DataParameter.Use.UserName, Du.UserName);
            Parameters2.Add(DataParameter.Use.UserName, Du.Password);

            TractParameters.Add(Parameters2, DataStoredProcedure.DeleteSPs.Ref_Users_Delete);

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }
    }
}
