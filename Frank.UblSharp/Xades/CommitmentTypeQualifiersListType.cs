namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CommitmentTypeQualifiersListType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class CommitmentTypeQualifiersListType
{
        
    private System.Collections.Generic.List<AnyType> _commitmentTypeQualifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeQualifier", Order=0)]
    public AnyType[] @__CommitmentTypeQualifier
    {
        get
        {
            return _commitmentTypeQualifier?.ToArray();
        }
        set
        {
            _commitmentTypeQualifier = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> CommitmentTypeQualifier
    {
        get { return _commitmentTypeQualifier ?? (_commitmentTypeQualifier = new System.Collections.Generic.List<AnyType>()); }
        set { _commitmentTypeQualifier = value; }
    }

}