namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CRLValuesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class CRLValuesType
{
        
    private System.Collections.Generic.List<EncapsulatedPKIDataType> _encapsulatedCRLValue;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EncapsulatedCRLValue", Order=0)]
    public EncapsulatedPKIDataType[] @__EncapsulatedCRLValue
    {
        get
        {
            return _encapsulatedCRLValue?.ToArray();
        }
        set
        {
            _encapsulatedCRLValue = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EncapsulatedPKIDataType> EncapsulatedCRLValue
    {
        get { return _encapsulatedCRLValue ?? (_encapsulatedCRLValue = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
        set { _encapsulatedCRLValue = value; }
    }

}