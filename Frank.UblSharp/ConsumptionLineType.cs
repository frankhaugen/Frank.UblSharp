/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ConsumptionLineType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ParentDocumentLineReferenceIDType ParentDocumentLineReferenceID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public InvoicedQuantityType InvoicedQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount { get; set; }

    /// <remarks/>
    public PeriodType Period { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Delivery")]
    public DeliveryType[] Delivery { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge")]
    public AllowanceChargeType[] AllowanceCharge { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal")]
    public TaxTotalType[] TaxTotal { get; set; }

    /// <remarks/>
    public UtilityItemType UtilityItem { get; set; }

    /// <remarks/>
    public PriceType Price { get; set; }

    /// <remarks/>
    public UnstructuredPriceType UnstructuredPrice { get; set; }
}