namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CRLRefType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class CRLRefType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DigestAlgAndValue", Order=0)]
    public DigestAlgAndValueType @__DigestAlgAndValue;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CRLIdentifier", Order=1)]
    public CRLIdentifierType @__CRLIdentifier;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DigestAlgAndValueType DigestAlgAndValue
    {
        get
        {
            if (__DigestAlgAndValue == null) { __DigestAlgAndValue = new DigestAlgAndValueType(); }
            return __DigestAlgAndValue;
        }
        set
        {
            __DigestAlgAndValue = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CRLIdentifierType CRLIdentifier
    {
        get
        {
            if (__CRLIdentifier == null) { __CRLIdentifier = new CRLIdentifierType(); }
            return __CRLIdentifier;
        }
        set
        {
            __CRLIdentifier = value;
        }
    }

}