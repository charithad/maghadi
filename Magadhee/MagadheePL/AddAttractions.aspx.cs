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

public partial class AddAttractions : System.Web.UI.Page
{
    DECVariables.ClsAddAttractions DECAttr = new DECVariables.ClsAddAttractions();
    DECVariables.ClsAddGuestHouse DECGuest = new DECVariables.ClsAddGuestHouse();
    SERAddAttractions SERAtt = new SERAddAttractions();
    SERAddGuestHouse SERGuest = new SERAddGuestHouse();

    string Cid;
    string strFilename01;
    string strFilename02;
    

    public void GVAttr_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        try
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);
            DECAttr.Atraction_Id = GVAttarct.Rows[rowIndex].Cells[0].Text.ToString().Trim();
            TextBox5.Text = GVAttarct.Rows[rowIndex].Cells[1].Text.ToString().Trim();
            Label2.Text = GVAttarct.Rows[rowIndex].Cells[0].Text.ToString().Trim();

            DataTable PL_Ref_Attraction_Selected = SERAtt.SERV_Ref_Attraction_Selected(DECAttr);
            if (PL_Ref_Attraction_Selected.Rows.Count != 0)
            {

                foreach (DataRow DR_Ref_Attraction_Selected in PL_Ref_Attraction_Selected.Rows)
                {
                    TextBox4.Text = DR_Ref_Attraction_Selected[3].ToString().Trim();
                }
            }

            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
            GVBangalow.DataBind();



            DataTable PL_Ref_Attraction_Wise_Guest_Selected = SERAtt.SERV_Ref_Attraction_Wise_Guest_Selected(DECAttr);
            if (PL_Ref_Attraction_Wise_Guest_Selected.Rows.Count != 0)
            {

                foreach (DataRow DR_Ref_Attraction_Wise_Guest_Selected in PL_Ref_Attraction_Wise_Guest_Selected.Rows)
                {
                    int rowIndexCit = 0;
                    foreach (GridViewRow gr in GVBangalow.Rows)
                    {
                        CheckBox cbGen2 = (CheckBox)gr.Cells[0].FindControl("ChkBang");

                        if (GVBangalow.Rows[rowIndexCit].Cells[0].Text.ToString().Trim() == DR_Ref_Attraction_Wise_Guest_Selected[0].ToString().Trim())
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
            Label5.Text = "There was an Error Try Again";
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
            Label4.Text = "An Error Occered while writting the file";
        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            string CIDS;

            HttpPostedFile myFile02 = FileUpload2.PostedFile;
            int nFileLen02 = myFile02.ContentLength;


            CIDS = Label2.Text.Trim();

            int rowIndCid = 0;

            List<DECVariables.ClsAddAttractions> ListUp3 = new List<DECVariables.ClsAddAttractions>();
            DECVariables.ClsAddAttractions row1;
            foreach (GridViewRow gt in GVBangalow.Rows)
            {
                CheckBox cb = (CheckBox)gt.Cells[0].FindControl("ChkBang");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsAddAttractions();

                    row1.Guest_Code = GVBangalow.Rows[rowIndCid].Cells[0].Text.ToString();
                    row1.Atraction_Id = CIDS;
                    ListUp3.Add(row1);
                }
                rowIndCid++;
            }
            DECAttr.Atraction_Id = CIDS.Trim();
            DECAttr.Heading = TextBox5.Text.Trim();
            DECAttr.Description = TextBox4.Text.Trim();

            string res = "";
            res = SERAtt.SERV_Ref_Attraction_Update_Main(DECAttr, ListUp3);
            if (res.Trim() == "1")
            {
                   try
                   {
            
                    if (nFileLen02 > 0)
                    {
                        try
                        {

                        if (System.IO.File.Exists(Server.MapPath("Images\\Attr_Img\\" + DECAttr.Atraction_Id.Trim() + "\\1.JPG")))
                        {
                            System.IO.File.Delete(Server.MapPath("Images\\Attr_Img\\" + DECAttr.Atraction_Id.Trim() + "\\1.JPG"));
                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\Attr_Img\\" + DECAttr.Atraction_Id.Trim() + "\\1.JPG"), ref myData02);
                        }

                        else
                        {


                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\Attr_Img\\" + DECAttr.Atraction_Id.Trim() + "\\1.JPG"), ref myData02);
                        }
                        DataTable Dt_Ref_Attraction_SelectAll = SERAtt.SERV_Ref_Attraction_SelectAll();
                        GVAttarct.DataSource = Dt_Ref_Attraction_SelectAll;
                        GVAttarct.DataBind();


                        DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                        GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                        GVBangalow.DataBind();
                    


                        }
                        catch
                        {
                            Label5.Text="There Was An Error While Saving The Image";
                            return;
                        }


                    }

                }
                catch
                {
                    Label5.Text = "There was a error";
                    return;
                }



                }
        }
        catch
        {
            Label5.Text = "Arrror Occored While editing the record"; 
        }
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            DECAttr.Atraction_Id = Label2.Text.Trim();

            string res = "";
            res = SERAtt.SERV_Ref_Attraction_Delete(DECAttr);
            if (res.Trim() == "1")
            {

                try
                {
                    if (System.IO.File.Exists(Server.MapPath("Images\\Attr_Img\\" + Label2.Text.Trim() + "\\1.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Attr_Img\\" + Label2.Text.Trim() + "\\1.JPG"));
                        System.IO.Directory.Delete(Server.MapPath("Images\\Attr_Img\\" + Label2.Text.Trim() + "\\"), true);
                    }
                    DataTable Dt_Ref_Attraction_SelectAll = SERAtt.SERV_Ref_Attraction_SelectAll();
                    GVAttarct.DataSource = Dt_Ref_Attraction_SelectAll;
                    GVAttarct.DataBind();

                    DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                    GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                    GVBangalow.DataBind();
                }
                catch
                {
                    Label5.Text = "There Was An Error While Deleting This Image";
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
            Label5.Text = "Error Occerd While Deleting";
        }

       
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {

            int num;



            HttpPostedFile myFile01 = FileUpload1.PostedFile;
            int nFileLen01 = myFile01.ContentLength;




            DataTable PL_Ref_Attraction_SelectAll = SERAtt.SERV_Ref_Attraction_SelectAll();

            if (PL_Ref_Attraction_SelectAll.Rows.Count > 0)
            {

                foreach (DataRow DR_Ref_Attraction_SelectAll in PL_Ref_Attraction_SelectAll.Rows)
                {
                    if (TextBox1.Text.Trim() == DR_Ref_Attraction_SelectAll[2].ToString().Trim())
                    {
                        Label4.Text = "";
                        Label4.Text = "The Attraction name " + TextBox1.Text + " Already Exists";
                        return;
                    }
                }
            }

            DataTable PL_Ref_Settings_SelectAll = SERAtt.SERV_Ref_Settings_SelectAll();
            if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
            {
                foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                {
                    num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[0]) + 1;

                    Cid = "AI" + num.ToString();
                }
            }
            DECAttr.Heading = TextBox1.Text;
            DECAttr.Description = TextBox2.Text;


            int rowIndex = 0;

            List<DECVariables.ClsAddAttractions> List2 = new List<DECVariables.ClsAddAttractions>();
            DECVariables.ClsAddAttractions row1;
            foreach (GridViewRow gr in GVGuestAdd.Rows)
            {
                CheckBox cb = (CheckBox)gr.Cells[0].FindControl("ChkGuest");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsAddAttractions();

                    row1.Guest_Code = GVGuestAdd.Rows[rowIndex].Cells[0].Text.ToString();
                    row1.Atraction_Id = Cid;
                    List2.Add(row1);
                }
                rowIndex++;
            }

            string res = "";
            res = SERAtt.SERV_Ref_Attraction_Insert_Main(DECAttr, List2);
            if (res.Trim() == "1")
            {
                System.IO.Directory.CreateDirectory(Server.MapPath("Images\\Attr_Img\\" + Cid.Trim()));
                
                if (nFileLen01 > 0)
                {
                    try
                    {
                        if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
                        {
                            foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                            {
                                num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[0]) + 1;

                                Cid = "AI" + num.ToString();

                            }
                        }

                        byte[] myData01 = new byte[nFileLen01];
                        myFile01.InputStream.Read(myData01, 0, nFileLen01);
                        strFilename01 = Path.GetFileName(myFile01.FileName);
                        WriteToFile(Server.MapPath("Images\\Attr_Img\\" + Cid.Trim() + "\\1.JPG"), ref myData01);


                    }
                    catch
                    {
                        Label4.Text = "There was an error saving this image";
                        return;
                    }
                }

                Response.Write("OK !");
                DataTable Dt_Ref_Attraction_SelectAll = SERAtt.SERV_Ref_Attraction_SelectAll();
                GVAttarct.DataSource = Dt_Ref_Attraction_SelectAll;
                GVAttarct.DataBind(); 

            }
            else
            {
                Response.Write(res);
            }
        }
        catch
        {
            Label4.Text = "An Error Occored";
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }
    


    protected void Page_Load(object sender, System.EventArgs e)
    {
        Session["Inits"] = "AddAttractions.aspx";

        string Numo = (string)(Session["usp"]);
        string pumo = (string)(Session["wasp"]);

        if (Numo == null && pumo == null)
        {
            Response.Redirect("login.aspx");
        }

        if (IsPostBack == false)
        {

            DataTable Dt_Ref_Attraction_SelectAll = SERAtt.SERV_Ref_Attraction_SelectAll();
            GVAttarct.DataSource = Dt_Ref_Attraction_SelectAll;
            GVAttarct.DataBind();


            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
            GVBangalow.DataBind();


            GVGuestAdd.DataSource = DT_Ref_Guest_SelectAll;
            GVGuestAdd.DataBind();

            
        }
    }

    
}