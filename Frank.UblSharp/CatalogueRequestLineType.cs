/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueRequestLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class CatalogueRequestLineType
{
    private NoteType[] noteField;
    private PeriodType lineValidityPeriodField;
    private ItemLocationQuantityType[] requiredItemLocationQuantityField;
    private ItemType itemField;
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ContractSubdivisionType ContractSubdivision { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public NoteType[] Note
    {
        get
        {
            return this.noteField;
        }

        set
        {
            this.noteField = value;
        }
    }

    /// <remarks/>
    public PeriodType LineValidityPeriod
    {
        get
        {
            return this.lineValidityPeriodField;
        }

        set
        {
            this.lineValidityPeriodField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
    public ItemLocationQuantityType[] RequiredItemLocationQuantity
    {
        get
        {
            return this.requiredItemLocationQuantityField;
        }

        set
        {
            this.requiredItemLocationQuantityField = value;
        }
    }

    /// <remarks/>
    public ItemType Item
    {
        get
        {
            return this.itemField;
        }

        set
        {
            this.itemField = value;
        }
    }
}