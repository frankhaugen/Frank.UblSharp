namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute("SignedSignatureProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=false)]
public partial class SignedSignaturePropertiesType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SigningTime", Order=0)]
    public System.DateTime @__SigningTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool @__SigningTimeSpecified;
        
    private System.Collections.Generic.List<CertIDType> _signingCertificate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("SigningCertificate", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable=false)]
    public CertIDType[] @__SigningCertificate
    {
        get
        {
            return _signingCertificate?.ToArray();
        }
        set
        {
            _signingCertificate = value == null ? null : new System.Collections.Generic.List<CertIDType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyIdentifier", Order=2)]
    public SignaturePolicyIdentifierType @__SignaturePolicyIdentifier;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignatureProductionPlace", Order=3)]
    public SignatureProductionPlaceType @__SignatureProductionPlace;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignerRole", Order=4)]
    public SignerRoleType @__SignerRole;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
    public string @__Id;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CertIDType> SigningCertificate
    {
        get { return _signingCertificate ?? (_signingCertificate = new System.Collections.Generic.List<CertIDType>()); }
        set { _signingCertificate = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.DateTime SigningTime
    {
        get
        {
            return __SigningTime;
        }
        set
        {
            __SigningTime = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public bool SigningTimeSpecified
    {
        get
        {
            return __SigningTimeSpecified;
        }
        set
        {
            __SigningTimeSpecified = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SignaturePolicyIdentifierType SignaturePolicyIdentifier
    {
        get
        {
            if (__SignaturePolicyIdentifier == null) { __SignaturePolicyIdentifier = new SignaturePolicyIdentifierType(); }
            return __SignaturePolicyIdentifier;
        }
        set
        {
            __SignaturePolicyIdentifier = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SignatureProductionPlaceType SignatureProductionPlace
    {
        get
        {
            if (__SignatureProductionPlace == null) { __SignatureProductionPlace = new SignatureProductionPlaceType(); }
            return __SignatureProductionPlace;
        }
        set
        {
            __SignatureProductionPlace = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SignerRoleType SignerRole
    {
        get
        {
            if (__SignerRole == null) { __SignerRole = new SignerRoleType(); }
            return __SignerRole;
        }
        set
        {
            __SignerRole = value;
        }
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