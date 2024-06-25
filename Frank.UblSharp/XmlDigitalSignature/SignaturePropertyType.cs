namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("SignatureProperty", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class SignaturePropertyType
{
        
#if FEATURE_XMLDOCUMENT
        private System.Collections.Generic.List<System.Xml.XmlElement> _items;
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        private System.Collections.Generic.List<System.Xml.Linq.XElement> _items;
#else
    private System.Collections.Generic.List<object> _items;
#endif
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
#if FEATURE_XMLDOCUMENT
        public System.Xml.XmlElement[] @__Items
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Xml.Linq.XElement[] @__Items
#else
    public object[] @__Items
#endif
    {
        get
        {
            return _items?.ToArray();
        }
        set
        {
#if FEATURE_XMLDOCUMENT
                _items = value == null ? null : new System.Collections.Generic.List<System.Xml.XmlElement>(value);
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
                _items = value == null ? null : new System.Collections.Generic.List<System.Xml.Linq.XElement>(value);
#else
            _items = value == null ? null : new System.Collections.Generic.List<object>(value);
#endif
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
    [System.Xml.Serialization.XmlAttributeAttribute("Target", DataType="anyURI")]
    public string @__Target;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlElement> Items
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XElement> Items
#else
    public System.Collections.Generic.List<object> Items
#endif
    {
#if FEATURE_XMLDOCUMENT
            get { return _items ?? (_items = new System.Collections.Generic.List<System.Xml.XmlElement>()); }
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
            get { return _items ?? (_items = new System.Collections.Generic.List<System.Xml.Linq.XElement>()); }
#else
        get { return _items ?? (_items = new System.Collections.Generic.List<object>()); }
#endif
        set { _items = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.String> Text
    {
        get { return _text ?? (_text = new System.Collections.Generic.List<System.String>()); }
        set { _text = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Target
    {
        get
        {
            return __Target;
        }
        set
        {
            __Target = value;
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