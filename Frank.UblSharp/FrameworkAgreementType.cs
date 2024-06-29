/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("FrameworkAgreement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class FrameworkAgreementType
{
    private JustificationType[] justificationField;
    private FrequencyType[] frequencyField;
    private PeriodType durationPeriodField;
    private TenderRequirementType[] subsequentProcessTenderRequirementField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExpectedOperatorQuantityType ExpectedOperatorQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public MaximumOperatorQuantityType MaximumOperatorQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Justification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public JustificationType[] Justification
    {
        get
        {
            return this.justificationField;
        }

        set
        {
            this.justificationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Frequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FrequencyType[] Frequency
    {
        get
        {
            return this.frequencyField;
        }

        set
        {
            this.frequencyField = value;
        }
    }

    /// <remarks/>
    public PeriodType DurationPeriod
    {
        get
        {
            return this.durationPeriodField;
        }

        set
        {
            this.durationPeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubsequentProcessTenderRequirement")]
    public TenderRequirementType[] SubsequentProcessTenderRequirement
    {
        get
        {
            return this.subsequentProcessTenderRequirementField;
        }

        set
        {
            this.subsequentProcessTenderRequirementField = value;
        }
    }
}