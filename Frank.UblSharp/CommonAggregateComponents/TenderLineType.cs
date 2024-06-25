using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Tender.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tender Line. Details
/// <para />ObjectClass: Tender Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SubTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SubTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TenderLineType
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
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__LineExtensionAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalTaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__TotalTaxAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderableUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType @__OrderableUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContentUnitQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public QuantityType @__ContentUnitQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderQuantityIncrementNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public NumericType @__OrderQuantityIncrementNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumOrderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public QuantityType @__MinimumOrderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumOrderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__MaximumOrderQuantity;
        
    private System.Collections.Generic.List<TextType> _warrantyInformation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public TextType[] @__WarrantyInformation
    {
        get
        {
            return _warrantyInformation?.ToArray();
        }
        set
        {
            _warrantyInformation = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public CodeType @__PackLevelCode;
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=12)]
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
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=13)]
    public ItemType @__Item;
        
    private System.Collections.Generic.List<ItemLocationQuantityType> _offeredItemLocationQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OfferedItemLocationQuantity", Order=14)]
    public ItemLocationQuantityType[] @__OfferedItemLocationQuantity
    {
        get
        {
            return _offeredItemLocationQuantity?.ToArray();
        }
        set
        {
            _offeredItemLocationQuantity = value == null ? null : new System.Collections.Generic.List<ItemLocationQuantityType>(value);
        }
    }
        
    private System.Collections.Generic.List<RelatedItemType> _replacementRelatedItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem", Order=15)]
    public RelatedItemType[] @__ReplacementRelatedItem
    {
        get
        {
            return _replacementRelatedItem?.ToArray();
        }
        set
        {
            _replacementRelatedItem = value == null ? null : new System.Collections.Generic.List<RelatedItemType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyParty", Order=16)]
    public PartyType @__WarrantyParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyValidityPeriod", Order=17)]
    public PeriodType @__WarrantyValidityPeriod;
        
    private System.Collections.Generic.List<TenderLineType> _subTenderLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubTenderLine", Order=18)]
    public TenderLineType[] @__SubTenderLine
    {
        get
        {
            return _subTenderLine?.ToArray();
        }
        set
        {
            _subTenderLine = value == null ? null : new System.Collections.Generic.List<TenderLineType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallForTendersLineReference", Order=19)]
    public LineReferenceType @__CallForTendersLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CallForTendersDocumentReference", Order=20)]
    public DocumentReferenceType @__CallForTendersDocumentReference;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Line
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
    /// Text about a warranty (provided by WarrantyParty) for the good or service described in this tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Warranty_ Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Warranty
    /// <para />PropertyTerm: Information
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Unless specified otherwise and in addition to any rights the Customer may have under statute, Dell warrants to the Customer that Dell branded Products (excluding third party products and software), will be free from defects in materials and workmanship affecting normal use for a period of one year from invoice date ( Standard Warranty ).</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> WarrantyInformation
    {
        get { return _warrantyInformation ?? (_warrantyInformation = new System.Collections.Generic.List<TextType>()); }
        set { _warrantyInformation = value; }
    }

        
    /// <summary>
    /// A reference to a document associated with this tender line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Line
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
    /// A set of location-specific properties (e.g., price, quantity, lead time) associated with the item described in this tender line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Offered_ Item Location Quantity. Item Location Quantity
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Offered
    /// <para />PropertyTerm: Item Location Quantity
    /// <para />AssociatedObjectClass: Item Location Quantity
    /// <para />RepresentationTerm: Item Location Quantity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemLocationQuantityType> OfferedItemLocationQuantity
    {
        get { return _offeredItemLocationQuantity ?? (_offeredItemLocationQuantity = new System.Collections.Generic.List<ItemLocationQuantityType>()); }
        set { _offeredItemLocationQuantity = value; }
    }

        
    /// <summary>
    /// A catalogue item that may be a replacement for the item described in this tender line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Replacement_ Related Item. Related Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Replacement
    /// <para />PropertyTerm: Related Item
    /// <para />AssociatedObjectClass: Related Item
    /// <para />RepresentationTerm: Related Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RelatedItemType> ReplacementRelatedItem
    {
        get { return _replacementRelatedItem ?? (_replacementRelatedItem = new System.Collections.Generic.List<RelatedItemType>()); }
        set { _replacementRelatedItem = value; }
    }

        
    /// <summary>
    /// An association to a Sub Tender Line
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Sub_ Tender Line. Tender Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Sub
    /// <para />PropertyTerm: Tender Line
    /// <para />AssociatedObjectClass: Tender Line
    /// <para />RepresentationTerm: Tender Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TenderLineType> SubTenderLine
    {
        get { return _subTenderLine ?? (_subTenderLine = new System.Collections.Generic.List<TenderLineType>()); }
        set { _subTenderLine = value; }
    }

        
    /// <summary>
    /// An identifier for this tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
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
    /// The quantity of the item quoted in this tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
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
    /// The total amount for this tender line, including allowance charges but net of taxes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Line Extension Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
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
    /// The total tax amount for this tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Total_ Tax Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Tax Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TotalTaxAmount
    {
        get
        {
            if (__TotalTaxAmount == null) { __TotalTaxAmount = new AmountType(); }
            return __TotalTaxAmount;
        }
        set
        {
            __TotalTaxAmount = value;
        }
    }

        
    /// <summary>
    /// Text describing a unit in which the item described in this tender line can be ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Orderable_ Unit. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Orderable
    /// <para />PropertyTerm: Unit
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType OrderableUnit
    {
        get
        {
            if (__OrderableUnit == null) { __OrderableUnit = new TextType(); }
            return __OrderableUnit;
        }
        set
        {
            __OrderableUnit = value;
        }
    }

        
    /// <summary>
    /// The unit of measure and quantity of the orderable unit.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Content Unit. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTerm: Content Unit
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>If order unit measure identifier is each , then content unit quantity is 1 .</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ContentUnitQuantity
    {
        get
        {
            if (__ContentUnitQuantity == null) { __ContentUnitQuantity = new QuantityType(); }
            return __ContentUnitQuantity;
        }
        set
        {
            __ContentUnitQuantity = value;
        }
    }

        
    /// <summary>
    /// The number of items that can set the order quantity increments.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Order Quantity Increment. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTerm: Order Quantity Increment
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType OrderQuantityIncrementNumeric
    {
        get
        {
            if (__OrderQuantityIncrementNumeric == null) { __OrderQuantityIncrementNumeric = new NumericType(); }
            return __OrderQuantityIncrementNumeric;
        }
        set
        {
            __OrderQuantityIncrementNumeric = value;
        }
    }

        
    /// <summary>
    /// The minimum number of items described in this tender line that can be ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Minimum_ Order Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Order Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>10 boxes</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumOrderQuantity
    {
        get
        {
            if (__MinimumOrderQuantity == null) { __MinimumOrderQuantity = new QuantityType(); }
            return __MinimumOrderQuantity;
        }
        set
        {
            __MinimumOrderQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum number of items described in this tender line that can be ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Maximum_ Order Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Order Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>1 tonne</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumOrderQuantity
    {
        get
        {
            if (__MaximumOrderQuantity == null) { __MaximumOrderQuantity = new QuantityType(); }
            return __MaximumOrderQuantity;
        }
        set
        {
            __MaximumOrderQuantity = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code signifying the level of packaging associated with the item described in this tender line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Line. Pack Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTerm: Pack Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Consumer Unit, Trading Unit
    /// </summary>
    /// <example>level 2 , Group 4</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PackLevelCode
    {
        get
        {
            if (__PackLevelCode == null) { __PackLevelCode = new CodeType(); }
            return __PackLevelCode;
        }
        set
        {
            __PackLevelCode = value;
        }
    }

        
    /// <summary>
    /// The item associated with this tender line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Item
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
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
    /// The party responsible for any warranty described in this tender line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Warranty_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Warranty
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType WarrantyParty
    {
        get
        {
            if (__WarrantyParty == null) { __WarrantyParty = new PartyType(); }
            return __WarrantyParty;
        }
        set
        {
            __WarrantyParty = value;
        }
    }

        
    /// <summary>
    /// The period for which a warranty associated with the item described in this tender line is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Warranty Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
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
    /// Reference to a Line on a Call For Tenders document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Call For Tenders_ Line Reference. Line Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Call For Tenders
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineReferenceType CallForTendersLineReference
    {
        get
        {
            if (__CallForTendersLineReference == null) { __CallForTendersLineReference = new LineReferenceType(); }
            return __CallForTendersLineReference;
        }
        set
        {
            __CallForTendersLineReference = value;
        }
    }

        
    /// <summary>
    /// A class defining references to a Call For Tenders document.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Line. Call For Tenders_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Line
    /// <para />PropertyTermQualifier: Call For Tenders
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType CallForTendersDocumentReference
    {
        get
        {
            if (__CallForTendersDocumentReference == null) { __CallForTendersDocumentReference = new DocumentReferenceType(); }
            return __CallForTendersDocumentReference;
        }
        set
        {
            __CallForTendersDocumentReference = value;
        }
    }

}