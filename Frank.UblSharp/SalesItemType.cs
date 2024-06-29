/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SalesItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class SalesItemType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public QuantityType2 Quantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActivityProperty")]
    public ActivityPropertyType[] ActivityProperty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxExclusivePrice")]
    public PriceType[] TaxExclusivePrice { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("TaxInclusivePrice")]
    public PriceType[] TaxInclusivePrice { get; set; }

    /// <remarks/>
    public ItemType Item { get; set; }
}