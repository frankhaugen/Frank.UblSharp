namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the supply (and therefore consumption) of an amount of energy or water.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Energy Water Supply. Details
/// <para />ObjectClass: Energy Water Supply
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EnergyWaterSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EnergyWaterSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EnergyWaterSupplyType
{
        
    private System.Collections.Generic.List<ConsumptionReportType> _consumptionReport;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionReport", Order=0)]
    public ConsumptionReportType[] @__ConsumptionReport
    {
        get
        {
            return _consumptionReport?.ToArray();
        }
        set
        {
            _consumptionReport = value == null ? null : new System.Collections.Generic.List<ConsumptionReportType>(value);
        }
    }
        
    private System.Collections.Generic.List<EnergyTaxReportType> _energyTaxReport;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EnergyTaxReport", Order=1)]
    public EnergyTaxReportType[] @__EnergyTaxReport
    {
        get
        {
            return _energyTaxReport?.ToArray();
        }
        set
        {
            _energyTaxReport = value == null ? null : new System.Collections.Generic.List<EnergyTaxReportType>(value);
        }
    }
        
    private System.Collections.Generic.List<ConsumptionAverageType> _consumptionAverage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionAverage", Order=2)]
    public ConsumptionAverageType[] @__ConsumptionAverage
    {
        get
        {
            return _consumptionAverage?.ToArray();
        }
        set
        {
            _consumptionAverage = value == null ? null : new System.Collections.Generic.List<ConsumptionAverageType>(value);
        }
    }
        
    private System.Collections.Generic.List<ConsumptionCorrectionType> _energyWaterConsumptionCorrection;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EnergyWaterConsumptionCorrection", Order=3)]
    public ConsumptionCorrectionType[] @__EnergyWaterConsumptionCorrection
    {
        get
        {
            return _energyWaterConsumptionCorrection?.ToArray();
        }
        set
        {
            _energyWaterConsumptionCorrection = value == null ? null : new System.Collections.Generic.List<ConsumptionCorrectionType>(value);
        }
    }
        
    /// <summary>
    /// An amount of energy or water consumed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Energy Water Supply. Consumption Report
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Energy Water Supply
    /// <para />PropertyTerm: Consumption Report
    /// <para />AssociatedObjectClass: Consumption Report
    /// <para />RepresentationTerm: Consumption Report
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsumptionReportType> ConsumptionReport
    {
        get { return _consumptionReport ?? (_consumptionReport = new System.Collections.Generic.List<ConsumptionReportType>()); }
        set { _consumptionReport = value; }
    }

        
    /// <summary>
    /// A tax on the consumption of energy or water.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Energy Water Supply. Energy Tax Report
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Energy Water Supply
    /// <para />PropertyTerm: Energy Tax Report
    /// <para />AssociatedObjectClass: Energy Tax Report
    /// <para />RepresentationTerm: Energy Tax Report
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EnergyTaxReportType> EnergyTaxReport
    {
        get { return _energyTaxReport ?? (_energyTaxReport = new System.Collections.Generic.List<EnergyTaxReportType>()); }
        set { _energyTaxReport = value; }
    }

        
    /// <summary>
    /// A consumption average.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Energy Water Supply. Consumption Average
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Energy Water Supply
    /// <para />PropertyTerm: Consumption Average
    /// <para />AssociatedObjectClass: Consumption Average
    /// <para />RepresentationTerm: Consumption Average
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsumptionAverageType> ConsumptionAverage
    {
        get { return _consumptionAverage ?? (_consumptionAverage = new System.Collections.Generic.List<ConsumptionAverageType>()); }
        set { _consumptionAverage = value; }
    }

        
    /// <summary>
    /// Describes any corrections or adjustments to the supply of energy or water.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Energy Water Supply. Energy Water_ Consumption Correction. Consumption Correction
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Energy Water Supply
    /// <para />PropertyTermQualifier: Energy Water
    /// <para />PropertyTerm: Consumption Correction
    /// <para />AssociatedObjectClass: Consumption Correction
    /// <para />RepresentationTerm: Consumption Correction
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsumptionCorrectionType> EnergyWaterConsumptionCorrection
    {
        get { return _energyWaterConsumptionCorrection ?? (_energyWaterConsumptionCorrection = new System.Collections.Generic.List<ConsumptionCorrectionType>()); }
        set { _energyWaterConsumptionCorrection = value; }
    }

}