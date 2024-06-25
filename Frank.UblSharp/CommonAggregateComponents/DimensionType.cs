using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a measurable dimension (length, mass, weight, volume, or area) of an item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Dimension. Details
/// <para />ObjectClass: Dimension
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Dimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Dimension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DimensionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AttributeID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__AttributeID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Measure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public MeasureType @__Measure;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public MeasureType @__MinimumMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public MeasureType @__MaximumMeasure;
        
    /// <summary>
    /// Text describing the measurement attribute.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Dimension. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Dimension
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
    /// An identifier for the attribute to which the measure applies.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Dimension. Attribute Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Dimension
    /// <para />PropertyTerm: Attribute Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
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
    /// The measurement value.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Dimension. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Dimension
    /// <para />PropertyTerm: Measure
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType Measure
    {
        get
        {
            if (__Measure == null) { __Measure = new MeasureType(); }
            return __Measure;
        }
        set
        {
            __Measure = value;
        }
    }

        
    /// <summary>
    /// The minimum value in a range of measurement of this dimension.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Dimension. Minimum_ Measure. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Dimension
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Measure
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType MinimumMeasure
    {
        get
        {
            if (__MinimumMeasure == null) { __MinimumMeasure = new MeasureType(); }
            return __MinimumMeasure;
        }
        set
        {
            __MinimumMeasure = value;
        }
    }

        
    /// <summary>
    /// The maximum value in a range of measurement of this dimension.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Dimension. Maximum_ Measure. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Dimension
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Measure
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType MaximumMeasure
    {
        get
        {
            if (__MaximumMeasure == null) { __MaximumMeasure = new MeasureType(); }
            return __MaximumMeasure;
        }
        set
        {
            __MaximumMeasure = value;
        }
    }

}