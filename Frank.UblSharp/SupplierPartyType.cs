/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AccountingSupplierParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class SupplierPartyType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public CustomerAssignedAccountIDType CustomerAssignedAccountID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdditionalAccountID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public AdditionalAccountIDType[] AdditionalAccountID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public DataSendingCapabilityType DataSendingCapability { get; set; }

    /// <remarks/>
    public PartyType Party { get; set; }

    /// <remarks/>
    public ContactType DespatchContact { get; set; }

    /// <remarks/>
    public ContactType AccountingContact { get; set; }

    /// <remarks/>
    public ContactType SellerContact { get; set; }
}