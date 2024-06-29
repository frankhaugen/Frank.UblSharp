/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RemittanceAdviceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class RemittanceAdviceLineType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public UUIDType UUID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DebitLineAmountType DebitLineAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CreditLineAmountType CreditLineAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BalanceAmountType BalanceAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentPurposeCodeType PaymentPurposeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InvoicingPartyReferenceType InvoicingPartyReference { get; set; }

    /// <remarks/>
    public SupplierPartyType AccountingSupplierParty { get; set; }

    /// <remarks/>
    public CustomerPartyType AccountingCustomerParty { get; set; }

    /// <remarks/>
    public CustomerPartyType BuyerCustomerParty { get; set; }

    /// <remarks/>
    public SupplierPartyType SellerSupplierParty { get; set; }

    /// <remarks/>
    public CustomerPartyType OriginatorCustomerParty { get; set; }

    /// <remarks/>
    public PartyType PayeeParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod")]
    public PeriodType[] InvoicePeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BillingReference")]
    public BillingReferenceType[] BillingReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference")]
    public DocumentReferenceType[] DocumentReference { get; set; }

    /// <remarks/>
    public ExchangeRateType ExchangeRate { get; set; }
}