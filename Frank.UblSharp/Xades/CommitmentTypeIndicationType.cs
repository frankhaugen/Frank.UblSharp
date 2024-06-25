namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("CommitmentTypeIndication", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class CommitmentTypeIndicationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeId", Order=0)]
    public ObjectIdentifierType @__CommitmentTypeId;
        
    private System.Collections.Generic.List<System.Object> _items;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllSignedDataObjects", typeof(object), Order=1)]
    [System.Xml.Serialization.XmlElementAttribute("ObjectReference", typeof(string), DataType="anyURI", Order=1)]
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
        
    private System.Collections.Generic.List<AnyType> _commitmentTypeQualifiers;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("CommitmentTypeQualifiers", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("CommitmentTypeQualifier", IsNullable=false)]
    public AnyType[] @__CommitmentTypeQualifiers
    {
        get
        {
            return _commitmentTypeQualifiers?.ToArray();
        }
        set
        {
            _commitmentTypeQualifiers = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<System.Object> Items
    {
        get { return _items ?? (_items = new System.Collections.Generic.List<System.Object>()); }
        set { _items = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> CommitmentTypeQualifiers
    {
        get { return _commitmentTypeQualifiers ?? (_commitmentTypeQualifiers = new System.Collections.Generic.List<AnyType>()); }
        set { _commitmentTypeQualifiers = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ObjectIdentifierType CommitmentTypeId
    {
        get
        {
            if (__CommitmentTypeId == null) { __CommitmentTypeId = new ObjectIdentifierType(); }
            return __CommitmentTypeId;
        }
        set
        {
            __CommitmentTypeId = value;
        }
    }

}