using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a contract.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Contract. Details
/// <para />ObjectClass: Contract
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Contract", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ContractType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__IssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NominationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__NominationDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NominationTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__NominationTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__ContractTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__ContractType1;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType[] @__Note
    {
        get
        {
            return _note?.ToArray();
        }
        set
        {
            _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IdentifierType @__VersionID;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
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
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=10)]
    public PeriodType @__ValidityPeriod;
        
    private System.Collections.Generic.List<DocumentReferenceType> _contractDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Order=11)]
    public DocumentReferenceType[] @__ContractDocumentReference
    {
        get
        {
            return _contractDocumentReference?.ToArray();
        }
        set
        {
            _contractDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NominationPeriod", Order=12)]
    public PeriodType @__NominationPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractualDelivery", Order=13)]
    public DeliveryType @__ContractualDelivery;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Remarks
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// Text describing this contract.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contract
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
    /// A reference to a contract document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contract. Contract_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contract
    /// <para />PropertyTermQualifier: Contract
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> ContractDocumentReference
    {
        get { return _contractDocumentReference ?? (_contractDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _contractDocumentReference = value; }
    }

        
    /// <summary>
    /// An identifier for this contract.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>CC23</example>
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
    /// The date on which this contract was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Issue Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType IssueDate
    {
        get
        {
            if (__IssueDate == null) { __IssueDate = new DateType(); }
            return __IssueDate;
        }
        set
        {
            __IssueDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this contract was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Issue Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType IssueTime
    {
        get
        {
            if (__IssueTime == null) { __IssueTime = new TimeType(); }
            return __IssueTime;
        }
        set
        {
            __IssueTime = value;
        }
    }

        
    /// <summary>
    /// In a transportation contract, the deadline date by which the services referred to in the transport execution plan have to be booked. For example, if this service is a carrier service scheduled for Wednesday 16 February 2011 at 10 a.m. CET, the nomination date might be Tuesday15 February 2011.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Nomination Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Nomination Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType NominationDate
    {
        get
        {
            if (__NominationDate == null) { __NominationDate = new DateType(); }
            return __NominationDate;
        }
        set
        {
            __NominationDate = value;
        }
    }

        
    /// <summary>
    /// In a transportation contract, the deadline time by which the services referred to in the transport execution plan have to be booked. For example, if this service is a carrier service scheduled for Wednesday 16 February 2011 at 10 a.m. CET, the nomination date might be Tuesday15 February 2011 and the nomination time 4 p.m. at the latest.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Nomination Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Nomination Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType NominationTime
    {
        get
        {
            if (__NominationTime == null) { __NominationTime = new TimeType(); }
            return __NominationTime;
        }
        set
        {
            __NominationTime = value;
        }
    }

        
    /// <summary>
    /// The type of this contract, expressed as a code, such as &quot;Cost plus award fee&quot; and &quot;Cost plus fixed fee&quot; from UNCEFACT Contract Type code list.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Contract Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Contract Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ContractTypeCode
    {
        get
        {
            if (__ContractTypeCode == null) { __ContractTypeCode = new CodeType(); }
            return __ContractTypeCode;
        }
        set
        {
            __ContractTypeCode = value;
        }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ContractType1
    {
        get
        {
            if (__ContractType1 == null) { __ContractType1 = new TextType(); }
            return __ContractType1;
        }
        set
        {
            __ContractType1 = value;
        }
    }

        
    /// <summary>
    /// An identifier for the current version of this contract.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract. Version. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTerm: Version
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType VersionID
    {
        get
        {
            if (__VersionID == null) { __VersionID = new IdentifierType(); }
            return __VersionID;
        }
        set
        {
            __VersionID = value;
        }
    }

        
    /// <summary>
    /// The period during which this contract is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contract. Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTermQualifier: Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ValidityPeriod
    {
        get
        {
            if (__ValidityPeriod == null) { __ValidityPeriod = new PeriodType(); }
            return __ValidityPeriod;
        }
        set
        {
            __ValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// In a transportation contract, the period required to book the services specified in the contract before the services can begin.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contract. Nomination_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTermQualifier: Nomination
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType NominationPeriod
    {
        get
        {
            if (__NominationPeriod == null) { __NominationPeriod = new PeriodType(); }
            return __NominationPeriod;
        }
        set
        {
            __NominationPeriod = value;
        }
    }

        
    /// <summary>
    /// In a transportation contract, the delivery of the services required to book the services specified in the contract.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contract. Contractual_ Delivery. Delivery
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract
    /// <para />PropertyTermQualifier: Contractual
    /// <para />PropertyTerm: Delivery
    /// <para />AssociatedObjectClass: Delivery
    /// <para />RepresentationTerm: Delivery
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DeliveryType ContractualDelivery
    {
        get
        {
            if (__ContractualDelivery == null) { __ContractualDelivery = new DeliveryType(); }
            return __ContractualDelivery;
        }
        set
        {
            __ContractualDelivery = value;
        }
    }

}