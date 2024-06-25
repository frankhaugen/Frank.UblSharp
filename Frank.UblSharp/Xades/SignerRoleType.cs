namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignerRoleType
{
        
    private System.Collections.Generic.List<AnyType> _claimedRoles;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("ClaimedRoles", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("ClaimedRole", IsNullable=false)]
    public AnyType[] @__ClaimedRoles
    {
        get
        {
            return _claimedRoles?.ToArray();
        }
        set
        {
            _claimedRoles = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    private System.Collections.Generic.List<EncapsulatedPKIDataType> _certifiedRoles;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("CertifiedRoles", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("CertifiedRole", IsNullable=false)]
    public EncapsulatedPKIDataType[] @__CertifiedRoles
    {
        get
        {
            return _certifiedRoles?.ToArray();
        }
        set
        {
            _certifiedRoles = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> ClaimedRoles
    {
        get { return _claimedRoles ?? (_claimedRoles = new System.Collections.Generic.List<AnyType>()); }
        set { _claimedRoles = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EncapsulatedPKIDataType> CertifiedRoles
    {
        get { return _certifiedRoles ?? (_certifiedRoles = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
        set { _certifiedRoles = value; }
    }

}