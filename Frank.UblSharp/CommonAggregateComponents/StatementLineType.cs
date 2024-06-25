using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Statement of account.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Statement Line. Details
/// <para />ObjectClass: Statement Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("StatementLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("StatementLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class StatementLineType
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
    [System.Xml.Serialization.XmlElementAttribute("BalanceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__BalanceAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__PaymentPurposeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Order=8)]
    public PaymentMeansType @__PaymentMeans;
        
    private System.Collections.Generic.List<PaymentTermsType> _paymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Order=9)]
    public PaymentTermsType[] @__PaymentTerms
    {
        get
        {
            return _paymentTerms?.ToArray();
        }
        set
        {
            _paymentTerms = value == null ? null : new System.Collections.Generic.List<PaymentTermsType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuyerCustomerParty", Order=10)]
    public CustomerPartyType @__BuyerCustomerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerSupplierParty", Order=11)]
    public SupplierPartyType @__SellerSupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Order=12)]
    public CustomerPartyType @__OriginatorCustomerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCustomerParty", Order=13)]
    public CustomerPartyType @__AccountingCustomerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingSupplierParty", Order=14)]
    public SupplierPartyType @__AccountingSupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PayeeParty", Order=15)]
    public PartyType @__PayeeParty;
        
    private System.Collections.Generic.List<PeriodType> _invoicePeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Order=16)]
    public PeriodType[] @__InvoicePeriod
    {
        get
        {
            return _invoicePeriod?.ToArray();
        }
        set
        {
            _invoicePeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
        }
    }
        
    private System.Collections.Generic.List<BillingReferenceType> _billingReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BillingReference", Order=17)]
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
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=18)]
    public DocumentReferenceType[] @__DocumentReference
    {
        get
        {
            return _documentReference?.ToArray();
        }
        set
        {
            _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Order=19)]
    public ExchangeRateType @__ExchangeRate;
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=20)]
    public AllowanceChargeType[] @__AllowanceCharge
    {
        get
        {
            return _allowanceCharge?.ToArray();
        }
        set
        {
            _allowanceCharge = value == null ? null : new System.Collections.Generic.List<AllowanceChargeType>(value);
        }
    }
        
    private System.Collections.Generic.List<PaymentType> _collectedPayment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CollectedPayment", Order=21)]
    public PaymentType[] @__CollectedPayment
    {
        get
        {
            return _collectedPayment?.ToArray();
        }
        set
        {
            _collectedPayment = value == null ? null : new System.Collections.Generic.List<PaymentType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Statement Line
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
    /// A specification of payment terms associated with this statement line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Payment Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PaymentTermsType> PaymentTerms
    {
        get { return _paymentTerms ?? (_paymentTerms = new System.Collections.Generic.List<PaymentTermsType>()); }
        set { _paymentTerms = value; }
    }

        
    /// <summary>
    /// An invoice period to which this statement line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Invoice_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Invoice
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PeriodType> InvoicePeriod
    {
        get { return _invoicePeriod ?? (_invoicePeriod = new System.Collections.Generic.List<PeriodType>()); }
        set { _invoicePeriod = value; }
    }

        
    /// <summary>
    /// A reference to a billing document associated with this statement line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Billing Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Statement Line
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
    /// A reference to a document associated with this statement line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
    {
        get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _documentReference = value; }
    }

        
    /// <summary>
    /// A charge or discount price component associated with this statement line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AllowanceChargeType> AllowanceCharge
    {
        get { return _allowanceCharge ?? (_allowanceCharge = new System.Collections.Generic.List<AllowanceChargeType>()); }
        set { _allowanceCharge = value; }
    }

        
    /// <summary>
    /// A collected payment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Collected_ Payment. Payment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Collected
    /// <para />PropertyTerm: Payment
    /// <para />AssociatedObjectClass: Payment
    /// <para />RepresentationTerm: Payment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PaymentType> CollectedPayment
    {
        get { return _collectedPayment ?? (_collectedPayment = new System.Collections.Generic.List<PaymentType>()); }
        set { _collectedPayment = value; }
    }

        
    /// <summary>
    /// An identifier for this statement line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Statement Line
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
    /// A universally unique identifier for this statement line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
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
    /// An indication that this statement line contains an outstanding balance from the previous bill(s) (true) or does not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. Balance Brought Forward_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
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
    /// The amount debited on this statement line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. Debit_ Line Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
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
    /// The amount credited on this statement line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. Credit_ Line Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
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
    /// The balance amount on this statement line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. Balance Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTerm: Balance Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType BalanceAmount
    {
        get
        {
            if (__BalanceAmount == null) { __BalanceAmount = new AmountType(); }
            return __BalanceAmount;
        }
        set
        {
            __BalanceAmount = value;
        }
    }

        
    /// <summary>
    /// A code signifying the business purpose for this payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Statement Line. Payment Purpose Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
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
    /// A means of payment associated with this statement line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Payment Means
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTerm: Payment Means
    /// <para />AssociatedObjectClass: Payment Means
    /// <para />RepresentationTerm: Payment Means
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentMeansType PaymentMeans
    {
        get
        {
            if (__PaymentMeans == null) { __PaymentMeans = new PaymentMeansType(); }
            return __PaymentMeans;
        }
        set
        {
            __PaymentMeans = value;
        }
    }

        
    /// <summary>
    /// The buyer associated with this statement line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Buyer_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Buyer
    /// <para />PropertyTerm: Customer Party
    /// <para />AssociatedObjectClass: Customer Party
    /// <para />RepresentationTerm: Customer Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CustomerPartyType BuyerCustomerParty
    {
        get
        {
            if (__BuyerCustomerParty == null) { __BuyerCustomerParty = new CustomerPartyType(); }
            return __BuyerCustomerParty;
        }
        set
        {
            __BuyerCustomerParty = value;
        }
    }

        
    /// <summary>
    /// The seller/supplier associated with this statement line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Seller_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Seller
    /// <para />PropertyTerm: Supplier Party
    /// <para />AssociatedObjectClass: Supplier Party
    /// <para />RepresentationTerm: Supplier Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SupplierPartyType SellerSupplierParty
    {
        get
        {
            if (__SellerSupplierParty == null) { __SellerSupplierParty = new SupplierPartyType(); }
            return __SellerSupplierParty;
        }
        set
        {
            __SellerSupplierParty = value;
        }
    }

        
    /// <summary>
    /// The originating party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Originator_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Originator
    /// <para />PropertyTerm: Customer Party
    /// <para />AssociatedObjectClass: Customer Party
    /// <para />RepresentationTerm: Customer Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CustomerPartyType OriginatorCustomerParty
    {
        get
        {
            if (__OriginatorCustomerParty == null) { __OriginatorCustomerParty = new CustomerPartyType(); }
            return __OriginatorCustomerParty;
        }
        set
        {
            __OriginatorCustomerParty = value;
        }
    }

        
    /// <summary>
    /// The Accounting Customer Party related to the statement information reported on this Statement Line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Accounting_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Accounting
    /// <para />PropertyTerm: Customer Party
    /// <para />AssociatedObjectClass: Customer Party
    /// <para />RepresentationTerm: Customer Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CustomerPartyType AccountingCustomerParty
    {
        get
        {
            if (__AccountingCustomerParty == null) { __AccountingCustomerParty = new CustomerPartyType(); }
            return __AccountingCustomerParty;
        }
        set
        {
            __AccountingCustomerParty = value;
        }
    }

        
    /// <summary>
    /// The Accounting Supplier Party related to the statement information reported on this Statement Line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Accounting_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Accounting
    /// <para />PropertyTerm: Supplier Party
    /// <para />AssociatedObjectClass: Supplier Party
    /// <para />RepresentationTerm: Supplier Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public SupplierPartyType AccountingSupplierParty
    {
        get
        {
            if (__AccountingSupplierParty == null) { __AccountingSupplierParty = new SupplierPartyType(); }
            return __AccountingSupplierParty;
        }
        set
        {
            __AccountingSupplierParty = value;
        }
    }

        
    /// <summary>
    /// The payee.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Payee_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
    /// <para />PropertyTermQualifier: Payee
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType PayeeParty
    {
        get
        {
            if (__PayeeParty == null) { __PayeeParty = new PartyType(); }
            return __PayeeParty;
        }
        set
        {
            __PayeeParty = value;
        }
    }

        
    /// <summary>
    /// The rate of exchange between the currency of the Statement and the currency of the document described in the BillingReference.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Statement Line. Exchange Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Statement Line
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