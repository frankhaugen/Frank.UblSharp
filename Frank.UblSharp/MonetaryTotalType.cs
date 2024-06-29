/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AnticipatedMonetaryTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class MonetaryTotalType
{
    private TaxInclusiveAmountType taxInclusiveAmountField;
    private AllowanceTotalAmountType allowanceTotalAmountField;
    private ChargeTotalAmountType chargeTotalAmountField;
    private PrepaidAmountType prepaidAmountField;
    private PayableRoundingAmountType payableRoundingAmountField;
    private PayableAmountType payableAmountField;
    private PayableAlternativeAmountType payableAlternativeAmountField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public LineExtensionAmountType LineExtensionAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxExclusiveAmountType TaxExclusiveAmount { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TaxInclusiveAmountType TaxInclusiveAmount
    {
        get
        {
            return this.taxInclusiveAmountField;
        }

        set
        {
            this.taxInclusiveAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AllowanceTotalAmountType AllowanceTotalAmount
    {
        get
        {
            return this.allowanceTotalAmountField;
        }

        set
        {
            this.allowanceTotalAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ChargeTotalAmountType ChargeTotalAmount
    {
        get
        {
            return this.chargeTotalAmountField;
        }

        set
        {
            this.chargeTotalAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PrepaidAmountType PrepaidAmount
    {
        get
        {
            return this.prepaidAmountField;
        }

        set
        {
            this.prepaidAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayableRoundingAmountType PayableRoundingAmount
    {
        get
        {
            return this.payableRoundingAmountField;
        }

        set
        {
            this.payableRoundingAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayableAmountType PayableAmount
    {
        get
        {
            return this.payableAmountField;
        }

        set
        {
            this.payableAmountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public PayableAlternativeAmountType PayableAlternativeAmount
    {
        get
        {
            return this.payableAlternativeAmountField;
        }

        set
        {
            this.payableAlternativeAmountField = value;
        }
    }
}