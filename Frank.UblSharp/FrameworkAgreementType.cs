/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("FrameworkAgreement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class FrameworkAgreementType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpectedOperatorQuantityType ExpectedOperatorQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumOperatorQuantityType MaximumOperatorQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Justification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public JustificationType[] Justification { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Frequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FrequencyType[] Frequency { get; set; }

    /// <remarks/>
    public PeriodType DurationPeriod { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubsequentProcessTenderRequirement")]
    public TenderRequirementType[] SubsequentProcessTenderRequirement { get; set; }
}