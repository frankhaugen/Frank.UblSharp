using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a package.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Package. Details
/// <para />ObjectClass: Package
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PackageType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReturnableMaterialIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IndicatorType @__ReturnableMaterialIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackageLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__PackageLevelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackagingTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__PackagingTypeCode;
        
    private System.Collections.Generic.List<TextType> _packingMaterial;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__PackingMaterial
    {
        get
        {
            return _packingMaterial?.ToArray();
        }
        set
        {
            _packingMaterial = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TraceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IdentifierType @__TraceID;
        
    private System.Collections.Generic.List<PackageType> _containedPackage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContainedPackage", Order=7)]
    public PackageType[] @__ContainedPackage
    {
        get
        {
            return _containedPackage?.ToArray();
        }
        set
        {
            _containedPackage = value == null ? null : new System.Collections.Generic.List<PackageType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContainingTransportEquipment", Order=8)]
    public TransportEquipmentType @__ContainingTransportEquipment;
        
    private System.Collections.Generic.List<GoodsItemType> _goodsItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GoodsItem", Order=9)]
    public GoodsItemType[] @__GoodsItem
    {
        get
        {
            return _goodsItem?.ToArray();
        }
        set
        {
            _goodsItem = value == null ? null : new System.Collections.Generic.List<GoodsItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<DimensionType> _measurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order=10)]
    public DimensionType[] @__MeasurementDimension
    {
        get
        {
            return _measurementDimension?.ToArray();
        }
        set
        {
            _measurementDimension = value == null ? null : new System.Collections.Generic.List<DimensionType>(value);
        }
    }
        
    private System.Collections.Generic.List<DeliveryUnitType> _deliveryUnit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit", Order=11)]
    public DeliveryUnitType[] @__DeliveryUnit
    {
        get
        {
            return _deliveryUnit?.ToArray();
        }
        set
        {
            _deliveryUnit = value == null ? null : new System.Collections.Generic.List<DeliveryUnitType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Order=12)]
    public DeliveryType @__Delivery;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Pickup", Order=13)]
    public PickupType @__Pickup;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Despatch", Order=14)]
    public DespatchType @__Despatch;
        
    /// <summary>
    /// Text describing the packaging material.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Package. Packing Material. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Packing Material
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> PackingMaterial
    {
        get { return _packingMaterial ?? (_packingMaterial = new System.Collections.Generic.List<TextType>()); }
        set { _packingMaterial = value; }
    }

        
    /// <summary>
    /// A package contained within this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Contained_ Package. Package
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Package
    /// <para />PropertyTermQualifier: Contained
    /// <para />PropertyTerm: Package
    /// <para />AssociatedObjectClass: Package
    /// <para />RepresentationTerm: Package
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PackageType> ContainedPackage
    {
        get { return _containedPackage ?? (_containedPackage = new System.Collections.Generic.List<PackageType>()); }
        set { _containedPackage = value; }
    }

        
    /// <summary>
    /// A goods item included in this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Goods Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Goods Item
    /// <para />AssociatedObjectClass: Goods Item
    /// <para />RepresentationTerm: Goods Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<GoodsItemType> GoodsItem
    {
        get { return _goodsItem ?? (_goodsItem = new System.Collections.Generic.List<GoodsItemType>()); }
        set { _goodsItem = value; }
    }

        
    /// <summary>
    /// A measurable dimension (length, mass, weight, or volume) of this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Package
    /// <para />PropertyTermQualifier: Measurement
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DimensionType> MeasurementDimension
    {
        get { return _measurementDimension ?? (_measurementDimension = new System.Collections.Generic.List<DimensionType>()); }
        set { _measurementDimension = value; }
    }

        
    /// <summary>
    /// A delivery unit within this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Delivery Unit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Delivery Unit
    /// <para />AssociatedObjectClass: Delivery Unit
    /// <para />RepresentationTerm: Delivery Unit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DeliveryUnitType> DeliveryUnit
    {
        get { return _deliveryUnit ?? (_deliveryUnit = new System.Collections.Generic.List<DeliveryUnitType>()); }
        set { _deliveryUnit = value; }
    }

        
    /// <summary>
    /// An identifier for this package.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Package. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
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
    /// The quantity of items contained in this package.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Package. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
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
    /// An indicator that the packaging material is returnable (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Package. Returnable Material_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTermQualifier: Returnable Material
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType ReturnableMaterialIndicator
    {
        get
        {
            if (__ReturnableMaterialIndicator == null) { __ReturnableMaterialIndicator = new IndicatorType(); }
            return __ReturnableMaterialIndicator;
        }
        set
        {
            __ReturnableMaterialIndicator = value;
        }
    }

        
    /// <summary>
    /// A code signifying a level of packaging.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Package. Package Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Package Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PackageLevelCode
    {
        get
        {
            if (__PackageLevelCode == null) { __PackageLevelCode = new CodeType(); }
            return __PackageLevelCode;
        }
        set
        {
            __PackageLevelCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying a type of packaging.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Package. Packaging Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Packaging Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Packaging Type
    /// <para />DataType: Packaging Type_ Code. Type
    /// <para />AlternativeBusinessTerms: Package classification code
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PackagingTypeCode
    {
        get
        {
            if (__PackagingTypeCode == null) { __PackagingTypeCode = new CodeType(); }
            return __PackagingTypeCode;
        }
        set
        {
            __PackagingTypeCode = value;
        }
    }

        
    /// <summary>
    /// An identifier for use in tracing this package, such as the EPC number used in RFID.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Package. Trace_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTermQualifier: Trace
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TraceID
    {
        get
        {
            if (__TraceID == null) { __TraceID = new IdentifierType(); }
            return __TraceID;
        }
        set
        {
            __TraceID = value;
        }
    }

        
    /// <summary>
    /// The piece of transport equipment containing this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Containing_ Transport Equipment. Transport Equipment
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTermQualifier: Containing
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportEquipmentType ContainingTransportEquipment
    {
        get
        {
            if (__ContainingTransportEquipment == null) { __ContainingTransportEquipment = new TransportEquipmentType(); }
            return __ContainingTransportEquipment;
        }
        set
        {
            __ContainingTransportEquipment = value;
        }
    }

        
    /// <summary>
    /// The delivery of this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Delivery
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Delivery
    /// <para />AssociatedObjectClass: Delivery
    /// <para />RepresentationTerm: Delivery
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DeliveryType Delivery
    {
        get
        {
            if (__Delivery == null) { __Delivery = new DeliveryType(); }
            return __Delivery;
        }
        set
        {
            __Delivery = value;
        }
    }

        
    /// <summary>
    /// The pickup of this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Pickup
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Pickup
    /// <para />AssociatedObjectClass: Pickup
    /// <para />RepresentationTerm: Pickup
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PickupType Pickup
    {
        get
        {
            if (__Pickup == null) { __Pickup = new PickupType(); }
            return __Pickup;
        }
        set
        {
            __Pickup = value;
        }
    }

        
    /// <summary>
    /// The despatch of this package.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Package. Despatch
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Package
    /// <para />PropertyTerm: Despatch
    /// <para />AssociatedObjectClass: Despatch
    /// <para />RepresentationTerm: Despatch
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DespatchType Despatch
    {
        get
        {
            if (__Despatch == null) { __Despatch = new DespatchType(); }
            return __Despatch;
        }
        set
        {
            __Despatch = value;
        }
    }

}