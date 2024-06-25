using Frank.UblSharp.XmlDigitalSignature;

namespace Frank.UblSharp.Xades;

[System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdESTimeStampType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("GenericTimeStampType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public abstract partial class GenericTimeStampType
{
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType), Order=0)]
    public object[] @__Items
    {
        get
        {
            return _items?.ToArray();
        }
        set
        {
            _items = value == null ? null : new System.Collections.Generic.List<System.Object>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#", Order=1)]
    public CanonicalizationMethodType @__CanonicalizationMethod;
        
    private System.Collections.Generic.List<System.Object> _items1;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType), Order=2)]
    [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType), Order=2)]
    public object[] @__Items1
    {
        get
        {
            return _items1?.ToArray();
        }
        set
        {
            _items1 = value == null ? null : new System.Collections.Generic.List<System.Object>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.Object> Items
    {
        get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
        set { _items = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.Object> Items1
    {
        get { return _items1 ?? (_items1 = new System.Collections.Generic.List<System.Object>()); }
        set { _items1 = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CanonicalizationMethodType CanonicalizationMethod
    {
        get
        {
            if (__CanonicalizationMethod == null) { __CanonicalizationMethod = new CanonicalizationMethodType(); }
            return __CanonicalizationMethod;
        }
        set
        {
            __CanonicalizationMethod = value;
        }
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