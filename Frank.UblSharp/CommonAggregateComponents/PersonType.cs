using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a person.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Person. Details
/// <para />ObjectClass: Person
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CrewMemberPerson", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CrewMemberPerson", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PersonType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FirstName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__FirstName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FamilyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public NameType @__FamilyName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Title", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__Title;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MiddleName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public NameType @__MiddleName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OtherName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public NameType @__OtherName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NameSuffix", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__NameSuffix;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("JobTitle", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType @__JobTitle;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NationalityID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IdentifierType @__NationalityID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GenderCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public CodeType @__GenderCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BirthDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public DateType @__BirthDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BirthplaceName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType @__BirthplaceName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrganizationDepartment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public TextType @__OrganizationDepartment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Contact", Order=13)]
    public ContactType @__Contact;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinancialAccount", Order=14)]
    public FinancialAccountType @__FinancialAccount;
        
    private System.Collections.Generic.List<DocumentReferenceType> _identityDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IdentityDocumentReference", Order=15)]
    public DocumentReferenceType[] @__IdentityDocumentReference
    {
        get
        {
            return _identityDocumentReference?.ToArray();
        }
        set
        {
            _identityDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResidenceAddress", Order=16)]
    public AddressType @__ResidenceAddress;
        
    /// <summary>
    /// A reference to a document that can precisely identify this person (e.g., a driver&apos;s license).
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Person. Identity_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Person
    /// <para />PropertyTermQualifier: Identity
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> IdentityDocumentReference
    {
        get { return _identityDocumentReference ?? (_identityDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _identityDocumentReference = value; }
    }

        
    /// <summary>
    /// An identifier for this person.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
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
    /// This person&apos;s given name.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. First_ Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTermQualifier: First
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType FirstName
    {
        get
        {
            if (__FirstName == null) { __FirstName = new NameType(); }
            return __FirstName;
        }
        set
        {
            __FirstName = value;
        }
    }

        
    /// <summary>
    /// This person&apos;s family name.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Family_ Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTermQualifier: Family
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType FamilyName
    {
        get
        {
            if (__FamilyName == null) { __FamilyName = new NameType(); }
            return __FamilyName;
        }
        set
        {
            __FamilyName = value;
        }
    }

        
    /// <summary>
    /// This person&apos;s title of address (e.g., Mr, Ms, Dr, Sir).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Title. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Title
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Title
    {
        get
        {
            if (__Title == null) { __Title = new TextType(); }
            return __Title;
        }
        set
        {
            __Title = value;
        }
    }

        
    /// <summary>
    /// This person&apos;s middle name(s) or initials.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Middle_ Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTermQualifier: Middle
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType MiddleName
    {
        get
        {
            if (__MiddleName == null) { __MiddleName = new NameType(); }
            return __MiddleName;
        }
        set
        {
            __MiddleName = value;
        }
    }

        
    /// <summary>
    /// This person&apos;s second family name.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Other_ Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTermQualifier: Other
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Delivery Dock</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType OtherName
    {
        get
        {
            if (__OtherName == null) { __OtherName = new NameType(); }
            return __OtherName;
        }
        set
        {
            __OtherName = value;
        }
    }

        
    /// <summary>
    /// A suffix to this person&apos;s name (e.g., PhD, OBE, Jr).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Name Suffix. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Name Suffix
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType NameSuffix
    {
        get
        {
            if (__NameSuffix == null) { __NameSuffix = new TextType(); }
            return __NameSuffix;
        }
        set
        {
            __NameSuffix = value;
        }
    }

        
    /// <summary>
    /// This person&apos;s job title (for a particular role) within an organization.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Job Title. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Job Title
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType JobTitle
    {
        get
        {
            if (__JobTitle == null) { __JobTitle = new TextType(); }
            return __JobTitle;
        }
        set
        {
            __JobTitle = value;
        }
    }

        
    /// <summary>
    /// An identifier for this person&apos;s nationality.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Nationality. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Nationality
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType NationalityID
    {
        get
        {
            if (__NationalityID == null) { __NationalityID = new IdentifierType(); }
            return __NationalityID;
        }
        set
        {
            __NationalityID = value;
        }
    }

        
    /// <summary>
    /// A code (e.g., ISO 5218) signifying the gender of this person.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Gender Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Gender Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType GenderCode
    {
        get
        {
            if (__GenderCode == null) { __GenderCode = new CodeType(); }
            return __GenderCode;
        }
        set
        {
            __GenderCode = value;
        }
    }

        
    /// <summary>
    /// This person&apos;s date of birth.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Birth Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Birth Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType BirthDate
    {
        get
        {
            if (__BirthDate == null) { __BirthDate = new DateType(); }
            return __BirthDate;
        }
        set
        {
            __BirthDate = value;
        }
    }

        
    /// <summary>
    /// The name of the place where this person was born, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Birthplace Name. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTerm: Birthplace Name
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType BirthplaceName
    {
        get
        {
            if (__BirthplaceName == null) { __BirthplaceName = new TextType(); }
            return __BirthplaceName;
        }
        set
        {
            __BirthplaceName = value;
        }
    }

        
    /// <summary>
    /// The department or subdivision of an organization that this person belongs to (in a particular role).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Person. Organization_ Department. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTermQualifier: Organization
    /// <para />PropertyTerm: Department
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType OrganizationDepartment
    {
        get
        {
            if (__OrganizationDepartment == null) { __OrganizationDepartment = new TextType(); }
            return __OrganizationDepartment;
        }
        set
        {
            __OrganizationDepartment = value;
        }
    }

        
    /// <summary>
    /// Contact information for this person.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Person. Contact
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
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
    /// The financial account associated with this person.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Person. Financial Account
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
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

        
    /// <summary>
    /// This person&apos;s address of residence.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Person. Residence_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Person
    /// <para />PropertyTermQualifier: Residence
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType ResidenceAddress
    {
        get
        {
            if (__ResidenceAddress == null) { __ResidenceAddress = new AddressType(); }
            return __ResidenceAddress;
        }
        set
        {
            __ResidenceAddress = value;
        }
    }

}