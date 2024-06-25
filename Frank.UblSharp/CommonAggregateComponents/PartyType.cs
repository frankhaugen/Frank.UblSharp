using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an organization, sub-organization, or individual fulfilling a role in a business process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Party. Details
/// <para />ObjectClass: Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalInformationParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalInformationParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MarkCareIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IndicatorType @__MarkCareIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MarkAttentionIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IndicatorType @__MarkAttentionIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WebsiteURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__WebsiteURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LogoReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IdentifierType @__LogoReferenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EndpointID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__EndpointID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndustryClassificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__IndustryClassificationCode;
        
    private System.Collections.Generic.List<PartyIdentificationType> _partyIdentification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartyIdentification", Order=6)]
    public PartyIdentificationType[] @__PartyIdentification
    {
        get
        {
            return _partyIdentification?.ToArray();
        }
        set
        {
            _partyIdentification = value == null ? null : new System.Collections.Generic.List<PartyIdentificationType>(value);
        }
    }
        
    private System.Collections.Generic.List<PartyNameType> _partyName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartyName", Order=7)]
    public PartyNameType[] @__PartyName
    {
        get
        {
            return _partyName?.ToArray();
        }
        set
        {
            _partyName = value == null ? null : new System.Collections.Generic.List<PartyNameType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Language", Order=8)]
    public LanguageType @__Language;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PostalAddress", Order=9)]
    public AddressType @__PostalAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PhysicalLocation", Order=10)]
    public LocationType @__PhysicalLocation;
        
    private System.Collections.Generic.List<PartyTaxSchemeType> _partyTaxScheme;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartyTaxScheme", Order=11)]
    public PartyTaxSchemeType[] @__PartyTaxScheme
    {
        get
        {
            return _partyTaxScheme?.ToArray();
        }
        set
        {
            _partyTaxScheme = value == null ? null : new System.Collections.Generic.List<PartyTaxSchemeType>(value);
        }
    }
        
    private System.Collections.Generic.List<PartyLegalEntityType> _partyLegalEntity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PartyLegalEntity", Order=12)]
    public PartyLegalEntityType[] @__PartyLegalEntity
    {
        get
        {
            return _partyLegalEntity?.ToArray();
        }
        set
        {
            _partyLegalEntity = value == null ? null : new System.Collections.Generic.List<PartyLegalEntityType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Contact", Order=13)]
    public ContactType @__Contact;
        
    private System.Collections.Generic.List<PersonType> _person;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Person", Order=14)]
    public PersonType[] @__Person
    {
        get
        {
            return _person?.ToArray();
        }
        set
        {
            _person = value == null ? null : new System.Collections.Generic.List<PersonType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AgentParty", Order=15)]
    public PartyType @__AgentParty;
        
    private System.Collections.Generic.List<ServiceProviderPartyType> _serviceProviderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ServiceProviderParty", Order=16)]
    public ServiceProviderPartyType[] @__ServiceProviderParty
    {
        get
        {
            return _serviceProviderParty?.ToArray();
        }
        set
        {
            _serviceProviderParty = value == null ? null : new System.Collections.Generic.List<ServiceProviderPartyType>(value);
        }
    }
        
    private System.Collections.Generic.List<PowerOfAttorneyType> _powerOfAttorney;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PowerOfAttorney", Order=17)]
    public PowerOfAttorneyType[] @__PowerOfAttorney
    {
        get
        {
            return _powerOfAttorney?.ToArray();
        }
        set
        {
            _powerOfAttorney = value == null ? null : new System.Collections.Generic.List<PowerOfAttorneyType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinancialAccount", Order=18)]
    public FinancialAccountType @__FinancialAccount;
        
    /// <summary>
    /// An identifier for this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Party Identification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Party Identification
    /// <para />AssociatedObjectClass: Party Identification
    /// <para />RepresentationTerm: Party Identification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyIdentificationType> PartyIdentification
    {
        get { return _partyIdentification ?? (_partyIdentification = new System.Collections.Generic.List<PartyIdentificationType>()); }
        set { _partyIdentification = value; }
    }

        
    /// <summary>
    /// A name for this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Party Name
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Party Name
    /// <para />AssociatedObjectClass: Party Name
    /// <para />RepresentationTerm: Party Name
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyNameType> PartyName
    {
        get { return _partyName ?? (_partyName = new System.Collections.Generic.List<PartyNameType>()); }
        set { _partyName = value; }
    }

        
    /// <summary>
    /// A tax scheme applying to this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Party Tax Scheme
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Party Tax Scheme
    /// <para />AssociatedObjectClass: Party Tax Scheme
    /// <para />RepresentationTerm: Party Tax Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyTaxSchemeType> PartyTaxScheme
    {
        get { return _partyTaxScheme ?? (_partyTaxScheme = new System.Collections.Generic.List<PartyTaxSchemeType>()); }
        set { _partyTaxScheme = value; }
    }

        
    /// <summary>
    /// A description of this party as a legal entity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Party Legal Entity
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Party Legal Entity
    /// <para />AssociatedObjectClass: Party Legal Entity
    /// <para />RepresentationTerm: Party Legal Entity
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyLegalEntityType> PartyLegalEntity
    {
        get { return _partyLegalEntity ?? (_partyLegalEntity = new System.Collections.Generic.List<PartyLegalEntityType>()); }
        set { _partyLegalEntity = value; }
    }

        
    /// <summary>
    /// A person associated with this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Person
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Person
    /// <para />AssociatedObjectClass: Person
    /// <para />RepresentationTerm: Person
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PersonType> Person
    {
        get { return _person ?? (_person = new System.Collections.Generic.List<PersonType>()); }
        set { _person = value; }
    }

        
    /// <summary>
    /// A party providing a service to this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Service Provider Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Service Provider Party
    /// <para />AssociatedObjectClass: Service Provider Party
    /// <para />RepresentationTerm: Service Provider Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ServiceProviderPartyType> ServiceProviderParty
    {
        get { return _serviceProviderParty ?? (_serviceProviderParty = new System.Collections.Generic.List<ServiceProviderPartyType>()); }
        set { _serviceProviderParty = value; }
    }

        
    /// <summary>
    /// A power of attorney associated with this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Power Of Attorney
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Power Of Attorney
    /// <para />AssociatedObjectClass: Power Of Attorney
    /// <para />RepresentationTerm: Power Of Attorney
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PowerOfAttorneyType> PowerOfAttorney
    {
        get { return _powerOfAttorney ?? (_powerOfAttorney = new System.Collections.Generic.List<PowerOfAttorneyType>()); }
        set { _powerOfAttorney = value; }
    }

        
    /// <summary>
    /// An indicator that this party is &quot;care of&quot; (c/o) (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party. Mark Care_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTermQualifier: Mark Care
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType MarkCareIndicator
    {
        get
        {
            if (__MarkCareIndicator == null) { __MarkCareIndicator = new IndicatorType(); }
            return __MarkCareIndicator;
        }
        set
        {
            __MarkCareIndicator = value;
        }
    }

        
    /// <summary>
    /// An indicator that this party is &quot;for the attention of&quot; (FAO) (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party. Mark Attention_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTermQualifier: Mark Attention
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType MarkAttentionIndicator
    {
        get
        {
            if (__MarkAttentionIndicator == null) { __MarkAttentionIndicator = new IndicatorType(); }
            return __MarkAttentionIndicator;
        }
        set
        {
            __MarkAttentionIndicator = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) that identifies this party&apos;s web site; i.e., the web site&apos;s Uniform Resource Locator (URL).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party. Website_ URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTermQualifier: Website
    /// <para />PropertyTerm: URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType WebsiteURI
    {
        get
        {
            if (__WebsiteURI == null) { __WebsiteURI = new IdentifierType(); }
            return __WebsiteURI;
        }
        set
        {
            __WebsiteURI = value;
        }
    }

        
    /// <summary>
    /// An identifier for this party&apos;s logo.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party. Logo Reference. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Logo Reference
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>http://www2.coca-cola.com/images/logo.gif</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LogoReferenceID
    {
        get
        {
            if (__LogoReferenceID == null) { __LogoReferenceID = new IdentifierType(); }
            return __LogoReferenceID;
        }
        set
        {
            __LogoReferenceID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the end point of the routing service (e.g., EAN Location Number, GLN).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party. Endpoint Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Endpoint Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>5790002221134</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType EndpointID
    {
        get
        {
            if (__EndpointID == null) { __EndpointID = new IdentifierType(); }
            return __EndpointID;
        }
        set
        {
            __EndpointID = value;
        }
    }

        
    /// <summary>
    /// This party&apos;s Industry Classification Code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party. Industry Classification Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Industry Classification Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Public authority , NAIC codes</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType IndustryClassificationCode
    {
        get
        {
            if (__IndustryClassificationCode == null) { __IndustryClassificationCode = new CodeType(); }
            return __IndustryClassificationCode;
        }
        set
        {
            __IndustryClassificationCode = value;
        }
    }

        
    /// <summary>
    /// The language associated with this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Language
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Language
    /// <para />AssociatedObjectClass: Language
    /// <para />RepresentationTerm: Language
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LanguageType Language
    {
        get
        {
            if (__Language == null) { __Language = new LanguageType(); }
            return __Language;
        }
        set
        {
            __Language = value;
        }
    }

        
    /// <summary>
    /// The party&apos;s postal address.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Postal_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTermQualifier: Postal
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType PostalAddress
    {
        get
        {
            if (__PostalAddress == null) { __PostalAddress = new AddressType(); }
            return __PostalAddress;
        }
        set
        {
            __PostalAddress = value;
        }
    }

        
    /// <summary>
    /// The physical location of this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Physical_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTermQualifier: Physical
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType PhysicalLocation
    {
        get
        {
            if (__PhysicalLocation == null) { __PhysicalLocation = new LocationType(); }
            return __PhysicalLocation;
        }
        set
        {
            __PhysicalLocation = value;
        }
    }

        
    /// <summary>
    /// The primary contact for this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Contact
    /// <para />AssociatedObjectClass: Contact
    /// <para />RepresentationTerm: Contact
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContactType Contact
    {
        get
        {
            if (__Contact == null) { __Contact = new ContactType(); }
            return __Contact;
        }
        set
        {
            __Contact = value;
        }
    }

        
    /// <summary>
    /// A party who acts as an agent for this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Agent_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTermQualifier: Agent
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    /// <example>Customs Broker</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType AgentParty
    {
        get
        {
            if (__AgentParty == null) { __AgentParty = new PartyType(); }
            return __AgentParty;
        }
        set
        {
            __AgentParty = value;
        }
    }

        
    /// <summary>
    /// The financial account associated with this party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party. Financial Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party
    /// <para />PropertyTerm: Financial Account
    /// <para />AssociatedObjectClass: Financial Account
    /// <para />RepresentationTerm: Financial Account
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public FinancialAccountType FinancialAccount
    {
        get
        {
            if (__FinancialAccount == null) { __FinancialAccount = new FinancialAccountType(); }
            return __FinancialAccount;
        }
        set
        {
            __FinancialAccount = value;
        }
    }

}