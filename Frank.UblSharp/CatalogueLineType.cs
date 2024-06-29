/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class CatalogueLineType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ActionCodeType ActionCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LifeCycleStatusCodeType LifeCycleStatusCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractSubdivisionType ContractSubdivision { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OrderableIndicatorType OrderableIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OrderableUnitType OrderableUnit { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContentUnitQuantityType ContentUnitQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public OrderQuantityIncrementNumericType OrderQuantityIncrementNumeric { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MinimumOrderQuantityType MinimumOrderQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumOrderQuantityType MaximumOrderQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("WarrantyInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public WarrantyInformationType[] WarrantyInformation { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PackLevelCodeType PackLevelCode { get; set; }

    /// <remarks/>
    public CustomerPartyType ContractorCustomerParty { get; set; }

    /// <remarks/>
    public SupplierPartyType SellerSupplierParty { get; set; }

    /// <remarks/>
    public PartyType WarrantyParty { get; set; }

    /// <remarks/>
    public PeriodType WarrantyValidityPeriod { get; set; }

    /// <remarks/>
    public PeriodType LineValidityPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemComparison")]
    public ItemComparisonType[] ItemComparison { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ComponentRelatedItem")]
    public RelatedItemType[] ComponentRelatedItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AccessoryRelatedItem")]
    public RelatedItemType[] AccessoryRelatedItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequiredRelatedItem")]
    public RelatedItemType[] RequiredRelatedItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem")]
    public RelatedItemType[] ReplacementRelatedItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ComplementaryRelatedItem")]
    public RelatedItemType[] ComplementaryRelatedItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReplacedRelatedItem")]
    public RelatedItemType[] ReplacedRelatedItem { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
    public ItemLocationQuantityType[] RequiredItemLocationQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
    public DocumentReferenceType[] DocumentReference { get; set; }

    /// <remarks/>
    public ItemType Item { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("KeywordItemProperty")]
    public ItemPropertyType[] KeywordItemProperty { get; set; }

    /// <remarks/>
    public LineReferenceType CallForTendersLineReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType CallForTendersDocumentReference { get; set; }
}