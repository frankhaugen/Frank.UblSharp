using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Credit Note or Self Billed Credit Note.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Credit Note Line. Details
/// <para />ObjectClass: Credit Note Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CreditNoteLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__UUID;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute("CreditedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__CreditedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__LineExtensionAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxPointDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public DateType @__TaxPointDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__AccountingCostCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__AccountingCost;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentPurposeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public CodeType @__PaymentPurposeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreeOfChargeIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IndicatorType @__FreeOfChargeIndicator;
        
    private System.Collections.Generic.List<PeriodType> _invoicePeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Order=10)]
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
        
    private System.Collections.Generic.List<OrderLineReferenceType> _orderLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderLineReference", Order=11)]
    public OrderLineReferenceType[] @__OrderLineReference
    {
        get
        {
            return _orderLineReference?.ToArray();
        }
        set
        {
            _orderLineReference = value == null ? null : new System.Collections.Generic.List<OrderLineReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<ResponseType> _discrepancyResponse;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse", Order=12)]
    public ResponseType[] @__DiscrepancyResponse
    {
        get
        {
            return _discrepancyResponse?.ToArray();
        }
        set
        {
            _discrepancyResponse = value == null ? null : new System.Collections.Generic.List<ResponseType>(value);
        }
    }
        
    private System.Collections.Generic.List<LineReferenceType> _despatchLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference", Order=13)]
    public LineReferenceType[] @__DespatchLineReference
    {
        get
        {
            return _despatchLineReference?.ToArray();
        }
        set
        {
            _despatchLineReference = value == null ? null : new System.Collections.Generic.List<LineReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<LineReferenceType> _receiptLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference", Order=14)]
    public LineReferenceType[] @__ReceiptLineReference
    {
        get
        {
            return _receiptLineReference?.ToArray();
        }
        set
        {
            _receiptLineReference = value == null ? null : new System.Collections.Generic.List<LineReferenceType>(value);
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
    [System.Xml.Serialization.XmlElementAttribute("PricingReference", Order=17)]
    public PricingReferenceType @__PricingReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginatorParty", Order=18)]
    public PartyType @__OriginatorParty;
        
    private System.Collections.Generic.List<DeliveryType> _delivery;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=19)]
    public DeliveryType[] @__Delivery
    {
        get
        {
            return _delivery?.ToArray();
        }
        set
        {
            _delivery = value == null ? null : new System.Collections.Generic.List<DeliveryType>(value);
        }
    }
        
    private System.Collections.Generic.List<PaymentTermsType> _paymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Order=20)]
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
        
    private System.Collections.Generic.List<TaxTotalType> _taxTotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=21)]
    public TaxTotalType[] @__TaxTotal
    {
        get
        {
            return _taxTotal?.ToArray();
        }
        set
        {
            _taxTotal = value == null ? null : new System.Collections.Generic.List<TaxTotalType>(value);
        }
    }
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=22)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=23)]
    public ItemType @__Item;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Price", Order=24)]
    public PriceType @__Price;
        
    private System.Collections.Generic.List<DeliveryTermsType> _deliveryTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Order=25)]
    public DeliveryTermsType[] @__DeliveryTerms
    {
        get
        {
            return _deliveryTerms?.ToArray();
        }
        set
        {
            _deliveryTerms = value == null ? null : new System.Collections.Generic.List<DeliveryTermsType>(value);
        }
    }
        
    private System.Collections.Generic.List<CreditNoteLineType> _subCreditNoteLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubCreditNoteLine", Order=26)]
    public CreditNoteLineType[] @__SubCreditNoteLine
    {
        get
        {
            return _subCreditNoteLine?.ToArray();
        }
        set
        {
            _subCreditNoteLine = value == null ? null : new System.Collections.Generic.List<CreditNoteLineType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemPriceExtension", Order=27)]
    public PriceExtensionType @__ItemPriceExtension;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
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
    /// An invoice period to which this credit note line applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Invoice_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
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
    /// A reference to an order line associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Order Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Order Line Reference
    /// <para />AssociatedObjectClass: Order Line Reference
    /// <para />RepresentationTerm: Order Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<OrderLineReferenceType> OrderLineReference
    {
        get { return _orderLineReference ?? (_orderLineReference = new System.Collections.Generic.List<OrderLineReferenceType>()); }
        set { _orderLineReference = value; }
    }

        
    /// <summary>
    /// A reason for the credit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Discrepancy_ Response. Response
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Discrepancy
    /// <para />PropertyTerm: Response
    /// <para />AssociatedObjectClass: Response
    /// <para />RepresentationTerm: Response
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ResponseType> DiscrepancyResponse
    {
        get { return _discrepancyResponse ?? (_discrepancyResponse = new System.Collections.Generic.List<ResponseType>()); }
        set { _discrepancyResponse = value; }
    }

        
    /// <summary>
    /// A reference to a despatch line associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Despatch_ Line Reference. Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Despatch
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineReferenceType> DespatchLineReference
    {
        get { return _despatchLineReference ?? (_despatchLineReference = new System.Collections.Generic.List<LineReferenceType>()); }
        set { _despatchLineReference = value; }
    }

        
    /// <summary>
    /// A reference to a receipt line associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Receipt_ Line Reference. Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Receipt
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineReferenceType> ReceiptLineReference
    {
        get { return _receiptLineReference ?? (_receiptLineReference = new System.Collections.Generic.List<LineReferenceType>()); }
        set { _receiptLineReference = value; }
    }

        
    /// <summary>
    /// A reference to a billing document associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Billing Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
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
    /// A reference to a document associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
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
    /// A delivery associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Delivery
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Delivery
    /// <para />AssociatedObjectClass: Delivery
    /// <para />RepresentationTerm: Delivery
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DeliveryType> Delivery
    {
        get { return _delivery ?? (_delivery = new System.Collections.Generic.List<DeliveryType>()); }
        set { _delivery = value; }
    }

        
    /// <summary>
    /// A specification of payment terms associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Payment Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
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
    /// A total amount of taxes of a particular kind applicable to this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Tax Total
    /// <para />AssociatedObjectClass: Tax Total
    /// <para />RepresentationTerm: Tax Total
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TaxTotalType> TaxTotal
    {
        get { return _taxTotal ?? (_taxTotal = new System.Collections.Generic.List<TaxTotalType>()); }
        set { _taxTotal = value; }
    }

        
    /// <summary>
    /// An allowance or charge associated with this credit note.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
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
    /// Terms and conditions of a delivery associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Delivery Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Delivery Terms
    /// <para />AssociatedObjectClass: Delivery Terms
    /// <para />RepresentationTerm: Delivery Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DeliveryTermsType> DeliveryTerms
    {
        get { return _deliveryTerms ?? (_deliveryTerms = new System.Collections.Generic.List<DeliveryTermsType>()); }
        set { _deliveryTerms = value; }
    }

        
    /// <summary>
    /// A class defining one or more Credit Note Lines detailing the credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Sub_ Credit Note Line. Credit Note Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Sub
    /// <para />PropertyTerm: Credit Note Line
    /// <para />AssociatedObjectClass: Credit Note Line
    /// <para />RepresentationTerm: Credit Note Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CreditNoteLineType> SubCreditNoteLine
    {
        get { return _subCreditNoteLine ?? (_subCreditNoteLine = new System.Collections.Generic.List<CreditNoteLineType>()); }
        set { _subCreditNoteLine = value; }
    }

        
    /// <summary>
    /// An identifier for this credit note line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Credit Note Line
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
    /// A universally unique identifier for this credit note line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
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
    /// The quantity of items credited in this credit note line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Credited_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Credited
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType CreditedQuantity
    {
        get
        {
            if (__CreditedQuantity == null) { __CreditedQuantity = new QuantityType(); }
            return __CreditedQuantity;
        }
        set
        {
            __CreditedQuantity = value;
        }
    }

        
    /// <summary>
    /// The total amount for this credit note line, including allowance charges but exclusive of taxes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Line Extension Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Line Extension Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType LineExtensionAmount
    {
        get
        {
            if (__LineExtensionAmount == null) { __LineExtensionAmount = new AmountType(); }
            return __LineExtensionAmount;
        }
        set
        {
            __LineExtensionAmount = value;
        }
    }

        
    /// <summary>
    /// The date of this credit note line, used to indicate the point at which tax becomes applicable.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Tax Point Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Tax Point Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType TaxPointDate
    {
        get
        {
            if (__TaxPointDate == null) { __TaxPointDate = new DateType(); }
            return __TaxPointDate;
        }
        set
        {
            __TaxPointDate = value;
        }
    }

        
    /// <summary>
    /// The buyer&apos;s accounting cost centre for this credit note line, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Accounting Cost Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
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
    /// The buyer&apos;s accounting cost centre for this credit note line, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Accounting Cost. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
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
    /// A code signifying the business purpose for this payment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Payment Purpose Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
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
    /// An indicator that this credit note line is free of charge (true) or not (false). The default is false.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Credit Note Line. Free Of Charge_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Free Of Charge
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType FreeOfChargeIndicator
    {
        get
        {
            if (__FreeOfChargeIndicator == null) { __FreeOfChargeIndicator = new IndicatorType(); }
            return __FreeOfChargeIndicator;
        }
        set
        {
            __FreeOfChargeIndicator = value;
        }
    }

        
    /// <summary>
    /// A reference to pricing and item location information associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Pricing Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Pricing Reference
    /// <para />AssociatedObjectClass: Pricing Reference
    /// <para />RepresentationTerm: Pricing Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PricingReferenceType PricingReference
    {
        get
        {
            if (__PricingReference == null) { __PricingReference = new PricingReferenceType(); }
            return __PricingReference;
        }
        set
        {
            __PricingReference = value;
        }
    }

        
    /// <summary>
    /// The party who originated the Order to which the Credit Note is related.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Originator_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Originator
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType OriginatorParty
    {
        get
        {
            if (__OriginatorParty == null) { __OriginatorParty = new PartyType(); }
            return __OriginatorParty;
        }
        set
        {
            __OriginatorParty = value;
        }
    }

        
    /// <summary>
    /// The item associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Item
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemType Item
    {
        get
        {
            if (__Item == null) { __Item = new ItemType(); }
            return __Item;
        }
        set
        {
            __Item = value;
        }
    }

        
    /// <summary>
    /// The price of the item associated with this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Price
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTerm: Price
    /// <para />AssociatedObjectClass: Price
    /// <para />RepresentationTerm: Price
    /// <para />AlternativeBusinessTerms: Unit Price, Base Price
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PriceType Price
    {
        get
        {
            if (__Price == null) { __Price = new PriceType(); }
            return __Price;
        }
        set
        {
            __Price = value;
        }
    }

        
    /// <summary>
    /// The price extension, calculated by multiplying the price per unit by the quantity of items on this credit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Credit Note Line. Item_ Price Extension. Price Extension
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Credit Note Line
    /// <para />PropertyTermQualifier: Item
    /// <para />PropertyTerm: Price Extension
    /// <para />AssociatedObjectClass: Price Extension
    /// <para />RepresentationTerm: Price Extension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PriceExtensionType ItemPriceExtension
    {
        get
        {
            if (__ItemPriceExtension == null) { __ItemPriceExtension = new PriceExtensionType(); }
            return __ItemPriceExtension;
        }
        set
        {
            __ItemPriceExtension = value;
        }
    }

}