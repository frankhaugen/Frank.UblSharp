namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("RSAKeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class RSAKeyValueType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Modulus", DataType="base64Binary")]
    public byte[] @__Modulus;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Exponent", DataType="base64Binary")]
    public byte[] @__Exponent;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] Modulus
    {
        get
        {
            return __Modulus;
        }
        set
        {
            __Modulus = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] Exponent
    {
        get
        {
            return __Exponent;
        }
        set
        {
            __Exponent = value;
        }
    }

}