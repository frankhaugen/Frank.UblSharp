namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("Object", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class ObjectType
{
        
#if FEATURE_XMLDOCUMENT
        private System.Collections.Generic.List<System.Xml.XmlNode> _any;
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        private System.Collections.Generic.List<System.Xml.Linq.XNode> _any;
#else
    private System.Collections.Generic.List<object> _any;
#endif
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
#if FEATURE_XMLDOCUMENT
        public System.Xml.XmlNode[] @__Any
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Xml.Linq.XNode[] @__Any
#else
    public object[] @__Any
#endif
    {
        get
        {
            return _any?.ToArray();
        }
        set
        {
#if FEATURE_XMLDOCUMENT
                _any = value == null ? null : new System.Collections.Generic.List<System.Xml.XmlNode>(value);
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
                _any = value == null ? null : new System.Collections.Generic.List<System.Xml.Linq.XNode>(value);
#else
            _any = value == null ? null : new System.Collections.Generic.List<object>(value);
#endif
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("MimeType")]
    public string @__MimeType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Encoding", DataType="anyURI")]
    public string @__Encoding;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlNode> Any
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XNode> Any
#else
    public System.Collections.Generic.List<object> Any
#endif
    {
#if FEATURE_XMLDOCUMENT
            get { return _any ?? (_any = new System.Collections.Generic.List<System.Xml.XmlNode>()); }
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
            get { return _any ?? (_any = new System.Collections.Generic.List<System.Xml.Linq.XNode>()); }
#else
        get { return _any ?? (_any = new System.Collections.Generic.List<object>()); }
#endif
        set { _any = value; }
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

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string MimeType
    {
        get
        {
            return __MimeType;
        }
        set
        {
            __MimeType = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Encoding
    {
        get
        {
            return __Encoding;
        }
        set
        {
            __Encoding = value;
        }
    }

}