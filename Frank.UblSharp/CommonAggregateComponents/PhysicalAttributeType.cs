using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a physical attribute.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Physical Attribute. Details
/// <para />ObjectClass: Physical Attribute
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PhysicalAttribute", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PhysicalAttribute", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PhysicalAttributeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AttributeID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__AttributeID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PositionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__PositionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DescriptionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__DescriptionCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    /// <summary>
    /// A description of the physical attribute, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Physical Attribute. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Physical Attribute
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// An identifier for this physical attribute.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Physical Attribute. Attribute Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Physical Attribute
    /// <para />PropertyTerm: Attribute Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>colour style</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType AttributeID
    {
        get
        {
            if (__AttributeID == null) { __AttributeID = new IdentifierType(); }
            return __AttributeID;
        }
        set
        {
            __AttributeID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the position of this physical attribute.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Physical Attribute. Position Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Physical Attribute
    /// <para />PropertyTerm: Position Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PositionCode
    {
        get
        {
            if (__PositionCode == null) { __PositionCode = new CodeType(); }
            return __PositionCode;
        }
        set
        {
            __PositionCode = value;
        }
    }

        
    /// <summary>
    /// A description of the physical attribute, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Physical Attribute. Description Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Physical Attribute
    /// <para />PropertyTerm: Description Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>XXL , Small</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DescriptionCode
    {
        get
        {
            if (__DescriptionCode == null) { __DescriptionCode = new CodeType(); }
            return __DescriptionCode;
        }
        set
        {
            __DescriptionCode = value;
        }
    }

}