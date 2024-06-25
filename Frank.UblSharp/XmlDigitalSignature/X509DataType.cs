namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("X509Data", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class X509DataType
{
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(byte[]), DataType="base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(byte[]), DataType="base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerialType))]
    [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(byte[]), DataType="base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
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
        
    private System.Collections.Generic.List<X509DataTypeItem> _itemsElementName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public X509DataTypeItem[] @__ItemsElementName
    {
        get
        {
            return _itemsElementName?.ToArray();
        }
        set
        {
            _itemsElementName = value == null ? null : new System.Collections.Generic.List<X509DataTypeItem>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.Object> Items
    {
        get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
        set { _items = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<X509DataTypeItem> ItemsElementName
    {
        get { return _itemsElementName ?? (_itemsElementName = new System.Collections.Generic.List<X509DataTypeItem>()); }
        set { _itemsElementName = value; }
    }

}