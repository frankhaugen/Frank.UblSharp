/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsolidatedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ShipmentType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingPriorityLevelCodeType ShippingPriorityLevelCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingCodeType HandlingCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingInstructionsType[] HandlingInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Information", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InformationType[] Information { get; set; }

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
    public GrossVolumeMeasureType GrossVolumeMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NetVolumeMeasureType NetVolumeMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTransportHandlingUnitQuantityType TotalTransportHandlingUnitQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InsuranceValueAmountType InsuranceValueAmount { get; set; }

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
    [System.Xml.Serialization.XmlElementAttribute("SpecialInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SpecialInstructionsType[] SpecialInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DeliveryInstructionsType[] DeliveryInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SplitConsignmentIndicatorType SplitConsignmentIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ConsignmentQuantityType ConsignmentQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Consignment")]
    public ConsignmentType[] Consignment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
    public GoodsItemType[] GoodsItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
    public ShipmentStageType[] ShipmentStage { get; set; }

    /// <remarks/>
    public DeliveryType Delivery { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportHandlingUnit")]
    public TransportHandlingUnitType[] TransportHandlingUnit { get; set; }

    /// <remarks/>
    public AddressType ReturnAddress { get; set; }

    /// <remarks/>
    public AddressType OriginAddress { get; set; }

    /// <remarks/>
    public LocationType1 FirstArrivalPortLocation { get; set; }

    /// <remarks/>
    public LocationType1 LastExitPortLocation { get; set; }

    /// <remarks/>
    public CountryType ExportCountry { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FreightAllowanceCharge")]
    public AllowanceChargeType[] FreightAllowanceCharge { get; set; }
}