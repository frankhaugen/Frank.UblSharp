namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("UnsignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("UnsignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class UnsignedPropertiesType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnsignedSignatureProperties", Order=0)]
    public UnsignedSignaturePropertiesType @__UnsignedSignatureProperties;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnsignedDataObjectProperties", Order=1)]
    public UnsignedDataObjectPropertiesType @__UnsignedDataObjectProperties;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public UnsignedSignaturePropertiesType UnsignedSignatureProperties
    {
        get
        {
            if (__UnsignedSignatureProperties == null) { __UnsignedSignatureProperties = new UnsignedSignaturePropertiesType(); }
            return __UnsignedSignatureProperties;
        }
        set
        {
            __UnsignedSignatureProperties = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties
    {
        get
        {
            if (__UnsignedDataObjectProperties == null) { __UnsignedDataObjectProperties = new UnsignedDataObjectPropertiesType(); }
            return __UnsignedDataObjectProperties;
        }
        set
        {
            __UnsignedDataObjectProperties = value;
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