namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("KeyInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class KeyInfoType
{
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValueType))]
    [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPDataType))]
    [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethodType))]
    [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIDataType))]
    [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509DataType))]
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
        
    private System.Collections.Generic.List<KeyInfoTypeItem> _itemsElementName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public KeyInfoTypeItem[] @__ItemsElementName
    {
        get
        {
            return _itemsElementName?.ToArray();
        }
        set
        {
            _itemsElementName = value == null ? null : new System.Collections.Generic.List<KeyInfoTypeItem>(value);
        }
    }
        
    private System.Collections.Generic.List<System.String> _text;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    public string[] @__Text
    {
        get
        {
            return _text?.ToArray();
        }
        set
        {
            _text = value == null ? null : new System.Collections.Generic.List<System.String>(value);
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
    public System.Collections.Generic.List<KeyInfoTypeItem> ItemsElementName
    {
        get { return _itemsElementName ?? (_itemsElementName = new System.Collections.Generic.List<KeyInfoTypeItem>()); }
        set { _itemsElementName = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.String> Text
    {
        get { return _text ?? (_text = new System.Collections.Generic.List<System.String>()); }
        set { _text = value; }
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