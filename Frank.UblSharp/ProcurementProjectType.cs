/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ProcurementProjectType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NameType1[] Name { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcurementTypeCodeType ProcurementTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProcurementSubTypeCodeType ProcurementSubTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QualityControlCodeType QualityControlCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredFeeAmountType RequiredFeeAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FeeDescriptionType[] FeeDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequestedDeliveryDateType RequestedDeliveryDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public EstimatedOverallContractQuantityType EstimatedOverallContractQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    public RequestedTenderTotalType RequestedTenderTotal { get; set; }

    /// <remarks/>
    public CommodityClassificationType MainCommodityClassification { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalCommodityClassification")]
    public CommodityClassificationType[] AdditionalCommodityClassification { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RealizedLocation")]
    public LocationType1[] RealizedLocation { get; set; }

    /// <remarks/>
    public PeriodType PlannedPeriod { get; set; }

    /// <remarks/>
    public ContractExtensionType ContractExtension { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequestForTenderLine")]
    public RequestForTenderLineType[] RequestForTenderLine { get; set; }
}