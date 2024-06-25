using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the awarding of a tender in a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tender Result. Details
/// <para />ObjectClass: Tender Result
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TenderResult", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TenderResult", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TenderResultType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderResultCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__TenderResultCode;
        
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdvertisementAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__AdvertisementAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__AwardDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__AwardTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceivedTenderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__ReceivedTenderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LowerTenderAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__LowerTenderAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HigherTenderAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public AmountType @__HigherTenderAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public DateType @__StartDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceivedElectronicTenderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__ReceivedElectronicTenderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceivedForeignTenderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public QuantityType @__ReceivedForeignTenderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Contract", Order=11)]
    public ContractType @__Contract;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardedTenderedProject", Order=12)]
    public TenderedProjectType @__AwardedTenderedProject;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractFormalizationPeriod", Order=13)]
    public PeriodType @__ContractFormalizationPeriod;
        
    private System.Collections.Generic.List<SubcontractTermsType> _subcontractTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubcontractTerms", Order=14)]
    public SubcontractTermsType[] @__SubcontractTerms
    {
        get
        {
            return _subcontractTerms?.ToArray();
        }
        set
        {
            _subcontractTerms = value == null ? null : new System.Collections.Generic.List<SubcontractTermsType>(value);
        }
    }
        
    private System.Collections.Generic.List<WinningPartyType> _winningParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WinningParty", Order=15)]
    public WinningPartyType[] @__WinningParty
    {
        get
        {
            return _winningParty?.ToArray();
        }
        set
        {
            _winningParty = value == null ? null : new System.Collections.Generic.List<WinningPartyType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the result of the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Result
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
    /// Subcontract terms for this tender result.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Result. Subcontract Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTerm: Subcontract Terms
    /// <para />AssociatedObjectClass: Subcontract Terms
    /// <para />RepresentationTerm: Subcontract Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<SubcontractTermsType> SubcontractTerms
    {
        get { return _subcontractTerms ?? (_subcontractTerms = new System.Collections.Generic.List<SubcontractTermsType>()); }
        set { _subcontractTerms = value; }
    }

        
    /// <summary>
    /// A party that is identified as the awarded by a tender result.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Result. Winning Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTerm: Winning Party
    /// <para />AssociatedObjectClass: Winning Party
    /// <para />RepresentationTerm: Winning Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<WinningPartyType> WinningParty
    {
        get { return _winningParty ?? (_winningParty = new System.Collections.Generic.List<WinningPartyType>()); }
        set { _winningParty = value; }
    }

        
    /// <summary>
    /// A code signifying the result of the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Tender_ Result Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Tender
    /// <para />PropertyTerm: Result Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TenderResultCode
    {
        get
        {
            if (__TenderResultCode == null) { __TenderResultCode = new CodeType(); }
            return __TenderResultCode;
        }
        set
        {
            __TenderResultCode = value;
        }
    }

        
    /// <summary>
    /// The monetary value of the advertisement for this tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Advertisement. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTerm: Advertisement
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType AdvertisementAmount
    {
        get
        {
            if (__AdvertisementAmount == null) { __AdvertisementAmount = new AmountType(); }
            return __AdvertisementAmount;
        }
        set
        {
            __AdvertisementAmount = value;
        }
    }

        
    /// <summary>
    /// The date on which this result was formalized.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Award Date. Date
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTerm: Award Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType AwardDate
    {
        get
        {
            if (__AwardDate == null) { __AwardDate = new DateType(); }
            return __AwardDate;
        }
        set
        {
            __AwardDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this result was formalized.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Award Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTerm: Award Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType AwardTime
    {
        get
        {
            if (__AwardTime == null) { __AwardTime = new TimeType(); }
            return __AwardTime;
        }
        set
        {
            __AwardTime = value;
        }
    }

        
    /// <summary>
    /// The total number of tenders received in this tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Received_ Tender. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Received
    /// <para />PropertyTerm: Tender
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ReceivedTenderQuantity
    {
        get
        {
            if (__ReceivedTenderQuantity == null) { __ReceivedTenderQuantity = new QuantityType(); }
            return __ReceivedTenderQuantity;
        }
        set
        {
            __ReceivedTenderQuantity = value;
        }
    }

        
    /// <summary>
    /// The least expensive tender received in the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Lower_ Tender. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Lower
    /// <para />PropertyTerm: Tender
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType LowerTenderAmount
    {
        get
        {
            if (__LowerTenderAmount == null) { __LowerTenderAmount = new AmountType(); }
            return __LowerTenderAmount;
        }
        set
        {
            __LowerTenderAmount = value;
        }
    }

        
    /// <summary>
    /// The most expensive tender received in this tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Higher_ Tender. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Higher
    /// <para />PropertyTerm: Tender
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType HigherTenderAmount
    {
        get
        {
            if (__HigherTenderAmount == null) { __HigherTenderAmount = new AmountType(); }
            return __HigherTenderAmount;
        }
        set
        {
            __HigherTenderAmount = value;
        }
    }

        
    /// <summary>
    /// The date on which the awarded contract begins.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Start Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTerm: Start Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType StartDate
    {
        get
        {
            if (__StartDate == null) { __StartDate = new DateType(); }
            return __StartDate;
        }
        set
        {
            __StartDate = value;
        }
    }

        
    /// <summary>
    /// The number of electronic tenders received.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Received_ Electronic Tender Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Received
    /// <para />PropertyTerm: Electronic Tender Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ReceivedElectronicTenderQuantity
    {
        get
        {
            if (__ReceivedElectronicTenderQuantity == null) { __ReceivedElectronicTenderQuantity = new QuantityType(); }
            return __ReceivedElectronicTenderQuantity;
        }
        set
        {
            __ReceivedElectronicTenderQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of foreing tenders received.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Result. Received_ Foreign Tender Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Received
    /// <para />PropertyTerm: Foreign Tender Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ReceivedForeignTenderQuantity
    {
        get
        {
            if (__ReceivedForeignTenderQuantity == null) { __ReceivedForeignTenderQuantity = new QuantityType(); }
            return __ReceivedForeignTenderQuantity;
        }
        set
        {
            __ReceivedForeignTenderQuantity = value;
        }
    }

        
    /// <summary>
    /// A contract governing this tender result.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Result. Contract
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTerm: Contract
    /// <para />AssociatedObjectClass: Contract
    /// <para />RepresentationTerm: Contract
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContractType Contract
    {
        get
        {
            if (__Contract == null) { __Contract = new ContractType(); }
            return __Contract;
        }
        set
        {
            __Contract = value;
        }
    }

        
    /// <summary>
    /// The awarded tendered project associated with this tender result.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Result. Awarded_ Tendered Project. Tendered Project
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Awarded
    /// <para />PropertyTerm: Tendered Project
    /// <para />AssociatedObjectClass: Tendered Project
    /// <para />RepresentationTerm: Tendered Project
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TenderedProjectType AwardedTenderedProject
    {
        get
        {
            if (__AwardedTenderedProject == null) { __AwardedTenderedProject = new TenderedProjectType(); }
            return __AwardedTenderedProject;
        }
        set
        {
            __AwardedTenderedProject = value;
        }
    }

        
    /// <summary>
    /// The period during which a contract associated with the awarded project is to be formalized.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Result. Contract Formalization_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Result
    /// <para />PropertyTermQualifier: Contract Formalization
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ContractFormalizationPeriod
    {
        get
        {
            if (__ContractFormalizationPeriod == null) { __ContractFormalizationPeriod = new PeriodType(); }
            return __ContractFormalizationPeriod;
        }
        set
        {
            __ContractFormalizationPeriod = value;
        }
    }

}