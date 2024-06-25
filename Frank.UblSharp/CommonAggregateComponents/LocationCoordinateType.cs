using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class for defining a set of geographical coordinates (apparently misnamed).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Location Coordinate. Details
/// <para />ObjectClass: Location Coordinate
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("LocationCoordinate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("LocationCoordinate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class LocationCoordinateType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CoordinateSystemCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__CoordinateSystemCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatitudeDegreesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public MeasureType @__LatitudeDegreesMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatitudeMinutesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public MeasureType @__LatitudeMinutesMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatitudeDirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__LatitudeDirectionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LongitudeDegreesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public MeasureType @__LongitudeDegreesMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LongitudeMinutesMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public MeasureType @__LongitudeMinutesMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LongitudeDirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__LongitudeDirectionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AltitudeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public MeasureType @__AltitudeMeasure;
        
    /// <summary>
    /// A code signifying the location system used.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Coordinate System Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTerm: Coordinate System Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CoordinateSystemCode
    {
        get
        {
            if (__CoordinateSystemCode == null) { __CoordinateSystemCode = new CodeType(); }
            return __CoordinateSystemCode;
        }
        set
        {
            __CoordinateSystemCode = value;
        }
    }

        
    /// <summary>
    /// The degree component of a latitude measured in degrees and minutes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Latitude_ Degrees. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTermQualifier: Latitude
    /// <para />PropertyTerm: Degrees
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType LatitudeDegreesMeasure
    {
        get
        {
            if (__LatitudeDegreesMeasure == null) { __LatitudeDegreesMeasure = new MeasureType(); }
            return __LatitudeDegreesMeasure;
        }
        set
        {
            __LatitudeDegreesMeasure = value;
        }
    }

        
    /// <summary>
    /// The minutes component of a latitude measured in degrees and minutes (modulo 60).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Latitude_ Minutes. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTermQualifier: Latitude
    /// <para />PropertyTerm: Minutes
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType LatitudeMinutesMeasure
    {
        get
        {
            if (__LatitudeMinutesMeasure == null) { __LatitudeMinutesMeasure = new MeasureType(); }
            return __LatitudeMinutesMeasure;
        }
        set
        {
            __LatitudeMinutesMeasure = value;
        }
    }

        
    /// <summary>
    /// A code signifying the direction of latitude measurement from the equator (north or south).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Latitude Direction Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTerm: Latitude Direction Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Latitude Direction
    /// <para />DataType: Latitude Direction_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LatitudeDirectionCode
    {
        get
        {
            if (__LatitudeDirectionCode == null) { __LatitudeDirectionCode = new CodeType(); }
            return __LatitudeDirectionCode;
        }
        set
        {
            __LatitudeDirectionCode = value;
        }
    }

        
    /// <summary>
    /// The degree component of a longitude measured in degrees and minutes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Longitude_ Degrees. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTermQualifier: Longitude
    /// <para />PropertyTerm: Degrees
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType LongitudeDegreesMeasure
    {
        get
        {
            if (__LongitudeDegreesMeasure == null) { __LongitudeDegreesMeasure = new MeasureType(); }
            return __LongitudeDegreesMeasure;
        }
        set
        {
            __LongitudeDegreesMeasure = value;
        }
    }

        
    /// <summary>
    /// The minutes component of a longitude measured in degrees and minutes (modulo 60).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Longitude_ Minutes. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTermQualifier: Longitude
    /// <para />PropertyTerm: Minutes
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType LongitudeMinutesMeasure
    {
        get
        {
            if (__LongitudeMinutesMeasure == null) { __LongitudeMinutesMeasure = new MeasureType(); }
            return __LongitudeMinutesMeasure;
        }
        set
        {
            __LongitudeMinutesMeasure = value;
        }
    }

        
    /// <summary>
    /// A code signifying the direction of longitude measurement from the prime meridian (east or west).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Longitude Direction Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTerm: Longitude Direction Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Longitude Direction
    /// <para />DataType: Longitude Direction_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LongitudeDirectionCode
    {
        get
        {
            if (__LongitudeDirectionCode == null) { __LongitudeDirectionCode = new CodeType(); }
            return __LongitudeDirectionCode;
        }
        set
        {
            __LongitudeDirectionCode = value;
        }
    }

        
    /// <summary>
    /// The altitude of the location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location Coordinate. Altitude. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location Coordinate
    /// <para />PropertyTerm: Altitude
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType AltitudeMeasure
    {
        get
        {
            if (__AltitudeMeasure == null) { __AltitudeMeasure = new MeasureType(); }
            return __AltitudeMeasure;
        }
        set
        {
            __AltitudeMeasure = value;
        }
    }

}