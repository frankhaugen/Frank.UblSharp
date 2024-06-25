using Frank.UblSharp.XmlDigitalSignature;

namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CounterSignature", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CounterSignature", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CounterSignatureType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", Order=0)]
    public XmlSignatureType @__Signature;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public XmlSignatureType Signature
    {
        get
        {
            if (__Signature == null) { __Signature = new XmlSignatureType(); }
            return __Signature;
        }
        set
        {
            __Signature = value;
        }
    }

}