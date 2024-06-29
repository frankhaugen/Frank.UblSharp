/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContainedGoodsItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class GoodsItemType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumberIDType SequenceNumberID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DescriptionType[] Description { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredCustomsValueAmountType DeclaredCustomsValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredForCarriageValueAmountType DeclaredForCarriageValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeclaredStatisticsValueAmountType DeclaredStatisticsValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FreeOnBoardValueAmountType FreeOnBoardValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsuranceValueAmountType InsuranceValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ValueAmountType ValueAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossWeightMeasureType GrossWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetWeightMeasureType NetWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetNetWeightMeasureType NetNetWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeableWeightMeasureType ChargeableWeightMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public GrossVolumeMeasureType GrossVolumeMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetVolumeMeasureType NetVolumeMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PreferenceCriterionCodeType PreferenceCriterionCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public RequiredCustomsIDType RequiredCustomsID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsStatusCodeType CustomsStatusCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsTariffQuantityType CustomsTariffQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomsImportClassifiedIndicatorType CustomsImportClassifiedIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeableQuantityType ChargeableQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReturnableQuantityType ReturnableQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TraceIDType TraceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Item")]
    public ItemType[] Item { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("GoodsItemContainer")]
    public GoodsItemContainerType[] GoodsItemContainer { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InvoiceLine")]
    public InvoiceLineType[] InvoiceLine { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Temperature")]
    public TemperatureType[] Temperature { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContainedGoodsItem")]
    public GoodsItemType[] ContainedGoodsItem { get; set; }

    /// <remarks/>
    public AddressType OriginAddress { get; set; }

    /// <remarks/>
    public DeliveryType Delivery { get; set; }

    /// <remarks/>
    public PickupType Pickup { get; set; }

    /// <remarks/>
    public DespatchType Despatch { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
    public DimensionType[] MeasurementDimension { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContainingPackage")]
    public PackageType[] ContainingPackage { get; set; }

    /// <remarks/>
    public DocumentReferenceType ShipmentDocumentReference { get; set; }

    /// <remarks/>
    public TemperatureType MinimumTemperature { get; set; }

    /// <remarks/>
    public TemperatureType MaximumTemperature { get; set; }
}