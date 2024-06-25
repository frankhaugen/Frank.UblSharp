using Frank.UblSharp.XmlDigitalSignature;

namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DigestAlgAndValueType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class DigestAlgAndValueType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", Order=0)]
    public DigestMethodType @__DigestMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary", Order=1)]
    public byte[] @__DigestValue;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DigestMethodType DigestMethod
    {
        get
        {
            if (__DigestMethod == null) { __DigestMethod = new DigestMethodType(); }
            return __DigestMethod;
        }
        set
        {
            __DigestMethod = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[] DigestValue
    {
        get
        {
            return __DigestValue;
        }
        set
        {
            __DigestValue = value;
        }
    }

}