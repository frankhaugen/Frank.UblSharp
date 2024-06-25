using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define common information related to an address.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Address. Details
/// <para />ObjectClass: Address
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Address", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AddressType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AddressTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__AddressTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AddressFormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__AddressFormatCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Postbox", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__Postbox;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Floor", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__Floor;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Room", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType @__Room;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StreetName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public NameType @__StreetName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalStreetName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public NameType @__AdditionalStreetName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BlockName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public NameType @__BlockName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuildingName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public NameType @__BuildingName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuildingNumber", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public TextType @__BuildingNumber;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InhouseMail", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType @__InhouseMail;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Department", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public TextType @__Department;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MarkAttention", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public TextType @__MarkAttention;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MarkCare", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public TextType @__MarkCare;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public TextType @__PlotIdentification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CitySubdivisionName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public NameType @__CitySubdivisionName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CityName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=17)]
    public NameType @__CityName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PostalZone", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=18)]
    public TextType @__PostalZone;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CountrySubentity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=19)]
    public TextType @__CountrySubentity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CountrySubentityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=20)]
    public CodeType @__CountrySubentityCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Region", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=21)]
    public TextType @__Region;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("District", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=22)]
    public TextType @__District;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TimezoneOffset", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=23)]
    public TextType @__TimezoneOffset;
        
    private System.Collections.Generic.List<AddressLineType> _addressLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AddressLine", Order=24)]
    public AddressLineType[] @__AddressLine
    {
        get
        {
            return _addressLine?.ToArray();
        }
        set
        {
            _addressLine = value == null ? null : new System.Collections.Generic.List<AddressLineType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Country", Order=25)]
    public CountryType @__Country;
        
    private System.Collections.Generic.List<LocationCoordinateType> _locationCoordinate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LocationCoordinate", Order=26)]
    public LocationCoordinateType[] @__LocationCoordinate
    {
        get
        {
            return _locationCoordinate?.ToArray();
        }
        set
        {
            _locationCoordinate = value == null ? null : new System.Collections.Generic.List<LocationCoordinateType>(value);
        }
    }
        
    /// <summary>
    /// An unstructured address line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Address. Address Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Address Line
    /// <para />AssociatedObjectClass: Address Line
    /// <para />RepresentationTerm: Address Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AddressLineType> AddressLine
    {
        get { return _addressLine ?? (_addressLine = new System.Collections.Generic.List<AddressLineType>()); }
        set { _addressLine = value; }
    }

        
    /// <summary>
    /// The geographical coordinates of this address.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Address. Location Coordinate
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Location Coordinate
    /// <para />AssociatedObjectClass: Location Coordinate
    /// <para />RepresentationTerm: Location Coordinate
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LocationCoordinateType> LocationCoordinate
    {
        get { return _locationCoordinate ?? (_locationCoordinate = new System.Collections.Generic.List<LocationCoordinateType>()); }
        set { _locationCoordinate = value; }
    }

        
    /// <summary>
    /// An identifier for this address within an agreed scheme of address identifiers.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: DetailsKey
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code signifying the type of this address.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Address Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Address Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AddressTypeCode
    {
        get
        {
            if (__AddressTypeCode == null) { __AddressTypeCode = new CodeType(); }
            return __AddressTypeCode;
        }
        set
        {
            __AddressTypeCode = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code signifying the format of this address.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Address Format Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Address Format Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AddressFormatCode
    {
        get
        {
            if (__AddressFormatCode == null) { __AddressFormatCode = new CodeType(); }
            return __AddressFormatCode;
        }
        set
        {
            __AddressFormatCode = value;
        }
    }

        
    /// <summary>
    /// A post office box number registered for postal delivery by a postal service provider.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Postbox. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Postbox
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: PostBox, PO Box
    /// </summary>
    /// <example>123</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Postbox
    {
        get
        {
            if (__Postbox == null) { __Postbox = new TextType(); }
            return __Postbox;
        }
        set
        {
            __Postbox = value;
        }
    }

        
    /// <summary>
    /// An identifiable floor of a building.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Floor. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Floor
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: SubPremiseNumber
    /// </summary>
    /// <example>30</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Floor
    {
        get
        {
            if (__Floor == null) { __Floor = new TextType(); }
            return __Floor;
        }
        set
        {
            __Floor = value;
        }
    }

        
    /// <summary>
    /// An identifiable room, suite, or apartment of a building.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Room. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Room
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: SubPremiseNumber
    /// </summary>
    /// <example>Reception</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Room
    {
        get
        {
            if (__Room == null) { __Room = new TextType(); }
            return __Room;
        }
        set
        {
            __Room = value;
        }
    }

        
    /// <summary>
    /// The name of the street, road, avenue, way, etc. to which the number of the building is attached.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Street Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Street Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// <para />AlternativeBusinessTerms: Thoroughfare
    /// </summary>
    /// <example>Kwun Tong Road</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType StreetName
    {
        get
        {
            if (__StreetName == null) { __StreetName = new NameType(); }
            return __StreetName;
        }
        set
        {
            __StreetName = value;
        }
    }

        
    /// <summary>
    /// An additional street name used to further clarify the address.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Additional_ Street Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Street Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// <para />AlternativeBusinessTerms: Thoroughfare
    /// </summary>
    /// <example>Cnr Aberdeen Road</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType AdditionalStreetName
    {
        get
        {
            if (__AdditionalStreetName == null) { __AdditionalStreetName = new NameType(); }
            return __AdditionalStreetName;
        }
        set
        {
            __AdditionalStreetName = value;
        }
    }

        
    /// <summary>
    /// The name of the block (an area surrounded by streets and usually containing several buildings) in which this address is located.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Block Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Block Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Seabird</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType BlockName
    {
        get
        {
            if (__BlockName == null) { __BlockName = new NameType(); }
            return __BlockName;
        }
        set
        {
            __BlockName = value;
        }
    }

        
    /// <summary>
    /// The name of a building.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Building Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Building Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// <para />AlternativeBusinessTerms: BuildingName
    /// </summary>
    /// <example>Plot 421</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType BuildingName
    {
        get
        {
            if (__BuildingName == null) { __BuildingName = new NameType(); }
            return __BuildingName;
        }
        set
        {
            __BuildingName = value;
        }
    }

        
    /// <summary>
    /// The number of a building within the street.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Building Number. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Building Number
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: PremiseNumber
    /// </summary>
    /// <example>388</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType BuildingNumber
    {
        get
        {
            if (__BuildingNumber == null) { __BuildingNumber = new TextType(); }
            return __BuildingNumber;
        }
        set
        {
            __BuildingNumber = value;
        }
    }

        
    /// <summary>
    /// The specific identifable location within a building where mail is delivered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Inhouse_ Mail. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTermQualifier: Inhouse
    /// <para />PropertyTerm: Mail
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: MailStop
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType InhouseMail
    {
        get
        {
            if (__InhouseMail == null) { __InhouseMail = new TextType(); }
            return __InhouseMail;
        }
        set
        {
            __InhouseMail = value;
        }
    }

        
    /// <summary>
    /// The department of the addressee.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Department. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Department
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: Department
    /// </summary>
    /// <example>Accounts Payable</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Department
    {
        get
        {
            if (__Department == null) { __Department = new TextType(); }
            return __Department;
        }
        set
        {
            __Department = value;
        }
    }

        
    /// <summary>
    /// The name, expressed as text, of a person or department in an organization to whose attention incoming mail is directed; corresponds to the printed forms &quot;for the attention of&quot;, &quot;FAO&quot;, and ATTN:&quot;.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Mark Attention. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Mark Attention
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MarkAttention
    {
        get
        {
            if (__MarkAttention == null) { __MarkAttention = new TextType(); }
            return __MarkAttention;
        }
        set
        {
            __MarkAttention = value;
        }
    }

        
    /// <summary>
    /// The name, expressed as text, of a person or organization at this address into whose care incoming mail is entrusted; corresponds to the printed forms &quot;care of&quot; and &quot;c/o&quot;.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Mark Care. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Mark Care
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType MarkCare
    {
        get
        {
            if (__MarkCare == null) { __MarkCare = new TextType(); }
            return __MarkCare;
        }
        set
        {
            __MarkCare = value;
        }
    }

        
    /// <summary>
    /// An identifier (e.g., a parcel number) for the piece of land associated with this address.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Plot Identification. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Plot Identification
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PlotIdentification
    {
        get
        {
            if (__PlotIdentification == null) { __PlotIdentification = new TextType(); }
            return __PlotIdentification;
        }
        set
        {
            __PlotIdentification = value;
        }
    }

        
    /// <summary>
    /// The name of the subdivision of a city, town, or village in which this address is located, such as the name of its district or borough.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. City Subdivision Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: City Subdivision Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType CitySubdivisionName
    {
        get
        {
            if (__CitySubdivisionName == null) { __CitySubdivisionName = new NameType(); }
            return __CitySubdivisionName;
        }
        set
        {
            __CitySubdivisionName = value;
        }
    }

        
    /// <summary>
    /// The name of a city, town, or village.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. City Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: City Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// <para />AlternativeBusinessTerms: LocalityName
    /// </summary>
    /// <example>Hong Kong</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType CityName
    {
        get
        {
            if (__CityName == null) { __CityName = new NameType(); }
            return __CityName;
        }
        set
        {
            __CityName = value;
        }
    }

        
    /// <summary>
    /// The postal identifier for this address according to the relevant national postal service, such as a ZIP code or Post Code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Postal_ Zone. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTermQualifier: Postal
    /// <para />PropertyTerm: Zone
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: PostalCodeNumber
    /// </summary>
    /// <example>SW11 4EW 2500 GG</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PostalZone
    {
        get
        {
            if (__PostalZone == null) { __PostalZone = new TextType(); }
            return __PostalZone;
        }
        set
        {
            __PostalZone = value;
        }
    }

        
    /// <summary>
    /// The political or administrative division of a country in which this address is located, such as the name of its county, province, or state, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Country Subentity. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Country Subentity
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: AdministrativeArea, State, Country, Shire, Canton
    /// </summary>
    /// <example>Florida , Tamilnadu</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CountrySubentity
    {
        get
        {
            if (__CountrySubentity == null) { __CountrySubentity = new TextType(); }
            return __CountrySubentity;
        }
        set
        {
            __CountrySubentity = value;
        }
    }

        
    /// <summary>
    /// The political or administrative division of a country in which this address is located, such as a county, province, or state, expressed as a code (typically nationally agreed).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Country Subentity Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Country Subentity Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: AdministrativeAreaCode, State Code
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CountrySubentityCode
    {
        get
        {
            if (__CountrySubentityCode == null) { __CountrySubentityCode = new CodeType(); }
            return __CountrySubentityCode;
        }
        set
        {
            __CountrySubentityCode = value;
        }
    }

        
    /// <summary>
    /// The recognized geographic or economic region or group of countries in which this address is located.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Region. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Region
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: LocalityName, Economic Zone
    /// </summary>
    /// <example>European Union</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Region
    {
        get
        {
            if (__Region == null) { __Region = new TextType(); }
            return __Region;
        }
        set
        {
            __Region = value;
        }
    }

        
    /// <summary>
    /// The district or geographical division of a country or region in which this address is located.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. District. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: District
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// <para />AlternativeBusinessTerms: LocalityName, Area
    /// </summary>
    /// <example>East Coast</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType District
    {
        get
        {
            if (__District == null) { __District = new TextType(); }
            return __District;
        }
        set
        {
            __District = value;
        }
    }

        
    /// <summary>
    /// The time zone in which this address is located (as an offset from Universal Coordinated Time (UTC)) at the time of exchange.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Address. Timezone Offset. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Timezone Offset
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>+8:00 -3:00</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TimezoneOffset
    {
        get
        {
            if (__TimezoneOffset == null) { __TimezoneOffset = new TextType(); }
            return __TimezoneOffset;
        }
        set
        {
            __TimezoneOffset = value;
        }
    }

        
    /// <summary>
    /// The country in which this address is situated.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Address. Country
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Address
    /// <para />PropertyTerm: Country
    /// <para />AssociatedObjectClass: Country
    /// <para />RepresentationTerm: Country
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CountryType Country
    {
        get
        {
            if (__Country == null) { __Country = new CountryType(); }
            return __Country;
        }
        set
        {
            __Country = value;
        }
    }

}