using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a transportation service.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transportation Service. Details
/// <para />ObjectClass: Transportation Service
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportationServiceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportServiceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__TransportServiceCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TariffClassCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__TariffClassCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Priority", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__Priority;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FreightRateClassCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__FreightRateClassCode;
        
    private System.Collections.Generic.List<TextType> _transportationServiceDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportationServiceDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__TransportationServiceDescription
    {
        get
        {
            return _transportationServiceDescription?.ToArray();
        }
        set
        {
            _transportationServiceDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportationServiceDetailsURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IdentifierType @__TransportationServiceDetailsURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NominationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public DateType @__NominationDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NominationTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TimeType @__NominationTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public NumericType @__SequenceNumeric;
        
    private System.Collections.Generic.List<TransportEquipmentType> _transportEquipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEquipment", Order=10)]
    public TransportEquipmentType[] @__TransportEquipment
    {
        get
        {
            return _transportEquipment?.ToArray();
        }
        set
        {
            _transportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEquipmentType> _supportedTransportEquipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupportedTransportEquipment", Order=11)]
    public TransportEquipmentType[] @__SupportedTransportEquipment
    {
        get
        {
            return _supportedTransportEquipment?.ToArray();
        }
        set
        {
            _supportedTransportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<TransportEquipmentType> _unsupportedTransportEquipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnsupportedTransportEquipment", Order=12)]
    public TransportEquipmentType[] @__UnsupportedTransportEquipment
    {
        get
        {
            return _unsupportedTransportEquipment?.ToArray();
        }
        set
        {
            _unsupportedTransportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
        }
    }
        
    private System.Collections.Generic.List<CommodityClassificationType> _commodityClassification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CommodityClassification", Order=13)]
    public CommodityClassificationType[] @__CommodityClassification
    {
        get
        {
            return _commodityClassification?.ToArray();
        }
        set
        {
            _commodityClassification = value == null ? null : new System.Collections.Generic.List<CommodityClassificationType>(value);
        }
    }
        
    private System.Collections.Generic.List<CommodityClassificationType> _supportedCommodityClassification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SupportedCommodityClassification", Order=14)]
    public CommodityClassificationType[] @__SupportedCommodityClassification
    {
        get
        {
            return _supportedCommodityClassification?.ToArray();
        }
        set
        {
            _supportedCommodityClassification = value == null ? null : new System.Collections.Generic.List<CommodityClassificationType>(value);
        }
    }
        
    private System.Collections.Generic.List<CommodityClassificationType> _unsupportedCommodityClassification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UnsupportedCommodityClassification", Order=15)]
    public CommodityClassificationType[] @__UnsupportedCommodityClassification
    {
        get
        {
            return _unsupportedCommodityClassification?.ToArray();
        }
        set
        {
            _unsupportedCommodityClassification = value == null ? null : new System.Collections.Generic.List<CommodityClassificationType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalCapacityDimension", Order=16)]
    public DimensionType @__TotalCapacityDimension;
        
    private System.Collections.Generic.List<ShipmentStageType> _shipmentStage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipmentStage", Order=17)]
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
        
    private System.Collections.Generic.List<TransportEventType> _transportEvent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEvent", Order=18)]
    public TransportEventType[] @__TransportEvent
    {
        get
        {
            return _transportEvent?.ToArray();
        }
        set
        {
            _transportEvent = value == null ? null : new System.Collections.Generic.List<TransportEventType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResponsibleTransportServiceProviderParty", Order=19)]
    public PartyType @__ResponsibleTransportServiceProviderParty;
        
    private System.Collections.Generic.List<EnvironmentalEmissionType> _environmentalEmission;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission", Order=20)]
    public EnvironmentalEmissionType[] @__EnvironmentalEmission
    {
        get
        {
            return _environmentalEmission?.ToArray();
        }
        set
        {
            _environmentalEmission = value == null ? null : new System.Collections.Generic.List<EnvironmentalEmissionType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedDurationPeriod", Order=21)]
    public PeriodType @__EstimatedDurationPeriod;
        
    private System.Collections.Generic.List<ServiceFrequencyType> _scheduledServiceFrequency;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ScheduledServiceFrequency", Order=22)]
    public ServiceFrequencyType[] @__ScheduledServiceFrequency
    {
        get
        {
            return _scheduledServiceFrequency?.ToArray();
        }
        set
        {
            _scheduledServiceFrequency = value == null ? null : new System.Collections.Generic.List<ServiceFrequencyType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this transportation service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Transportation Service Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Transportation Service Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> TransportationServiceDescription
    {
        get { return _transportationServiceDescription ?? (_transportationServiceDescription = new System.Collections.Generic.List<TextType>()); }
        set { _transportationServiceDescription = value; }
    }

        
    /// <summary>
    /// A piece of transport equipment used in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Transport Equipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentType> TransportEquipment
    {
        get { return _transportEquipment ?? (_transportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
        set { _transportEquipment = value; }
    }

        
    /// <summary>
    /// A piece of transport equipment supported in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Supported_ Transport Equipment. Transport Equipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Supported
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentType> SupportedTransportEquipment
    {
        get { return _supportedTransportEquipment ?? (_supportedTransportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
        set { _supportedTransportEquipment = value; }
    }

        
    /// <summary>
    /// A piece of transport equipment that is not supported in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Unsupported_ Transport Equipment. Transport Equipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Unsupported
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentType> UnsupportedTransportEquipment
    {
        get { return _unsupportedTransportEquipment ?? (_unsupportedTransportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
        set { _unsupportedTransportEquipment = value; }
    }

        
    /// <summary>
    /// A classification of this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Commodity Classification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Commodity Classification
    /// <para />AssociatedObjectClass: Commodity Classification
    /// <para />RepresentationTerm: Commodity Classification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CommodityClassificationType> CommodityClassification
    {
        get { return _commodityClassification ?? (_commodityClassification = new System.Collections.Generic.List<CommodityClassificationType>()); }
        set { _commodityClassification = value; }
    }

        
    /// <summary>
    /// A classification (e.g., general cargo) for commodities that can be handled in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Supported_ Commodity Classification. Commodity Classification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Supported
    /// <para />PropertyTerm: Commodity Classification
    /// <para />AssociatedObjectClass: Commodity Classification
    /// <para />RepresentationTerm: Commodity Classification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CommodityClassificationType> SupportedCommodityClassification
    {
        get { return _supportedCommodityClassification ?? (_supportedCommodityClassification = new System.Collections.Generic.List<CommodityClassificationType>()); }
        set { _supportedCommodityClassification = value; }
    }

        
    /// <summary>
    /// A classification for commodities that cannot be handled in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Unsupported_ Commodity Classification. Commodity Classification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Unsupported
    /// <para />PropertyTerm: Commodity Classification
    /// <para />AssociatedObjectClass: Commodity Classification
    /// <para />RepresentationTerm: Commodity Classification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CommodityClassificationType> UnsupportedCommodityClassification
    {
        get { return _unsupportedCommodityClassification ?? (_unsupportedCommodityClassification = new System.Collections.Generic.List<CommodityClassificationType>()); }
        set { _unsupportedCommodityClassification = value; }
    }

        
    /// <summary>
    /// One of the stages of shipment in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Shipment Stage
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
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
    /// One of the transport events taking place in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Transport Event
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Transport Event
    /// <para />AssociatedObjectClass: Transport Event
    /// <para />RepresentationTerm: Transport Event
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEventType> TransportEvent
    {
        get { return _transportEvent ?? (_transportEvent = new System.Collections.Generic.List<TransportEventType>()); }
        set { _transportEvent = value; }
    }

        
    /// <summary>
    /// An environmental emission resulting from this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Environmental Emission
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Environmental Emission
    /// <para />AssociatedObjectClass: Environmental Emission
    /// <para />RepresentationTerm: Environmental Emission
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EnvironmentalEmissionType> EnvironmentalEmission
    {
        get { return _environmentalEmission ?? (_environmentalEmission = new System.Collections.Generic.List<EnvironmentalEmissionType>()); }
        set { _environmentalEmission = value; }
    }

        
    /// <summary>
    /// A class to specify which day of the week a transport service is operational.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Scheduled_ Service Frequency. Service Frequency
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Scheduled
    /// <para />PropertyTerm: Service Frequency
    /// <para />AssociatedObjectClass: Service Frequency
    /// <para />RepresentationTerm: Service Frequency
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ServiceFrequencyType> ScheduledServiceFrequency
    {
        get { return _scheduledServiceFrequency ?? (_scheduledServiceFrequency = new System.Collections.Generic.List<ServiceFrequencyType>()); }
        set { _scheduledServiceFrequency = value; }
    }

        
    /// <summary>
    /// A code signifying the extent of this transportation service (e.g., door-to-door, port-to-port).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Transport Service Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Transport Service Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportServiceCode
    {
        get
        {
            if (__TransportServiceCode == null) { __TransportServiceCode = new CodeType(); }
            return __TransportServiceCode;
        }
        set
        {
            __TransportServiceCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the tariff class applicable to this transportation service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Tariff Class Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Tariff Class Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Tariff Class Specifier
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TariffClassCode
    {
        get
        {
            if (__TariffClassCode == null) { __TariffClassCode = new CodeType(); }
            return __TariffClassCode;
        }
        set
        {
            __TariffClassCode = value;
        }
    }

        
    /// <summary>
    /// The priority of this transportation service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Priority. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Priority
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Priority
    {
        get
        {
            if (__Priority == null) { __Priority = new TextType(); }
            return __Priority;
        }
        set
        {
            __Priority = value;
        }
    }

        
    /// <summary>
    /// A code signifying the rate class for freight in this transportation service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Freight Rate Class Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Freight Rate Class Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Charge Basis
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType FreightRateClassCode
    {
        get
        {
            if (__FreightRateClassCode == null) { __FreightRateClassCode = new CodeType(); }
            return __FreightRateClassCode;
        }
        set
        {
            __FreightRateClassCode = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) of a document providing additional details regarding this transportation service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Transportation Service Details URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Transportation Service Details URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TransportationServiceDetailsURI
    {
        get
        {
            if (__TransportationServiceDetailsURI == null) { __TransportationServiceDetailsURI = new IdentifierType(); }
            return __TransportationServiceDetailsURI;
        }
        set
        {
            __TransportationServiceDetailsURI = value;
        }
    }

        
    /// <summary>
    /// In a transport contract, the deadline date by which this transportation service has to be booked. For example, if this service is scheduled for Wednesday 16 February 2011 at 10 a.m. CET, the nomination date might be Tuesday15 February 2011.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Nomination Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Nomination Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType NominationDate
    {
        get
        {
            if (__NominationDate == null) { __NominationDate = new DateType(); }
            return __NominationDate;
        }
        set
        {
            __NominationDate = value;
        }
    }

        
    /// <summary>
    /// In a transport contract, the deadline time by which this transportation service has to be booked. For example, if this service is scheduled for Wednesday 16 February 2011 at 10 a.m. CET, the nomination date might be Tuesday15 February 2011 and the nomination time 4 p.m. at the latest.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Nomination Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Nomination Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType NominationTime
    {
        get
        {
            if (__NominationTime == null) { __NominationTime = new TimeType(); }
            return __NominationTime;
        }
        set
        {
            __NominationTime = value;
        }
    }

        
    /// <summary>
    /// The name of this transportation service.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType Name
    {
        get
        {
            if (__Name == null) { __Name = new NameType(); }
            return __Name;
        }
        set
        {
            __Name = value;
        }
    }

        
    /// <summary>
    /// A number indicating the order of this transportation service in a sequence of transportation services.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transportation Service. Sequence. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTerm: Sequence
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
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
    /// The total capacity or volume available in this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Total Capacity_ Dimension. Dimension
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Total Capacity
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DimensionType TotalCapacityDimension
    {
        get
        {
            if (__TotalCapacityDimension == null) { __TotalCapacityDimension = new DimensionType(); }
            return __TotalCapacityDimension;
        }
        set
        {
            __TotalCapacityDimension = value;
        }
    }

        
    /// <summary>
    /// The transport service provider responsible for this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Responsible Transport Service Provider_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Responsible Transport Service Provider
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ResponsibleTransportServiceProviderParty
    {
        get
        {
            if (__ResponsibleTransportServiceProviderParty == null) { __ResponsibleTransportServiceProviderParty = new PartyType(); }
            return __ResponsibleTransportServiceProviderParty;
        }
        set
        {
            __ResponsibleTransportServiceProviderParty = value;
        }
    }

        
    /// <summary>
    /// The estimated duration of this transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transportation Service. Estimated Duration_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transportation Service
    /// <para />PropertyTermQualifier: Estimated Duration
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType EstimatedDurationPeriod
    {
        get
        {
            if (__EstimatedDurationPeriod == null) { __EstimatedDurationPeriod = new PeriodType(); }
            return __EstimatedDurationPeriod;
        }
        set
        {
            __EstimatedDurationPeriod = value;
        }
    }

}