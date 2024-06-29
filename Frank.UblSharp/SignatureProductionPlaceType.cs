/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignatureProductionPlace", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
public partial class SignatureProductionPlaceType
{
    /// <remarks/>
    public string City { get; set; }

    /// <remarks/>
    public string StateOrProvince { get; set; }

    /// <remarks/>
    public string PostalCode { get; set; }

    /// <remarks/>
    public string CountryName { get; set; }
}