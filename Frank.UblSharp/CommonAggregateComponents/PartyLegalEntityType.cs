using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a party as a legal entity.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Party Legal Entity. Details
/// <para />ObjectClass: Party Legal Entity
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PartyLegalEntity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PartyLegalEntityType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NameType @__RegistrationName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompanyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__CompanyID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__RegistrationDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationExpirationDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__RegistrationExpirationDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompanyLegalFormCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__CompanyLegalFormCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompanyLegalForm", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType @__CompanyLegalForm;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SoleProprietorshipIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IndicatorType @__SoleProprietorshipIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompanyLiquidationStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__CompanyLiquidationStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CorporateStockAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public AmountType @__CorporateStockAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FullyPaidSharesIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IndicatorType @__FullyPaidSharesIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationAddress", Order=10)]
    public AddressType @__RegistrationAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CorporateRegistrationScheme", Order=11)]
    public CorporateRegistrationSchemeType @__CorporateRegistrationScheme;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HeadOfficeParty", Order=12)]
    public PartyType @__HeadOfficeParty;
        
    private System.Collections.Generic.List<ShareholderPartyType> _shareholderParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShareholderParty", Order=13)]
    public ShareholderPartyType[] @__ShareholderParty
    {
        get
        {
            return _shareholderParty?.ToArray();
        }
        set
        {
            _shareholderParty = value == null ? null : new System.Collections.Generic.List<ShareholderPartyType>(value);
        }
    }
        
    /// <summary>
    /// A party owning shares in this legal entity.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Shareholder Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Shareholder Party
    /// <para />AssociatedObjectClass: Shareholder Party
    /// <para />RepresentationTerm: Shareholder Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShareholderPartyType> ShareholderParty
    {
        get { return _shareholderParty ?? (_shareholderParty = new System.Collections.Generic.List<ShareholderPartyType>()); }
        set { _shareholderParty = value; }
    }

        
    /// <summary>
    /// The name of the party as registered with the relevant legal authority.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Registration_ Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTermQualifier: Registration
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Microsoft Corporation</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType RegistrationName
    {
        get
        {
            if (__RegistrationName == null) { __RegistrationName = new NameType(); }
            return __RegistrationName;
        }
        set
        {
            __RegistrationName = value;
        }
    }

        
    /// <summary>
    /// An identifier for the party as registered within a company registration scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Company Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Company Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Business Registration Number, Company Number
    /// </summary>
    /// <example>3556625</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType CompanyID
    {
        get
        {
            if (__CompanyID == null) { __CompanyID = new IdentifierType(); }
            return __CompanyID;
        }
        set
        {
            __CompanyID = value;
        }
    }

        
    /// <summary>
    /// The registration date of the CompanyID.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Registration_ Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTermQualifier: Registration
    /// <para />PropertyTerm: Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType RegistrationDate
    {
        get
        {
            if (__RegistrationDate == null) { __RegistrationDate = new DateType(); }
            return __RegistrationDate;
        }
        set
        {
            __RegistrationDate = value;
        }
    }

        
    /// <summary>
    /// The date upon which a registration expires (e.g., registration for an import/export license).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Registration Expiration_ Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTermQualifier: Registration Expiration
    /// <para />PropertyTerm: Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType RegistrationExpirationDate
    {
        get
        {
            if (__RegistrationExpirationDate == null) { __RegistrationExpirationDate = new DateType(); }
            return __RegistrationExpirationDate;
        }
        set
        {
            __RegistrationExpirationDate = value;
        }
    }

        
    /// <summary>
    /// A code signifying the party&apos;s legal status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Company Legal Form Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Company Legal Form Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Legal Status
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CompanyLegalFormCode
    {
        get
        {
            if (__CompanyLegalFormCode == null) { __CompanyLegalFormCode = new CodeType(); }
            return __CompanyLegalFormCode;
        }
        set
        {
            __CompanyLegalFormCode = value;
        }
    }

        
    /// <summary>
    /// The company legal status, expressed as a text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Company Legal Form. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Company Legal Form
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CompanyLegalForm
    {
        get
        {
            if (__CompanyLegalForm == null) { __CompanyLegalForm = new TextType(); }
            return __CompanyLegalForm;
        }
        set
        {
            __CompanyLegalForm = value;
        }
    }

        
    /// <summary>
    /// An indicator that the company is owned and controlled by one person (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Sole Proprietorship Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Sole Proprietorship Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType SoleProprietorshipIndicator
    {
        get
        {
            if (__SoleProprietorshipIndicator == null) { __SoleProprietorshipIndicator = new IndicatorType(); }
            return __SoleProprietorshipIndicator;
        }
        set
        {
            __SoleProprietorshipIndicator = value;
        }
    }

        
    /// <summary>
    /// A code signifying the party&apos;s liquidation status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Company Liquidation Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Company Liquidation Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CompanyLiquidationStatusCode
    {
        get
        {
            if (__CompanyLiquidationStatusCode == null) { __CompanyLiquidationStatusCode = new CodeType(); }
            return __CompanyLiquidationStatusCode;
        }
        set
        {
            __CompanyLiquidationStatusCode = value;
        }
    }

        
    /// <summary>
    /// The number of shares in the capital stock of a corporation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Corporate Stock_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTermQualifier: Corporate Stock
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType CorporateStockAmount
    {
        get
        {
            if (__CorporateStockAmount == null) { __CorporateStockAmount = new AmountType(); }
            return __CorporateStockAmount;
        }
        set
        {
            __CorporateStockAmount = value;
        }
    }

        
    /// <summary>
    /// An indicator that all shares of corporate stock have been paid by shareholders (true) or not (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Fully Paid Shares Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Fully Paid Shares Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType FullyPaidSharesIndicator
    {
        get
        {
            if (__FullyPaidSharesIndicator == null) { __FullyPaidSharesIndicator = new IndicatorType(); }
            return __FullyPaidSharesIndicator;
        }
        set
        {
            __FullyPaidSharesIndicator = value;
        }
    }

        
    /// <summary>
    /// The registered address of the party within a corporate registration scheme.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Registration_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTermQualifier: Registration
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType RegistrationAddress
    {
        get
        {
            if (__RegistrationAddress == null) { __RegistrationAddress = new AddressType(); }
            return __RegistrationAddress;
        }
        set
        {
            __RegistrationAddress = value;
        }
    }

        
    /// <summary>
    /// The corporate registration scheme used to register the party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Corporate Registration Scheme
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTerm: Corporate Registration Scheme
    /// <para />AssociatedObjectClass: Corporate Registration Scheme
    /// <para />RepresentationTerm: Corporate Registration Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CorporateRegistrationSchemeType CorporateRegistrationScheme
    {
        get
        {
            if (__CorporateRegistrationScheme == null) { __CorporateRegistrationScheme = new CorporateRegistrationSchemeType(); }
            return __CorporateRegistrationScheme;
        }
        set
        {
            __CorporateRegistrationScheme = value;
        }
    }

        
    /// <summary>
    /// The head office of the legal entity
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party Legal Entity. Head Office_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Legal Entity
    /// <para />PropertyTermQualifier: Head Office
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType HeadOfficeParty
    {
        get
        {
            if (__HeadOfficeParty == null) { __HeadOfficeParty = new PartyType(); }
            return __HeadOfficeParty;
        }
        set
        {
            __HeadOfficeParty = value;
        }
    }

}