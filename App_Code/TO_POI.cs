using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for TO_POI
/// </summary>
public class TO_POI
{
    private string _POI_ID;
    private decimal _POI_Latitude;
    private decimal _POI_Logitude;
    private string _POI_Title;
    private string _POI_Description;
    private string _POI_Image1;
    private string _POI_Image2;
    private string _POI_Image3;
    private string _POI_Image4;
    private string _POI_Image5;
    private string _POI_Image6;
    private string _POI_Address1;
    private string _POI_Address2;
    private string _POI_City;
    private string _POI_State;
    private int _POI_ZipCode;
    private string _POI_ContactName;
    private string _POI_Phone;
    private string _POI_URL;
    private string _POI_Category;
    private bool _POI_PetFriendly;
    private string _POI_Image1_Desc;
    private string _POI_Image2_Desc;
    private string _POI_Image3_Desc;
    private string _POI_Image4_Desc;
    private string _POI_Image5_Desc;
    private string _POI_Image6_Desc;


	public TO_POI()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public TO_POI(string parPOI_ID, decimal parPOI_Latitude, decimal parPOI_Longitude, 
                  string parPOI_title, string parPOI_Description,
                  string parPOI_Image1, string parPOI_Image2, string parPOI_Image3, string parPOI_Image4,
                  string parPOI_Image5, string parPOI_Image6,
                  string parPOI_Address1, string parPOI_Address2, string parPOI_City,
                  string parPOI_State, int parPOI_ZipCode, string parPOI_ContactName,
                  string parPOI_Phone, string parPOI_URL, string parPOI_Category, bool parPOI_PetFriendly, string parPOI_Image1_Desc,
                  string parPOI_Image2_Desc, string parPOI_Image3_Desc, string parPOI_Image4_Desc,
                  string parPOI_Image5_Desc, string parPOI_Image6_Desc)
    {
        _POI_ID = parPOI_ID;
        _POI_Latitude = parPOI_Latitude;
        _POI_Logitude = parPOI_Longitude;
        _POI_Title = parPOI_title;
        _POI_Description = parPOI_Description;
        _POI_Image1 = parPOI_Image1;
        _POI_Image2 = parPOI_Image2;
        _POI_Image3 = parPOI_Image3;
        _POI_Image4 = parPOI_Image4;
        _POI_Image5 = parPOI_Image5;
        _POI_Image6 = parPOI_Image6;
        _POI_Address1 = parPOI_Address1;
        _POI_Address2 = parPOI_Address2;
        _POI_City = parPOI_City;
        _POI_State = parPOI_State;
        _POI_ZipCode = parPOI_ZipCode;
        _POI_ContactName = parPOI_ContactName;
        _POI_Phone = parPOI_Phone;
        _POI_URL = parPOI_URL;
        _POI_Category = parPOI_Category;
        _POI_PetFriendly = parPOI_PetFriendly;
        _POI_Image1_Desc = parPOI_Image1_Desc;
        _POI_Image2_Desc = parPOI_Image2_Desc;
        _POI_Image3_Desc = parPOI_Image3_Desc;
        _POI_Image4_Desc = parPOI_Image4_Desc;
        _POI_Image5_Desc = parPOI_Image5_Desc;
        _POI_Image6_Desc = parPOI_Image6_Desc;
    }

    public string POI_ID
    {
        get
        {
            return _POI_ID;
        }
        set
        {
            _POI_ID = value;
        }
    }
    public decimal POI_Latitude
    {
        get
        {
            return _POI_Latitude;
        }
        set
        {
            _POI_Latitude = value;
        }
    }
    public decimal POI_Longitude
    {
        get
        {
            return _POI_Logitude;
        }
        set
        {
            _POI_Logitude = value;
        }
    }
    public string POI_Title
    {
        get
        {
            return _POI_Title;
        }
        set
        {
            _POI_Title = value;
        }
    }
    public string POI_Description
    {
        get
        {
            return _POI_Description;
        }
        set
        {
            _POI_Description = value;
        }
    }
    public string POI_Image1
    {
        get
        {
            return _POI_Image1;
        }
        set
        {
            _POI_Image1 = value;
        }
    }
    public string POI_Image2
    {
        get
        {
            return _POI_Image2;
        }
        set
        {
            _POI_Image2 = value;
        }
    }
    public string POI_Image3
    {
        get
        {
            return _POI_Image3;
        }
        set
        {
            _POI_Image3 = value;
        }
    }
    public string POI_Image4
    {
        get
        {
            return _POI_Image4;
        }
        set
        {
            _POI_Image4 = value;
        }
    }
    public string POI_Image5
    {
        get
        {
            return _POI_Image5;
        }
        set
        {
            _POI_Image5 = value;
        }
    }
    public string POI_Image6
    {
        get
        {
            return _POI_Image6;
        }
        set
        {
            _POI_Image6 = value;
        }
    }
    public string POI_Address1
    {
        get
        {
            return _POI_Address1;
        }
        set
        {
            _POI_Address1 = value;
        }
    }
    public string POI_Address2
    {
        get
        {
            return _POI_Address2;
        }
        set
        {
            _POI_Address2 = value;
        }
    }
    public string POI_City
    {
        get
        {
            return _POI_City;
        }
        set
        {
            _POI_City = value;
        }
    }
    public string POI_State
    {
        get
        {
            return _POI_State;
        }
        set
        {
            _POI_State = value;
        }
    }
    public int POI_ZipCode
    {
        get
        {
            return _POI_ZipCode;
        }
        set
        {
            _POI_ZipCode = value;
        }
    }
    public string POI_ContactName
    {
        get
        {
            return _POI_ContactName;
        }
        set
        {
            _POI_ContactName = value;
        }
    }
    public string POI_Phone
    {
        get
        {
            return _POI_Phone;
        }
        set
        {
            _POI_Phone = value;
        }
    }
    public string POI_URL
    {
        get
        {
            return _POI_URL;
        }
        set
        {
            _POI_URL = value;
        }
    }
    public string POI_Category
    {
        get
        {
            return _POI_Category;
        }
        set
        {
            _POI_Category = value;
        }
    }
    public bool POI_PetFriendly
    {
        get
        {
            return _POI_PetFriendly;
        }
        set
        {
            _POI_PetFriendly = value;
        }
    }
    public string POI_Image1_Desc
    {
        get
        {   
            return _POI_Image1_Desc;
        }
        set
        {
            _POI_Image1_Desc = value;
        }
    }
    public string POI_Image2_Desc
    {
        get
        {
            return _POI_Image2_Desc;
        }
        set
        {
            _POI_Image2_Desc = value;
        }
    }
    public string POI_Image3_Desc
    {
        get
        {
            return _POI_Image3_Desc;
        }
        set
        {
            _POI_Image3_Desc = value;
        }
    }
    public string POI_Image4_Desc
    {
        get
        {
            return _POI_Image4_Desc;
        }
        set
        {
            _POI_Image4_Desc = value;
        }
    }
    public string POI_Image5_Desc
    {
        get
        {
            return _POI_Image5_Desc;
        }
        set
        {
            _POI_Image5_Desc = value;
        }
    }
    public string POI_Image6_Desc
    {
        get
        {
            return _POI_Image6_Desc;
        }
        set
        {
            _POI_Image6_Desc = value;
        }
    }
}