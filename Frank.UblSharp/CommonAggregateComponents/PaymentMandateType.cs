using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a payment mandate.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Payment Mandate. Details
/// <para />ObjectClass: Payment Mandate
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PaymentMandateType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MandateTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__MandateTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumPaymentInstructionsNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public NumericType @__MaximumPaymentInstructionsNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumPaidAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__MaximumPaidAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SignatureID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__SignatureID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayerParty", Order=5)]
    public PartyType @__PayerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayerFinancialAccount", Order=6)]
    public FinancialAccountType @__PayerFinancialAccount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=7)]
    public PeriodType @__ValidityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentReversalPeriod", Order=8)]
    public PeriodType @__PaymentReversalPeriod;
        
    private System.Collections.Generic.List<ClauseType> _clause;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Clause", Order=9)]
    public ClauseType[] @__Clause
    {
        get
        {
            return _clause?.ToArray();
        }
        set
        {
            _clause = value == null ? null : new System.Collections.Generic.List<ClauseType>(value);
        }
    }
        
    /// <summary>
    /// A clause applicable to this payment mandate.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Mandate. Clause
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTerm: Clause
    /// <para />AssociatedObjectClass: Clause
    /// <para />RepresentationTerm: Clause
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ClauseType> Clause
    {
        get { return _clause ?? (_clause = new System.Collections.Generic.List<ClauseType>()); }
        set { _clause = value; }
    }

        
    /// <summary>
    /// An identifier for this payment mandate.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Mandate. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
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
    /// A code signifying the type of this payment mandate.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Mandate. Mandate Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTerm: Mandate Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType MandateTypeCode
    {
        get
        {
            if (__MandateTypeCode == null) { __MandateTypeCode = new CodeType(); }
            return __MandateTypeCode;
        }
        set
        {
            __MandateTypeCode = value;
        }
    }

        
    /// <summary>
    /// The number of maximum payment instructions allowed within the validity period.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Mandate. Maximum Payment Instructions. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTerm: Maximum Payment Instructions
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType MaximumPaymentInstructionsNumeric
    {
        get
        {
            if (__MaximumPaymentInstructionsNumeric == null) { __MaximumPaymentInstructionsNumeric = new NumericType(); }
            return __MaximumPaymentInstructionsNumeric;
        }
        set
        {
            __MaximumPaymentInstructionsNumeric = value;
        }
    }

        
    /// <summary>
    /// The maximum amount to be paid within a single instruction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Mandate. Maximum_ Paid Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Paid Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MaximumPaidAmount
    {
        get
        {
            if (__MaximumPaidAmount == null) { __MaximumPaidAmount = new AmountType(); }
            return __MaximumPaidAmount;
        }
        set
        {
            __MaximumPaidAmount = value;
        }
    }

        
    /// <summary>
    /// An identifier for a signature applied by a signatory party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Payment Mandate. Signature Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTerm: Signature Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SignatureID
    {
        get
        {
            if (__SignatureID == null) { __SignatureID = new IdentifierType(); }
            return __SignatureID;
        }
        set
        {
            __SignatureID = value;
        }
    }

        
    /// <summary>
    /// The payer party (if different from the debtor).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Mandate. Payer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTermQualifier: Payer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType PayerParty
    {
        get
        {
            if (__PayerParty == null) { __PayerParty = new PartyType(); }
            return __PayerParty;
        }
        set
        {
            __PayerParty = value;
        }
    }

        
    /// <summary>
    /// The payer&apos;s financial account.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Mandate. Payer_ Financial Account. Financial Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTermQualifier: Payer
    /// <para />PropertyTerm: Financial Account
    /// <para />AssociatedObjectClass: Financial Account
    /// <para />RepresentationTerm: Financial Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public FinancialAccountType PayerFinancialAccount
    {
        get
        {
            if (__PayerFinancialAccount == null) { __PayerFinancialAccount = new FinancialAccountType(); }
            return __PayerFinancialAccount;
        }
        set
        {
            __PayerFinancialAccount = value;
        }
    }

        
    /// <summary>
    /// The period during which this mandate is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Mandate. Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
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
    /// The period of the reverse payment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Payment Mandate. Payment Reversal_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Payment Mandate
    /// <para />PropertyTermQualifier: Payment Reversal
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType PaymentReversalPeriod
    {
        get
        {
            if (__PaymentReversalPeriod == null) { __PaymentReversalPeriod = new PeriodType(); }
            return __PaymentReversalPeriod;
        }
        set
        {
            __PaymentReversalPeriod = value;
        }
    }

}