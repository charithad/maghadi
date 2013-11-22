using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using MagadheeDAL;
using MagadheeDEC.GuestHouseDec;

namespace MgadheeService.GuestHouseService
{
   public class SERAddNews
    {

       DALAddNews DALNews = new DALAddNews();

       public DataTable SERV_Ref_News_SelectAll()
        {
            return DALNews.DAL_Ref_News_SelectAll();
        }

       public DataTable SERV_Ref_News_Selected(DECVariables.ClsNews DECNews)
        {
            return DALNews.DAL_Ref_News_Selected(DECNews);
        }


       public string SERV_Ref_News_Insert_Main(DECVariables.ClsNews DECNews)
        {
            return DALNews.DAL_Ref_News_Insert_Main(DECNews);
        }

       public string SERV_DAL_Ref_News_Update_Main(DECVariables.ClsNews DECNews)
        {
            return DALNews.DAL_Ref_News_Update_Main(DECNews);
        }

       public string SERV_Ref_News_Delete(DECVariables.ClsNews DECNews)
        {
            return DALNews.DAL_Ref_News_Delete(DECNews);
        }


    }
}
