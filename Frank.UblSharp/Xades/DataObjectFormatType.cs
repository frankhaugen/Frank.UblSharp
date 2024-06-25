namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DataObjectFormat", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("DataObjectFormat", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class DataObjectFormatType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Order=0)]
    public string @__Description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ObjectIdentifier", Order=1)]
    public ObjectIdentifierType @__ObjectIdentifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MimeType", Order=2)]
    public string @__MimeType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Encoding", DataType="anyURI", Order=3)]
    public string @__Encoding;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("ObjectReference", DataType="anyURI")]
    public string @__ObjectReference;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Description
    {
        get
        {
            return __Description;
        }
        set
        {
            __Description = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ObjectIdentifierType ObjectIdentifier
    {
        get
        {
            if (__ObjectIdentifier == null) { __ObjectIdentifier = new ObjectIdentifierType(); }
            return __ObjectIdentifier;
        }
        set
        {
            __ObjectIdentifier = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string MimeType
    {
        get
        {
            return __MimeType;
        }
        set
        {
            __MimeType = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Encoding
    {
        get
        {
            return __Encoding;
        }
        set
        {
            __Encoding = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string ObjectReference
    {
        get
        {
            return __ObjectReference;
        }
        set
        {
            __ObjectReference = value;
        }
    }

}