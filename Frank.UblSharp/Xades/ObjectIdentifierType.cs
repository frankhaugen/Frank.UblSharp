namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ObjectIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("ObjectIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class ObjectIdentifierType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Identifier", Order=0)]
    public Xades.IdentifierType @__Identifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Order=1)]
    public string @__Description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentationReferences", Order=2)]
    public DocumentationReferencesType @__DocumentationReferences;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public Xades.IdentifierType Identifier
    {
        get
        {
            if (__Identifier == null) { __Identifier = new Xades.IdentifierType(); }
            return __Identifier;
        }
        set
        {
            __Identifier = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string Description
    {
        get
        {
            return __Description;
        }
        set
        {
            __Description = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentationReferencesType DocumentationReferences
    {
        get
        {
            if (__DocumentationReferences == null) { __DocumentationReferences = new DocumentationReferencesType(); }
            return __DocumentationReferences;
        }
        set
        {
            __DocumentationReferences = value;
        }
    }

}