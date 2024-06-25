namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("UnsignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("UnsignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class UnsignedSignaturePropertiesType
{
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ArchiveTimeStamp", typeof(XAdESTimeStampType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("AttrAuthoritiesCertValues", typeof(CertificateValuesType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("AttributeCertificateRefs", typeof(CompleteCertificateRefsType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("AttributeRevocationRefs", typeof(CompleteRevocationRefsType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("AttributeRevocationValues", typeof(RevocationValuesType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("CertificateValues", typeof(CertificateValuesType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("CompleteCertificateRefs", typeof(CompleteCertificateRefsType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("CompleteRevocationRefs", typeof(CompleteRevocationRefsType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("CounterSignature", typeof(CounterSignatureType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("RefsOnlyTimeStamp", typeof(XAdESTimeStampType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("RevocationValues", typeof(RevocationValuesType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("SigAndRefsTimeStamp", typeof(XAdESTimeStampType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("SignatureTimeStamp", typeof(XAdESTimeStampType), Order=0)]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("__ItemsElementName")]
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
        
    private System.Collections.Generic.List<UnsignedSignaturePropertiesTypeItem> _itemsElementName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=1)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public UnsignedSignaturePropertiesTypeItem[] @__ItemsElementName
    {
        get
        {
            return _itemsElementName?.ToArray();
        }
        set
        {
            _itemsElementName = value == null ? null : new System.Collections.Generic.List<UnsignedSignaturePropertiesTypeItem>(value);
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
    public System.Collections.Generic.List<UnsignedSignaturePropertiesTypeItem> ItemsElementName
    {
        get { return _itemsElementName ?? (_itemsElementName = new System.Collections.Generic.List<UnsignedSignaturePropertiesTypeItem>()); }
        set { _itemsElementName = value; }
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