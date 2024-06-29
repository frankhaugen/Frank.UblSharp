/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DebitNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class DebitNoteLineType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DebitedQuantityType DebitedQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxPointDateType TaxPointDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostCodeType AccountingCostCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostType AccountingCost { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentPurposeCodeType PaymentPurposeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse")]
    public ResponseType[] DiscrepancyResponse { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference")]
    public LineReferenceType[] DespatchLineReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReceiptLineReference")]
    public LineReferenceType[] ReceiptLineReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
    public BillingReferenceType[] BillingReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
    public DocumentReferenceType[] DocumentReference { get; set; }

    /// <remarks/>
    public PricingReferenceType PricingReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Delivery")]
    public DeliveryType[] Delivery { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
    public TaxTotalType[] TaxTotal { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge { get; set; }

    /// <remarks/>
    public ItemType Item { get; set; }

    /// <remarks/>
    public PriceType Price { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubDebitNoteLine")]
    public DebitNoteLineType[] SubDebitNoteLine { get; set; }
}