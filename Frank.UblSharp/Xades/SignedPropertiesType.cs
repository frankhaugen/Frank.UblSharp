namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignedPropertiesType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignedSignatureProperties", Order=0)]
    public SignedSignaturePropertiesType @__SignedSignatureProperties;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignedDataObjectProperties", Order=1)]
    public SignedDataObjectPropertiesType @__SignedDataObjectProperties;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SignedSignaturePropertiesType SignedSignatureProperties
    {
        get
        {
            if (__SignedSignatureProperties == null) { __SignedSignatureProperties = new SignedSignaturePropertiesType(); }
            return __SignedSignatureProperties;
        }
        set
        {
            __SignedSignatureProperties = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SignedDataObjectPropertiesType SignedDataObjectProperties
    {
        get
        {
            if (__SignedDataObjectProperties == null) { __SignedDataObjectProperties = new SignedDataObjectPropertiesType(); }
            return __SignedDataObjectProperties;
        }
        set
        {
            __SignedDataObjectProperties = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Id
    {
        get
        {
            return __Id;
        }
        set
        {
            __Id = value;
        }
    }

}