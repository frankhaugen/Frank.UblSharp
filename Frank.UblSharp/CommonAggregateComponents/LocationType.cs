using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a location.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Location. Details
/// <para />ObjectClass: Location
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ActivityFinalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ActivityFinalLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class LocationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _conditions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Conditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Conditions
    {
        get
        {
            return _conditions?.ToArray();
        }
        set
        {
            _conditions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CountrySubentity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__CountrySubentity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CountrySubentityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__CountrySubentityCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LocationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__LocationTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InformationURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IdentifierType @__InformationURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public NameType @__Name;
        
    private System.Collections.Generic.List<PeriodType> _validityPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=8)]
    public PeriodType[] @__ValidityPeriod
    {
        get
        {
            return _validityPeriod?.ToArray();
        }
        set
        {
            _validityPeriod = value == null ? null : new System.Collections.Generic.List<PeriodType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Address", Order=9)]
    public AddressType @__Address;
        
    private System.Collections.Generic.List<LocationType> _subsidiaryLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubsidiaryLocation", Order=10)]
    public LocationType[] @__SubsidiaryLocation
    {
        get
        {
            return _subsidiaryLocation?.ToArray();
        }
        set
        {
            _subsidiaryLocation = value == null ? null : new System.Collections.Generic.List<LocationType>(value);
        }
    }
        
    private System.Collections.Generic.List<LocationCoordinateType> _locationCoordinate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LocationCoordinate", Order=11)]
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
    /// Text describing this location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Location
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Free-form text describing the physical conditions of the location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Conditions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Location
    /// <para />PropertyTerm: Conditions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Conditions
    {
        get { return _conditions ?? (_conditions = new System.Collections.Generic.List<TextType>()); }
        set { _conditions = value; }
    }

        
    /// <summary>
    /// A period during which this location can be used (e.g., for delivery).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Location. Validity_ Period. Period
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Location
    /// <para />PropertyTermQualifier: Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PeriodType> ValidityPeriod
    {
        get { return _validityPeriod ?? (_validityPeriod = new System.Collections.Generic.List<PeriodType>()); }
        set { _validityPeriod = value; }
    }

        
    /// <summary>
    /// A location subsidiary to this location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Location. Subsidiary_ Location. Location
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Location
    /// <para />PropertyTermQualifier: Subsidiary
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LocationType> SubsidiaryLocation
    {
        get { return _subsidiaryLocation ?? (_subsidiaryLocation = new System.Collections.Generic.List<LocationType>()); }
        set { _subsidiaryLocation = value; }
    }

        
    /// <summary>
    /// The geographical coordinates of this location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Location. Location Coordinate
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Location
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
    /// An identifier for this location, e.g., the EAN Location Number, GLN.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>5790002221134</example>
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
    /// A territorial division of a country, such as a county or state, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Country Subentity. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location
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
    /// A territorial division of a country, such as a county or state, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Country Subentity Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location
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
    /// A code signifying the type of location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Location Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location
    /// <para />PropertyTerm: Location Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LocationTypeCode
    {
        get
        {
            if (__LocationTypeCode == null) { __LocationTypeCode = new CodeType(); }
            return __LocationTypeCode;
        }
        set
        {
            __LocationTypeCode = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) of a document providing information about this location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Information_ URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location
    /// <para />PropertyTermQualifier: Information
    /// <para />PropertyTerm: URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType InformationURI
    {
        get
        {
            if (__InformationURI == null) { __InformationURI = new IdentifierType(); }
            return __InformationURI;
        }
        set
        {
            __InformationURI = value;
        }
    }

        
    /// <summary>
    /// The name of this location.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Location. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>winter 2005 collection</example>
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
    /// The address of this location.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Location. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Location
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType Address
    {
        get
        {
            if (__Address == null) { __Address = new AddressType(); }
            return __Address;
        }
        set
        {
            __Address = value;
        }
    }

}