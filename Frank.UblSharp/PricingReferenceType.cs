/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PricingReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class PricingReferenceType
{
    /// <remarks/>
    public ItemLocationQuantityType OriginalItemLocationQuantity { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AlternativeConditionPrice")]
    public PriceType[] AlternativeConditionPrice { get; set; }
}