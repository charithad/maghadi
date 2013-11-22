using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagadheeDAL
{
    internal static class DataParameter
    {
        internal sealed class CommonParameter
        {
            
            
                public const string TOName = "@Name";
                public const string TONickName = "@NickName";
                public const string TODescription = "@Description";

                public const string TOAddress = "@Address";
                public const string TOEMail = "@EMail";

                public const string TOAlternateEMail = "@AlternateEMail";


        }

        internal sealed class ClsAddAttraction
        {
            public const string Atraction_Id = "@Atraction_Id";
            public const string Image_path = "@Image_path";
            public const string Heading = "@Heading";
            public const string Description = "@Description";
            public const string Guest_Code = "@Guest_Code";
            public const string Guest_Id = "@Guest_Id";
            public const string Attraction_Id = "@Attraction_Id";
                
        }


        internal sealed class ClsGuest
        {
            public const string Guest_Code = "@Guest_Code";
            public const string Guest_Id = "@Guest_Id";
            public const string Guest_name = "@Guest_name";
            public const string Description = "@Description";
            public const string Price_Per_Day = "@Price_Per_Day";
            public const string Room_price = "@Room_price";
            public const string No_Of_Rooms = "@No_Of_Rooms";
            public const string Has_Breakfast = "@Has_Breakfast";
            public const string Word_1 = "@Word_1";
            public const string Word_2 = "@Word_2";
            public const string Word_3 = "@Word_3";
            public const string Price_Per_Day_With_Breakfast = "@Price_Per_Day_With_Breakfast";
            public const string Conatct_No = "@Conatct_No";
            public const string E_mail = "@E_mail";
            public const string Max_Guests = "@Max_Guests";
            public const string Contact_person = "@Contact_person";

        }


        internal sealed class ClsHomeContent
        {
            public const string Home_Content_Id = "@Home_Content_Id";
            public const string Header = "@Header";
            public const string Home_Content = "@Home_Content";
            public const string Word_1 = "@Word_1";
            public const string Word_2 = "@Word_2";
            public const string Word_3 = "@Word_3";

        }

        internal sealed class ClsCust_Test
        {
            public const string Client_Test_Id = "@Client_Test_Id";
            public const string Client_Name = "@Client_Name";
            public const string Client_Content = "@Client_Content";
            public const string Client_Date = "@Client_Date";
            public const string IsHighlighted = "@IsHighlighted";
            public const string Guest_Code = "@Guest_Code";
            public const string Guest_Id = "@Guest_Id";
            
           
        }

        internal sealed class ClsAddLocation
        {
            public const string Location_Id = "@Location_Id";
            public const string Location_Name = "@Location_Name";
            public const string Description = "@Description";

            public const string location_Id = "@location_Id";
            public const string Guest_Id = "@Guest_Id";
        }

        internal sealed class ClsAddNews
        {
            public const string News_Id = "@News_Id";
            public const string Heading = "@Heading";
            public const string Description = "@Description";

            public const string News_Date = "@News_Date";
            
        }

        internal sealed class ClsAddPromotion
        {
            public const string Promotion_Id = "@Promotion_Id";
            
            
            public const string Precentage = "@Precentage";
            public const string Description = "@Description";
            public const string To_Date = "@To_Date";
            public const string From_Date = "@From_Date";
            public const string Amount_In_Rs = "@Amount_In_Rs";
            public const string Heading = "@Heading";
            public const string Precentage_with_Breakfast = "@Precentage_with_Breakfast ";
            public const string Amount_With_Breakfast = "@Amount_With_Breakfast";

            public const string Guest_Id = "@Guest_Id";

        }


        internal sealed class LoginParameters
        {
            public const string User = "@UserName";
            public const string Pass = "@Password";
        }

        internal sealed class GenreParam
        {
          public const string desc= "@Description";
          public const string Picdesc = "@PicDesc";
          public const string GenreCode = "@GenreCode";
        }

        internal sealed class AddRegion
        {
            public const string desc = "@Description";
            public const string Picdesc = "@PicDesc";
            public const string RegionID = "@RegionID";
            public const string CapitalCityCode = "@CapitalCityCode";
            public const string Distance2Capital4mCol = "@Distance2Capital4mCol";
        }

        internal sealed class AddCity
        {
            public const string CityCode = "@CityCode";
            public const string City="@City";
            public const string RegionID="@RegionID";
            public const string Distance4mCol="@Distance4mCol";
            public const string PicDesc = "@PicDesc";

            public const string GenreCode = "@GenreCode";
        }

        internal sealed class AddPOI
        {

            public const string PoICode = "@PoICode";
            public const string PlaceOfInterest="@PlaceOfInterest";
            public const string Descreption="@Descreption";
            public const string CityCode="@CityCode";
            public const string PicDesc = "@PicDesc";
            public const string Distance4mCity="@Distance4mCity";

            public const string GenreCode = "@GenreCode";

           
        }

        internal sealed class AddCountry
        {

            public const string CountryCode = "@CountryCode";
            public const string Country = "@Country";
            public const string CountryFlagImg = "@CountryFlagImg";
            public const string CurrencyCode = "@CurrencyCode";
            public const string IDDCode = "@IDDCode";
            public const string LanguageCode = "@LanguageCode";

        }

        internal sealed class ClsRequestProess
        {

            public const string Request_Id = "@Request_Id";
            public const string Requester_First_Name = "@Requester_First_Name";
            public const string Requester_Last_Name = "@Requester_Last_Name";
            public const string EMail = "@EMail";
            public const string Contact01 = "@Contact01";
            public const string Contact02 = "@Contact02";
            public const string Fax = "@Fax";
            public const string Country = "@Country";
            public const string Guest_From = "@Guest_From";
            public const string Guest_To = "@Guest_To";
            public const string Adults = "@Adults";
            public const string Children = "@Children";
            public const string Request_Date = "@Request_Date";
            public const string Progress_Status = "@Progress_Status";
            public const string IsConfirmed = "@IsConfirmed";
            public const string IsCancelled = "@IsCancelled";
            public const string IsCompleated = "@IsCompleated";
            public const string Amount = "@Amount";
            public const string Breakfast= "@Breakfast";
            public const string Guest_Id = "@Guest_Id";
            public const string Guest_name = "@Guest_name";
            public const string Promo_Id = "@Promo_Id";
            public const string Promo_Amount = "@Promo_Amount";
            public const string Vat = "@Vat";
            public const string Net_Amount = "@Net_Amount";
            public const string Comments = "@Comments";
            public const string Completed_Date = "@Completed_Date";
            public const string Confirmed_Date = "@Confirmed_Date";

        }

        internal sealed class Use
        {
            public const string UserName = "@UserName";
            public const string Password = "@Password";
        }
    }
}
