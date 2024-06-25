using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a location on board a means of transport where specified goods or transport equipment have been stowed or are to be stowed.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Stowage. Details
/// <para />ObjectClass: Stowage
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Stowage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Stowage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class StowageType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LocationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__LocationID;
        
    private System.Collections.Generic.List<TextType> _location;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Location", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__Location
    {
        get
        {
            return _location?.ToArray();
        }
        set
        {
            _location = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<DimensionType> _measurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order=2)]
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
        
    /// <summary>
    /// Text describing the location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stowage. Location. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Stowage
    /// <para />PropertyTerm: Location
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Cell Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Location
    {
        get { return _location ?? (_location = new System.Collections.Generic.List<TextType>()); }
        set { _location = value; }
    }

        
    /// <summary>
    /// A measurable dimension (length, mass, weight, or volume) of this stowage.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Stowage. Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Stowage
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
    /// An identifier for the location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Stowage. Location Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Stowage
    /// <para />PropertyTerm: Location Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Cell Location, coded
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LocationID
    {
        get
        {
            if (__LocationID == null) { __LocationID = new IdentifierType(); }
            return __LocationID;
        }
        set
        {
            __LocationID = value;
        }
    }

}