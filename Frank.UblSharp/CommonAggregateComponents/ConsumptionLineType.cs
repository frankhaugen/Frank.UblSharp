using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a line item for utility consumption. To specify more than one utility item, use separate consumption lines.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption Line. Details
/// <para />ObjectClass: Consumption Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsumptionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ParentDocumentLineReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__ParentDocumentLineReferenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InvoicedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__InvoicedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__LineExtensionAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Period", Order=4)]
    public PeriodType @__Period;
        
    private System.Collections.Generic.List<DeliveryType> _delivery;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=5)]
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
        
    private System.Collections.Generic.List<AllowanceChargeType> _allowanceCharge;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=6)]
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
        
    private System.Collections.Generic.List<TaxTotalType> _taxTotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=7)]
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
    [System.Xml.Serialization.XmlElementAttribute("UtilityItem", Order=8)]
    public UtilityItemType @__UtilityItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Price", Order=9)]
    public PriceType @__Price;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnstructuredPrice", Order=10)]
    public UnstructuredPriceType @__UnstructuredPrice;
        
    /// <summary>
    /// A delivery of the utility item on this consumption line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Line. Delivery
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Line
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
    /// An allowance or charge that applies to this consumption line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Line. Allowance Charge
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Line
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
    /// A total amount of taxes of a particular kind applicable to this consumption line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Line. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Line
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
    /// An identifier for this consumption line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Line
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1</example>
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
    /// An identifier for the transaction line on a related document (such as an invoice) that covers this consumption line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Line. Parent_ Document Line Reference Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Line
    /// <para />PropertyTermQualifier: Parent
    /// <para />PropertyTerm: Document Line Reference Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>Consumption</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ParentDocumentLineReferenceID
    {
        get
        {
            if (__ParentDocumentLineReferenceID == null) { __ParentDocumentLineReferenceID = new IdentifierType(); }
            return __ParentDocumentLineReferenceID;
        }
        set
        {
            __ParentDocumentLineReferenceID = value;
        }
    }

        
    /// <summary>
    /// The quantity invoiced.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Line. Invoiced_ Quantity. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Line
    /// <para />PropertyTermQualifier: Invoiced
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType InvoicedQuantity
    {
        get
        {
            if (__InvoicedQuantity == null) { __InvoicedQuantity = new QuantityType(); }
            return __InvoicedQuantity;
        }
        set
        {
            __InvoicedQuantity = value;
        }
    }

        
    /// <summary>
    /// The monetary amount, including discount, to be charged for this consumption line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Line. Line Extension Amount. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Line
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
    /// The period of time covered by this consumption line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Line. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Line
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType Period
    {
        get
        {
            if (__Period == null) { __Period = new PeriodType(); }
            return __Period;
        }
        set
        {
            __Period = value;
        }
    }

        
    /// <summary>
    /// The utility item consumed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Line. Utility Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Consumption Line
    /// <para />PropertyTerm: Utility Item
    /// <para />AssociatedObjectClass: Utility Item
    /// <para />RepresentationTerm: Utility Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public UtilityItemType UtilityItem
    {
        get
        {
            if (__UtilityItem == null) { __UtilityItem = new UtilityItemType(); }
            return __UtilityItem;
        }
        set
        {
            __UtilityItem = value;
        }
    }

        
    /// <summary>
    /// The price associated with this consumption line, expressed in a data structure containing multiple properties.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Line. Price
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Line
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
    /// The price associated with this consumption line expressed in a less structured form that includes just the amount and the time of use.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Consumption Line. Unstructured Price
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Line
    /// <para />PropertyTerm: Unstructured Price
    /// <para />AssociatedObjectClass: Unstructured Price
    /// <para />RepresentationTerm: Unstructured Price
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public UnstructuredPriceType UnstructuredPrice
    {
        get
        {
            if (__UnstructuredPrice == null) { __UnstructuredPrice = new UnstructuredPriceType(); }
            return __UnstructuredPrice;
        }
        set
        {
            __UnstructuredPrice = value;
        }
    }

}