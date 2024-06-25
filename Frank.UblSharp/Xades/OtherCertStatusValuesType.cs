namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OtherCertStatusValuesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class OtherCertStatusValuesType
{
        
    private System.Collections.Generic.List<AnyType> _otherValue;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OtherValue", Order=0)]
    public AnyType[] @__OtherValue
    {
        get
        {
            return _otherValue?.ToArray();
        }
        set
        {
            _otherValue = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> OtherValue
    {
        get { return _otherValue ?? (_otherValue = new System.Collections.Generic.List<AnyType>()); }
        set { _otherValue = value; }
    }

}