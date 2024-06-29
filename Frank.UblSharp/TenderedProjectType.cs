/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AwardedTenderedProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TenderedProjectType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public VariantIDType VariantID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FeeAmountType FeeAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public FeeDescriptionType[] FeeDescription { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TenderEnvelopeIDType TenderEnvelopeID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode { get; set; }

    /// <remarks/>
    public ProcurementProjectLotType ProcurementProjectLot { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EvidenceDocumentReference")]
    public DocumentReferenceType[] EvidenceDocumentReference { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
    public TaxTotalType[] TaxTotal { get; set; }

    /// <remarks/>
    public MonetaryTotalType LegalMonetaryTotal { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TenderLine")]
    public TenderLineType[] TenderLine { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionResponse")]
    public AwardingCriterionResponseType[] AwardingCriterionResponse { get; set; }
}