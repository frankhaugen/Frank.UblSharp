namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EncapsulatedPKIData", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("EncapsulatedPKIData", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class EncapsulatedPKIDataType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Encoding", DataType="anyURI")]
    public string @__Encoding;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
    public byte[] @__Value;
        
    public static implicit operator EncapsulatedPKIDataType(byte[] value)
    {
        return new EncapsulatedPKIDataType { Value = value };
    }

    public static implicit operator byte[](EncapsulatedPKIDataType value)
    {
        return value.Value;
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
    public byte[] Value
    {
        get
        {
            return __Value;
        }
        set
        {
            __Value = value;
        }
    }

}