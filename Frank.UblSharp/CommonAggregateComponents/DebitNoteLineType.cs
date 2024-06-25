using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Debit Note.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Debit Note Line. Details
/// <para />ObjectClass: Debit Note Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DebitNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DebitNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DebitNoteLineType
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
    [System.Xml.Serialization.XmlElementAttribute("DebitedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__DebitedQuantity;
        
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
        
    private System.Collections.Generic.List<ResponseType> _discrepancyResponse;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse", Order=9)]
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
    [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference", Order=10)]
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
    [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference", Order=11)]
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
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=13)]
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
    [System.Xml.Serialization.XmlElementAttribute("PricingReference", Order=14)]
    public PricingReferenceType @__PricingReference;
        
    private System.Collections.Generic.List<DeliveryType> _delivery;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=15)]
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
        
    private System.Collections.Generic.List<TaxTotalType> _taxTotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=16)]
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
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=17)]
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
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=18)]
    public ItemType @__Item;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Price", Order=19)]
    public PriceType @__Price;
        
    private System.Collections.Generic.List<DebitNoteLineType> _subDebitNoteLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubDebitNoteLine", Order=20)]
    public DebitNoteLineType[] @__SubDebitNoteLine
    {
        get
        {
            return _subDebitNoteLine?.ToArray();
        }
        set
        {
            _subDebitNoteLine = value == null ? null : new System.Collections.Generic.List<DebitNoteLineType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A reason for the debit.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Discrepancy_ Response. Response
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A reference to a despatch line associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Despatch_ Line Reference. Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A reference to a receipt line associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Receipt_ Line Reference. Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A reference to a billing document associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Billing Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A reference to a document associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A delivery associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Delivery
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A total amount of taxes of a particular kind applicable to this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// An allowance or charge associated with this debit note.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
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
    /// A recursive description of a debit note line subsidiary to this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Sub_ Debit Note Line. Debit Note Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Debit Note Line
    /// <para />PropertyTermQualifier: Sub
    /// <para />PropertyTerm: Debit Note Line
    /// <para />AssociatedObjectClass: Debit Note Line
    /// <para />RepresentationTerm: Debit Note Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DebitNoteLineType> SubDebitNoteLine
    {
        get { return _subDebitNoteLine ?? (_subDebitNoteLine = new System.Collections.Generic.List<DebitNoteLineType>()); }
        set { _subDebitNoteLine = value; }
    }

        
    /// <summary>
    /// An identifier for this debit note line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Debit Note Line
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
    /// A universally unique identifier for this debit note line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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
    /// The quantity of Items debited in this debit note line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. Debited_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
    /// <para />PropertyTermQualifier: Debited
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType DebitedQuantity
    {
        get
        {
            if (__DebitedQuantity == null) { __DebitedQuantity = new QuantityType(); }
            return __DebitedQuantity;
        }
        set
        {
            __DebitedQuantity = value;
        }
    }

        
    /// <summary>
    /// The total amount for this debit note line, including allowance charges but net of taxes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. Line Extension Amount. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Debit Note Line
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
    /// The date of this debit note line, used to indicate the point at which tax becomes applicable.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. Tax Point Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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
    /// The buyer&apos;s accounting cost centre for this debit note line, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. Accounting Cost Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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
    /// The buyer&apos;s accounting cost centre for this debit note line, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Debit Note Line. Accounting Cost. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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
    /// <para />DictionaryEntryName: Debit Note Line. Payment Purpose Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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
    /// A reference to pricing and item location information associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Pricing Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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
    /// The item associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Item
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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
    /// The price of the item associated with this debit note line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Debit Note Line. Price
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Debit Note Line
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

}