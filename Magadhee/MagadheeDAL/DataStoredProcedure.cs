using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MagadheeDAL
{
    internal static class DataStoredProcedure
    {
        internal static class SelectSPs
        {
            public static string Ref_Settings_SelectAll = "Sp_Ref_Settings_SelectAll";

            public static string Ref_Attraction_Selected = "Sp_Ref_Attraction_Selected";
            public static string Ref_Attraction_Wise_Guest_Selected = "Sp_Ref_Attraction_Wise_Guest_Selected";
            public static string Ref_Attraction_SelectAll = "Sp_Ref_Attraction_SelectAll";

            public static string Ref_Client_Testimonials_SelectAll = "Sp_Ref_Client_Testimonials_SelectAll";
            public static string Ref_Client_Testimonials_Selected = "Sp_Ref_Client_Testimonials_Selected";
            public static string Ref_Client_Testimonials_Wise_Guest_Selected = "Sp_Ref_Client_Testimonials_Wise_Guest_Selected";

            public static string Ref_Guest_SelectAll = "Sp_Ref_Guest_SelectAll";
            public static string Ref_Guest_Selected = "Sp_Ref_Guest_Selected";
            public static string Ref_Guest_Wise_Image_Selected = "Sp_Ref_Guest_Wise_Image_Selected";
            public static string Joint_Ref_Guesthouse_Wise_Promotion_Select = "Sp_Joint_Ref_Guesthouse_Wise_Promotion_Select";

            public static string Ref_Home_Content_Select = "Sp_Ref_Home_Content_Select";

            public static string Ref_Location_SelectAll = "Sp_Ref_Location_SelectAll";
            public static string Ref_Location_Selected = "Sp_Ref_Location_Selected";
            public static string Ref_Location_Wise_Guest_House_Selected = "Sp_Ref_Location_Wise_Guest_House_Selected";

            public static string Ref_News_SelectAll = "Sp_Ref_News_SelectAll";
            public static string Ref_News_Selected = "Sp_Ref_News_Selected";

            public static string Ref_Promotions_Select_All = "Sp_Ref_Promotions_Select_All";
            public static string Ref_Promotions_Selected = "Sp_Ref_Promotions_Selected";
            public static string Ref_Promotions_Wise_Guest_Selected = "Sp_Ref_Promotions_Wise_Guest_Selected";
            
            public static string REF_City_Selected_Region = "Sp_REF_City_Selected_Region";
            public static string REF_City_Wise_Genre_Selected = "Sp_REF_City_Wise_Genre_Selected";
            public static string REF_Region_Select = "Sp_REF_Region_Select";

            
            public static string REF_Region_Wise_Genre_Select = "Sp_REF_Region_Wise_Genre_Select";
            public static string REF_Region_Wise_Cities_Select = "Sp_REF_Region_Wise_Cities_Select";
            public static string REF_Region_Wise_Cities_Selected = "Sp_REF_Region_Wise_Cities_Selected";

            public static string REF_Place_Of_Interest_Select = "Sp_REF_Place_Of_Interest_Select";
            public static string REF_PlaceOfInterest_Wise_Genre_Select = "Sp_REF_PlaceOfInterest_Wise_Genre_Select";
            public static string REF_PlaceOfInterest_Selected = "Sp_REF_PlaceOfInterest_Selected";

            public static string REF_Country_Wise_Language_Select = "Sp_REF_Country_Wise_Language_Select";
            public static string REF_Country_Wise_Currency_Select = "Sp_REF_Country_Wise_Currency_Select";
            public static string REF_Country_Select = "Sp_REF_Country_Select";
            public static string REF_Country_Selected = "Sp_REF_Country_Selected";

            public static string Trn_Request_Master_Select_All = "Sp_Trn_Request_Master_Select_All";
            public static string Trn_Request_Master_Selected = "Sp_Trn_Request_Master_Selected";
            public static string Trn_Request_Master_Select_All_Confirmed = "Sp_Trn_Request_Master_Select_All_Confirmed";

            public static string Trn_Request_Wise_Comments_Select_Request_wise = "Sp_Trn_Request_Wise_Comments_Select_Request_wise";

            public static string Ref_Users_Select_All = "Sp_Ref_Users_Select_All";
            public static string Ref_Users_Selected = "Sp_Ref_Users_Selected";
            public static string Ref_Users_Selected_Users = "Sp_Ref_Users_Selected_Users";
            

            //---------------------------------------------------------

            //joint selects

            public static string Joint_Ref_Guesthouse_Wise_Attraction_Select = "Sp_Joint_Ref_Guesthouse_Wise_Attraction_Select";
        }

        internal static class InsertSPs
        {
            public static string Ref_Attraction_Insert = "Sp_Ref_Attraction_Insert";
            public static string Ref_Attraction_Wise_Guest_Insert = "Sp_Ref_Attraction_Wise_Guest_Insert";

            public static string Ref_Client_Testimonials_Insert = "Sp_Ref_Client_Testimonials_Insert";
            public static string Ref_Client_Testimonials_Wise_Guest_Insert = "Sp_Ref_Client_Testimonials_Wise_Guest_Insert";

            public static string Ref_Guest_Insert = "Sp_Ref_Guest_Insert";

            public static string Ref_Home_Content_Insert = "Sp_Ref_Home_Content_Insert";

            public static string Ref_Location_Insert = "Sp_Ref_Location_Insert";
            public static string Ref_Location_Wise_Guest_House_Insert = "Sp_Ref_Location_Wise_Guest_House_Insert";

            public static string Ref_News_Insert = "Sp_Ref_News_Insert";

            public static string Ref_Promotions_Insert = "Sp_Ref_Promotions_Insert";
            public static string Ref_Promotions_Wise_Guest_Insert = "Sp_Ref_Promotions_Wise_Guest_Insert";
            
            public static string REF_Region_Wise_Cities_Insert = "Sp_REF_Region_Wise_Cities_Insert";

            public static string REF_City_Insert = "Sp_REF_City_Insert";
            public static string REF_City_Wise_Genre_Insert = "Sp_REF_City_Wise_Genre_Insert";

            public static string REF_Place_Of_Interest_Insert = "Sp_REF_Place_Of_Interest_Insert";
            public static string REF_PlaceOfInterest_Wise_Genre_Insert="Sp_REF_PlaceOfInterest_Wise_Genre_Insert";

            public static string REF_Country_Wise_Language_Insert="Sp_REF_Country_Wise_Language_Insert";
            public static string REF_Country_Wise_Currency_Insert="Sp_REF_Country_Wise_Currency_Insert";
            public static string REF_Country_Insert = "Sp_REF_Country_Insert";

            public static string Trn_Guest_Wise_Request_Insert = "Sp_Trn_Guest_Wise_Request_Insert";
            public static string Trn_Request_Master_Insert = "Sp_Trn_Request_Master_Insert";

            public static string Trn_Request_Wise_Comments_Insert_Main = "Sp_Trn_Request_Wise_Comments_Insert_Main";

            public static string Trn_Request_Compleated_Insert = "Sp_Trn_Request_Compleated_Insert";

            public static string Ref_Users_Insert = "Sp_Ref_Users_Insert";

            
            //---------------------------------------------------------------

        }

        internal static class UpdateSPs
        {
            //Charitha------------------------------
            public static string Ref_Attraction_Update = "Sp_Ref_Attraction_Update";

            public static string Ref_Client_Testimonials_Update = "Sp_Ref_Client_Testimonials_Update";

            public static string Ref_Guest_Update = "Sp_Ref_Guest_Update";

            public static string Ref_Home_Content_Update = "Sp_Ref_Home_Content_Update";

            public static string Ref_Location_Update = "Sp_Ref_Location_Update";

            public static string Ref_News_Update = "Sp_Ref_News_Update";

            public static string Ref_Promotions_Update = "Sp_Ref_Promotions_Update";

            public static string Trn_Request_Master_Confirmed_Update = "Sp_Trn_Request_Master_Confirmed_Update";
            public static string Trn_Request_Master_Cancel_Update = "Sp_Trn_Request_Master_Cancel_Update";
            public static string Trn_Request_Master_Update = "Sp_Trn_Request_Master_Update";
            //--------------------------------------
        }

        internal static class DeleteSPs
        {
            //Charitha----------------------------

            public static string Ref_Attraction_Wise_Guest_Delete = "Sp_Ref_Attraction_Wise_Guest_Delete";
            public static string Ref_Attraction_Delete = "Sp_Ref_Attraction_Delete";

            public static string Ref_Client_Testimonials_Delete = "Sp_Ref_Client_Testimonials_Delete";
            public static string Ref_Client_Testimonials_Wise_Guest_Delete = "Sp_Ref_Client_Testimonials_Wise_Guest_Delete";

            public static string Ref_Guest_Delete = "Sp_Ref_Guest_Delete";

            public static string Ref_Home_Content_Delete = "Sp_Ref_Home_Content_Delete";

            public static string Ref_Location_Wise_Guest_House_Delete = "Sp_Ref_Location_Wise_Guest_House_Delete";
            public static string Ref_Location_Delete = "Sp_Ref_Location_Delete";


            public static string Ref_News_Delete = "Sp_Ref_News_Delete";


            public static string Ref_Promotions_Delete = "Sp_Ref_Promotions_Delete";
            public static string Ref_Promotions_Wise_Guest_Delete = "Sp_Ref_Promotions_Wise_Guest_Delete";

            public static string Trn_Guest_Wise_Request_Delete = "Sp_Trn_Guest_Wise_Request_Delete";

            public static string Trn_Request_Master_Delete = "Sp_Trn_Request_Master_Delete";

            public static string Ref_Users_Delete = "Sp_Ref_Users_Delete";

            
            
            //------------------------------------
        }

        internal static class SearchSPs
        {

        }
    }
}
