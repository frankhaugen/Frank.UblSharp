namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OCSPIdentifierType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class OCSPIdentifierType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResponderID", Order=0)]
    public ResponderIDType @__ResponderID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProducedAt", Order=1)]
    public System.DateTime @__ProducedAt;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
    public string @__URI;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ResponderIDType ResponderID
    {
        get
        {
            if (__ResponderID == null) { __ResponderID = new ResponderIDType(); }
            return __ResponderID;
        }
        set
        {
            __ResponderID = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.DateTime ProducedAt
    {
        get
        {
            return __ProducedAt;
        }
        set
        {
            __ProducedAt = value;
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