using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a set of payment terms.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Payment Terms. Details
/// <para />ObjectClass: Payment Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("BonusPaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("BonusPaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PaymentTermsType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<IdentifierType> _paymentMeansID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentMeansID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType[] @__PaymentMeansID
    {
        get
        {
            return _paymentMeansID?.ToArray();
        }
        set
        {
            _paymentMeansID = value == null ? null : new System.Collections.Generic.List<IdentifierType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrepaidPaymentReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__PrepaidPaymentReferenceID;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
    [System.Xml.Serialization.XmlElementAttribute("ReferenceEventCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__ReferenceEventCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SettlementDiscountPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public PercentType @__SettlementDiscountPercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PenaltySurchargePercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public PercentType @__PenaltySurchargePercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public PercentType @__PaymentPercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SettlementDiscountAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public AmountType @__SettlementDiscountAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PenaltyAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public AmountType @__PenaltyAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentTermsDetailsURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public IdentifierType @__PaymentTermsDetailsURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentDueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public DateType @__PaymentDueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InstallmentDueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public DateType @__InstallmentDueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoicingPartyReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public TextType @__InvoicingPartyReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SettlementPeriod", Order=15)]
    public PeriodType @__SettlementPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PenaltyPeriod", Order=16)]
    public PeriodType @__PenaltyPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Order=17)]
    public ExchangeRateType @__ExchangeRate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=18)]
    public PeriodType @__ValidityPeriod;
        
    /// <summary>
    /// An identifier for a means of payment associated with these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Payment Means Identifier. Identifier
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Payment Means Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<IdentifierType> PaymentMeansID
    {
        get { return _paymentMeansID ?? (_paymentMeansID = new System.Collections.Generic.List<IdentifierType>()); }
        set { _paymentMeansID = value; }
    }

        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// An identifier for this set of payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
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
    /// An identifier for a reference to a prepaid payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Prepaid Payment Reference Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Prepaid Payment Reference Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType PrepaidPaymentReferenceID
    {
        get
        {
            if (__PrepaidPaymentReferenceID == null) { __PrepaidPaymentReferenceID = new IdentifierType(); }
            return __PrepaidPaymentReferenceID;
        }
        set
        {
            __PrepaidPaymentReferenceID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the event during which these terms are offered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Reference_ Event Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Reference
    /// <para />PropertyTerm: Event Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ReferenceEventCode
    {
        get
        {
            if (__ReferenceEventCode == null) { __ReferenceEventCode = new CodeType(); }
            return __ReferenceEventCode;
        }
        set
        {
            __ReferenceEventCode = value;
        }
    }

        
    /// <summary>
    /// The percentage for the settlement discount that is offered for payment under these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Settlement_ Discount Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Settlement
    /// <para />PropertyTerm: Discount Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType SettlementDiscountPercent
    {
        get
        {
            if (__SettlementDiscountPercent == null) { __SettlementDiscountPercent = new PercentType(); }
            return __SettlementDiscountPercent;
        }
        set
        {
            __SettlementDiscountPercent = value;
        }
    }

        
    /// <summary>
    /// The penalty for payment after the settlement period, expressed as a percentage of the payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Penalty_ Surcharge Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Penalty
    /// <para />PropertyTerm: Surcharge Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType PenaltySurchargePercent
    {
        get
        {
            if (__PenaltySurchargePercent == null) { __PenaltySurchargePercent = new PercentType(); }
            return __PenaltySurchargePercent;
        }
        set
        {
            __PenaltySurchargePercent = value;
        }
    }

        
    /// <summary>
    /// The part of a payment, expressed as a percent, relevant for these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Payment Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Payment Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType PaymentPercent
    {
        get
        {
            if (__PaymentPercent == null) { __PaymentPercent = new PercentType(); }
            return __PaymentPercent;
        }
        set
        {
            __PaymentPercent = value;
        }
    }

        
    /// <summary>
    /// The monetary amount covered by these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType Amount
    {
        get
        {
            if (__Amount == null) { __Amount = new AmountType(); }
            return __Amount;
        }
        set
        {
            __Amount = value;
        }
    }

        
    /// <summary>
    /// The amount of a settlement discount offered for payment under these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Settlement_ Discount Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Settlement
    /// <para />PropertyTerm: Discount Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType SettlementDiscountAmount
    {
        get
        {
            if (__SettlementDiscountAmount == null) { __SettlementDiscountAmount = new AmountType(); }
            return __SettlementDiscountAmount;
        }
        set
        {
            __SettlementDiscountAmount = value;
        }
    }

        
    /// <summary>
    /// The monetary amount of the penalty for payment after the settlement period.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Penalty_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Penalty
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PenaltyAmount
    {
        get
        {
            if (__PenaltyAmount == null) { __PenaltyAmount = new AmountType(); }
            return __PenaltyAmount;
        }
        set
        {
            __PenaltyAmount = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) of a document providing additional details regarding these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Payment Terms Details URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Payment Terms Details URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType PaymentTermsDetailsURI
    {
        get
        {
            if (__PaymentTermsDetailsURI == null) { __PaymentTermsDetailsURI = new IdentifierType(); }
            return __PaymentTermsDetailsURI;
        }
        set
        {
            __PaymentTermsDetailsURI = value;
        }
    }

        
    /// <summary>
    /// The due date for these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Payment Due Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Payment Due Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType PaymentDueDate
    {
        get
        {
            if (__PaymentDueDate == null) { __PaymentDueDate = new DateType(); }
            return __PaymentDueDate;
        }
        set
        {
            __PaymentDueDate = value;
        }
    }

        
    /// <summary>
    /// The due date for an installment payment for these payment terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Installment Due Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Installment Due Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType InstallmentDueDate
    {
        get
        {
            if (__InstallmentDueDate == null) { __InstallmentDueDate = new DateType(); }
            return __InstallmentDueDate;
        }
        set
        {
            __InstallmentDueDate = value;
        }
    }

        
    /// <summary>
    /// A reference to the payment terms used by the invoicing party. This may have been requested of the payer by the payee to accompany its remittance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Terms. Invoicing Party_ Reference. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Invoicing Party
    /// <para />PropertyTerm: Reference
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType InvoicingPartyReference
    {
        get
        {
            if (__InvoicingPartyReference == null) { __InvoicingPartyReference = new TextType(); }
            return __InvoicingPartyReference;
        }
        set
        {
            __InvoicingPartyReference = value;
        }
    }

        
    /// <summary>
    /// The period during which settlement may occur.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Terms. Settlement_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Settlement
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType SettlementPeriod
    {
        get
        {
            if (__SettlementPeriod == null) { __SettlementPeriod = new PeriodType(); }
            return __SettlementPeriod;
        }
        set
        {
            __SettlementPeriod = value;
        }
    }

        
    /// <summary>
    /// The period during which penalties may apply.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Terms. Penalty_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTermQualifier: Penalty
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType PenaltyPeriod
    {
        get
        {
            if (__PenaltyPeriod == null) { __PenaltyPeriod = new PeriodType(); }
            return __PenaltyPeriod;
        }
        set
        {
            __PenaltyPeriod = value;
        }
    }

        
    /// <summary>
    /// The currency exchange rate for purposes of these payment terms.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Terms. Exchange Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
    /// <para />PropertyTerm: Exchange Rate
    /// <para />AssociatedObjectClass: Exchange Rate
    /// <para />RepresentationTerm: Exchange Rate
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ExchangeRateType ExchangeRate
    {
        get
        {
            if (__ExchangeRate == null) { __ExchangeRate = new ExchangeRateType(); }
            return __ExchangeRate;
        }
        set
        {
            __ExchangeRate = value;
        }
    }

        
    /// <summary>
    /// The period during which these payment terms are valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Terms. Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Terms
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

}