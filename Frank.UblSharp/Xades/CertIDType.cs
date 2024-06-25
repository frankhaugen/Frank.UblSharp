using Frank.UblSharp.XmlDigitalSignature;

namespace Frank.UblSharp.Xades;

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CertIDType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable=true)]
public partial class CertIDType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CertDigest", Order=0)]
    public DigestAlgAndValueType @__CertDigest;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuerSerial", Order=1)]
    public X509IssuerSerialType @__IssuerSerial;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
    public string @__URI;
        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DigestAlgAndValueType CertDigest
    {
        get
        {
            if (__CertDigest == null) { __CertDigest = new DigestAlgAndValueType(); }
            return __CertDigest;
        }
        set
        {
            __CertDigest = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public X509IssuerSerialType IssuerSerial
    {
        get
        {
            if (__IssuerSerial == null) { __IssuerSerial = new X509IssuerSerialType(); }
            return __IssuerSerial;
        }
        set
        {
            __IssuerSerial = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public string URI
    {
        get
        {
            return __URI;
        }
        set
        {
            __URI = value;
        }
    }

}