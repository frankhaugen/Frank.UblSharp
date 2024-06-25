namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("QualifyingProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class QualifyingPropertiesType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignedProperties", Order=0)]
    public SignedPropertiesType @__SignedProperties;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnsignedProperties", Order=1)]
    public UnsignedPropertiesType @__UnsignedProperties;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Target", DataType="anyURI")]
    public string @__Target;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SignedPropertiesType SignedProperties
    {
        get
        {
            if (__SignedProperties == null) { __SignedProperties = new SignedPropertiesType(); }
            return __SignedProperties;
        }
        set
        {
            __SignedProperties = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public UnsignedPropertiesType UnsignedProperties
    {
        get
        {
            if (__UnsignedProperties == null) { __UnsignedProperties = new UnsignedPropertiesType(); }
            return __UnsignedProperties;
        }
        set
        {
            __UnsignedProperties = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Target
    {
        get
        {
            return __Target;
        }
        set
        {
            __Target = value;
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