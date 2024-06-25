using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The Statement of correction, for examples heating correction.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption Correction. Details
/// <para />ObjectClass: Consumption Correction
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsumptionCorrection", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionCorrection", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionCorrectionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CorrectionType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__CorrectionType;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CorrectionTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__CorrectionTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeterNumber", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__MeterNumber;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GasPressureQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__GasPressureQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ActualTemperatureReductionQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__ActualTemperatureReductionQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NormalTemperatureReductionQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__NormalTemperatureReductionQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DifferenceTemperatureReductionQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public QuantityType @__DifferenceTemperatureReductionQuantity;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
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
    [System.Xml.Serialization.XmlElementAttribute("CorrectionUnitAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__CorrectionUnitAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionEnergyQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__ConsumptionEnergyQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionWaterQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public QuantityType @__ConsumptionWaterQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CorrectionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public AmountType @__CorrectionAmount;
        
    /// <summary>
    /// Description related to the corrections.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Correction
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
    /// Statement for the correction type.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Correction Type. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Correction Type
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Heating Correction</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CorrectionType
    {
        get
        {
            if (__CorrectionType == null) { __CorrectionType = new TextType(); }
            return __CorrectionType;
        }
        set
        {
            __CorrectionType = value;
        }
    }

        
    /// <summary>
    /// Statement at the code for the correction type.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Correction Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Correction Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>HeatingCorrection</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CorrectionTypeCode
    {
        get
        {
            if (__CorrectionTypeCode == null) { __CorrectionTypeCode = new CodeType(); }
            return __CorrectionTypeCode;
        }
        set
        {
            __CorrectionTypeCode = value;
        }
    }

        
    /// <summary>
    /// Statement for meter number.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Meter Number. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Meter Number
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>530071575</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MeterNumber
    {
        get
        {
            if (__MeterNumber == null) { __MeterNumber = new TextType(); }
            return __MeterNumber;
        }
        set
        {
            __MeterNumber = value;
        }
    }

        
    /// <summary>
    /// Correction of the gas pressure.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Gas Pressure. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Gas Pressure
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType GasPressureQuantity
    {
        get
        {
            if (__GasPressureQuantity == null) { __GasPressureQuantity = new QuantityType(); }
            return __GasPressureQuantity;
        }
        set
        {
            __GasPressureQuantity = value;
        }
    }

        
    /// <summary>
    /// Statement for the actuel heating correction temperature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Actual_ Temperature Reduction. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTermQualifier: Actual
    /// <para />PropertyTerm: Temperature Reduction
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>-36.69</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ActualTemperatureReductionQuantity
    {
        get
        {
            if (__ActualTemperatureReductionQuantity == null) { __ActualTemperatureReductionQuantity = new QuantityType(); }
            return __ActualTemperatureReductionQuantity;
        }
        set
        {
            __ActualTemperatureReductionQuantity = value;
        }
    }

        
    /// <summary>
    /// Statement for the standard for heating correction temperature.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Normal_ Temperature Reduction. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTermQualifier: Normal
    /// <para />PropertyTerm: Temperature Reduction
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>-37.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType NormalTemperatureReductionQuantity
    {
        get
        {
            if (__NormalTemperatureReductionQuantity == null) { __NormalTemperatureReductionQuantity = new QuantityType(); }
            return __NormalTemperatureReductionQuantity;
        }
        set
        {
            __NormalTemperatureReductionQuantity = value;
        }
    }

        
    /// <summary>
    /// Deviation from standard heating correction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Difference_ Temperature Reduction. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTermQualifier: Difference
    /// <para />PropertyTerm: Temperature Reduction
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>0.31</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType DifferenceTemperatureReductionQuantity
    {
        get
        {
            if (__DifferenceTemperatureReductionQuantity == null) { __DifferenceTemperatureReductionQuantity = new QuantityType(); }
            return __DifferenceTemperatureReductionQuantity;
        }
        set
        {
            __DifferenceTemperatureReductionQuantity = value;
        }
    }

        
    /// <summary>
    /// Correction per MWH per degree C.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Correction Unit Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Correction Unit Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>0.0000</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType CorrectionUnitAmount
    {
        get
        {
            if (__CorrectionUnitAmount == null) { __CorrectionUnitAmount = new AmountType(); }
            return __CorrectionUnitAmount;
        }
        set
        {
            __CorrectionUnitAmount = value;
        }
    }

        
    /// <summary>
    /// Your consumpt for district heating energy.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Consumption Energy. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Consumption Energy
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>563.6240</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ConsumptionEnergyQuantity
    {
        get
        {
            if (__ConsumptionEnergyQuantity == null) { __ConsumptionEnergyQuantity = new QuantityType(); }
            return __ConsumptionEnergyQuantity;
        }
        set
        {
            __ConsumptionEnergyQuantity = value;
        }
    }

        
    /// <summary>
    /// Your consumpt for district heating water.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Consumption Water. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Consumption Water
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    /// <example>13212.14</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ConsumptionWaterQuantity
    {
        get
        {
            if (__ConsumptionWaterQuantity == null) { __ConsumptionWaterQuantity = new QuantityType(); }
            return __ConsumptionWaterQuantity;
        }
        set
        {
            __ConsumptionWaterQuantity = value;
        }
    }

        
    /// <summary>
    /// Your correction for heating correction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Correction. Correction Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Correction
    /// <para />PropertyTerm: Correction Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>0.00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType CorrectionAmount
    {
        get
        {
            if (__CorrectionAmount == null) { __CorrectionAmount = new AmountType(); }
            return __CorrectionAmount;
        }
        set
        {
            __CorrectionAmount = value;
        }
    }

}