namespace Frank.UblSharp.XmlDigitalSignature;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("Manifest", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable=false)]
public partial class ManifestType
{
        
    private System.Collections.Generic.List<ReferenceType> _reference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Reference")]
    public ReferenceType[] @__Reference
    {
        get
        {
            return _reference?.ToArray();
        }
        set
        {
            _reference = value == null ? null : new System.Collections.Generic.List<ReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ReferenceType> Reference
    {
        get { return _reference ?? (_reference = new System.Collections.Generic.List<ReferenceType>()); }
        set { _reference = value; }
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