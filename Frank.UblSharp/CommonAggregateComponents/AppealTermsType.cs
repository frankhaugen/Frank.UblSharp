using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the terms and conditions, set by the contracting authority, under which an appeal can be lodged for a tender award.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Appeal Terms. Details
/// <para />ObjectClass: Appeal Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AppealTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AppealTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AppealTermsType
{
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PresentationPeriod", Order=1)]
    public PeriodType @__PresentationPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AppealInformationParty", Order=2)]
    public PartyType @__AppealInformationParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AppealReceiverParty", Order=3)]
    public PartyType @__AppealReceiverParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MediationParty", Order=4)]
    public PartyType @__MediationParty;
        
    /// <summary>
    /// Text describing the terms of an appeal.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Appeal Terms. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Appeal Terms
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// The period during which an appeal can be presented.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Appeal Terms. Presentation_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Appeal Terms
    /// <para />PropertyTermQualifier: Presentation
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType PresentationPeriod
    {
        get
        {
            if (__PresentationPeriod == null) { __PresentationPeriod = new PeriodType(); }
            return __PresentationPeriod;
        }
        set
        {
            __PresentationPeriod = value;
        }
    }

        
    /// <summary>
    /// The party presenting the information for an appeal.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Appeal Terms. Appeal Information_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Appeal Terms
    /// <para />PropertyTermQualifier: Appeal Information
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType AppealInformationParty
    {
        get
        {
            if (__AppealInformationParty == null) { __AppealInformationParty = new PartyType(); }
            return __AppealInformationParty;
        }
        set
        {
            __AppealInformationParty = value;
        }
    }

        
    /// <summary>
    /// The party to whom an appeal should be presented.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Appeal Terms. Appeal Receiver_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Appeal Terms
    /// <para />PropertyTermQualifier: Appeal Receiver
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType AppealReceiverParty
    {
        get
        {
            if (__AppealReceiverParty == null) { __AppealReceiverParty = new PartyType(); }
            return __AppealReceiverParty;
        }
        set
        {
            __AppealReceiverParty = value;
        }
    }

        
    /// <summary>
    /// The party that has been appointed to mediate any appeal.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Appeal Terms. Mediation_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Appeal Terms
    /// <para />PropertyTermQualifier: Mediation
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType MediationParty
    {
        get
        {
            if (__MediationParty == null) { __MediationParty = new PartyType(); }
            return __MediationParty;
        }
        set
        {
            __MediationParty = value;
        }
    }

}