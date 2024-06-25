namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ClaimedRolesListType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class ClaimedRolesListType
{
        
    private System.Collections.Generic.List<AnyType> _claimedRole;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ClaimedRole", Order=0)]
    public AnyType[] @__ClaimedRole
    {
        get
        {
            return _claimedRole?.ToArray();
        }
        set
        {
            _claimedRole = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> ClaimedRole
    {
        get { return _claimedRole ?? (_claimedRole = new System.Collections.Generic.List<AnyType>()); }
        set { _claimedRole = value; }
    }

}