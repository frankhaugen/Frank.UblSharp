using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in an Instruction for Returns.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Instruction For Returns Line. Details
/// <para />ObjectClass: Instruction For Returns Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("InstructionForReturnsLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("InstructionForReturnsLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class InstructionForReturnsLineType
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
    [System.Xml.Serialization.XmlElementAttribute("ManufacturerParty", Order=3)]
    public PartyType @__ManufacturerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=4)]
    public ItemType @__Item;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Instruction For Returns Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Instruction For Returns Line
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
    /// An identifier for this instruction for returns line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Instruction For Returns Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Instruction For Returns Line
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
    /// The quantity of goods being returned.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Instruction For Returns Line. Quantity
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Instruction For Returns Line
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
    /// The manufacturer of the goods being returned.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Instruction For Returns Line. Manufacturer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Instruction For Returns Line
    /// <para />PropertyTermQualifier: Manufacturer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ManufacturerParty
    {
        get
        {
            if (__ManufacturerParty == null) { __ManufacturerParty = new PartyType(); }
            return __ManufacturerParty;
        }
        set
        {
            __ManufacturerParty = value;
        }
    }

        
    /// <summary>
    /// A description of the item being returned.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Instruction For Returns Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Instruction For Returns Line
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