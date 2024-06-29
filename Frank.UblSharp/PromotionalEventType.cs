/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PromotionalEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PromotionalEventType
{
    private FirstShipmentAvailibilityDateType firstShipmentAvailibilityDateField;
    private LatestProposalAcceptanceDateType latestProposalAcceptanceDateField;
    private PromotionalSpecificationType[] promotionalSpecificationField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PromotionalEventTypeCodeType PromotionalEventTypeCode { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SubmissionDateType SubmissionDate { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FirstShipmentAvailibilityDateType FirstShipmentAvailibilityDate
    {
        get
        {
            return this.firstShipmentAvailibilityDateField;
        }

        set
        {
            this.firstShipmentAvailibilityDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LatestProposalAcceptanceDateType LatestProposalAcceptanceDate
    {
        get
        {
            return this.latestProposalAcceptanceDateField;
        }

        set
        {
            this.latestProposalAcceptanceDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PromotionalSpecification")]
    public PromotionalSpecificationType[] PromotionalSpecification
    {
        get
        {
            return this.promotionalSpecificationField;
        }

        set
        {
            this.promotionalSpecificationField = value;
        }
    }
}