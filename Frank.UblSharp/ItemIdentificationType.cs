/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class ItemIdentificationType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public IDType ID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public ExtendedIDType ExtendedID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public BarcodeSymbologyIDType BarcodeSymbologyID { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PhysicalAttribute")]
    public PhysicalAttributeType[] PhysicalAttribute { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension")]
    public DimensionType[] MeasurementDimension { get; set; }

    /// <remarks/>
    public PartyType IssuerParty { get; set; }
}