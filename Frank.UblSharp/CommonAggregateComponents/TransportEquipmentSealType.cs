using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a device (a transport equipment seal) for securing the doors of a shipping container.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transport Equipment Seal. Details
/// <para />ObjectClass: Transport Equipment Seal
/// <para />AlternativeBusinessTerms: Container Seal
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TransportEquipmentSeal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportEquipmentSeal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportEquipmentSealType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SealIssuerTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__SealIssuerTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Condition", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__Condition;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SealStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__SealStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SealingPartyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__SealingPartyType;
        
    /// <summary>
    /// An identifier for this transport equipment seal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment Seal. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Transport Equipment Seal
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>ACS1234</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of party that issues and is responsible for this transport equipment seal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment Seal. Seal Issuer Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment Seal
    /// <para />PropertyTerm: Seal Issuer Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SealIssuerTypeCode
    {
        get
        {
            if (__SealIssuerTypeCode == null) { __SealIssuerTypeCode = new CodeType(); }
            return __SealIssuerTypeCode;
        }
        set
        {
            __SealIssuerTypeCode = value;
        }
    }

        
    /// <summary>
    /// The condition of this transport equipment seal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment Seal. Condition. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment Seal
    /// <para />PropertyTerm: Condition
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Condition
    {
        get
        {
            if (__Condition == null) { __Condition = new TextType(); }
            return __Condition;
        }
        set
        {
            __Condition = value;
        }
    }

        
    /// <summary>
    /// A code signifying the condition of this transport equipment seal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment Seal. Seal Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment Seal
    /// <para />PropertyTerm: Seal Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SealStatusCode
    {
        get
        {
            if (__SealStatusCode == null) { __SealStatusCode = new CodeType(); }
            return __SealStatusCode;
        }
        set
        {
            __SealStatusCode = value;
        }
    }

        
    /// <summary>
    /// The role of the sealing party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Equipment Seal. Sealing Party Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Equipment Seal
    /// <para />PropertyTerm: Sealing Party Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Sealing Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType SealingPartyType
    {
        get
        {
            if (__SealingPartyType == null) { __SealingPartyType = new TextType(); }
            return __SealingPartyType;
        }
        set
        {
            __SealingPartyType = value;
        }
    }

}