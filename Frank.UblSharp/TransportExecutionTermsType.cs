/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportExecutionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TransportExecutionTermsType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportUserSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportUserSpecialTermsType[] TransportUserSpecialTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportServiceProviderSpecialTermsType[] TransportServiceProviderSpecialTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ChangeConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChangeConditionsType[] ChangeConditions { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms")]
    public PaymentTermsType[] PaymentTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms")]
    public DeliveryTermsType[] DeliveryTerms { get; set; }

    /// <remarks/>
    public PaymentTermsType BonusPaymentTerms { get; set; }

    /// <remarks/>
    public PaymentTermsType CommissionPaymentTerms { get; set; }

    /// <remarks/>
    public PaymentTermsType PenaltyPaymentTerms { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission")]
    public EnvironmentalEmissionType[] EnvironmentalEmission { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NotificationRequirement")]
    public NotificationRequirementType[] NotificationRequirement { get; set; }

    /// <remarks/>
    public PaymentTermsType ServiceChargePaymentTerms { get; set; }
}