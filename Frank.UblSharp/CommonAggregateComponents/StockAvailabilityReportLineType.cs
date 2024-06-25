using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Stock Availability Report describing the availability of an item of sale.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Stock Availability Report Line. Details
/// <para />ObjectClass: Stock Availability Report Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("StockAvailabilityReportLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("StockAvailabilityReportLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class StockAvailabilityReportLineType
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
    [System.Xml.Serialization.XmlElementAttribute("ValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__ValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AvailabilityDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__AvailabilityDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AvailabilityStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__AvailabilityStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=6)]
    public ItemType @__Item;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stock Availability Report Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Stock Availability Report Line
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
    /// An identifier for this stock availability line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stock Availability Report Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Stock Availability Report Line
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
    /// The quantity of the item currently in stock.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stock Availability Report Line. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Stock Availability Report Line
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
    /// The monetary value of the quantity of the item currently in stock.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stock Availability Report Line. Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Stock Availability Report Line
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType ValueAmount
    {
        get
        {
            if (__ValueAmount == null) { __ValueAmount = new AmountType(); }
            return __ValueAmount;
        }
        set
        {
            __ValueAmount = value;
        }
    }

        
    /// <summary>
    /// The date from which the item will be available. A date identical to or earlier than the IssueDate of the Stock Availability Report means that the item is available now
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stock Availability Report Line. Availability Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Stock Availability Report Line
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
    /// A code signifying the level of availability of the item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stock Availability Report Line. Availability Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Stock Availability Report Line
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
    /// The item associated with this stock availability report line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Stock Availability Report Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Stock Availability Report Line
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