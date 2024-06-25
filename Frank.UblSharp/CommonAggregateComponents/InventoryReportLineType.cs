using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in an Inventory Report.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Inventory Report Line. Details
/// <para />ObjectClass: Inventory Report Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("InventoryReportLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("InventoryReportLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class InventoryReportLineType
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
    [System.Xml.Serialization.XmlElementAttribute("InventoryValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__InventoryValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AvailabilityDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__AvailabilityDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AvailabilityStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__AvailabilityStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=6)]
    public ItemType @__Item;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InventoryLocation", Order=7)]
    public LocationType @__InventoryLocation;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Inventory Report Line
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
    /// An identifier for this inventory report line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Inventory Report Line
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
    /// The quantity of the item reported that is currently in stock.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Inventory Report Line
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
    /// The value of the quantity of the item reported that is currently in stock.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Inventory_ Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Inventory Report Line
    /// <para />PropertyTermQualifier: Inventory
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType InventoryValueAmount
    {
        get
        {
            if (__InventoryValueAmount == null) { __InventoryValueAmount = new AmountType(); }
            return __InventoryValueAmount;
        }
        set
        {
            __InventoryValueAmount = value;
        }
    }

        
    /// <summary>
    /// The date from which the goods will be available. If not present, the goods are available now.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Availability Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Inventory Report Line
    /// <para />PropertyTerm: Availability Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType AvailabilityDate
    {
        get
        {
            if (__AvailabilityDate == null) { __AvailabilityDate = new DateType(); }
            return __AvailabilityDate;
        }
        set
        {
            __AvailabilityDate = value;
        }
    }

        
    /// <summary>
    /// A code signifying the item&apos;s level of availability.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Availability Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Inventory Report Line
    /// <para />PropertyTerm: Availability Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AvailabilityStatusCode
    {
        get
        {
            if (__AvailabilityStatusCode == null) { __AvailabilityStatusCode = new CodeType(); }
            return __AvailabilityStatusCode;
        }
        set
        {
            __AvailabilityStatusCode = value;
        }
    }

        
    /// <summary>
    /// The item associated with this inventory report line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Inventory Report Line
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
    /// The location of the reported quantity of goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Inventory Report Line. Inventory_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Inventory Report Line
    /// <para />PropertyTermQualifier: Inventory
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType InventoryLocation
    {
        get
        {
            if (__InventoryLocation == null) { __InventoryLocation = new LocationType(); }
            return __InventoryLocation;
        }
        set
        {
            __InventoryLocation = value;
        }
    }

}