using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an environmental emission.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Environmental Emission. Details
/// <para />ObjectClass: Environmental Emission
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EnvironmentalEmission", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EnvironmentalEmission", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EnvironmentalEmissionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmissionTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__EnvironmentalEmissionTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValueMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public MeasureType @__ValueMeasure;
        
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
        
    private System.Collections.Generic.List<EmissionCalculationMethodType> _emissionCalculationMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmissionCalculationMethod", Order=3)]
    public EmissionCalculationMethodType[] @__EmissionCalculationMethod
    {
        get
        {
            return _emissionCalculationMethod?.ToArray();
        }
        set
        {
            _emissionCalculationMethod = value == null ? null : new System.Collections.Generic.List<EmissionCalculationMethodType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this environmental emission.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Environmental Emission. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Environmental Emission
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
    /// A method used to calculate the amount of this emission.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Environmental Emission. Emission Calculation Method
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Environmental Emission
    /// <para />PropertyTerm: Emission Calculation Method
    /// <para />AssociatedObjectClass: Emission Calculation Method
    /// <para />RepresentationTerm: Emission Calculation Method
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EmissionCalculationMethodType> EmissionCalculationMethod
    {
        get { return _emissionCalculationMethod ?? (_emissionCalculationMethod = new System.Collections.Generic.List<EmissionCalculationMethodType>()); }
        set { _emissionCalculationMethod = value; }
    }

        
    /// <summary>
    /// A code specifying the type of environmental emission.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Environmental Emission. Environmental Emission Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Environmental Emission
    /// <para />PropertyTerm: Environmental Emission Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType EnvironmentalEmissionTypeCode
    {
        get
        {
            if (__EnvironmentalEmissionTypeCode == null) { __EnvironmentalEmissionTypeCode = new CodeType(); }
            return __EnvironmentalEmissionTypeCode;
        }
        set
        {
            __EnvironmentalEmissionTypeCode = value;
        }
    }

        
    /// <summary>
    /// A value measurement for the environmental emission.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Environmental Emission. Value. Measure
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Environmental Emission
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType ValueMeasure
    {
        get
        {
            if (__ValueMeasure == null) { __ValueMeasure = new MeasureType(); }
            return __ValueMeasure;
        }
        set
        {
            __ValueMeasure = value;
        }
    }

}