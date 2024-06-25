using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe one segment or leg in a transportation service.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transportation Segment. Details
/// <para />ObjectClass: Transportation Segment
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportationSegment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportationSegmentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NumericType @__SequenceNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportExecutionPlanReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__TransportExecutionPlanReferenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportationService", Order=2)]
    public TransportationServiceType @__TransportationService;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderParty", Order=3)]
    public PartyType @__TransportServiceProviderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferencedConsignment", Order=4)]
    public ConsignmentType @__ReferencedConsignment;
        
    private System.Collections.Generic.List<ShipmentStageType> _shipmentStage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipmentStage", Order=5)]
    public ShipmentStageType[] @__ShipmentStage
    {
        get
        {
            return _shipmentStage?.ToArray();
        }
        set
        {
            _shipmentStage = value == null ? null : new System.Collections.Generic.List<ShipmentStageType>(value);
        }
    }
        
    /// <summary>
    /// The shipment stage associated with this transportation segment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Segment. Shipment Stage
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Segment
    /// <para />PropertyTerm: Shipment Stage
    /// <para />AssociatedObjectClass: Shipment Stage
    /// <para />RepresentationTerm: Shipment Stage
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentStageType> ShipmentStage
    {
        get { return _shipmentStage ?? (_shipmentStage = new System.Collections.Generic.List<ShipmentStageType>()); }
        set { _shipmentStage = value; }
    }

        
    /// <summary>
    /// A number indicating the order of this segment in the sequence of transportation segments making up a transportation service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Segment. Sequence. Numeric
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Transportation Segment
    /// <para />PropertyTerm: Sequence
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    /// <example>1, 2, 3, 4, etc.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType SequenceNumeric
    {
        get
        {
            if (__SequenceNumeric == null) { __SequenceNumeric = new NumericType(); }
            return __SequenceNumeric;
        }
        set
        {
            __SequenceNumeric = value;
        }
    }

        
    /// <summary>
    /// An identifier for the transport execution plan governing this transportation segment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Segment. Transport Execution Plan Reference. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Segment
    /// <para />PropertyTerm: Transport Execution Plan Reference
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TransportExecutionPlanReferenceID
    {
        get
        {
            if (__TransportExecutionPlanReferenceID == null) { __TransportExecutionPlanReferenceID = new IdentifierType(); }
            return __TransportExecutionPlanReferenceID;
        }
        set
        {
            __TransportExecutionPlanReferenceID = value;
        }
    }

        
    /// <summary>
    /// The transportation service used in this transportation segment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Segment. Transportation Service
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Transportation Segment
    /// <para />PropertyTerm: Transportation Service
    /// <para />AssociatedObjectClass: Transportation Service
    /// <para />RepresentationTerm: Transportation Service
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TransportationServiceType TransportationService
    {
        get
        {
            if (__TransportationService == null) { __TransportationService = new TransportationServiceType(); }
            return __TransportationService;
        }
        set
        {
            __TransportationService = value;
        }
    }

        
    /// <summary>
    /// The transport service provider responsible for carrying out transportation services in this transportation segment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Segment. Transport Service Provider_ Party. Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Transportation Segment
    /// <para />PropertyTermQualifier: Transport Service Provider
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType TransportServiceProviderParty
    {
        get
        {
            if (__TransportServiceProviderParty == null) { __TransportServiceProviderParty = new PartyType(); }
            return __TransportServiceProviderParty;
        }
        set
        {
            __TransportServiceProviderParty = value;
        }
    }

        
    /// <summary>
    /// A consignment referenced in this transportation segment. Such a consignment may have different identifiers than the consignment identifiers being used in the transportation service agreed between the transport user and the transport service provider.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Segment. Referenced_ Consignment. Consignment
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Segment
    /// <para />PropertyTermQualifier: Referenced
    /// <para />PropertyTerm: Consignment
    /// <para />AssociatedObjectClass: Consignment
    /// <para />RepresentationTerm: Consignment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ConsignmentType ReferencedConsignment
    {
        get
        {
            if (__ReferencedConsignment == null) { __ReferencedConsignment = new ConsignmentType(); }
            return __ReferencedConsignment;
        }
        set
        {
            __ReferencedConsignment = value;
        }
    }

}