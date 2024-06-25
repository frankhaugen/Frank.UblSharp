using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Remittance Advice.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Remittance Advice Line. Details
/// <para />ObjectClass: Remittance Advice Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RemittanceAdviceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RemittanceAdviceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RemittanceAdviceLineType
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
    [System.Xml.Serialization.XmlElementAttribute("DebitLineAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__DebitLineAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CreditLineAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__CreditLineAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BalanceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public AmountType @__BalanceAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__PaymentPurposeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoicingPartyReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__InvoicingPartyReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingSupplierParty", Order=8)]
    public SupplierPartyType @__AccountingSupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCustomerParty", Order=9)]
    public CustomerPartyType @__AccountingCustomerParty;
        
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
    [System.Xml.Serialization.XmlElementAttribute("PayeeParty", Order=13)]
    public PartyType @__PayeeParty;
        
    private System.Collections.Generic.List<PeriodType> _invoicePeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Order=14)]
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
    [System.Xml.Serialization.XmlElementAttribute("BillingReference", Order=15)]
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
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=16)]
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
    [System.Xml.Serialization.XmlElementAttribute("ExchangeRate", Order=17)]
    public ExchangeRateType @__ExchangeRate;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Remittance Advice Line
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
    /// An invoice period to which this remittance advice line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Invoice_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Remittance Advice Line
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
    /// A reference to a billing document associated with this remittance advice line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Billing Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Remittance Advice Line
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
    /// A reference to a document associated with this remittance advice line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Remittance Advice Line
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
    /// An identifier for this remittance advice line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// A universally unique identifier for this remittance advice line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The amount debited on this remittance advice line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Debit_ Line Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The amount credited on this remittance advice line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Credit_ Line Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The monetary balance associated with this remittance advice line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Balance Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// <para />DictionaryEntryName: Remittance Advice Line. Payment Purpose Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// A reference to the order for payment used by the invoicing party. This may have been requested of the payer by the payee to accompany its remittance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Invoicing Party_ Reference. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The Accounting Supplier Party related to the remittance information reported on this Remittance Advice Line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Accounting_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The Accounting Customer Party related to the remittance information reported on this Remittance Advice Line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Accounting_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The buyer associated with this remittance advice line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Buyer_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The seller/supplier associated with this remittance advice line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Seller_ Supplier Party. Supplier Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// <para />DictionaryEntryName: Remittance Advice Line. Originator_ Customer Party. Customer Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The payee.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Payee_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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
    /// The rate of exchange between the currency of the Remittance Advice and the currency of the document described in the BillingReference.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Remittance Advice Line. Exchange Rate
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Remittance Advice Line
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