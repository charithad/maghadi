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

public partial class Add_GuestHouse : System.Web.UI.Page
{
    DECVariables.ClsAddGuestHouse DecGuestVar = new DECVariables.ClsAddGuestHouse();
    SERAddGuestHouse SERGuest = new SERAddGuestHouse();
    SERAddAttractions SERAtt = new SERAddAttractions();

    string strFile;
    string Cid;

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Inits"]="AddGuestHouse.aspx";

        string Numo = (string)(Session["usp"]);
        string pumo = (string)(Session["wasp"]);

        if (Numo == null && pumo == null)
        {
            Response.Redirect("login.aspx");
        }

        if (IsPostBack != true)
        {
            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVClient.DataSource = DT_Ref_Guest_SelectAll;
            GVClient.DataBind();
        }
    }

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

        }
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

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



        DataTable PL_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
        Label1.Text = "";
        if (PL_Ref_Guest_SelectAll.Rows.Count > 0)
        {

            foreach (DataRow DR_Ref_Guest_SelectAll in PL_Ref_Guest_SelectAll.Rows)
            {
                if (TextBox1.Text.Trim() == DR_Ref_Guest_SelectAll[1].ToString().Trim())
                {
                    Label2.Text = "";
                    Label2.Text = "The Guest House Name " + TextBox1.Text + " Already Exists";
                    return;
                }
            }
        }
        DataTable PL_Ref_Settings_SelectAll = SERAtt.SERV_Ref_Settings_SelectAll();
        if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
        {
            foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
            {
                num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[2]) + 1;

                Cid = "GC" + num.ToString();
            }
        }




        DecGuestVar.Guest_name = TextBox1.Text.Trim();
        DecGuestVar.Description = TextBox2.Text;


        try
        {
            double am = double.Parse(TextBox13.Text);
        }
        catch
        {
            Label3.Text = "Please Enter Numeric Values";
            return;
        }

        try
        {
            double am = double.Parse(TextBox14.Text);
        }
        catch
        {
            Label3.Text = "Please Enter Numeric Values";
            return;
        }

        try
        {
            double am = double.Parse(TextBox15.Text);
        }
        catch
        {
            Label3.Text = "Please Enter Numeric Values";
            return;
        }

        try
        {
            double am = double.Parse(TextBox17.Text);
        }
        catch
        {
            Label3.Text = "Please Enter Numeric Values";
            return;
        }

        try
        {
            double am = double.Parse(TextBox20.Text);
        }
        catch
        {
            Label3.Text = "Please Enter Numeric Values";
            return;
        }


        DecGuestVar.Price_Per_Day = Convert.ToDouble(TextBox13.Text.Trim());
        DecGuestVar.Room_price = Convert.ToDouble(TextBox14.Text.Trim());
        DecGuestVar.No_Of_Rooms = Convert.ToInt16(TextBox15.Text.Trim());
        DecGuestVar.Price_Per_Day_With_Breakfast = Convert.ToDouble(TextBox17.Text.Trim());
        DecGuestVar.Word_1 = TextBox3.Text.Trim();
        DecGuestVar.Word_2 = TextBox5.Text.Trim();
        DecGuestVar.Word_3 = TextBox6.Text.Trim();
        DecGuestVar.Conatct_No =TextBox18.Text.Trim();
        DecGuestVar.E_mail= TextBox19.Text.Trim();
        DecGuestVar.Max_Guests = Convert.ToInt16(TextBox20.Text.Trim());
        DecGuestVar.Contact_person = TextBox21.Text.Trim();


        string res = "";
        res = SERGuest.SERV_Ref_Guest_Insert_Main(DecGuestVar);
        if (res.Trim() == "1")
        {
            System.IO.Directory.CreateDirectory(Server.MapPath("Images\\Guest_Img\\" + Cid.Trim()+"\\"));
            if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                {
                    num1 = Convert.ToInt32(Dr_Ref_Settings_SelectAll[2]);
                    int numL = num1 + 1;
                    Cid = "GC" + numL.ToString();
                    
                }
            }

            if (nFileLen01 > 0)
            {
                try
                {


                    byte[] myData01 = new byte[nFileLen01];
                    myFile01.InputStream.Read(myData01, 0, nFileLen01);
                    strFilename01 = Path.GetFileName(myFile01.FileName);

                    WriteToFile(Server.MapPath("Images\\Guest_Img\\" + Cid.Trim() + "\\1.JPG"), ref myData01);
                }
                catch
                {
                    Label3.Text = "There Was an Error saving the 1.jpg image";
                    return;
                }


            }

            if (nFileLen02 > 0)
            {

                try
                {

                    byte[] myData02 = new byte[nFileLen02];
                    myFile02.InputStream.Read(myData02, 0, nFileLen02);
                    strFilename02 = Path.GetFileName(myFile02.FileName);

                    WriteToFile(Server.MapPath("Images\\Guest_Img\\" + Cid.Trim() + "\\2.JPG"), ref myData02);
                }
                catch
                {
                    Label3.Text = "There Was an Error saving the 2.jpg image";
                    return;
                }


            }

            if (nFileLen03 > 0)
            {

                try
                {
                    byte[] myData03 = new byte[nFileLen03];
                    myFile03.InputStream.Read(myData03, 0, nFileLen03);
                    strFilename03 = Path.GetFileName(myFile03.FileName);

                    WriteToFile(Server.MapPath("Images\\Guest_Img\\" + Cid.Trim() + "\\3.JPG"), ref myData03);
                }
                catch
                {
                    Label3.Text = "There Was an Error saving the 3.jpg image";
                    return;
                }


            }

           

            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVClient.DataSource = DT_Ref_Guest_SelectAll;
            GVClient.DataBind(); 

        }
        else
        {
            Response.Write(res);
        }

        }
        catch
        {
            Label3.Text = "There Was an Error saving this Guesthouse";
        }


    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
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

            DecGuestVar.Guest_Code = Label1.Text;
            DecGuestVar.Guest_name = TextBox26.Text.ToString().Trim();
            DecGuestVar.Description = TextBox4.Text;

            try
            {
                double am = double.Parse(TextBox10.Text);
            }
            catch
            {
                Label4.Text = "Please Enter Numeric Values";
                return;
            }

            try
            {
                double am = double.Parse(TextBox11.Text);
            }
            catch
            {
                Label4.Text = "Please Enter Numeric Values";
                return;
            }

            try
            {
                double am = double.Parse(TextBox12.Text);
            }
            catch
            {
                Label4.Text = "Please Enter Numeric Values";
                return;
            }

            try
            {
                double am = double.Parse(TextBox16.Text);
            }
            catch
            {
                Label4.Text = "Please Enter Numeric Values";
                return;
            }

            try
            {
                double am = double.Parse(TextBox24.Text);
            }
            catch
            {
                Label4.Text = "Please Enter Numeric Values";
                return;
            }

            DecGuestVar.Price_Per_Day = Convert.ToDouble(TextBox10.Text.Trim());
            DecGuestVar.Room_price = Convert.ToDouble(TextBox11.Text.Trim());
            DecGuestVar.No_Of_Rooms = Convert.ToInt16(TextBox12.Text.Trim());
            DecGuestVar.Price_Per_Day_With_Breakfast = Convert.ToDouble(TextBox16.Text.Trim());
            DecGuestVar.Word_1 = TextBox7.Text.Trim();
            DecGuestVar.Word_2 = TextBox8.Text.Trim();
            DecGuestVar.Word_3 = TextBox9.Text.Trim();
            DecGuestVar.Conatct_No = TextBox22.Text.Trim();
            DecGuestVar.E_mail = TextBox23.Text.Trim();
            DecGuestVar.Max_Guests = Convert.ToInt16(TextBox24.Text.Trim());
            DecGuestVar.Contact_person = TextBox25.Text.Trim();


            string res;
            res = SERGuest.SERV_DAL_Ref_Guest_Update_Main_Main(DecGuestVar);

            if (res.Trim() == "1")
            {
                if (nFileLen04 > 0)
                {

                    try
                    {
                        if (System.IO.File.Exists(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\1.JPG")))
                        {
                            System.IO.File.Delete(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\1.JPG"));
                            byte[] myData04 = new byte[nFileLen04];
                            myFile04.InputStream.Read(myData04, 0, nFileLen04);
                            strFilename04 = Path.GetFileName(myFile04.FileName);

                            WriteToFile(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\1.JPG"), ref myData04);
                        }

                        else
                        {


                            byte[] myData04 = new byte[nFileLen04];
                            myFile04.InputStream.Read(myData04, 0, nFileLen04);
                            strFilename04 = Path.GetFileName(myFile04.FileName);

                            WriteToFile(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\1.JPG"), ref myData04);
                        }

                    }
                    catch
                    {
                        Label4.Text = "There Was an Error Updating the 1.jpg image";
                        return;
                    }
                }


                if (nFileLen05 > 0)
                {
                    try
                    {

                        if (System.IO.File.Exists(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\2.JPG")))
                        {
                            System.IO.File.Delete(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\2.JPG"));
                            byte[] myData05 = new byte[nFileLen05];
                            myFile05.InputStream.Read(myData05, 0, nFileLen05);
                            strFilename05 = Path.GetFileName(myFile05.FileName);

                            WriteToFile(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\2.JPG"), ref myData05);
                        }

                        else
                        {


                            byte[] myData05 = new byte[nFileLen05];
                            myFile05.InputStream.Read(myData05, 0, nFileLen05);
                            strFilename05 = Path.GetFileName(myFile05.FileName);

                            WriteToFile(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\2.JPG"), ref myData05);
                        }
                    }
                    catch
                    {
                        Label4.Text = "There Was an Error Updating the 2.jpg image";
                        return;
                    }

                }


                if (nFileLen06 > 0)
                {

                    try
                    {
                        if (System.IO.File.Exists(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\3.JPG")))
                        {
                            System.IO.File.Delete(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\3.JPG"));
                            byte[] myData06 = new byte[nFileLen06];
                            myFile06.InputStream.Read(myData06, 0, nFileLen06);
                            strFilename06 = Path.GetFileName(myFile06.FileName);

                            WriteToFile(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\3.JPG"), ref myData06);
                        }

                        else
                        {


                            byte[] myData06 = new byte[nFileLen06];
                            myFile06.InputStream.Read(myData06, 0, nFileLen06);
                            strFilename06 = Path.GetFileName(myFile06.FileName);

                            WriteToFile(Server.MapPath("Images\\Guest_Img\\" + DecGuestVar.Guest_Code.Trim() + "\\3.JPG"), ref myData06);
                        }
                    }
                    catch
                    {
                        Label4.Text = "There Was an Error Updating the 3.jpg image";
                        return;

                    }



                }

                Response.Write("OK !");

            }
            else
            {
                Response.Write(res);
            }
        }
        catch
        {
            Label4.Text = "There Was an Error Saving This Record";
        }
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DecGuestVar.Guest_Code = Label1.Text;
            string res;
            res = SERGuest.SERV_Ref_Guest_Delete(DecGuestVar);
            strFile = Label1.Text.ToString().Trim();
            if (res.Trim() == "1")
            {
                try
                {
                    if (System.IO.File.Exists(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\1.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\1.JPG"));


                    }
                }
                catch
                {
                    Label4.Text = "There Was an Error Deleting the 1.jpg image";
                    return;
                }

                try
                {
                    if (System.IO.File.Exists(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\2.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\2.JPG"));


                    }

                    if (System.IO.File.Exists(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\3.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\3.JPG"));


                    }
                }
                catch
                {
                    Label4.Text = "There Was an Error Deleting the 1.jpg image";
                    return;
                }

                try
                {
                    if (System.IO.Directory.Exists(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\")))
                    {
                        System.IO.Directory.Delete(Server.MapPath("Images\\Guest_Img\\" + strFile + "\\"), true);
                    }
                }
                catch
                {
                    Label4.Text = "There Was an Error Deleting The Directory";
                }
                Response.Write("OK");
                DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                GVClient.DataSource = DT_Ref_Guest_SelectAll;
                GVClient.DataBind();
                
            }
            else
            {
                Response.Write(res);
            }
        }
        catch (Exception ex)
        {
            Label4.Text = "There Was an Error saving the 1.jpg image";
        }
    }

    public void GVClient_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            DecGuestVar.Guest_Code = GVClient.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            Label1.Text = GVClient.Rows[rowIndex].Cells[0].Text.ToString().Trim();

            DataTable PL_Ref_Guest_Selected = SERGuest.SERV_Ref_Guest_Selected(DecGuestVar);
            if (PL_Ref_Guest_Selected.Rows.Count > 0)
            {
                foreach (DataRow DR_Ref_Guest_Selected in PL_Ref_Guest_Selected.Rows)
                {
                    Label1.Text = DR_Ref_Guest_Selected[0].ToString().Trim();
                    TextBox4.Text = DR_Ref_Guest_Selected[1].ToString().Trim();
                    TextBox10.Text = DR_Ref_Guest_Selected[2].ToString().Trim();
                    TextBox11.Text = DR_Ref_Guest_Selected[3].ToString().Trim();
                    TextBox12.Text = DR_Ref_Guest_Selected[4].ToString().Trim();
                    TextBox7.Text = DR_Ref_Guest_Selected[7].ToString().Trim();
                    TextBox8.Text = DR_Ref_Guest_Selected[8].ToString().Trim();
                    TextBox9.Text = DR_Ref_Guest_Selected[9].ToString().Trim();
                    TextBox16.Text = DR_Ref_Guest_Selected[10].ToString().Trim();
                    TextBox22.Text = DR_Ref_Guest_Selected[11].ToString().Trim();
                    TextBox23.Text = DR_Ref_Guest_Selected[12].ToString().Trim();
                    TextBox24.Text = DR_Ref_Guest_Selected[13].ToString().Trim();
                    TextBox25.Text = DR_Ref_Guest_Selected[14].ToString().Trim();
                    TextBox26.Text = DR_Ref_Guest_Selected[6].ToString().Trim();

                }
            }


        }
        catch
        {
            Label4.Text = "There Was an Error";
        }


       

    }

    
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}