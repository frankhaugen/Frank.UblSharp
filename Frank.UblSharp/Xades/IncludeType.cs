namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Include", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("Include", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class IncludeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
    public string @__URI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("referencedData")]
    public bool @__referencedData;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool @__referencedDataSpecified;
        
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

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool referencedData
    {
        get
        {
            return __referencedData;
        }
        set
        {
            __referencedData = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool referencedDataSpecified
    {
        get
        {
            return __referencedDataSpecified;
        }
        set
        {
            __referencedDataSpecified = value;
        }
    }

}