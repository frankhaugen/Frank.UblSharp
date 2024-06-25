namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CertificateValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CertificateValues", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CertificateValuesType
{
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(AnyType), Order=0)]
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
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.Object> Items
    {
        get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
        set { _items = value; }
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