namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("SPKIData", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class SPKIDataType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType="base64Binary")]
    public byte[][] @__SPKISexp;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
#if FEATURE_XMLDOCUMENT
        public System.Xml.XmlElement @__Any;
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Xml.Linq.XElement @__Any;
#else
    public object @__Any;
#endif
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public byte[][] SPKISexp
    {
        get
        {
            return __SPKISexp;
        }
        set
        {
            __SPKISexp = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
#if FEATURE_XMLDOCUMENT
        public System.Xml.XmlElement Any
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Xml.Linq.XElement Any
#else
    public object Any
#endif
    {
        get
        {
            return __Any;
        }
        set
        {
            __Any = value;
        }
    }

}