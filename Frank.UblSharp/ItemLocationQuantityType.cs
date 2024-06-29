/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ItemLocationQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ItemLocationQuantityType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LeadTimeMeasureType LeadTimeMeasure { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumQuantityType MinimumQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumQuantityType MaximumQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TradingRestrictions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TradingRestrictionsType[] TradingRestrictions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ApplicableTerritoryAddress")]
    public AddressType[] ApplicableTerritoryAddress { get; set; }

    /// <remarks/>
    public PriceType Price { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryUnit")]
    public DeliveryUnitType[] DeliveryUnit { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ApplicableTaxCategory")]
    public TaxCategoryType[] ApplicableTaxCategory { get; set; }

    /// <remarks/>
    public PackageType Package { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge { get; set; }

    /// <remarks/>
    public DependentPriceReferenceType DependentPriceReference { get; set; }
}