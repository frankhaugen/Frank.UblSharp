namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("Transform", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class TransformType
{
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("XPath", typeof(string))]
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
    [System.Xml.Serialization.XmlAttributeAttribute("Algorithm", DataType="anyURI")]
    public string @__Algorithm;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.Object> Items
    {
        get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
        set { _items = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.String> Text
    {
        get { return _text ?? (_text = new System.Collections.Generic.List<System.String>()); }
        set { _text = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Algorithm
    {
        get
        {
            return __Algorithm;
        }
        set
        {
            __Algorithm = value;
        }
    }

}