using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Request for Tender describing an item of goods or a service solicited in the Request for Tender.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Request For Tender Line. Details
/// <para />ObjectClass: Request For Tender Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RequestForTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RequestForTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RequestForTenderLineType
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
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__MinimumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__MaximumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxIncludedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IndicatorType @__TaxIncludedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public AmountType @__MinimumAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__MaximumAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public AmountType @__EstimatedAmount;
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=10)]
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
        
    private System.Collections.Generic.List<PeriodType> _deliveryPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryPeriod", Order=11)]
    public PeriodType[] @__DeliveryPeriod
    {
        get
        {
            return _deliveryPeriod?.ToArray();
        }
        set
        {
            _deliveryPeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
        }
    }
        
    private System.Collections.Generic.List<ItemLocationQuantityType> _requiredItemLocationQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity", Order=12)]
    public ItemLocationQuantityType[] @__RequiredItemLocationQuantity
    {
        get
        {
            return _requiredItemLocationQuantity?.ToArray();
        }
        set
        {
            _requiredItemLocationQuantity = value == null ? null : new System.Collections.Generic.List<ItemLocationQuantityType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyValidityPeriod", Order=13)]
    public PeriodType @__WarrantyValidityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=14)]
    public ItemType @__Item;
        
    private System.Collections.Generic.List<RequestForTenderLineType> _subRequestForTenderLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubRequestForTenderLine", Order=15)]
    public RequestForTenderLineType[] @__SubRequestForTenderLine
    {
        get
        {
            return _subRequestForTenderLine?.ToArray();
        }
        set
        {
            _subRequestForTenderLine = value == null ? null : new System.Collections.Generic.List<RequestForTenderLineType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Request For Tender Line
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
    /// A reference to a document associated with this request for tender line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Request For Tender Line
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
    /// An applicable period for the deliverable or set of deliverables in this tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Delivery_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PeriodType> DeliveryPeriod
    {
        get { return _deliveryPeriod ?? (_deliveryPeriod = new System.Collections.Generic.List<PeriodType>()); }
        set { _deliveryPeriod = value; }
    }

        
    /// <summary>
    /// Properties of the item specified in this request for tender line that are dependent on location and quantity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Required_ Item Location Quantity. Item Location Quantity
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Item Location Quantity
    /// <para />AssociatedObjectClass: Item Location Quantity
    /// <para />RepresentationTerm: Item Location Quantity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemLocationQuantityType> RequiredItemLocationQuantity
    {
        get { return _requiredItemLocationQuantity ?? (_requiredItemLocationQuantity = new System.Collections.Generic.List<ItemLocationQuantityType>()); }
        set { _requiredItemLocationQuantity = value; }
    }

        
    /// <summary>
    /// A subsidiary request for tender line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Sub_ Request For Tender Line. Request For Tender Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Sub
    /// <para />PropertyTerm: Request For Tender Line
    /// <para />AssociatedObjectClass: Request For Tender Line
    /// <para />RepresentationTerm: Request For Tender Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RequestForTenderLineType> SubRequestForTenderLine
    {
        get { return _subRequestForTenderLine ?? (_subRequestForTenderLine = new System.Collections.Generic.List<RequestForTenderLineType>()); }
        set { _subRequestForTenderLine = value; }
    }

        
    /// <summary>
    /// An identifier for this request for tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
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
    /// A universally unique identifier for this request for tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
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
    /// The quantity of the item for which a tender is requested in this line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// The minimum quantity of the item associated with this request for tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Minimum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumQuantity
    {
        get
        {
            if (__MinimumQuantity == null) { __MinimumQuantity = new QuantityType(); }
            return __MinimumQuantity;
        }
        set
        {
            __MinimumQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum quantity of the item associated with this request for tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Maximum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumQuantity
    {
        get
        {
            if (__MaximumQuantity == null) { __MaximumQuantity = new QuantityType(); }
            return __MaximumQuantity;
        }
        set
        {
            __MaximumQuantity = value;
        }
    }

        
    /// <summary>
    /// Indicates whether the amounts are taxes included (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Tax Included_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Tax Included
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType TaxIncludedIndicator
    {
        get
        {
            if (__TaxIncludedIndicator == null) { __TaxIncludedIndicator = new IndicatorType(); }
            return __TaxIncludedIndicator;
        }
        set
        {
            __TaxIncludedIndicator = value;
        }
    }

        
    /// <summary>
    /// The minimum amount allowed for this deliverable.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Minimum_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MinimumAmount
    {
        get
        {
            if (__MinimumAmount == null) { __MinimumAmount = new AmountType(); }
            return __MinimumAmount;
        }
        set
        {
            __MinimumAmount = value;
        }
    }

        
    /// <summary>
    /// The maximum amount allowed for this deliverable.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Maximum_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MaximumAmount
    {
        get
        {
            if (__MaximumAmount == null) { __MaximumAmount = new AmountType(); }
            return __MaximumAmount;
        }
        set
        {
            __MaximumAmount = value;
        }
    }

        
    /// <summary>
    /// The estimated total amount of the deliverable.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Estimated_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Estimated
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType EstimatedAmount
    {
        get
        {
            if (__EstimatedAmount == null) { __EstimatedAmount = new AmountType(); }
            return __EstimatedAmount;
        }
        set
        {
            __EstimatedAmount = value;
        }
    }

        
    /// <summary>
    /// The period during which a warranty to be associated with this request for tender line must apply.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Warranty Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Tender Line
    /// <para />PropertyTermQualifier: Warranty Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType WarrantyValidityPeriod
    {
        get
        {
            if (__WarrantyValidityPeriod == null) { __WarrantyValidityPeriod = new PeriodType(); }
            return __WarrantyValidityPeriod;
        }
        set
        {
            __WarrantyValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// An item for which a tender is requested.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Tender Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Request For Tender Line
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

}