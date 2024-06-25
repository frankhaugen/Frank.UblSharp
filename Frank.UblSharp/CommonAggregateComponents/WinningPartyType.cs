using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A party that is identified as the awarded by a tender result.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Winning Party. Details
/// <para />ObjectClass: Winning Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("WinningParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("WinningParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class WinningPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Rank", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__Rank;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=1)]
    public PartyType @__Party;
        
    /// <summary>
    /// Indicates the rank obtained in the award.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Winning Party. Rank. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Winning Party
    /// <para />PropertyTerm: Rank
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Rank
    {
        get
        {
            if (__Rank == null) { __Rank = new TextType(); }
            return __Rank;
        }
        set
        {
            __Rank = value;
        }
    }

        
    /// <summary>
    /// Information about an organization, sub-organization, or individual fulfilling a role in a business process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Winning Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Winning Party
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType Party
    {
        get
        {
            if (__Party == null) { __Party = new PartyType(); }
            return __Party;
        }
        set
        {
            __Party = value;
        }
    }

}