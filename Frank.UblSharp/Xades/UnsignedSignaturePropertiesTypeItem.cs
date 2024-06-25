namespace Frank.UblSharp.Xades;

[System.CodeDom.Compiler.GeneratedCodeAttribute("Frank.UblSharp.Generator", "1.0.0+0b1eda275a14df82b2b572e41efe08b43639b132")]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#", IncludeInSchema=false)]
public enum UnsignedSignaturePropertiesTypeItem
{
        
    [System.Xml.Serialization.XmlEnumAttribute("##any:")]
    Item,
        
    ArchiveTimeStamp,
        
    AttrAuthoritiesCertValues,
        
    AttributeCertificateRefs,
        
    AttributeRevocationRefs,
        
    AttributeRevocationValues,
        
    CertificateValues,
        
    CompleteCertificateRefs,
        
    CompleteRevocationRefs,
        
    CounterSignature,
        
    RefsOnlyTimeStamp,
        
    RevocationValues,
        
    SigAndRefsTimeStamp,
        
    SignatureTimeStamp,
}