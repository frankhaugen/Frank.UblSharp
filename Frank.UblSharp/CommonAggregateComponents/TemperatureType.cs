using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a measurement of temperature.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Temperature. Details
/// <para />ObjectClass: Temperature
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalTemperature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TemperatureType
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
        
    /// <summary>
    /// Text describing this temperature measurement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Temperature. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Temperature
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>at sea level</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// An identifier for this temperature measurement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Temperature. Attribute Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Temperature
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
    /// The value of this temperature measurement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Temperature. Measure
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Temperature
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

}