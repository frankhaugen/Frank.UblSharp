namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignaturePolicyIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignaturePolicyIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignaturePolicyIdentifierType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyId", typeof(SignaturePolicyIdType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyImplied", typeof(object), Order=0)]
    public object @__Item;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public object Item
    {
        get
        {
            return __Item;
        }
        set
        {
            __Item = value;
        }
    }

}