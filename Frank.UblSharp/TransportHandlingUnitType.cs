/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PackagedTransportHandlingUnit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TransportHandlingUnitType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingCodeType HandlingCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HandlingInstructions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HandlingInstructionsType[] HandlingInstructions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalPackageQuantityType TotalPackageQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DamageRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DamageRemarksType[] DamageRemarks { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ShippingMarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ShippingMarksType[] ShippingMarks { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TraceIDType TraceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HandlingUnitDespatchLine")]
    public DespatchLineType[] HandlingUnitDespatchLine { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActualPackage")]
    public PackageType[] ActualPackage { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReceivedHandlingUnitReceiptLine")]
    public ReceiptLineType[] ReceivedHandlingUnitReceiptLine { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportEquipment")]
    public TransportEquipmentType[] TransportEquipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportMeans")]
    public TransportMeansType[] TransportMeans { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit")]
    public HazardousGoodsTransitType[] HazardousGoodsTransit { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
    public DimensionType[] MeasurementDimension { get; set; }

    /// <remarks/>
    public TemperatureType MinimumTemperature { get; set; }

    /// <remarks/>
    public TemperatureType MaximumTemperature { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
    public GoodsItemType[] GoodsItem { get; set; }

    /// <remarks/>
    public DimensionType FloorSpaceMeasurementDimension { get; set; }

    /// <remarks/>
    public DimensionType PalletSpaceMeasurementDimension { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ShipmentDocumentReference")]
    public DocumentReferenceType[] ShipmentDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Status")]
    public StatusType[] Status { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CustomsDeclaration")]
    public CustomsDeclarationType[] CustomsDeclaration { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReferencedShipment")]
    public ShipmentType[] ReferencedShipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Package")]
    public PackageType[] Package { get; set; }
}