namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OCSPRefType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class OCSPRefType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OCSPIdentifier", Order=0)]
    public OCSPIdentifierType @__OCSPIdentifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DigestAlgAndValue", Order=1)]
    public DigestAlgAndValueType @__DigestAlgAndValue;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public OCSPIdentifierType OCSPIdentifier
    {
        get
        {
            if (__OCSPIdentifier == null) { __OCSPIdentifier = new OCSPIdentifierType(); }
            return __OCSPIdentifier;
        }
        set
        {
            __OCSPIdentifier = value;
        }
    }

        
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

}