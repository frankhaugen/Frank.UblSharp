/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SubTenderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TenderLineType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TotalTaxAmountType TotalTaxAmount { get; set; }

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
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
    public DocumentReferenceType[] DocumentReference { get; set; }

    /// <remarks/>
    public ItemType Item { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OfferedItemLocationQuantity")]
    public ItemLocationQuantityType[] OfferedItemLocationQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReplacementRelatedItem")]
    public RelatedItemType[] ReplacementRelatedItem { get; set; }

    /// <remarks/>
    public PartyType WarrantyParty { get; set; }

    /// <remarks/>
    public PeriodType WarrantyValidityPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubTenderLine")]
    public TenderLineType[] SubTenderLine { get; set; }

    /// <remarks/>
    public LineReferenceType CallForTendersLineReference { get; set; }

    /// <remarks/>
    public DocumentReferenceType CallForTendersDocumentReference { get; set; }
}