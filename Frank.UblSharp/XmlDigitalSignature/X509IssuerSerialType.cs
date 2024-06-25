namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("X509IssuerSerialType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=true)]
public partial class X509IssuerSerialType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("X509IssuerName")]
    public string @__X509IssuerName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("X509SerialNumber", DataType="integer")]
    public string @__X509SerialNumber;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string X509IssuerName
    {
        get
        {
            return __X509IssuerName;
        }
        set
        {
            __X509IssuerName = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string X509SerialNumber
    {
        get
        {
            return __X509SerialNumber;
        }
        set
        {
            __X509SerialNumber = value;
        }
    }

}