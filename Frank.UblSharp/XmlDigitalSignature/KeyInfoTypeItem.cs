namespace Frank.UblSharp.XmlDigitalSignature;

[System.CodeDom.Compiler.GeneratedCodeAttribute("Frank.UblSharp.Generator", "1.0.0+0b1eda275a14df82b2b572e41efe08b43639b132")]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#", IncludeInSchema=false)]
public enum KeyInfoTypeItem
{
        
    [System.Xml.Serialization.XmlEnumAttribute("##any:")]
    Item,
        
    KeyName,
        
    KeyValue,
        
    MgmtData,
        
    PGPData,
        
    RetrievalMethod,
        
    SPKIData,
        
    X509Data,
}