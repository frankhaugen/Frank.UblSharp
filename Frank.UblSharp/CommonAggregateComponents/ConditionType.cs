using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a measurable condition of an object.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Condition. Details
/// <para />ObjectClass: Condition
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Condition", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Condition", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConditionType
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
    /// Text describing the attribute that applies to the condition.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Condition. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Condition
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
    /// An identifier for the attribute that applies to the condition.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Condition. Attribute Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Condition
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
    /// <para />DictionaryEntryName: Condition. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Condition
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
    /// The minimum value in a range of measurement for this condition.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Condition. Minimum_ Measure. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Condition
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
    /// The maximum value in a range of measurement for this condition.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Condition. Maximum_ Measure. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Condition
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