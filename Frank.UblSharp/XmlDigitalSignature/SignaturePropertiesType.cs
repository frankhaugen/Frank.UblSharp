namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("SignatureProperties", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class SignaturePropertiesType
{
        
    private System.Collections.Generic.List<SignaturePropertyType> _signatureProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignatureProperty")]
    public SignaturePropertyType[] @__SignatureProperty
    {
        get
        {
            return _signatureProperty?.ToArray();
        }
        set
        {
            _signatureProperty = value == null ? null : new System.Collections.Generic.List<SignaturePropertyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<SignaturePropertyType> SignatureProperty
    {
        get { return _signatureProperty ?? (_signatureProperty = new System.Collections.Generic.List<SignaturePropertyType>()); }
        set { _signatureProperty = value; }
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