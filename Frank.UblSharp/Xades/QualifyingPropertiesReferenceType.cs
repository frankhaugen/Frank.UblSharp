namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("QualifyingPropertiesReference", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("QualifyingPropertiesReference", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class QualifyingPropertiesReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
    public string @__URI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
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