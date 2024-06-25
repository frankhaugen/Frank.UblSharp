namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OCSPValuesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class OCSPValuesType
{
        
    private System.Collections.Generic.List<EncapsulatedPKIDataType> _encapsulatedOCSPValue;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EncapsulatedOCSPValue", Order=0)]
    public EncapsulatedPKIDataType[] @__EncapsulatedOCSPValue
    {
        get
        {
            return _encapsulatedOCSPValue?.ToArray();
        }
        set
        {
            _encapsulatedOCSPValue = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EncapsulatedPKIDataType> EncapsulatedOCSPValue
    {
        get { return _encapsulatedOCSPValue ?? (_encapsulatedOCSPValue = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
        set { _encapsulatedOCSPValue = value; }
    }

}