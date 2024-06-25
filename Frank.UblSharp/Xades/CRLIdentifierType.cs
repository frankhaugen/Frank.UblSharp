namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CRLIdentifierType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class CRLIdentifierType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Issuer", Order=0)]
    public string @__Issuer;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Order=1)]
    public System.DateTime @__IssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Number", DataType="integer", Order=2)]
    public string @__Number;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
    public string @__URI;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Issuer
    {
        get
        {
            return __Issuer;
        }
        set
        {
            __Issuer = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.DateTime IssueTime
    {
        get
        {
            return __IssueTime;
        }
        set
        {
            __IssueTime = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Number
    {
        get
        {
            return __Number;
        }
        set
        {
            __Number = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string URI
    {
        get
        {
            return __URI;
        }
        set
        {
            __URI = value;
        }
    }

}