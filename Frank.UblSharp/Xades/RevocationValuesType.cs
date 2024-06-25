namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RevocationValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("RevocationValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class RevocationValuesType
{
        
    private System.Collections.Generic.List<EncapsulatedPKIDataType> _cRLValues;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("CRLValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable=false)]
    public EncapsulatedPKIDataType[] @__CRLValues
    {
        get
        {
            return _cRLValues?.ToArray();
        }
        set
        {
            _cRLValues = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
        }
    }
        
    private System.Collections.Generic.List<EncapsulatedPKIDataType> _oCSPValues;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("OCSPValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable=false)]
    public EncapsulatedPKIDataType[] @__OCSPValues
    {
        get
        {
            return _oCSPValues?.ToArray();
        }
        set
        {
            _oCSPValues = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
        }
    }
        
    private System.Collections.Generic.List<AnyType> _otherValues;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("OtherValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable=false)]
    public AnyType[] @__OtherValues
    {
        get
        {
            return _otherValues?.ToArray();
        }
        set
        {
            _otherValues = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EncapsulatedPKIDataType> CRLValues
    {
        get { return _cRLValues ?? (_cRLValues = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
        set { _cRLValues = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EncapsulatedPKIDataType> OCSPValues
    {
        get { return _oCSPValues ?? (_oCSPValues = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
        set { _oCSPValues = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> OtherValues
    {
        get { return _otherValues ?? (_otherValues = new System.Collections.Generic.List<AnyType>()); }
        set { _otherValues = value; }
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