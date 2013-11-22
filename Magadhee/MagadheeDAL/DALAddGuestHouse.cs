using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MagadheeDEC.GuestHouseDec;
using MagadheeDAL;

namespace MagadheeDAL
{
   public class DALAddGuestHouse
    {

       public DataTable DAL_Ref_Guest_SelectAll()
        {
            return DatabaseConnection.SelectAll(DataStoredProcedure.SelectSPs.Ref_Guest_SelectAll);
        }

       public DataTable DAL_Ref_Guest_Selected(DECVariables.ClsAddGuestHouse DECGuest)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsGuest.Guest_Code, DECGuest.Guest_Code);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Ref_Guest_Selected, Parameters);
        }





       public string DAL_Ref_Guest_Insert_Main(DECVariables.ClsAddGuestHouse DECGuest)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();


            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsGuest.Description, DECGuest.Description);
            Parameters.Add(DataParameter.ClsGuest.Price_Per_Day, DECGuest.Price_Per_Day);
            Parameters.Add(DataParameter.ClsGuest.Room_price, DECGuest.Room_price);
            Parameters.Add(DataParameter.ClsGuest.No_Of_Rooms, DECGuest.No_Of_Rooms);
            Parameters.Add(DataParameter.ClsGuest.Guest_name, DECGuest.Guest_name);
            Parameters.Add(DataParameter.ClsGuest.Word_1, DECGuest.Word_1);
            Parameters.Add(DataParameter.ClsGuest.Word_2, DECGuest.Word_2);
            Parameters.Add(DataParameter.ClsGuest.Word_3, DECGuest.Word_3);
            Parameters.Add(DataParameter.ClsGuest.Price_Per_Day_With_Breakfast, DECGuest.Price_Per_Day_With_Breakfast);
            Parameters.Add(DataParameter.ClsGuest.Conatct_No, DECGuest.Conatct_No);
            Parameters.Add(DataParameter.ClsGuest.E_mail, DECGuest.E_mail);
            Parameters.Add(DataParameter.ClsGuest.Max_Guests, DECGuest.Max_Guests);
            Parameters.Add(DataParameter.ClsGuest.Contact_person, DECGuest.Contact_person);



            TractParameters.Add(Parameters, DataStoredProcedure.InsertSPs.Ref_Guest_Insert);
            
            
            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }


        public string DAL_Ref_Guest_Update_Main(DECVariables.ClsAddGuestHouse DECGuest)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsGuest.Guest_Code, DECGuest.Guest_Code);
            Parameters.Add(DataParameter.ClsGuest.Description, DECGuest.Description);
            Parameters.Add(DataParameter.ClsGuest.Price_Per_Day, DECGuest.Price_Per_Day);
            Parameters.Add(DataParameter.ClsGuest.Room_price, DECGuest.Room_price);
            Parameters.Add(DataParameter.ClsGuest.No_Of_Rooms, DECGuest.No_Of_Rooms);
            Parameters.Add(DataParameter.ClsGuest.Guest_name, DECGuest.Guest_name);
            Parameters.Add(DataParameter.ClsGuest.Word_1, DECGuest.Word_1);
            Parameters.Add(DataParameter.ClsGuest.Word_2, DECGuest.Word_2);
            Parameters.Add(DataParameter.ClsGuest.Word_3, DECGuest.Word_3);
            Parameters.Add(DataParameter.ClsGuest.Price_Per_Day_With_Breakfast, DECGuest.Price_Per_Day_With_Breakfast);
            Parameters.Add(DataParameter.ClsGuest.Conatct_No, DECGuest.Conatct_No);
            Parameters.Add(DataParameter.ClsGuest.E_mail, DECGuest.E_mail);
            Parameters.Add(DataParameter.ClsGuest.Max_Guests, DECGuest.Max_Guests);
            Parameters.Add(DataParameter.ClsGuest.Contact_person, DECGuest.Contact_person);

            TractParameters.Add(Parameters, DataStoredProcedure.UpdateSPs.Ref_Guest_Update);

            

            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }

        public string DAL_Ref_Guest_Delete(DECVariables.ClsAddGuestHouse DECGuest)
        {
            Dictionary<Dictionary<string, object>, string> TractParameters = new Dictionary<Dictionary<string, object>, string>();

            // Sp_REF_City_Delete

            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add(DataParameter.ClsGuest.Guest_Code, DECGuest.Guest_Code);

            TractParameters.Add(Parameters, DataStoredProcedure.DeleteSPs.Ref_Guest_Delete);

           
            string s = DatabaseConnection.insertTransaction(TractParameters);
            return s;
        }
//home page and guest house page sellects



        public DataTable DAL_Joint_Ref_Guesthouse_Wise_Attraction_Select(DECVariables.ClsAddGuestHouse DECGuest)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsGuest.Guest_Code, DECGuest.Guest_Code);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Joint_Ref_Guesthouse_Wise_Attraction_Select, Parameters);
        }

        public DataTable DAL_Joint_Ref_Guesthouse_Wise_Promotion_Select(DECVariables.ClsAddGuestHouse DECGuest)
        {
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add(DataParameter.ClsGuest.Guest_Id, DECGuest.Guest_Code);

            return DatabaseConnection.Select(DataStoredProcedure.SelectSPs.Joint_Ref_Guesthouse_Wise_Promotion_Select, Parameters);
        }

    }
}
