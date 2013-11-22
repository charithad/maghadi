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

public partial class AddPromotions : System.Web.UI.Page
{

    DECVariables.ClsPromotions DECPromo = new DECVariables.ClsPromotions();
    DECVariables.ClsAddGuestHouse DECGuest = new DECVariables.ClsAddGuestHouse();
    SERAddPromotions SERPromo = new SERAddPromotions();
    SERAddGuestHouse SERGuest = new SERAddGuestHouse();
    SERAddAttractions SERAtt = new SERAddAttractions();

    string Cid;
    string strFilename01;
    string strFilename02;

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Inits"] = "AddPromotions.aspx";

        string Numo = (string)(Session["usp"]);
        string pumo = (string)(Session["wasp"]);

        if (Numo == null && pumo == null)
        {
            Response.Redirect("login.aspx");
        }

        if (IsPostBack == false)
        {
            DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
            GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
            GVBangalow.DataBind();

            DataTable DT_Ref_Promotions_Select_All = SERPromo.SERV_Ref_Promotions_Select_All();
            GVPromo.DataSource = DT_Ref_Promotions_Select_All;
            GVPromo.DataBind();


            GVGuestAdd.DataSource = DT_Ref_Guest_SelectAll;
            GVGuestAdd.DataBind();
        }
    }


    public void GVPromo_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowIndex = Convert.ToInt32(e.CommandArgument);
        DECPromo.Promotion_Id = GVPromo.Rows[rowIndex].Cells[0].Text.ToString().Trim();
        Label1.Text = GVPromo.Rows[rowIndex].Cells[0].Text.ToString().Trim();
        DataTable PL_Ref_Promotions_Selected = SERPromo.SERV_Ref_Promotions_Selected(DECPromo);
        if (PL_Ref_Promotions_Selected.Rows.Count != 0)
        {

            foreach (DataRow DR_Ref_Promotions_Selected in PL_Ref_Promotions_Selected.Rows)
            {
                TextBox4.Text = DR_Ref_Promotions_Selected[2].ToString().Trim();
                TextBox5.Text = DR_Ref_Promotions_Selected[6].ToString().Trim();
                TextBox11.Text = DR_Ref_Promotions_Selected[7].ToString().Trim();
                TextBox12.Text = DR_Ref_Promotions_Selected[8].ToString().Trim();
                TextBox6.Text = DR_Ref_Promotions_Selected[1].ToString().Trim();
                TextBox7.Text = DR_Ref_Promotions_Selected[5].ToString().Trim();
                TextBox13.Text = DR_Ref_Promotions_Selected[3].ToString();
                TextBox14.Text = DR_Ref_Promotions_Selected[4].ToString();
                
                
            }
        }

        DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
        GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
        GVBangalow.DataBind();



        DataTable PL_Ref_Promotions_Wise_Guest_Selected = SERPromo.SERV_Ref_Promotions_Wise_Guest_Selected(DECPromo);
        if (PL_Ref_Promotions_Wise_Guest_Selected.Rows.Count != 0)
        {

            foreach (DataRow DR_Ref_Promotions_Wise_Guest_Selected in PL_Ref_Promotions_Wise_Guest_Selected.Rows)
            {
                int rowIndexCit = 0;
                foreach (GridViewRow gr in GVBangalow.Rows)
                {
                    CheckBox cbGen2 = (CheckBox)gr.Cells[0].FindControl("ChkGuestUp");

                    if (GVBangalow.Rows[rowIndexCit].Cells[0].Text.ToString().Trim() == DR_Ref_Promotions_Wise_Guest_Selected[1].ToString().Trim())
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


    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

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

            double amounts;
            double pricewith;
            double pres;

            List<DECVariables.ClsPromotions> List3 = new List<DECVariables.ClsPromotions>();
            DECVariables.ClsPromotions row1;
            foreach (GridViewRow gr in GVBangalow.Rows)
            {
                CheckBox cb = (CheckBox)gr.Cells[0].FindControl("ChkGuestUp");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsPromotions();

                    row1.Guest_Id = GVBangalow.Rows[rowIndCid].Cells[0].Text.ToString();
                    row1.Promotion_Id = Label1.Text.ToString();
                    row1.price_With_breakfast = Convert.ToDouble(GVBangalow.Rows[rowIndCid].Cells[2].Text.ToString());
                    row1.price_without_breakfast = Convert.ToDouble(GVBangalow.Rows[rowIndCid].Cells[3].Text.ToString());

                    if (TextBox12.Text != "")
                    {
                        try
                        {
                            double am = double.Parse(TextBox12.Text);
                        }
                        catch
                        {
                            Label3.Text = "Please Enter Numeric Values";
                            return;
                        }

                        amounts = Convert.ToDouble(TextBox12.Text);
                        pricewith = row1.price_With_breakfast;

                        DECPromo.Precentage_with_Breakfast = amounts / row1.price_With_breakfast * 100;
                        DECPromo.Amount_With_Breakfast = Convert.ToDouble(TextBox12.Text);
                    }

                    if (TextBox11.Text != "")
                    {
                        try
                        {
                            double am = double.Parse(TextBox11.Text);
                        }
                        catch
                        {
                            Label3.Text = "Please Enter Numeric Values";
                            return;
                        }

                        pres = Convert.ToDouble(TextBox11.Text);
                        pricewith = row1.price_With_breakfast;

                        DECPromo.Amount_With_Breakfast = pres * row1.price_With_breakfast / 100;
                        DECPromo.Precentage_with_Breakfast = Convert.ToDouble(TextBox11.Text);
                    }

                    if (TextBox7.Text != "")
                    {
                        try
                        {
                            double am = double.Parse(TextBox7.Text);
                        }
                        catch
                        {
                            Label3.Text = "Please Enter Numeric Values";
                            return;
                        }

                        amounts = Convert.ToDouble(TextBox7.Text);
                        pricewith = row1.price_With_breakfast;

                        DECPromo.Precentage = amounts / row1.price_without_breakfast * 100;
                        DECPromo.Amount_In_Rs = Convert.ToDouble(TextBox7.Text);
                    }

                    if (TextBox6.Text != "")
                    {
                        try
                        {
                            double am = double.Parse(TextBox6.Text);
                        }
                        catch
                        {
                            Label3.Text = "Please Enter Numeric Values";
                            return;
                        }

                        pres = Convert.ToDouble(TextBox6.Text);
                        pricewith = row1.price_With_breakfast;

                        DECPromo.Amount_In_Rs = pres * row1.price_without_breakfast / 100;
                        DECPromo.Precentage = Convert.ToDouble(TextBox6.Text.ToString());
                    }
                    List3.Add(row1);
                }
                rowIndCid++;
            }


            DECPromo.Heading = TextBox1.Text;
            DECPromo.Description = TextBox2.Text;
            DECPromo.From_Date = Calendar1.SelectedDate;
            DECPromo.To_Date = Calendar2.SelectedDate;
            DECPromo.Promotion_Id = Label1.Text.ToString();
            
             
           
                DECPromo.From_Date = Convert.ToDateTime(TextBox13.Text);
            
                DECPromo.To_Date = Convert.ToDateTime(TextBox14.Text);
            
            string res = "";
            res = SERPromo.SERV_Ref_Promotions_Update_Main(DECPromo, List3);
            if (res.Trim() == "1")
            {
                

                if (nFileLen02 > 0)
                {
                    try
                    {
                        if (System.IO.File.Exists(Server.MapPath("Images\\Promo_Image\\" + DECPromo.Promotion_Id.Trim() + "\\1.JPG")))
                        {
                            System.IO.File.Delete(Server.MapPath("Images\\Promo_Image\\" + DECPromo.Promotion_Id.Trim() + "\\1.JPG"));
                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\Promo_Image\\" + DECPromo.Promotion_Id.Trim() + "\\1.JPG"), ref myData02);
                        }

                        else
                        {


                            byte[] myData02 = new byte[nFileLen02];
                            myFile02.InputStream.Read(myData02, 0, nFileLen02);
                            strFilename02 = Path.GetFileName(myFile02.FileName);

                            WriteToFile(Server.MapPath("Images\\Promo_Image\\" + DECPromo.Promotion_Id.Trim() + "\\1.JPG"), ref myData02);
                        }



                        DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                        GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                        GVBangalow.DataBind();
                    }
                    catch
                    {
                        Label3.Text = "There was an error updating this image";
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
            DECPromo.Promotion_Id = Label1.Text.Trim();

            string res = "";
            res = SERPromo.SERV_Ref_Promotions_Delete(DECPromo);
            if (res.Trim() == "1")
            {
                try
                {

                    if (System.IO.File.Exists(Server.MapPath("Images\\Promo_Image\\" + Label1.Text.Trim() + "\\1.JPG")))
                    {
                        System.IO.File.Delete(Server.MapPath("Images\\Promo_Image\\" + Label1.Text.Trim() + "\\1.JPG"));
                        System.IO.Directory.Delete(Server.MapPath("Images\\Promo_Image\\" + Label1.Text.Trim() + "\\"), true);
                    }
                    DataTable DT_Ref_Promotions_Select_All = SERPromo.SERV_Ref_Promotions_Select_All();
                    GVPromo.DataSource = DT_Ref_Promotions_Select_All;
                    GVPromo.DataBind();

                    DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                    GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                    GVBangalow.DataBind();


                    GVPromo.DataBind();
                }
                catch
                {
                    Label3.Text = "There was an error deleting";
                }


            }
            else
            {
                
            }

        }
        catch
        {
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
            Label2.Text = "There was an Error";
        }
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
                    num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[6]) + 1;

                    Cid = "PI" + num.ToString();
                }
            }


           DECPromo.Heading = TextBox1.Text;
           DECPromo.Description = TextBox2.Text;

           DECPromo.From_Date= Calendar1.SelectedDate;
           DECPromo.To_Date = Calendar2.SelectedDate;

            int rowIndex = 0;
            double amounts;
            double pricewith;
            double pres;
            

            List<DECVariables.ClsPromotions> List2 = new List<DECVariables.ClsPromotions>();
            DECVariables.ClsPromotions row1;
            foreach (GridViewRow gr in GVGuestAdd.Rows)
            {
                CheckBox cb = (CheckBox)gr.Cells[0].FindControl("ChkGuest");
                if (cb.Checked == true)
                {
                    row1 = new DECVariables.ClsPromotions();

                    row1.Guest_Id= GVGuestAdd.Rows[rowIndex].Cells[0].Text.ToString();
                    row1.Promotion_Id = Cid;
                    row1.price_With_breakfast =Convert.ToDouble(GVGuestAdd.Rows[rowIndex].Cells[2].Text.ToString());
                    row1.price_without_breakfast = Convert.ToDouble(GVGuestAdd.Rows[rowIndex].Cells[3].Text.ToString());
                    
                    if(TextBox8.Text!="")
                    {
                        try
                        {
                            double am = double.Parse(TextBox8.Text);
                        }
                        catch
                        {
                            Label2.Text = "Please Enter Numeric Values";
                            return;
                        }

                        amounts=Convert.ToDouble(TextBox8.Text);
                        pricewith=row1.price_With_breakfast;

                        DECPromo.Precentage_with_Breakfast = amounts / row1.price_With_breakfast * 100;
                        DECPromo.Amount_With_Breakfast = Convert.ToDouble(TextBox8.Text);
                    }

                    if (TextBox3.Text != "")
                    {
                        try
                        {
                            double am = double.Parse(TextBox3.Text);
                        }
                        catch
                        {
                            Label2.Text = "Please Enter Numeric Values";
                            return;


                        }
                        pres = Convert.ToDouble(TextBox3.Text);
                        pricewith = row1.price_With_breakfast;

                        DECPromo.Amount_With_Breakfast = pres * row1.price_With_breakfast / 100;
                        DECPromo.Precentage_with_Breakfast = Convert.ToDouble(TextBox3.Text);
                    }

                    if (TextBox10.Text != "")
                    {
                        try
                        {
                            double am = double.Parse(TextBox10.Text);
                        }
                        catch
                        {
                            Label2.Text = "Please Enter Numeric Values";
                            return;
                        }

                        amounts = Convert.ToDouble(TextBox10.Text);
                        pricewith = row1.price_With_breakfast;

                        DECPromo.Precentage = amounts / row1.price_without_breakfast * 100;
                        DECPromo.Amount_In_Rs = Convert.ToDouble(TextBox10.Text);
                    }

                    if (TextBox9.Text != "")
                    {
                        try
                        {
                            double am = double.Parse(TextBox9.Text);
                        }
                        catch
                        {
                            Label2.Text = "Please Enter Numeric Values";
                            return;
                        }

                        pres = Convert.ToDouble(TextBox9.Text);
                        pricewith = row1.price_With_breakfast;

                        DECPromo.Amount_In_Rs = pres * row1.price_without_breakfast / 100;
                        DECPromo.Precentage = Convert.ToDouble(TextBox9.Text.ToString());
                    }
                    List2.Add(row1);
                }
                rowIndex++;
            }

            string res = "";
            res = SERPromo.SERV_Ref_Promotions_Insert_Main(DECPromo, List2);
            if (res.Trim() == "1")
            {
                try
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath("Images\\Promo_Image\\" + Cid.Trim()));
                    if (nFileLen01 > 0)
                    {

                        if (PL_Ref_Settings_SelectAll.Rows.Count > 0)
                        {
                            foreach (DataRow Dr_Ref_Settings_SelectAll in PL_Ref_Settings_SelectAll.Rows)
                            {
                                num = Convert.ToInt32(Dr_Ref_Settings_SelectAll[6]) + 1;

                                Cid = "PI" + num.ToString();

                            }
                        }

                        byte[] myData01 = new byte[nFileLen01];
                        myFile01.InputStream.Read(myData01, 0, nFileLen01);
                        strFilename01 = Path.GetFileName(myFile01.FileName);
                        WriteToFile(Server.MapPath("Images\\Promo_Image\\" + Cid.Trim() + "\\1.JPG"), ref myData01);


                    }


                    Response.Write("OK !");
                    DataTable Dt_Ref_Promotions_Select_All = SERPromo.SERV_Ref_Promotions_Select_All();
                    GVPromo.DataSource = Dt_Ref_Promotions_Select_All;
                    GVPromo.DataBind();


                    DataTable DT_Ref_Guest_SelectAll = SERGuest.SERV_Ref_Guest_SelectAll();
                    GVBangalow.DataSource = DT_Ref_Guest_SelectAll;
                    GVBangalow.DataBind();


                    GVGuestAdd.DataSource = DT_Ref_Guest_SelectAll;
                    GVGuestAdd.DataBind();

                }
                catch
                {
                    Label2.Text = "There was an error saving the image";
                    return;
                }
            }
            else
            {
                
            }
        }
        catch
        {

        }
    }
    protected void Calendar3_SelectionChanged(object sender, EventArgs e)
    {
        TextBox13.Text = Calendar3.SelectedDate.ToString();
    }
    protected void Calendar4_SelectionChanged(object sender, EventArgs e)
    {
        TextBox14.Text = Calendar4.SelectedDate.ToString();
    }
}