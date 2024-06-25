namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("KeyValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class KeyValueType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValueType))]
    [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValueType))]
    public object @__Item;
        
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
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.String> Text
    {
        get { return _text ?? (_text = new System.Collections.Generic.List<System.String>()); }
        set { _text = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public object Item
    {
        get
        {
            return __Item;
        }
        set
        {
            __Item = value;
        }
    }

}