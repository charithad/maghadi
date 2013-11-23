using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagadheeDEC.GuestHouseDec
{
    public class DECVariables
    {

        public class ClsAddAttractions
        {
            public string Atraction_Id { get; set; }
            public string Image_path { get; set; }
            public string Heading { get; set; }
            public string Description { get; set; }
            public string Guest_Code { get; set; }
            public DateTime DateUpdated { get; set; }
        }


        public class ClsAddGuestHouse
        {
            public string Guest_Code { get; set; }
            public string Guest_name { get; set; }
            public string Description { get; set; }
            public double Price_Per_Day { get; set; }
            public double Room_price { get; set; }
            public int No_Of_Rooms { get; set; }
            public string Has_Breakfast { get; set; }
            public string Word_1 { get; set; }
            public string Word_2 { get; set; }
            public string Word_3 { get; set; }
            public double Price_Per_Day_With_Breakfast { get; set; }
            public string Conatct_No { get; set; }
            public string E_mail { get; set; }
            public string Contact_person { get; set; }
            public int Max_Guests { get; set; }
            
        }


        public class ClsAddHomeContent
        {
            public string Home_Content_Id { get; set; }
            public string Header { get; set; }
            public string Home_Content { get; set; }
            public string Word_1 { get; set; }
            public string Word_2 { get; set; }
            public string Word_3 { get; set; }

        }

        public class ClsCust_Test
        {
            public string Client_Test_Id { get; set; }
            public string Client_Name { get; set; }
            public string Client_Content { get; set; }
            public string IsHighlighted { get; set; }
            public string Guest_Code { get; set; }
            public DateTime Client_Date { get; set; }
        }


        public class ClsLocation
        {
            public string Location_Id { get; set; }
            public string Location_Name { get; set; }
            public string Description { get; set; }
            public string Guest_Id { get; set; }
           
        }

        public class ClsNews
        {
            public string News_Id { get; set; }
            public string Heading { get; set; }
            public string Description { get; set; }
            public DateTime News_Date { get; set; }

        }


        public class ClsPromotions
        {
            public string Promotion_Id { get; set; }
            public double Precentage { get; set; }
            public string Description { get; set; }
            public DateTime From_Date { get; set; }
            public DateTime To_Date { get; set; }
            public double Amount_In_Rs { get; set; }
            public string Heading { get; set; }
            public string Guest_Id { get; set; }
            public double price_With_breakfast { get; set; }
            public double price_without_breakfast{ get; set; }
            public double Precentage_with_Breakfast { get; set; }
            public double Amount_With_Breakfast { get; set; }
            

        }

        public class ClsRequest
        {
            public string Request_Id { get; set; }
            public string Requester_First_Name { get; set; }
            public string Requester_Last_Name { get; set; }
            public DateTime Guest_From { get; set; }
            public DateTime Guest_To { get; set; }
            public DateTime Request_Date { get; set; }
            public string EMail { get; set; }
            public string Contact01 { get; set; }
            public string Contact02 { get; set; }
            public string Fax { get; set; }
            public string Country { get; set; }
            public int Adults{ get; set; }
            public int Children { get; set; }
            public string Progress_Status { get; set; }
            public string IsConfirmed { get; set; }
            public string IsCancelled { get; set; }
            public string IsCompleated { get; set; }
            public double Amount { get; set; }
            public string Breakfast { get; set; }
            public string Guest_Id { get; set; }
            public string Guest_name { get; set; }
            public string Promo_Id { get; set; }
            public double Vat { get; set; }
            public double Net_Amount { get; set; }
            public double Promo_Amount { get; set; }
            public string Comments { get; set; }
            public DateTime Completed_Date { get; set; }
            public DateTime Confirmed_Date { get; set; }


        }


        public class ClsUse
        {
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        public class ClsMail
        {
            public string fromAddress { get; set; }
            public string fromName { get; set; }
            public string toAddress { get; set; }
            public string toName { get; set; }
            public string msgSubject { get; set; }
            public string msgBody { get; set; }
        }
    }
}
