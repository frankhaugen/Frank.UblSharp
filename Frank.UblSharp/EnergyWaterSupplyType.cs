/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EnergyWaterSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class EnergyWaterSupplyType
{
    private ConsumptionAverageType[] consumptionAverageField;
    private ConsumptionCorrectionType[] energyWaterConsumptionCorrectionField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionReport")]
    public ConsumptionReportType[] ConsumptionReport { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EnergyTaxReport")]
    public EnergyTaxReportType[] EnergyTaxReport { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionAverage")]
    public ConsumptionAverageType[] ConsumptionAverage
    {
        get
        {
            return this.consumptionAverageField;
        }

        set
        {
            this.consumptionAverageField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EnergyWaterConsumptionCorrection")]
    public ConsumptionCorrectionType[] EnergyWaterConsumptionCorrection
    {
        get
        {
            return this.energyWaterConsumptionCorrectionField;
        }

        set
        {
            this.energyWaterConsumptionCorrectionField = value;
        }
    }
}