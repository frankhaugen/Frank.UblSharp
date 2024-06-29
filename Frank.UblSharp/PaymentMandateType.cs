/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PaymentMandate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PaymentMandateType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MandateTypeCodeType MandateTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumPaymentInstructionsNumericType MaximumPaymentInstructionsNumeric { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumPaidAmountType MaximumPaidAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SignatureIDType SignatureID { get; set; }

    /// <remarks/>
    public PartyType PayerParty { get; set; }

    /// <remarks/>
    public FinancialAccountType PayerFinancialAccount { get; set; }

    /// <remarks/>
    public PeriodType ValidityPeriod { get; set; }

    /// <remarks/>
    public PeriodType PaymentReversalPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Clause")]
    public ClauseType[] Clause { get; set; }
}