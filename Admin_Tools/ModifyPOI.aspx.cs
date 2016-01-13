using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Data.OleDb;

/// <summary>
/// name:         ModifyPOI.aspx
/// description:  This page contains all the code that is used when updating a POI
/// </summary>

public partial class UpdatePOI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        if (!Page.IsPostBack)
        {
            this.FillDropDown();
        }
        else
        {
            this.ChangeRecord();
            this.DisplayRecord();
        }
        this.DisplayRecord();

        ///<summary>
        ///This is the code for displaying images. It is also used to navigate to the POI_Images.aspx
        ///</summary>

        string poiID = Request.QueryString["qrypoiID"];

        DA_POI poiDAObject = new DA_POI();

        DataRow dataRowObject = poiDAObject.GetPOI(poiID);

        string imageFilename1 = Convert.ToString(dataRowObject["POI_Image1"]);
        string imageFilename2 = Convert.ToString(dataRowObject["POI_Image2"]);
        string imageFilename3 = Convert.ToString(dataRowObject["POI_Image3"]);
        string imageFilename4 = Convert.ToString(dataRowObject["POI_Image4"]);
        string imageFilename5 = Convert.ToString(dataRowObject["POI_Image5"]);
        string imageFilename6 = Convert.ToString(dataRowObject["POI_Image6"]);

        //Image 1 Info
        if (imageFilename1 == "")
        {
            imageFilename1 = "no-image.jpg";
        }

        Trace.Warn("imageFilename1 = " + imageFilename1);

        //Display Image 1 info  
        string image1WithPath = "~/Images/" + imageFilename1;
        imgImage1.ImageUrl = image1WithPath;
        imgImage1.ToolTip = imageFilename1;
        imgImage1.AlternateText = "Image file not found!";

        //Image 2 Info
        if (imageFilename2 == "")
        {
            imageFilename2 = "no-image.jpg";

        }
        //Display Image 2 info
        imgImage2.ImageUrl = "~/Images/" + imageFilename2;
        imgImage2.ToolTip = imageFilename2;
        imgImage2.AlternateText = "Image file not found!";
        hypImage2.NavigateUrl = "POI_Images.aspx?qrypoiID=" + poiID;
        hypImage2.Text = "Edit Images";

        //Image 3 Info
        if (imageFilename3 == "")
        {
            imageFilename3 = "no-image.jpg";
        }
        Trace.Warn("imageFilename3 = " + imageFilename3);

        //Display Image 3info
        imgImage3.ImageUrl = "~/Images/" + imageFilename3;
        imgImage3.ToolTip = imageFilename3;
        imgImage3.AlternateText = "Image file not found!";

        //Image 4 Info
        if (imageFilename4 == "")
        {
            imageFilename4 = "no-image.jpg";
        }
       

        //Display Image 4 info
        imgImage4.ImageUrl = "~/Images/" + imageFilename4;
        imgImage4.ToolTip = imageFilename4;
        imgImage4.AlternateText = "Image file not found!";

        //Image 5 Info
        if (imageFilename5 == "")
        {
            imageFilename5 = "no-image.jpg";
        }

        //Display Image 5 info
        imgImage5.ImageUrl = "~/Images/" + imageFilename5;
        imgImage5.ToolTip = imageFilename5;
        imgImage5.AlternateText = "Image file not found!";

        //Image 6 Info
        if (imageFilename6 == "")
        {
            imageFilename6 = "no-image.jpg";
        }
        //Display Image 6 info
        imgImage6.ImageUrl = "~/Images/" + imageFilename6;
        imgImage6.ToolTip = imageFilename6;
        imgImage6.AlternateText = "Image file not found!";

    }

    /// <summary>
    /// name:         ChangeRecord
    /// description:  This method contains the front end code needed to update a POI, it uses the UpdatePOI method in the DA_POI class
    /// </summary>
    private void ChangeRecord()
    {
        //Get ID value
        string locationID = (Request.QueryString["qrypoiID"]);

        //Declare Variables
        string title;
        decimal latitude;
        decimal longitude;
        string description;
        string Address1;
        string Address2;
        string City;
        string State;
        int ZipCode;
        string ContactName;
        string Phone;
        string URL;
        string Category;
        bool isActive;
        bool petFriendly;
       

        //Get values for variables
        //If Statements for Missing Long/Lat Values
        if (txtLongitude.Text == "")
        {
            longitude = 0;
        }
        else
        {
            longitude = Convert.ToDecimal(txtLongitude.Text);
        }
        if (txtLatitude.Text == "")
        {
            latitude = 0;
        }
        else
        {
            latitude = Convert.ToDecimal(txtLatitude.Text);
        }
        //If Statements for Missing Address2/URL Values
        if (txtURL.Text == "")
        {
            URL = "";
        }
        else
        {
            URL = txtURL.Text;
        }
        if (txtAddress2.Text == "")
        {
            Address2 = "";
        }
        else
        {
            Address2 = txtAddress2.Text;
        }

        title = Convert.ToString(txtTitle.Text);
        description = Convert.ToString(txtDescription.Text);
        Address1 = txtAddress1.Text;
        City = txtCity.Text;
        State = txtState.Text;
        ZipCode = Convert.ToInt32(txtZipCode.Text);
        ContactName = txtContactName.Text;
        Phone = txtPhone.Text;
        Category = ddlCategory.SelectedValue;
       

        if (chkIsActive.Checked == true)
        {
            isActive = true;
        }
        else
        {
            isActive = false;
        }

        if (chkPetFriendly.Checked == true)
        {
            petFriendly = true;
        }
        else
        {
            petFriendly = false;
        }

     
        DA_POI inventoryObject = new DA_POI();
        inventoryObject.UpdatePOI(latitude, longitude, title,
                        description, Address1, Address2, City, State,
                        ZipCode, ContactName, Phone, URL,
                        Category, isActive, locationID, petFriendly);

        lblDisplay.Text = "The POI information has been saved.";
        this.DisplayRecord();
    }

    /// <summary>
    /// name:         DisplayRecord
    /// description:  method to display data when modifying a POI
    /// </summary>
    private void DisplayRecord()
    {
        string locationID = (Request.QueryString["qrypoiID"]);


        DA_POI inventoryObject = new DA_POI();
        DataRow dataRowObject = inventoryObject.GetPOI(locationID);

        //Assign the field values of the DataRow object to variables
        string ID = Convert.ToString(dataRowObject["POI_ID"]);
        decimal latitude = Convert.ToDecimal(dataRowObject["POI_Latitude"]);
        decimal longitude = Convert.ToDecimal(dataRowObject["POI_Longitude"]);
        string title = Convert.ToString(dataRowObject["POI_Title"]);
        string description = Convert.ToString(dataRowObject["POI_Description"]);
        string address1 = Convert.ToString(dataRowObject["POI_Address1"]);
        string address2 = Convert.ToString(dataRowObject["POI_Address2"]);
        string city = Convert.ToString(dataRowObject["POI_City"]);
        string state = Convert.ToString(dataRowObject["POI_State"]);
        string ZipCode = Convert.ToString(dataRowObject["POI_ZipCode"]);
        string contactName = Convert.ToString(dataRowObject["POI_ContactName"]);
        string phone = Convert.ToString(dataRowObject["POI_Phone"]);
        string url = Convert.ToString(dataRowObject["POI_URL"]);
        string category = Convert.ToString(dataRowObject["POI_Category"]);
        bool isActive = Convert.ToBoolean(dataRowObject["IsActive"]);
        bool petFriendly = Convert.ToBoolean(dataRowObject["Pet_Friendly"]);
       

        lblID.Text = ID.ToString();
        txtLongitude.Text = longitude.ToString();
        txtLatitude.Text = latitude.ToString();
        txtTitle.Text = title;
        txtDescription.Text = description;
        txtAddress1.Text = address1;
        txtAddress2.Text = address2;
        txtCity.Text = city;
        txtState.Text = state;
        txtZipCode.Text = ZipCode;
        txtContactName.Text = contactName;
        txtPhone.Text = phone;
        txtURL.Text = url;
        ddlCategory.SelectedValue = category.ToString();
        


        if (isActive == true)
        {
            chkIsActive.Checked = true;
        }
        else
        {
            chkIsActive.Checked = false;
        }

        if (petFriendly == true)
        {
            chkPetFriendly.Checked = true;
        }
        else
        {
            chkPetFriendly.Checked = false;
        }

    }

    /// <summary>
    /// name:         butUpdate_Click
    /// description:  button click method that is used to initiate the ChangeRecord method
    /// </summary>
    protected void butUpdate_Click(object sender, EventArgs e)
    {
        this.ChangeRecord();
    }

    /// <summary>
    /// Need to fill the drop down...
    /// Jason Eades
    /// </summary>
    private void FillDropDown()
    {
        DA_POI_Category DAObject = new DA_POI_Category();
        ddlCategory.DataSource = DAObject.GetAllCategories();
        ddlCategory.DataTextField = "Category_Name";
        ddlCategory.DataValueField = "Category_Code";
        ddlCategory.DataBind();
    }
}
