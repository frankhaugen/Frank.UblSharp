namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("PGPData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class PGPDataType
{
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(byte[]), DataType="base64Binary")]
    [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(byte[]), DataType="base64Binary")]
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
        
    private System.Collections.Generic.List<PGPDataTypeItem> _itemsElementName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public PGPDataTypeItem[] @__ItemsElementName
    {
        get
        {
            return _itemsElementName?.ToArray();
        }
        set
        {
            _itemsElementName = value == null ? null : new System.Collections.Generic.List<PGPDataTypeItem>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.Object> Items
    {
        get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
        set { _items = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PGPDataTypeItem> ItemsElementName
    {
        get { return _itemsElementName ?? (_itemsElementName = new System.Collections.Generic.List<PGPDataTypeItem>()); }
        set { _itemsElementName = value; }
    }

}