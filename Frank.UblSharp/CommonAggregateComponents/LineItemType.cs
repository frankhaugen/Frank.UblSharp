using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a line item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Line Item. Details
/// <para />ObjectClass: Line Item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AlternativeLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AlternativeLineItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class LineItemType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SalesOrderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__SalesOrderID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__UUID;
        
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
    [System.Xml.Serialization.XmlElementAttribute("LineStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__LineStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__LineExtensionAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalTaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public AmountType @__TotalTaxAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public QuantityType @__MinimumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__MaximumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumBackorderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public QuantityType @__MinimumBackorderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumBackorderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public QuantityType @__MaximumBackorderQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InspectionMethodCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public CodeType @__InspectionMethodCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartialDeliveryIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public IndicatorType @__PartialDeliveryIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BackOrderAllowedIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public IndicatorType @__BackOrderAllowedIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public CodeType @__AccountingCostCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public TextType @__AccountingCost;
        
    private System.Collections.Generic.List<TextType> _warrantyInformation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
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
        
    private System.Collections.Generic.List<DeliveryType> _delivery;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=18)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Order=19)]
    public DeliveryTermsType @__DeliveryTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OriginatorParty", Order=20)]
    public PartyType @__OriginatorParty;
        
    private System.Collections.Generic.List<OrderedShipmentType> _orderedShipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderedShipment", Order=21)]
    public OrderedShipmentType[] @__OrderedShipment
    {
        get
        {
            return _orderedShipment?.ToArray();
        }
        set
        {
            _orderedShipment = value == null ? null : new System.Collections.Generic.List<OrderedShipmentType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PricingReference", Order=22)]
    public PricingReferenceType @__PricingReference;
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=23)]
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
    [System.Xml.Serialization.XmlElementAttribute("Price", Order=24)]
    public PriceType @__Price;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=25)]
    public ItemType @__Item;
        
    private System.Collections.Generic.List<LineItemType> _subLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubLineItem", Order=26)]
    public LineItemType[] @__SubLineItem
    {
        get
        {
            return _subLineItem?.ToArray();
        }
        set
        {
            _subLineItem = value == null ? null : new System.Collections.Generic.List<LineItemType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyValidityPeriod", Order=27)]
    public PeriodType @__WarrantyValidityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WarrantyParty", Order=28)]
    public PartyType @__WarrantyParty;
        
    private System.Collections.Generic.List<TaxTotalType> _taxTotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=29)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemPriceExtension", Order=30)]
    public PriceExtensionType @__ItemPriceExtension;
        
    private System.Collections.Generic.List<LineReferenceType> _lineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineReference", Order=31)]
    public LineReferenceType[] @__LineReference
    {
        get
        {
            return _lineReference?.ToArray();
        }
        set
        {
            _lineReference = value == null ? null : new System.Collections.Generic.List<LineReferenceType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
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
    /// Text describing a warranty (provided by WarrantyParty) for the good or service described in this line item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Warranty_ Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
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
    /// A delivery associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Delivery
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
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
    /// An ordered shipment associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Ordered Shipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Ordered Shipment
    /// <para />AssociatedObjectClass: Ordered Shipment
    /// <para />RepresentationTerm: Ordered Shipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<OrderedShipmentType> OrderedShipment
    {
        get { return _orderedShipment ?? (_orderedShipment = new System.Collections.Generic.List<OrderedShipmentType>()); }
        set { _orderedShipment = value; }
    }

        
    /// <summary>
    /// An allowance or charge associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
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
    /// The subsidiary line items that constitute the main line item, such as in a bill of materials.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Sub_ Line Item. Line Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTermQualifier: Sub
    /// <para />PropertyTerm: Line Item
    /// <para />AssociatedObjectClass: Line Item
    /// <para />RepresentationTerm: Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineItemType> SubLineItem
    {
        get { return _subLineItem ?? (_subLineItem = new System.Collections.Generic.List<LineItemType>()); }
        set { _subLineItem = value; }
    }

        
    /// <summary>
    /// A total amount of taxes of a particular kind applicable to this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
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
    /// A reference to a line in a document associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineReferenceType> LineReference
    {
        get { return _lineReference ?? (_lineReference = new System.Collections.Generic.List<LineReferenceType>()); }
        set { _lineReference = value; }
    }

        
    /// <summary>
    /// An identifier for this line item, assigned by the buyer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Line Item
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
    /// An identifier for this line item, assigned by the seller.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Sales_ Order Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTermQualifier: Sales
    /// <para />PropertyTerm: Order Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SalesOrderID
    {
        get
        {
            if (__SalesOrderID == null) { __SalesOrderID = new IdentifierType(); }
            return __SalesOrderID;
        }
        set
        {
            __SalesOrderID = value;
        }
    }

        
    /// <summary>
    /// A universally unique identifier for this line item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// A code signifying the status of this line item with respect to its original state.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Line Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Line Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Line Status
    /// <para />DataType: Line Status_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LineStatusCode
    {
        get
        {
            if (__LineStatusCode == null) { __LineStatusCode = new CodeType(); }
            return __LineStatusCode;
        }
        set
        {
            __LineStatusCode = value;
        }
    }

        
    /// <summary>
    /// The quantity of items associated with this line item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The total amount for this line item, including allowance charges but net of taxes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Line Extension Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The total tax amount for this line item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Total_ Tax Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The minimum quantity of the item associated with this line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Minimum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The maximum quantity of the item associated with this line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Maximum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The minimum back order quantity of the item associated with this line (where back order is allowed).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Minimum_ Backorder. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Backorder
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumBackorderQuantity
    {
        get
        {
            if (__MinimumBackorderQuantity == null) { __MinimumBackorderQuantity = new QuantityType(); }
            return __MinimumBackorderQuantity;
        }
        set
        {
            __MinimumBackorderQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum back order quantity of the item associated with this line (where back order is allowed).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Maximum_ Backorder. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Backorder
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumBackorderQuantity
    {
        get
        {
            if (__MaximumBackorderQuantity == null) { __MaximumBackorderQuantity = new QuantityType(); }
            return __MaximumBackorderQuantity;
        }
        set
        {
            __MaximumBackorderQuantity = value;
        }
    }

        
    /// <summary>
    /// A code signifying the inspection requirements for the item associated with this line item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Inspection Method Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Inspection Method Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType InspectionMethodCode
    {
        get
        {
            if (__InspectionMethodCode == null) { __InspectionMethodCode = new CodeType(); }
            return __InspectionMethodCode;
        }
        set
        {
            __InspectionMethodCode = value;
        }
    }

        
    /// <summary>
    /// An indicator that a partial delivery is allowed (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Partial Delivery Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Partial Delivery Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType PartialDeliveryIndicator
    {
        get
        {
            if (__PartialDeliveryIndicator == null) { __PartialDeliveryIndicator = new IndicatorType(); }
            return __PartialDeliveryIndicator;
        }
        set
        {
            __PartialDeliveryIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that back order is allowed (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Back Order Allowed Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Back Order Allowed Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType BackOrderAllowedIndicator
    {
        get
        {
            if (__BackOrderAllowedIndicator == null) { __BackOrderAllowedIndicator = new IndicatorType(); }
            return __BackOrderAllowedIndicator;
        }
        set
        {
            __BackOrderAllowedIndicator = value;
        }
    }

        
    /// <summary>
    /// The buyer&apos;s accounting cost centre for this line item, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Accounting Cost Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The buyer&apos;s accounting cost centre for this line item, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Item. Accounting Cost. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// Terms and conditions of the delivery associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Delivery Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Delivery Terms
    /// <para />AssociatedObjectClass: Delivery Terms
    /// <para />RepresentationTerm: Delivery Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DeliveryTermsType DeliveryTerms
    {
        get
        {
            if (__DeliveryTerms == null) { __DeliveryTerms = new DeliveryTermsType(); }
            return __DeliveryTerms;
        }
        set
        {
            __DeliveryTerms = value;
        }
    }

        
    /// <summary>
    /// The party who originated the Order associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Originator_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// A reference to pricing and item location information associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Pricing Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The price of the item of trade associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Price
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
    /// <para />PropertyTerm: Price
    /// <para />AssociatedObjectClass: Price
    /// <para />RepresentationTerm: Price
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
    /// The item of trade associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Line Item
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
    /// The period during which the warranty associated with this line item is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Warranty Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The party responsible for any warranty associated with this line item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Warranty_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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
    /// The price extension, calculated by multiplying the price per unit by the quantity of items.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Item. Item_ Price Extension. Price Extension
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Item
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