using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The type of contracting party that is independent of its role.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Contracting Party Type. Details
/// <para />ObjectClass: Contracting Party Type
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ContractingPartyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractingPartyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ContractingPartyTypeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartyTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__PartyTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__PartyType;
        
    /// <summary>
    /// A code specifying the type of party that is independent of its role.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contracting Party Type. Party Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contracting Party Type
    /// <para />PropertyTerm: Party Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PartyTypeCode
    {
        get
        {
            if (__PartyTypeCode == null) { __PartyTypeCode = new CodeType(); }
            return __PartyTypeCode;
        }
        set
        {
            __PartyTypeCode = value;
        }
    }

        
    /// <summary>
    /// The type of party that is independent of its role, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contracting Party Type. Party Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contracting Party Type
    /// <para />PropertyTerm: Party Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PartyType
    {
        get
        {
            if (__PartyType == null) { __PartyType = new TextType(); }
            return __PartyType;
        }
        set
        {
            __PartyType = value;
        }
    }

}