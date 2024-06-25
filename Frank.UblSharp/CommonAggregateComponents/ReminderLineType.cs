using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Reminder document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Reminder Line. Details
/// <para />ObjectClass: Reminder Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ReminderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ReminderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ReminderLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BalanceBroughtForwardIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IndicatorType @__BalanceBroughtForwardIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DebitLineAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__DebitLineAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CreditLineAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public AmountType @__CreditLineAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__AccountingCostCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__AccountingCost;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PenaltySurchargePercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public PercentType @__PenaltySurchargePercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public CodeType @__PaymentPurposeCode;
        
    private System.Collections.Generic.List<PeriodType> _reminderPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReminderPeriod", Order=11)]
    public PeriodType[] @__ReminderPeriod
    {
        get
        {
            return _reminderPeriod?.ToArray();
        }
        set
        {
            _reminderPeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
        }
    }
        
    private System.Collections.Generic.List<BillingReferenceType> _billingReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BillingReference", Order=12)]
    public BillingReferenceType[] @__BillingReference
    {
        get
        {
            return _billingReference?.ToArray();
        }
        set
        {
            _billingReference = value == null ? null : new System.Collections.Generic.List<BillingReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Order=13)]
    public ExchangeRateType @__ExchangeRate;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Reminder Line
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
    /// A period to which this reminder line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Reminder Line. Reminder_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTermQualifier: Reminder
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PeriodType> ReminderPeriod
    {
        get { return _reminderPeriod ?? (_reminderPeriod = new System.Collections.Generic.List<PeriodType>()); }
        set { _reminderPeriod = value; }
    }

        
    /// <summary>
    /// A reference to a billing document associated with this reminder line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Reminder Line. Billing Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTerm: Billing Reference
    /// <para />AssociatedObjectClass: Billing Reference
    /// <para />RepresentationTerm: Billing Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<BillingReferenceType> BillingReference
    {
        get { return _billingReference ?? (_billingReference = new System.Collections.Generic.List<BillingReferenceType>()); }
        set { _billingReference = value; }
    }

        
    /// <summary>
    /// An identifier for this reminder line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Reminder Line
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
    /// A universally unique identifier for this reminder line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTerm: UUID
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType UUID
    {
        get
        {
            if (__UUID == null) { __UUID = new IdentifierType(); }
            return __UUID;
        }
        set
        {
            __UUID = value;
        }
    }

        
    /// <summary>
    /// An indication that this reminder line contains a balance brought forward (true) or does not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Balance Brought Forward_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTermQualifier: Balance Brought Forward
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType BalanceBroughtForwardIndicator
    {
        get
        {
            if (__BalanceBroughtForwardIndicator == null) { __BalanceBroughtForwardIndicator = new IndicatorType(); }
            return __BalanceBroughtForwardIndicator;
        }
        set
        {
            __BalanceBroughtForwardIndicator = value;
        }
    }

        
    /// <summary>
    /// The amount debited on this reminder line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Debit_ Line Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTermQualifier: Debit
    /// <para />PropertyTerm: Line Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType DebitLineAmount
    {
        get
        {
            if (__DebitLineAmount == null) { __DebitLineAmount = new AmountType(); }
            return __DebitLineAmount;
        }
        set
        {
            __DebitLineAmount = value;
        }
    }

        
    /// <summary>
    /// The amount credited on this reminder line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Credit_ Line Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTermQualifier: Credit
    /// <para />PropertyTerm: Line Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType CreditLineAmount
    {
        get
        {
            if (__CreditLineAmount == null) { __CreditLineAmount = new AmountType(); }
            return __CreditLineAmount;
        }
        set
        {
            __CreditLineAmount = value;
        }
    }

        
    /// <summary>
    /// The buyer&apos;s accounting cost centre for this reminder line, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Accounting Cost Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTerm: Accounting Cost Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AccountingCostCode
    {
        get
        {
            if (__AccountingCostCode == null) { __AccountingCostCode = new CodeType(); }
            return __AccountingCostCode;
        }
        set
        {
            __AccountingCostCode = value;
        }
    }

        
    /// <summary>
    /// The buyer&apos;s accounting cost centre for this reminder line, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Accounting Cost. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTerm: Accounting Cost
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType AccountingCost
    {
        get
        {
            if (__AccountingCost == null) { __AccountingCost = new TextType(); }
            return __AccountingCost;
        }
        set
        {
            __AccountingCost = value;
        }
    }

        
    /// <summary>
    /// The penalty for late payment, expressed as a percentage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Penalty_ Surcharge Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
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
    /// The amount on this reminder line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
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
    /// A code signifying the business purpose for this payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Reminder Line. Payment Purpose Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
    /// <para />PropertyTerm: Payment Purpose Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PaymentPurposeCode
    {
        get
        {
            if (__PaymentPurposeCode == null) { __PaymentPurposeCode = new CodeType(); }
            return __PaymentPurposeCode;
        }
        set
        {
            __PaymentPurposeCode = value;
        }
    }

        
    /// <summary>
    /// The rate of exchange between the currency of the Reminder and the currency of the document described in the BillingReference.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Reminder Line. Exchange Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Reminder Line
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

}