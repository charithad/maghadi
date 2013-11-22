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

public partial class AddHomeContent : System.Web.UI.Page
{
    DECVariables.ClsAddHomeContent DecHome = new DECVariables.ClsAddHomeContent();
    SERAddHomeContent SERVHome = new SERAddHomeContent();

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Inits"] = "AddHomeContent.aspx";

        string Numo = (string)(Session["usp"]);
        string pumo = (string)(Session["wasp"]);

        if (Numo == null && pumo == null)
        {
            Response.Redirect("login.aspx");
        }

            DataTable Pl_Ref_Home_Content_Select = SERVHome.SERV_Ref_Home_Content_Select();
            if (Pl_Ref_Home_Content_Select.Rows.Count > 0)
            {
                foreach (DataRow DR_Ref_Home_Content_Select in Pl_Ref_Home_Content_Select.Rows)
                {

                    TextBox9.Text = DR_Ref_Home_Content_Select[4].ToString().Trim();
                    TextBox10.Text = DR_Ref_Home_Content_Select[5].ToString().Trim();
                    TextBox4.Text = DR_Ref_Home_Content_Select[1].ToString().Trim();
                    TextBox5.Text = DR_Ref_Home_Content_Select[2].ToString().Trim();
                    TextBox6.Text = DR_Ref_Home_Content_Select[3].ToString().Trim();


                }
            }
        
    }

    private void WriteToFile(string strPath, ref byte[] Buffer)
    {
        FileStream newFile = new FileStream(strPath, FileMode.Create);
        newFile.Write(Buffer, 0, Buffer.Length);
        newFile.Close();
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DecHome.Home_Content_Id="Home";
            string res;
            res = SERVHome.SERV_Ref_Home_Content_Delete(DecHome);
            
            if (res.Trim() == "1")
            {
                try
                {
                    if (System.IO.File.Exists(Server.MapPath("Images\\Home\\1.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Home\\1.JPG"));


                    }
                    if (System.IO.File.Exists(Server.MapPath("Images\\Home\\2.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Home\\2.JPG"));


                    }

                    if (System.IO.File.Exists(Server.MapPath("Images\\Home\\3.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Home\\3.JPG"));


                    }
                }
                catch
                {
                    Label1.Text = "There was an Error deleting these images";
                    return;
                }

                DataTable Pl_Ref_Home_Content_Select = SERVHome.SERV_Ref_Home_Content_Select();
                if (Pl_Ref_Home_Content_Select.Rows.Count == 0)
                {
                    TextBox9.Text = "";
                    TextBox10.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                }

                Response.Write("OK");

                
            }
            else
            {
                Response.Write(res);
            }
        }
        catch (Exception ex)
        {
            Label1.Text = "There was an Error";
        }

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        string strFilename04 = null;
        string strFilename05 = null;
        string strFilename06 = null;

        HttpPostedFile myFile04 = FileUpload2.PostedFile;
        int nFileLen04 = myFile04.ContentLength;

        HttpPostedFile myFile05 = FileUpload5.PostedFile;
        int nFileLen05 = myFile05.ContentLength;

        HttpPostedFile myFile06 = FileUpload6.PostedFile;
        int nFileLen06 = myFile06.ContentLength;

        DecHome.Header = TextBox9.Text;
        DecHome.Home_Content = TextBox10.Text.Trim();
        DecHome.Word_1 = TextBox4.Text.Trim();
        DecHome.Word_2 = TextBox5.Text.Trim();
        DecHome.Word_3 = TextBox6.Text.Trim();


        string res;
        res = SERVHome.SERV_Ref_Home_Content_Update_Main(DecHome);

        if (res.Trim() == "1")
        {
            if (nFileLen04 > 0)
            {

                try
                {
                    if (System.IO.File.Exists(Server.MapPath("Images\\Home\\1.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Home\\1.JPG"));
                        byte[] myData04 = new byte[nFileLen04];
                        myFile04.InputStream.Read(myData04, 0, nFileLen04);
                        strFilename04 = Path.GetFileName(myFile04.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\1.JPG"), ref myData04);
                    }

                    else
                    {


                        byte[] myData04 = new byte[nFileLen04];
                        myFile04.InputStream.Read(myData04, 0, nFileLen04);
                        strFilename04 = Path.GetFileName(myFile04.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\1.JPG"), ref myData04);
                    }
                }
                catch
                {
                    Label2.Text = "There was an error saving this image";
                    return;
                }


            }


            if (nFileLen05 > 0)
            {

                try
                {
                    if (System.IO.File.Exists(Server.MapPath("Images\\Home\\2.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Home\\2.JPG"));
                        byte[] myData05 = new byte[nFileLen05];
                        myFile05.InputStream.Read(myData05, 0, nFileLen05);
                        strFilename05 = Path.GetFileName(myFile05.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\2.JPG"), ref myData05);
                    }

                    else
                    {


                        byte[] myData05 = new byte[nFileLen05];
                        myFile05.InputStream.Read(myData05, 0, nFileLen05);
                        strFilename05 = Path.GetFileName(myFile05.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\2.JPG"), ref myData05);
                    }
                }
                catch
                {
                    Label2.Text = "There was an error updating the image";
                }

            }


            if (nFileLen06 > 0)
            {
                try
                {

                    if (System.IO.File.Exists(Server.MapPath("Images\\Home\\3.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Home\\3.JPG"));
                        byte[] myData06 = new byte[nFileLen06];
                        myFile06.InputStream.Read(myData06, 0, nFileLen06);
                        strFilename06 = Path.GetFileName(myFile06.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\3.JPG"), ref myData06);
                    }

                    else
                    {


                        byte[] myData06 = new byte[nFileLen06];
                        myFile06.InputStream.Read(myData06, 0, nFileLen06);
                        strFilename06 = Path.GetFileName(myFile06.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\3.JPG"), ref myData06);
                    }
                }
                catch
                {
                    Label2.Text = "There was an error updating the image";
                }


            }

            
            
        }
        else
        {
            
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            int num;
            int num1;

            string strFilename01 = null;
            string strFilename02 = null;
            string strFilename03 = null;

            HttpPostedFile myFile01 = FileUpload1.PostedFile;
            int nFileLen01 = myFile01.ContentLength;

            HttpPostedFile myFile02 = FileUpload3.PostedFile;
            int nFileLen02 = myFile02.ContentLength;

            HttpPostedFile myFile03 = FileUpload4.PostedFile;
            int nFileLen03 = myFile03.ContentLength;


            DecHome.Header = TextBox7.Text.Trim();
            DecHome.Home_Content = TextBox8.Text.Trim();
            DecHome.Word_1 = TextBox1.Text.Trim();
            DecHome.Word_2 = TextBox2.Text.Trim();
            DecHome.Word_3 = TextBox3.Text.Trim();
            DataTable Pl_Ref_Home_Content_Select = SERVHome.SERV_Ref_Home_Content_Select();
            if (Pl_Ref_Home_Content_Select.Rows.Count == 1)
            {
                return;
            }

            if (Pl_Ref_Home_Content_Select.Rows.Count == 0)
            {
            string res = "";
            res = SERVHome.SERV_Ref_Home_Content_Insert(DecHome);
            if (res.Trim() == "1")
            {



                if (nFileLen01 > 0)
                {
                    try
                    {


                        byte[] myData01 = new byte[nFileLen01];
                        myFile01.InputStream.Read(myData01, 0, nFileLen01);
                        strFilename01 = Path.GetFileName(myFile01.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\1.JPG"), ref myData01);

                    }
                    catch
                    {
                        Label1.Text = "There was an error saving the image";
                    }

                }

                if (nFileLen02 > 0)
                {

                    try
                    {

                        byte[] myData02 = new byte[nFileLen02];
                        myFile02.InputStream.Read(myData02, 0, nFileLen02);
                        strFilename02 = Path.GetFileName(myFile02.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\2.JPG"), ref myData02);

                    }
                    catch
                    {
                        Label1.Text = "There was an error saving the image";
                    }

                }

                if (nFileLen03 > 0)
                {

                    try
                    {
                        byte[] myData03 = new byte[nFileLen03];
                        myFile03.InputStream.Read(myData03, 0, nFileLen03);
                        strFilename03 = Path.GetFileName(myFile03.FileName);

                        WriteToFile(Server.MapPath("Images\\Home\\3.JPG"), ref myData03);
                    }
                    catch
                    {
                        Label1.Text = "There was an error saving the image";
                    }


                }

                

            } 

            
            else
            {
            }    
          }

        }
        catch
        {
            Label1.Text = "There was an error saving this record";
        }
    }
}