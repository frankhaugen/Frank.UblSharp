using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define the terms for awarding a contract.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Awarding Terms. Details
/// <para />ObjectClass: Awarding Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AwardingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AwardingTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AwardingTermsType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WeightingAlgorithmCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__WeightingAlgorithmCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
        
    private System.Collections.Generic.List<TextType> _technicalCommitteeDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__TechnicalCommitteeDescription
    {
        get
        {
            return _technicalCommitteeDescription?.ToArray();
        }
        set
        {
            _technicalCommitteeDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _lowTendersDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LowTendersDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__LowTendersDescription
    {
        get
        {
            return _lowTendersDescription?.ToArray();
        }
        set
        {
            _lowTendersDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrizeIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IndicatorType @__PrizeIndicator;
        
    private System.Collections.Generic.List<TextType> _prizeDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrizeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__PrizeDescription
    {
        get
        {
            return _prizeDescription?.ToArray();
        }
        set
        {
            _prizeDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _paymentDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType[] @__PaymentDescription
    {
        get
        {
            return _paymentDescription?.ToArray();
        }
        set
        {
            _paymentDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FollowupContractIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public IndicatorType @__FollowupContractIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BindingOnBuyerIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IndicatorType @__BindingOnBuyerIndicator;
        
    private System.Collections.Generic.List<AwardingCriterionType> _awardingCriterion;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardingCriterion", Order=9)]
    public AwardingCriterionType[] @__AwardingCriterion
    {
        get
        {
            return _awardingCriterion?.ToArray();
        }
        set
        {
            _awardingCriterion = value == null ? null : new System.Collections.Generic.List<AwardingCriterionType>(value);
        }
    }
        
    private System.Collections.Generic.List<PersonType> _technicalCommitteePerson;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TechnicalCommitteePerson", Order=10)]
    public PersonType[] @__TechnicalCommitteePerson
    {
        get
        {
            return _technicalCommitteePerson?.ToArray();
        }
        set
        {
            _technicalCommitteePerson = value == null ? null : new System.Collections.Generic.List<PersonType>(value);
        }
    }
        
    /// <summary>
    /// Text describing terms under which the contract is to be awarded.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Terms
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
    /// Text describing the committee of experts evaluating the subjective criteria for awarding the contract.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Technical Committee_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTermQualifier: Technical Committee
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> TechnicalCommitteeDescription
    {
        get { return _technicalCommitteeDescription ?? (_technicalCommitteeDescription = new System.Collections.Generic.List<TextType>()); }
        set { _technicalCommitteeDescription = value; }
    }

        
    /// <summary>
    /// Text describing the exclusion criterion for abnormally low tenders.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Low Tenders_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTermQualifier: Low Tenders
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> LowTendersDescription
    {
        get { return _lowTendersDescription ?? (_lowTendersDescription = new System.Collections.Generic.List<TextType>()); }
        set { _lowTendersDescription = value; }
    }

        
    /// <summary>
    /// Number and value of the prizes to be awarded.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Prize Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTerm: Prize Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> PrizeDescription
    {
        get { return _prizeDescription ?? (_prizeDescription = new System.Collections.Generic.List<TextType>()); }
        set { _prizeDescription = value; }
    }

        
    /// <summary>
    /// Details of payments to all participants.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Payment Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTerm: Payment Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> PaymentDescription
    {
        get { return _paymentDescription ?? (_paymentDescription = new System.Collections.Generic.List<TextType>()); }
        set { _paymentDescription = value; }
    }

        
    /// <summary>
    /// Defines a criterion for awarding this tender.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Awarding Terms. Awarding Criterion
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTerm: Awarding Criterion
    /// <para />AssociatedObjectClass: Awarding Criterion
    /// <para />RepresentationTerm: Awarding Criterion
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AwardingCriterionType> AwardingCriterion
    {
        get { return _awardingCriterion ?? (_awardingCriterion = new System.Collections.Generic.List<AwardingCriterionType>()); }
        set { _awardingCriterion = value; }
    }

        
    /// <summary>
    /// A member of a committee of experts evaluating the subjective criteria for awarding the contract.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Awarding Terms. Technical Committee_ Person. Person
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTermQualifier: Technical Committee
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PersonType> TechnicalCommitteePerson
    {
        get { return _technicalCommitteePerson ?? (_technicalCommitteePerson = new System.Collections.Generic.List<PersonType>()); }
        set { _technicalCommitteePerson = value; }
    }

        
    /// <summary>
    /// A code signifying the weighting algorithm for awarding criteria. When multiple awarding criteria is used, different weighting and choices management algorithms based upon scores and weights of all award criteria can be used. An algorithm for weighting criteria shall be reported in the call for tenders document. It is used to determine how to perform the final management of tenders based on the results in each of the established award criteria
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Weighting Algorithm Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTerm: Weighting Algorithm Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType WeightingAlgorithmCode
    {
        get
        {
            if (__WeightingAlgorithmCode == null) { __WeightingAlgorithmCode = new CodeType(); }
            return __WeightingAlgorithmCode;
        }
        set
        {
            __WeightingAlgorithmCode = value;
        }
    }

        
    /// <summary>
    /// Indicates whether a prize will be awarded (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Prize Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTerm: Prize Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType PrizeIndicator
    {
        get
        {
            if (__PrizeIndicator == null) { __PrizeIndicator = new IndicatorType(); }
            return __PrizeIndicator;
        }
        set
        {
            __PrizeIndicator = value;
        }
    }

        
    /// <summary>
    /// Indicates if any service contract following the contest will be awarded to the winner or one of the winners of the contest (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Followup Contract Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTerm: Followup Contract Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType FollowupContractIndicator
    {
        get
        {
            if (__FollowupContractIndicator == null) { __FollowupContractIndicator = new IndicatorType(); }
            return __FollowupContractIndicator;
        }
        set
        {
            __FollowupContractIndicator = value;
        }
    }

        
    /// <summary>
    /// Indicates if the decision is binding on the buyer (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Terms. Binding On Buyer Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Terms
    /// <para />PropertyTerm: Binding On Buyer Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType BindingOnBuyerIndicator
    {
        get
        {
            if (__BindingOnBuyerIndicator == null) { __BindingOnBuyerIndicator = new IndicatorType(); }
            return __BindingOnBuyerIndicator;
        }
        set
        {
            __BindingOnBuyerIndicator = value;
        }
    }

}