/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.9037.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable = false)]
public partial class TransportationSegmentType
{
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public SequenceNumericType SequenceNumeric { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
    public TransportExecutionPlanReferenceIDType TransportExecutionPlanReferenceID { get; set; }

    /// <remarks/>
    public TransportationServiceType TransportationService { get; set; }

    /// <remarks/>
    public PartyType TransportServiceProviderParty { get; set; }

    /// <remarks/>
    public ConsignmentType ReferencedConsignment { get; set; }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ShipmentStage")]
    public ShipmentStageType[] ShipmentStage { get; set; }
}