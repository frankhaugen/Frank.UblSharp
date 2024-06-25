namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DocumentationReferencesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class DocumentationReferencesType
{
        
    private System.Collections.Generic.List<System.String> _documentationReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentationReference", DataType="anyURI", Order=0)]
    public string[] @__DocumentationReference
    {
        get
        {
            return _documentationReference?.ToArray();
        }
        set
        {
            _documentationReference = value == null ? null : new System.Collections.Generic.List<System.String>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.String> DocumentationReference
    {
        get { return _documentationReference ?? (_documentationReference = new System.Collections.Generic.List<System.String>()); }
        set { _documentationReference = value; }
    }

}