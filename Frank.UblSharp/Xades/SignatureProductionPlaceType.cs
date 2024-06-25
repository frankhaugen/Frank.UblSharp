namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignatureProductionPlace", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignatureProductionPlace", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignatureProductionPlaceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("City", Order=0)]
    public string @__City;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StateOrProvince", Order=1)]
    public string @__StateOrProvince;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PostalCode", Order=2)]
    public string @__PostalCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CountryName", Order=3)]
    public string @__CountryName;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string City
    {
        get
        {
            return __City;
        }
        set
        {
            __City = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string StateOrProvince
    {
        get
        {
            return __StateOrProvince;
        }
        set
        {
            __StateOrProvince = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string PostalCode
    {
        get
        {
            return __PostalCode;
        }
        set
        {
            __PostalCode = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string CountryName
    {
        get
        {
            return __CountryName;
        }
        set
        {
            __CountryName = value;
        }
    }

}