using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a property group or classification.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Property Group. Details
/// <para />ObjectClass: Item Property Group
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ItemPropertyGroup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemPropertyGroup", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemPropertyGroupType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ImportanceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__ImportanceCode;
        
    /// <summary>
    /// An identifier for this group of item properties.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property Group. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Item Property Group
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>233-004</example>
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
    /// The name of this item property group.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property Group. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property Group
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Electrical Specifications , Dietary Content</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType Name
    {
        get
        {
            if (__Name == null) { __Name = new NameType(); }
            return __Name;
        }
        set
        {
            __Name = value;
        }
    }

        
    /// <summary>
    /// A code signifying the importance of this property group in using it to describe a required Item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Property Group. Importance Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Property Group
    /// <para />PropertyTerm: Importance Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ImportanceCode
    {
        get
        {
            if (__ImportanceCode == null) { __ImportanceCode = new CodeType(); }
            return __ImportanceCode;
        }
        set
        {
            __ImportanceCode = value;
        }
    }

}