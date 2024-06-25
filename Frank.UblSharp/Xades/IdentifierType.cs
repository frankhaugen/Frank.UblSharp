namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("IdentifierType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class IdentifierType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Qualifier")]
    public QualifierType @__Qualifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool @__QualifierSpecified;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
    public string @__Value;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QualifierType Qualifier
    {
        get
        {                
            return __Qualifier;
        }
        set
        {
            __Qualifier = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool QualifierSpecified
    {
        get
        {
            return __QualifierSpecified;
        }
        set
        {
            __QualifierSpecified = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Value
    {
        get
        {
            return __Value;
        }
        set
        {
            __Value = value;
        }
    }

}