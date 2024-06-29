/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActualPackage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PackageType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ReturnableMaterialIndicatorType ReturnableMaterialIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackageLevelCodeType PackageLevelCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackagingTypeCodeType PackagingTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PackingMaterial", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackingMaterialType[] PackingMaterial { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TraceIDType TraceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContainedPackage")]
    public PackageType[] ContainedPackage { get; set; }

    /// <remarks/>
    public TransportEquipmentType ContainingTransportEquipment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("GoodsItem")]
    public GoodsItemType[] GoodsItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
    public DimensionType[] MeasurementDimension { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
    public DeliveryUnitType[] DeliveryUnit { get; set; }

    /// <remarks/>
    public DeliveryType Delivery { get; set; }

    /// <remarks/>
    public PickupType Pickup { get; set; }

    /// <remarks/>
    public DespatchType Despatch { get; set; }
}