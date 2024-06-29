/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemInformationRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ItemInformationRequestLineType
{
    private ForecastTypeCodeType forecastTypeCodeField;
    private PerformanceMetricTypeCodeType performanceMetricTypeCodeField;
    private PeriodType[] periodField;
    private SalesItemType[] salesItemField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TimeFrequencyCodeType TimeFrequencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ForecastTypeCodeType ForecastTypeCode
    {
        get
        {
            return this.forecastTypeCodeField;
        }

        set
        {
            this.forecastTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PerformanceMetricTypeCodeType PerformanceMetricTypeCode
    {
        get
        {
            return this.performanceMetricTypeCodeField;
        }

        set
        {
            this.performanceMetricTypeCodeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Period")]
    public PeriodType[] Period
    {
        get
        {
            return this.periodField;
        }

        set
        {
            this.periodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SalesItem")]
    public SalesItemType[] SalesItem
    {
        get
        {
            return this.salesItemField;
        }

        set
        {
            this.salesItemField = value;
        }
    }
}