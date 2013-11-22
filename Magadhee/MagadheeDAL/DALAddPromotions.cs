using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
   public class DALAddPromotions
    {

       public DataTable DAL_Ref_Promotions_Select_All()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Promotions_Select_All);
        }

       public DataTable DAL_Ref_Promotions_Selected(DECVariables.ClsPromotions DECAtt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAtt.Promotion_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Promotions_Selected, Parameters);
        }

       public DataTable DAL_Ref_Promotions_Wise_Guest_Selected(DECVariables.ClsPromotions DECAtt)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAtt.Promotion_Id);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Promotions_Wise_Guest_Selected, Parameters);
        }



       public string DAL_Ref_Promotions_Insert_Main(DECVariables.ClsPromotions DECAtt, List<DECVariables.ClsPromotions> list2)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddPromotion.Heading, DECAtt.Heading);
            Parameters.Add(DataParameter.ClsAddPromotion.Description, DECAtt.Description);
            Parameters.Add(DataParameter.ClsAddPromotion.Precentage, DECAtt.Precentage);
            Parameters.Add(DataParameter.ClsAddPromotion.From_Date, DECAtt.From_Date);
            Parameters.Add(DataParameter.ClsAddPromotion.To_Date, DECAtt.To_Date);
            Parameters.Add(DataParameter.ClsAddPromotion.Amount_In_Rs, DECAtt.Amount_In_Rs);
            Parameters.Add(DataParameter.ClsAddPromotion.Amount_With_Breakfast, DECAtt.Amount_With_Breakfast);
            Parameters.Add(DataParameter.ClsAddPromotion.Precentage_with_Breakfast, DECAtt.Precentage_with_Breakfast);





            TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Ref_Promotions_Insert);
          
            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();

            foreach (DECVariables.ClsPromotions DECAttList in list2)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAttList.Promotion_Id);
                Parameters4.Add(DataParameter.ClsAddPromotion.Guest_Id, DECAttList.Guest_Id);

                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Promotions_Wise_Guest_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


        public string DAL_Ref_Promotions_Update_Main(DECVariables.ClsPromotions DECAtt, List<DECVariables.ClsPromotions> list3)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Update

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAtt.Promotion_Id);
            Parameters.Add(DataParameter.ClsAddPromotion.Heading, DECAtt.Heading);
            Parameters.Add(DataParameter.ClsAddPromotion.Description, DECAtt.Description);
            Parameters.Add(DataParameter.ClsAddPromotion.Precentage, DECAtt.Precentage);
            Parameters.Add(DataParameter.ClsAddPromotion.From_Date, DECAtt.From_Date);
            Parameters.Add(DataParameter.ClsAddPromotion.To_Date, DECAtt.To_Date);
            Parameters.Add(DataParameter.ClsAddPromotion.Amount_In_Rs, DECAtt.Amount_In_Rs);
            Parameters.Add(DataParameter.ClsAddPromotion.Amount_With_Breakfast, DECAtt.Amount_With_Breakfast);
            Parameters.Add(DataParameter.ClsAddPromotion.Precentage_with_Breakfast, DECAtt.Precentage_with_Breakfast);



            TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Ref_Promotions_Update);

            // Sp_REF_TO_Master_Insert

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAtt.Promotion_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Promotions_Wise_Guest_Delete);

            //Sp_REF_City_Wise_Genre_Insert

            Dictionary<string, object> Parameters4 = new Dictionary<string, object>();
            foreach (DECVariables.ClsPromotions DECAttrList in list3)
            {
                Parameters4 = new Dictionary<string, object>();
                Parameters4.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAttrList.Promotion_Id);
                Parameters4.Add(DataParameter.ClsAddPromotion.Guest_Id, DECAttrList.Guest_Id);

                TractParameters.Add(Parameters4, DataStoredProcedure.InsertSPs.Ref_Promotions_Wise_Guest_Insert);
            }

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

        public string DAL_Ref_Promotions_Delete(DECVariables.ClsPromotions DECAttr)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Delete

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAttr.Promotion_Id);

            TractParameters.Add(Parameters, DataStoredProcedure.DeleteSPs.Ref_Promotions_Delete);

            // Sp_REF_City_Wise_Genre_Delete

            Dictionary<string, object> Parameters3 = new Dictionary<string, object>();

            Parameters3.Add(DataParameter.ClsAddPromotion.Promotion_Id, DECAttr.Promotion_Id);

            TractParameters.Add(Parameters3, DataStoredProcedure.DeleteSPs.Ref_Promotions_Wise_Guest_Delete);

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


    }
}
