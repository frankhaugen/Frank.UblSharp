using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a particular vehicle or vessel used for the conveyance of goods or persons.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transport Means. Details
/// <para />ObjectClass: Transport Means
/// <para />AlternativeBusinessTerms: Conveyance
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ApplicableTransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ApplicableTransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportMeansType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("JourneyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__JourneyID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationNationalityID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__RegistrationNationalityID;
        
    private System.Collections.Generic.List<TextType> _registrationNationality;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationNationality", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__RegistrationNationality
    {
        get
        {
            return _registrationNationality?.ToArray();
        }
        set
        {
            _registrationNationality = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DirectionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__DirectionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportMeansTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__TransportMeansTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TradeServiceCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__TradeServiceCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Stowage", Order=6)]
    public StowageType @__Stowage;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AirTransport", Order=7)]
    public AirTransportType @__AirTransport;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RoadTransport", Order=8)]
    public RoadTransportType @__RoadTransport;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RailTransport", Order=9)]
    public RailTransportType @__RailTransport;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaritimeTransport", Order=10)]
    public MaritimeTransportType @__MaritimeTransport;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OwnerParty", Order=11)]
    public PartyType @__OwnerParty;
        
    private System.Collections.Generic.List<DimensionType> _measurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order=12)]
    public DimensionType[] @__MeasurementDimension
    {
        get
        {
            return _measurementDimension?.ToArray();
        }
        set
        {
            _measurementDimension = value == null ? null : new System.Collections.Generic.List<DimensionType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the country in which this means of transport is registered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Means. Registration_ Nationality. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTermQualifier: Registration
    /// <para />PropertyTerm: Nationality
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Flag of Vessel, Nationality of Ship
    /// </summary>
    /// <example>Liberia</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> RegistrationNationality
    {
        get { return _registrationNationality ?? (_registrationNationality = new System.Collections.Generic.List<TextType>()); }
        set { _registrationNationality = value; }
    }

        
    /// <summary>
    /// A measurable dimension (length, mass, weight, or volume) of this means of transport.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Means. Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTermQualifier: Measurement
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DimensionType> MeasurementDimension
    {
        get { return _measurementDimension ?? (_measurementDimension = new System.Collections.Generic.List<DimensionType>()); }
        set { _measurementDimension = value; }
    }

        
    /// <summary>
    /// An identifier for the regular service schedule of this means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Means. Journey Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Journey Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Voyage Number, Scheduled Conveyance Identifier (WCO ID 205), Flight Number
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType JourneyID
    {
        get
        {
            if (__JourneyID == null) { __JourneyID = new IdentifierType(); }
            return __JourneyID;
        }
        set
        {
            __JourneyID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the country in which this means of transport is registered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Means. Registration_ Nationality Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTermQualifier: Registration
    /// <para />PropertyTerm: Nationality Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Nationality of Means of Transport (WCO 175, 178 and 179)
    /// </summary>
    /// <example>LIB</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType RegistrationNationalityID
    {
        get
        {
            if (__RegistrationNationalityID == null) { __RegistrationNationalityID = new IdentifierType(); }
            return __RegistrationNationalityID;
        }
        set
        {
            __RegistrationNationalityID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the direction of this means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Means. Direction Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Direction Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Transit Direction
    /// </summary>
    /// <example>North , East</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DirectionCode
    {
        get
        {
            if (__DirectionCode == null) { __DirectionCode = new CodeType(); }
            return __DirectionCode;
        }
        set
        {
            __DirectionCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of this means of transport (truck, vessel, etc.).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Means. Transport Means Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Transport Means Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportMeansTypeCode
    {
        get
        {
            if (__TransportMeansTypeCode == null) { __TransportMeansTypeCode = new CodeType(); }
            return __TransportMeansTypeCode;
        }
        set
        {
            __TransportMeansTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the service regularly provided by the carrier operating this means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Means. Trade Service Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Trade Service Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TradeServiceCode
    {
        get
        {
            if (__TradeServiceCode == null) { __TradeServiceCode = new CodeType(); }
            return __TradeServiceCode;
        }
        set
        {
            __TradeServiceCode = value;
        }
    }

        
    /// <summary>
    /// The location within the means of transport where goods are to be or have been stowed.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Means. Stowage
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Stowage
    /// <para />AssociatedObjectClass: Stowage
    /// <para />RepresentationTerm: Stowage
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public StowageType Stowage
    {
        get
        {
            if (__Stowage == null) { __Stowage = new StowageType(); }
            return __Stowage;
        }
        set
        {
            __Stowage = value;
        }
    }

        
    /// <summary>
    /// An aircraft used for transport.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Means. Air Transport
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Air Transport
    /// <para />AssociatedObjectClass: Air Transport
    /// <para />RepresentationTerm: Air Transport
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AirTransportType AirTransport
    {
        get
        {
            if (__AirTransport == null) { __AirTransport = new AirTransportType(); }
            return __AirTransport;
        }
        set
        {
            __AirTransport = value;
        }
    }

        
    /// <summary>
    /// A vehicle used for road transport.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Means. Road Transport
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Road Transport
    /// <para />AssociatedObjectClass: Road Transport
    /// <para />RepresentationTerm: Road Transport
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RoadTransportType RoadTransport
    {
        get
        {
            if (__RoadTransport == null) { __RoadTransport = new RoadTransportType(); }
            return __RoadTransport;
        }
        set
        {
            __RoadTransport = value;
        }
    }

        
    /// <summary>
    /// Equipment used for rail transport.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Means. Rail Transport
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Rail Transport
    /// <para />AssociatedObjectClass: Rail Transport
    /// <para />RepresentationTerm: Rail Transport
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RailTransportType RailTransport
    {
        get
        {
            if (__RailTransport == null) { __RailTransport = new RailTransportType(); }
            return __RailTransport;
        }
        set
        {
            __RailTransport = value;
        }
    }

        
    /// <summary>
    /// A vessel used for transport by water (not only by sea).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Means. Maritime Transport
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTerm: Maritime Transport
    /// <para />AssociatedObjectClass: Maritime Transport
    /// <para />RepresentationTerm: Maritime Transport
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MaritimeTransportType MaritimeTransport
    {
        get
        {
            if (__MaritimeTransport == null) { __MaritimeTransport = new MaritimeTransportType(); }
            return __MaritimeTransport;
        }
        set
        {
            __MaritimeTransport = value;
        }
    }

        
    /// <summary>
    /// The party that owns this means of transport.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Means. Owner_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Means
    /// <para />PropertyTermQualifier: Owner
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType OwnerParty
    {
        get
        {
            if (__OwnerParty == null) { __OwnerParty = new PartyType(); }
            return __OwnerParty;
        }
        set
        {
            __OwnerParty = value;
        }
    }

}