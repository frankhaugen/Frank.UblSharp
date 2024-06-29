/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PaymentMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PaymentMeansType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentMeansCodeType PaymentMeansCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentDueDateType PaymentDueDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentChannelCodeType PaymentChannelCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionIDType InstructionID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("InstructionNote", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InstructionNoteType[] InstructionNote { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PaymentIDType[] PaymentID { get; set; }

    /// <remarks/>
    public CardAccountType CardAccount { get; set; }

    /// <remarks/>
    public FinancialAccountType PayerFinancialAccount { get; set; }

    /// <remarks/>
    public FinancialAccountType PayeeFinancialAccount { get; set; }

    /// <remarks/>
    public CreditAccountType CreditAccount { get; set; }

    /// <remarks/>
    public PaymentMandateType PaymentMandate { get; set; }

    /// <remarks/>
    public TradeFinancingType TradeFinancing { get; set; }
}