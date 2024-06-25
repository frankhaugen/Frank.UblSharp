using Frank.UblSharp.XmlDigitalSignature;

namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SignaturePolicyIdType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class SignaturePolicyIdType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SigPolicyId", Order=0)]
    public ObjectIdentifierType @__SigPolicyId;
        
    private System.Collections.Generic.List<TransformType> _transforms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("Transforms", Namespace = "http://www.w3.org/2000/09/xmldsig#", Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
    public TransformType[] @__Transforms
    {
        get
        {
            return _transforms?.ToArray();
        }
        set
        {
            _transforms = value == null ? null : new System.Collections.Generic.List<TransformType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SigPolicyHash", Order=2)]
    public DigestAlgAndValueType @__SigPolicyHash;
        
    private System.Collections.Generic.List<AnyType> _sigPolicyQualifiers;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlArrayAttribute("SigPolicyQualifiers", Namespace = "http://uri.etsi.org/01903/v1.3.2#", Order=3)]
    [System.Xml.Serialization.XmlArrayItemAttribute("SigPolicyQualifier", IsNullable=false)]
    public AnyType[] @__SigPolicyQualifiers
    {
        get
        {
            return _sigPolicyQualifiers?.ToArray();
        }
        set
        {
            _sigPolicyQualifiers = value == null ? null : new System.Collections.Generic.List<AnyType>(value);
        }
    }
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransformType> Transforms
    {
        get { return _transforms ?? (_transforms = new System.Collections.Generic.List<TransformType>()); }
        set { _transforms = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AnyType> SigPolicyQualifiers
    {
        get { return _sigPolicyQualifiers ?? (_sigPolicyQualifiers = new System.Collections.Generic.List<AnyType>()); }
        set { _sigPolicyQualifiers = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ObjectIdentifierType SigPolicyId
    {
        get
        {
            if (__SigPolicyId == null) { __SigPolicyId = new ObjectIdentifierType(); }
            return __SigPolicyId;
        }
        set
        {
            __SigPolicyId = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DigestAlgAndValueType SigPolicyHash
    {
        get
        {
            if (__SigPolicyHash == null) { __SigPolicyHash = new DigestAlgAndValueType(); }
            return __SigPolicyHash;
        }
        set
        {
            __SigPolicyHash = value;
        }
    }

}