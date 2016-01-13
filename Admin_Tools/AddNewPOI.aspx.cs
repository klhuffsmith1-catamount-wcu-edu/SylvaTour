﻿using System;
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

/// <summary>
/// name:         AddNewPOI.aspx
/// description:  This page contains all the front end code for adding a new POI    
/// </summary>

public partial class AddNewPOI : System.Web.UI.Page
{
    HttpContext currentContext = HttpContext.Current;
    /// <summary>
    /// name:         FillGridView
    /// description:  method used after the "Add" POI button is clicked, fills textboxes with the new POI's information
    /// </summary>
    private void AddNewRecord()
    {
        currentContext.Trace.Warn("inside AddNewRecord Local Method");
        DA_POI inventoryObject = new DA_POI();

        //Declare Variables
        decimal latitude;
        decimal longitude;
        string title;
        string description;
        string Address1;
        string Address2;
        string City;
        string State;
        int ZipCode;
        string ContactName;
        string Phone;
        string URL;
        string categoryCode;
        bool isActive = false;
        bool petFriendly = false;

        //Get values for variables
        //If Statements for Missing Long/Lat Values
        if (txtLatitude.Text == "")
        {
            latitude = 0;
        }
        else
        {
            latitude = Convert.ToDecimal(txtLatitude.Text);
        }
        if (txtLongitude.Text == "")
        {
            longitude = 0;
        }
        else
        {
            longitude = Convert.ToDecimal(txtLongitude.Text);
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

        title = txtTitle.Text;
        description = txtDescription.Text;
        Address1 = txtAddress1.Text;
        City = txtCity.Text;
        State = txtState.Text;
        ZipCode = Convert.ToInt32(txtZipCode.Text);
        ContactName = txtContactName.Text;
        Phone = txtPhone.Text;
        categoryCode = ddlCategory.SelectedItem.Value;

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

        inventoryObject.AddPOI(latitude, longitude,
                                title, description, Address1, Address2, City, State,
                        ZipCode, ContactName, Phone, URL,
                        categoryCode, isActive, petFriendly);
    }

    /// <summary>
    /// name:         butAdd_Click
    /// description:  button click method that inities the FillGridView method   
    /// </summary>
    protected void butAdd_Click(object sender, EventArgs e)
    {
        //First add the record with only text-type stuff, no image filenames
        this.AddNewRecord();

        //Get POI_ID for newly added record
        DA_POI poiDAObject = new DA_POI();
        int newPOI_ID = poiDAObject.GetNewlyAddedPOI_ID();
        Trace.Warn("newPOI_ID = " + newPOI_ID);

        //Display newly added record info
        //Note:  will have a link to the page that allows images to be added.
        hypAddImagePage.NavigateUrl = "POI_Images.aspx?qrypoiID=" + newPOI_ID;

    }

    /// <summary>
    /// This method FillDropDown() will fill the dropdown list with the available categories.  When a user is 
    /// adding a New POI, they will now have to choose a category for that POI.
    /// By. Jason Eades
    /// </summary>
    private void FillDropDown()
    {
        //Bind the drop down list to the categories table in the database
        DA_POI_Category poiDAObject = new DA_POI_Category();
        ddlCategory.DataSource = poiDAObject.GetAllCategories();
        ddlCategory.DataTextField = "Category_Name";
        Trace.Warn("DataTextField = " + ddlCategory.DataTextField);
        ddlCategory.DataValueField = "Category_Code";
        Trace.Warn("DataValueField = " + ddlCategory.DataValueField);
        ddlCategory.DataBind();

        ddlCategory.Items.Insert(0, new ListItem("----"));
        ddlCategory.SelectedIndex = 0;

    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FillDropDown();
            pnlInput.Visible = true;
            pnlDisplay.Visible = false;
            ddlCategory.Focus();
        }
        else
        {
            pnlDisplay.Visible = true;
            pnlInput.Visible = false;
            lbUpdate.Visible = false;
        }
    }
}


