using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
   public class DALAddNews
    {

       public DataTable DAL_Ref_News_SelectAll()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_News_SelectAll);
        }

       public DataTable DAL_Ref_News_Selected(DECVariables.ClsNews DECAtt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddNews.News_Id, DECAtt.News_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_News_Selected, Parameters);
        }


       public string DAL_Ref_News_Insert_Main(DECVariables.ClsNews DECAtt)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddNews.Heading, DECAtt.Heading);
            Parameters.Add(DataParameter.ClsAddNews.Description, DECAtt.Description);
            Parameters.Add(DataParameter.ClsAddNews.News_Date, DECAtt.News_Date);
            
            TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Ref_News_Insert);
                     

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


        public string DAL_Ref_News_Update_Main(DECVariables.ClsNews DECAtt)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

           
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddNews.News_Id, DECAtt.News_Id);
            Parameters.Add(DataParameter.ClsAddNews.Heading, DECAtt.Heading);
            Parameters.Add(DataParameter.ClsAddNews.Description, DECAtt.Description);
            Parameters.Add(DataParameter.ClsAddNews.News_Date, DECAtt.News_Date);


            TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Ref_News_Update);

           
            

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

        public string DAL_Ref_News_Delete(DECVariables.ClsNews DECAttr)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

      

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddNews.News_Id, DECAttr.News_Id);

            TractParameters.Add(Parameters, DataStoredProcedure.DeleteSPs.Ref_News_Delete);

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


    }
}
