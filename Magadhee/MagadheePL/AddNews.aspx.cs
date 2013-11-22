using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Configuration;
using System.Data;
using System.Xml.Linq;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Text;
using MagadheeDEC.GuestHouseDec;
using MgadheeService.GuestHouseService;

public partial class AddNews : System.Web.UI.Page
{

    DECVariables.ClsNews DECNews = new DECVariables.ClsNews();
    SERAddNews SERNews = new SERAddNews();
    SERAddAttractions SERAtt = new SERAddAttractions();

    string Cid;
    string strFilename01;
    string strFilename02;

    private void WriteToFile(string strPath, ref byte[] Buffer)
    {
        try
        {
            FileStream newFile = new FileStream(strPath, FileMode.Create);
            newFile.Write(Buffer, 0, Buffer.Length);
            newFile.Close();
        }
        catch
        {
            Label2.Text = "There was and Error Saving The Image";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Session["Inits"] = "AddNews.aspx";

            string Numo = (string)(Session["usp"]);
            string pumo = (string)(Session["wasp"]);

            if (Numo == null && pumo == null)
            {
                Response.Redirect("login.aspx");
            }

            if (IsPostBack == false)
            {

                DataTable Dt_Ref_News_SelectAll = SERNews.SERV_Ref_News_SelectAll();
                GVNews.DataSource = Dt_Ref_News_SelectAll;
                GVNews.DataBind();
            }
        }
        catch
        {
            Label2.Text = "Error Occered While Loading";
            return;
        }
    }


    public void GVNews_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {

            int rowIndex = Convert.ToInt32(e.CommandArgument);
            DECNews.News_Id = GVNews.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            Label1.Text = GVNews.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            Calendar2.SelectedDate = Convert.ToDateTime(GVNews.Rows[rowIndex].Cells[2].Text.ToString().Trim());


            DataTable PL_Client_Testimonials_Selected = SERNews.SERV_Ref_News_Selected(DECNews);
            if (PL_Client_Testimonials_Selected.Rows.Count != 0)
            {

                foreach (DataRow DR_Client_Testimonials_Selected in PL_Client_Testimonials_Selected.Rows)
                {
                    TextBox4.Text = DR_Client_Testimonials_Selected[2].ToString().Trim();
                    TextBox5.Text = DR_Client_Testimonials_Selected[1].ToString().Trim();
                }
            }
        }
        catch
        {
            Label2.Text = "There was an error";
        }

    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DECNews.News_Id = Label1.Text.Trim();

            string res = "";
            res = SERNews.SERV_Ref_News_Delete(DECNews);
            if (res.Trim() == "1")
            {
                try
                {
                    Response.Write("OK !");

                    if (System.IO.File.Exists(Server.MapPath("Images\\News_Img\\" + Label1.Text.Trim() + "\\1.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\News_Img\\" + Label1.Text.Trim() + "\\1.JPG"));
                        System.IO.Directory.Delete(Server.MapPath("Images\\News_Img\\" + Label1.Text.Trim() + "\\"), true);
                    }
                    DataTable Dt_Ref_News_SelectAll = SERNews.SERV_Ref_News_SelectAll();
                    GVNews.DataSource = Dt_Ref_News_SelectAll;
                    GVNews.DataBind();

                }
                catch
                {
                    Label3.Text = "There Was an Error Deleting The Image";
                    return;
                }

            }
            else
            {
                Response.Write(res);
            }

        }
        catch
        {
            
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string CIDS;

            HttpPostedFile myFile02 = FileUpload2.PostedFile;
            int nFileLen02 = myFile02.ContentLength;


            CIDS = Label1.Text.Trim();

            
            DECNews.News_Id = CIDS.Trim();
            DECNews.Heading = TextBox5.Text.Trim();
            DECNews.Description = TextBox4.Text.Trim();
            DECNews.News_Date = Calendar2.SelectedDate;


            string res = "";
            res = SERNews.SERV_DAL_Ref_News_Update_Main(DECNews);
            if (res.Trim() == "1")
            {
                Response.Write("OK !");

                if (nFileLen02 > 0)
                {
                    try
                    {
                        if (System.IO.File.Exists(Server.MapPath("Images\\News_Img\\" + DECNews.News_Id.Trim() + "\\1.JPG")))
                        {
                            System.IO.File.Delete(Server.MapPath("Images\\News_Img\\" + DECNews.News_Id.Trim() + "\\1.JPG"));
                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\News_Img\\" + DECNews.News_Id.Trim() + "\\1.JPG"), ref myData02);
                        }

                        else
                        {


                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\News_Img\\" + DECNews.News_Id.Trim() + "\\1.JPG"), ref myData02);
                        }
                    }
                    catch
                    {
                        Label3.Text = "There was An Error Updating This Image";
                        return;
                    }




               }
                DataTable Dt_Ref_News_SelectAll = SERNews.SERV_Ref_News_SelectAll();
                GVNews.DataSource = Dt_Ref_News_SelectAll;
                GVNews.DataBind();
            }
            else
            {
                Response.Write(res);
            }
        }
        catch
        {
            Label3.Text = "There Was An Error Updating This Item";
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            int num;



            HttpPostedFile myFile01 = FileUpload1.PostedFile;
            int nFileLen01 = myFile01.ContentLength;




            DataTable PL_Ref_News_SelectAll = SERNews.SERV_Ref_News_SelectAll();

            if (PL_Ref_News_SelectAll.Rows.Count > 0)
            {

                foreach (DataRow DR_Ref_News_SelectAll in PL_Ref_News_SelectAll.Rows)
                {
                    if (TextBox1.Text.Trim() == DR_Ref_News_SelectAll[2].ToString().Trim())
                    {
                        Label2.Text = "";
                        Label2.Text = "The Attraction name " + TextBox1.Text + " Already Exists";
                        return;
                    }
                }
            }

            DataTable PL_Ref_Settings_SelectAll = SERAtt.SERV_Ref_Settings_SelectAll();
            if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                {
                    num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[5]) + 1;

                    Cid = "NI" + num.ToString();
                }
            }
            DECNews.Heading = TextBox1.Text;
            DECNews.Description = TextBox2.Text;
            DECNews.News_Date = Calendar1.SelectedDate;


            
            
            string res = "";
            res = SERNews.SERV_Ref_News_Insert_Main(DECNews);
            if (res.Trim() == "1")
            {
                System.IO.Directory.CreateDirectory(Server.MapPath("Images\\News_Img\\" + Cid.Trim()));

                if (nFileLen01 > 0)
                {
                    try
                    {
                        if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
                        {
                            foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                            {
                                num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[5]) + 1;

                                Cid = "NI" + num.ToString();

                            }
                        }

                        byte[] myData01 = new byte[nFileLen01];
                        myFile01.InputStream.Read(myData01, 0, nFileLen01);
                        strFilename01 = Path.GetFileName(myFile01.FileName);
                        WriteToFile(Server.MapPath("Images\\News_Img\\" + Cid.Trim() + "\\1.JPG"), ref myData01);

                    }
                    catch
                    {
                        Label2.Text = "There Was An Error While Saving This Image";
                        return;
                    }

                }

                Response.Write("OK !");

                DataTable Dt_Ref_News_SelectAll = SERNews.SERV_Ref_News_SelectAll();
                GVNews.DataSource = Dt_Ref_News_SelectAll;
                GVNews.DataBind();

            }
            else
            {
                Response.Write(res);
            }
        }
        catch
        {
            Label2.Text = "An Error Occored";
        }
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {

    }
}