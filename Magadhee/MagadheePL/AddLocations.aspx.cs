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


public partial class AddLocations : System.Web.UI.Page
{
    SERAddAttractions SERAtt = new SERAddAttractions();
    SERAddLocations SERLoc = new SERAddLocations();
    SERAddGuestHouse SERGuest = new SERAddGuestHouse();

    DECVariables.ClsLocation DECLoc = new DECVariables.ClsLocation();
    DECVariables.ClsAddGuestHouse DECGuest = new DECVariables.ClsAddGuestHouse();
    string Cid;
    string strFilename01;
    string strFilename02;

    public void GVLoc_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            DECLoc.Location_Id = GVLocation.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            Label1.Text = GVLocation.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            DataTable PL_Ref_Location_Selected = SERLoc.SERV_Ref_Location_Selected(DECLoc);
            if (PL_Ref_Location_Selected.Rows.Count != 0)
            {

                foreach (DataRow DR_Ref_Location_Selected in PL_Ref_Location_Selected.Rows)
                {
                    TextBox4.Text = DR_Ref_Location_Selected[2].ToString().Trim();
                    TextBox5.Text = DR_Ref_Location_Selected[1].ToString().Trim();
                }
            }

            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
            GVBangalow.DataBind();



            DataTable PL_Ref_Location_Wise_Guest_House_Selected = SERLoc.SERV_Ref_Location_Wise_Guest_House_Selected(DECLoc);
            if (PL_Ref_Location_Wise_Guest_House_Selected.Rows.Count != 0)
            {

                foreach (DataRow DR_Ref_Location_Wise_Guest_House_Selected in PL_Ref_Location_Wise_Guest_House_Selected.Rows)
                {
                    int rowIndexCit = 0;
                    foreach (GridViewRow gr in GVBangalow.Rows)
                    {
                        CheckBox cbGen2 = (CheckBox)gr.Cells[2].FindControl("ChkBang");

                        if (GVBangalow.Rows[rowIndexCit].Cells[0].Text.ToString().Trim() == DR_Ref_Location_Wise_Guest_House_Selected[1].ToString().Trim())
                        {
                            if (cbGen2.Checked != true)
                            {
                                cbGen2.Checked = true;
                            }
                        }
                        rowIndexCit++;
                    }
                }
            }
        }
        catch
        {
            Label2.Text = "There Was an Error";
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
            Label2.Text = "There Was an Error";
        }
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            int num;

            HttpPostedFile myFile01 = FileUpload1.PostedFile;
            int nFileLen01 = myFile01.ContentLength;


            DataTable PL_Ref_Settings_SelectAll = SERAtt.SERV_Ref_Settings_SelectAll();
            if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                {
                    num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[4]) + 1;

                    Cid = "LI" + num.ToString();
                }
            }
            DECLoc.Location_Name = TextBox1.Text;
            DECLoc.Description = TextBox2.Text;
            

            

            int rowIndex = 0;

            List<DECVariables.ClsLocation> List2 = new List<DECVariables.ClsLocation>();
            DECVariables.ClsLocation row1;
            foreach (GridViewRow gr in GVGuestAdd.Rows)
            {
                CheckBox cb = (CheckBox)gr.Cells[0].FindControl("ChkGuest");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsLocation();

                    row1.Guest_Id= GVGuestAdd.Rows[rowIndex].Cells[0].Text.ToString();
                    row1.Location_Id = Cid;
                    List2.Add(row1);
                }
                rowIndex++;
            }

            string res = "";
            res = SERLoc.SERV_Ref_Location_Insert_Main(DECLoc, List2);
            if (res.Trim() == "1")
            {

                System.IO.Directory.CreateDirectory(Server.MapPath("Images\\Location_Img\\" + Cid.Trim()));
                if (nFileLen01 > 0)
                {
                    try
                    {
                        if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
                        {
                            foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                            {
                                num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[4]) + 1;

                                Cid = "LI" + num.ToString();

                            }
                        }

                        byte[] myData01 = new byte[nFileLen01];
                        myFile01.InputStream.Read(myData01, 0, nFileLen01);
                        strFilename01 = Path.GetFileName(myFile01.FileName);
                        WriteToFile(Server.MapPath("Images\\Location_Img\\" + Cid.Trim() + "\\1.JPG"), ref myData01);

                    }
                    catch
                    {
                        Label2.Text = "There Was an Error writting the Image";
                        return;
                    }
                }

                DataTable Dt_Ref_Location_SelectAll = SERLoc.SERV_Ref_Location_SelectAll();
                GVLocation.DataSource = Dt_Ref_Location_SelectAll;
                GVLocation.DataBind();

            }
            else
            {
                Response.Write(res);
            }           
        }
        catch
        {
            Label2.Text = "There was an error saving Item";
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

            int rowIndCid = 0;

            List<DECVariables.ClsLocation> ListUp3 = new List<DECVariables.ClsLocation>();
            DECVariables.ClsLocation row1;
            foreach (GridViewRow gt in GVBangalow.Rows)
            {
                CheckBox cb = (CheckBox)gt.Cells[0].FindControl("ChkBang");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsLocation();

                    row1.Guest_Id = GVBangalow.Rows[rowIndCid].Cells[0].Text.ToString();
                    row1.Location_Id = CIDS;
                    ListUp3.Add(row1);
                }
                rowIndCid++;
            }
            DECLoc.Location_Id = CIDS.Trim();
            DECLoc.Location_Name = TextBox5.Text.Trim();
            DECLoc.Description = TextBox4.Text.Trim();

            string res = "";
            res = SERLoc.SERV_Ref_Location_Update_Main(DECLoc, ListUp3);
            if (res.Trim() == "1")
            {
                Response.Write("OK !");

                if (nFileLen02 > 0)
                {
                    try
                    {
                        if (System.IO.File.Exists(Server.MapPath("Images\\Location_Img\\" + DECLoc.Location_Id.Trim() + "\\1.JPG")))
                        {
                            System.IO.File.Delete(Server.MapPath("Images\\Location_Img\\" + DECLoc.Location_Id.Trim() + "\\1.JPG"));
                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\Location_Img\\" + DECLoc.Location_Id.Trim() + "\\1.JPG"), ref myData02);
                        }

                        else
                        {


                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\Location_Img\\" + DECLoc.Location_Id.Trim() + "\\1.JPG"), ref myData02);
                        }



                        DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                        GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                        GVBangalow.DataBind();
                    }
                    catch
                    {
                        Label2.Text = "There Was an Error updating The Image";
                        return;
                    }

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
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DECLoc.Location_Id = Label1.Text.Trim();

            string res = "";
            res = SERLoc.SERV_Ref_Location_Delete(DECLoc);
            if (res.Trim() == "1")
            {
                try
                {

                    if (System.IO.File.Exists(Server.MapPath("Images\\Location_Img\\" + Label1.Text.Trim() + "\\1.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Location_Img\\" + Label1.Text.Trim() + "\\1.JPG"));
                        System.IO.Directory.Delete(Server.MapPath("Images\\Location_Img\\" + Label1.Text.Trim() + "\\"), true);
                    }
                    DataTable Dt_Ref_Location_SelectAll = SERLoc.SERV_Ref_Location_SelectAll();
                    GVLocation.DataSource = Dt_Ref_Location_SelectAll;
                    GVLocation.DataBind();

                    DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                    GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                    GVBangalow.DataBind();
                }
                catch
                {
                    Label3.Text = "There was an error deleting the image";
                    return;
                }
            }
            else
            {
                
            }
       
        }
        catch
        {
            Label3.Text = "There was an error Deleting the image";
        }
    }
    
    protected void Page_Load(object sender, System.EventArgs e)
    {
        Session["Inits"] = "AddLocations.aspx";



        string Numo = (string)(Session["usp"]);
        string pumo = (string)(Session["wasp"]);

        if (Numo == null && pumo == null)
        {
            Response.Redirect("login.aspx");
        }


        if (IsPostBack == false)
        {

            DataTable Dt_Ref_Location_SelectAll = SERLoc.SERV_Ref_Location_SelectAll();
            GVLocation.DataSource = Dt_Ref_Location_SelectAll;
            GVLocation.DataBind();


            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
            GVBangalow.DataBind();


            GVGuestAdd.DataSource = DT_Ref_Guest_SelectAll;
            GVGuestAdd.DataBind();


        }
    }
}