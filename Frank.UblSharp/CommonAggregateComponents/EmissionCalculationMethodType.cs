using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define how an environmental emission is calculated.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Emission Calculation Method. Details
/// <para />ObjectClass: Emission Calculation Method
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EmissionCalculationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EmissionCalculationMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EmissionCalculationMethodType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CalculationMethodCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__CalculationMethodCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FullnessIndicationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__FullnessIndicationCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementFromLocation", Order=2)]
    public LocationType @__MeasurementFromLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementToLocation", Order=3)]
    public LocationType @__MeasurementToLocation;
        
    /// <summary>
    /// A code signifying the method used to calculate the emission.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Emission Calculation Method. Calculation Method Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Emission Calculation Method
    /// <para />PropertyTerm: Calculation Method Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CalculationMethodCode
    {
        get
        {
            if (__CalculationMethodCode == null) { __CalculationMethodCode = new CodeType(); }
            return __CalculationMethodCode;
        }
        set
        {
            __CalculationMethodCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying whether a piece of transport equipment is full, partially full, or empty. This indication is used as a parameter when calculating the environmental emission.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Emission Calculation Method. Fullness Indication Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Emission Calculation Method
    /// <para />PropertyTerm: Fullness Indication Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType FullnessIndicationCode
    {
        get
        {
            if (__FullnessIndicationCode == null) { __FullnessIndicationCode = new CodeType(); }
            return __FullnessIndicationCode;
        }
        set
        {
            __FullnessIndicationCode = value;
        }
    }

        
    /// <summary>
    /// A start location from which an environmental emission is calculated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Emission Calculation Method. Measurement From_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Emission Calculation Method
    /// <para />PropertyTermQualifier: Measurement From
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType MeasurementFromLocation
    {
        get
        {
            if (__MeasurementFromLocation == null) { __MeasurementFromLocation = new LocationType(); }
            return __MeasurementFromLocation;
        }
        set
        {
            __MeasurementFromLocation = value;
        }
    }

        
    /// <summary>
    /// An end location to which an environmental emission is calculated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Emission Calculation Method. Measurement To_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Emission Calculation Method
    /// <para />PropertyTermQualifier: Measurement To
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType MeasurementToLocation
    {
        get
        {
            if (__MeasurementToLocation == null) { __MeasurementToLocation = new LocationType(); }
            return __MeasurementToLocation;
        }
        set
        {
            __MeasurementToLocation = value;
        }
    }

}