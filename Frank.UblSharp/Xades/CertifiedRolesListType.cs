namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CertifiedRolesListType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class CertifiedRolesListType
{
        
    private System.Collections.Generic.List<EncapsulatedPKIDataType> _certifiedRole;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CertifiedRole", Order=0)]
    public EncapsulatedPKIDataType[] @__CertifiedRole
    {
        get
        {
            return _certifiedRole?.ToArray();
        }
        set
        {
            _certifiedRole = value == null ? null : new System.Collections.Generic.List<EncapsulatedPKIDataType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EncapsulatedPKIDataType> CertifiedRole
    {
        get { return _certifiedRole ?? (_certifiedRole = new System.Collections.Generic.List<EncapsulatedPKIDataType>()); }
        set { _certifiedRole = value; }
    }

}