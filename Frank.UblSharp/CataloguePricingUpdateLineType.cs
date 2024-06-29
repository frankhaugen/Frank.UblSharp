/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CataloguePricingUpdateLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class CataloguePricingUpdateLineType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    public CustomerPartyType ContractorCustomerParty { get; set; }

    /// <remarks/>
    public SupplierPartyType SellerSupplierParty { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RequiredItemLocationQuantity")]
    public ItemLocationQuantityType[] RequiredItemLocationQuantity { get; set; }
}