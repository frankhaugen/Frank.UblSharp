using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a shareholder party.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Shareholder Party. Details
/// <para />ObjectClass: Shareholder Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ShareholderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ShareholderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ShareholderPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartecipationPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public PercentType @__PartecipationPercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=1)]
    public PartyType @__Party;
        
    /// <summary>
    /// The shareholder participation, expressed as a percentage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Shareholder Party. Partecipation. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shareholder Party
    /// <para />PropertyTerm: Partecipation
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType PartecipationPercent
    {
        get
        {
            if (__PartecipationPercent == null) { __PartecipationPercent = new PercentType(); }
            return __PartecipationPercent;
        }
        set
        {
            __PartecipationPercent = value;
        }
    }

        
    /// <summary>
    /// The shareholder party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Shareholder Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Shareholder Party
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