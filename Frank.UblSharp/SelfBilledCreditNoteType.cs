/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SelfBilledCreditNote-2")]
[System.Xml.Serialization.XmlRootAttribute("SelfBilledCreditNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:SelfBilledCreditNote-2", IsNullable = false)]
public partial class SelfBilledCreditNoteType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [System.Xml.Serialization.XmlArrayItemAttribute("UBLExtension", IsNullable = false)]
    public UBLExtensionType[] UBLExtensions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UBLVersionIDType UBLVersionID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomizationIDType CustomizationID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileIDType ProfileID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ProfileExecutionIDType ProfileExecutionID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CopyIndicatorType CopyIndicator { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueDateType IssueDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IssueTimeType IssueTime { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxPointDateType TaxPointDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DocumentCurrencyCodeType DocumentCurrencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxCurrencyCodeType TaxCurrencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PricingCurrencyCodeType PricingCurrencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentCurrencyCodeType PaymentCurrencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentAlternativeCurrencyCodeType PaymentAlternativeCurrencyCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostCodeType AccountingCostCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AccountingCostType AccountingCost { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineCountNumericType LineCountNumeric { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PeriodType[] InvoicePeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ResponseType[] DiscrepancyResponse { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public OrderReferenceType OrderReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BillingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public BillingReferenceType[] BillingReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DespatchDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] DespatchDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReceiptDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] ReceiptDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ContractDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] ContractDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("StatementDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] StatementDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OriginatorDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] OriginatorDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DocumentReferenceType[] AdditionalDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SignatureType[] Signature { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType AccountingCustomerParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SupplierPartyType AccountingSupplierParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType PayeeParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CustomerPartyType BuyerCustomerParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public SupplierPartyType SellerSupplierParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PartyType TaxRepresentativeParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Delivery", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DeliveryType[] Delivery { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public DeliveryTermsType[] DeliveryTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PaymentMeansType[] PaymentMeans { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public PaymentTermsType[] PaymentTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public AllowanceChargeType[] AllowanceCharge { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType TaxExchangeRate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType PricingExchangeRate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType PaymentExchangeRate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public ExchangeRateType PaymentAlternativeExchangeRate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public TaxTotalType[] TaxTotal { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public MonetaryTotalType LegalMonetaryTotal { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CreditNoteLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public CreditNoteLineType[] CreditNoteLine { get; set; }
}