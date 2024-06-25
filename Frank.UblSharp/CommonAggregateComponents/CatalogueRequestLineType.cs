using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line describing a request for a catalogue line.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Catalogue Request Line. Details
/// <para />ObjectClass: Catalogue Request Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CatalogueRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CatalogueRequestLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractSubdivision", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__ContractSubdivision;
        
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
    [System.Xml.Serialization.XmlElementAttribute("LineValidityPeriod", Order=3)]
    public PeriodType @__LineValidityPeriod;
        
    private System.Collections.Generic.List<ItemLocationQuantityType> _requiredItemLocationQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity", Order=4)]
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
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=5)]
    public ItemType @__Item;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Request Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Request Line
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
    /// Properties of the item in the requested catalogue line that are dependent on location and quantity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Request Line. Required_ Item Location Quantity. Item Location Quantity
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Request Line
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
    /// An identifier for the requested catalogue line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Request Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Request Line
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
    /// A subdivision of a contract or tender covering the line being requested.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Request Line. Contract Subdivision. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Request Line
    /// <para />PropertyTerm: Contract Subdivision
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Installation , Phase One , Support and Maintenance</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ContractSubdivision
    {
        get
        {
            if (__ContractSubdivision == null) { __ContractSubdivision = new TextType(); }
            return __ContractSubdivision;
        }
        set
        {
            __ContractSubdivision = value;
        }
    }

        
    /// <summary>
    /// The period for which the information in the requested catalogue line is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Request Line. Line Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Request Line
    /// <para />PropertyTermQualifier: Line Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType LineValidityPeriod
    {
        get
        {
            if (__LineValidityPeriod == null) { __LineValidityPeriod = new PeriodType(); }
            return __LineValidityPeriod;
        }
        set
        {
            __LineValidityPeriod = value;
        }
    }

        
    /// <summary>
    /// The item associated with the requested catalogue line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Catalogue Request Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Request Line
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