using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a credit card, debit card, or charge card account.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Card Account. Details
/// <para />ObjectClass: Card Account
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CardAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CardAccount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CardAccountType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrimaryAccountNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__PrimaryAccountNumberID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetworkID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__NetworkID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CardTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__CardTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityStartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__ValidityStartDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpiryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__ExpiryDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuerID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IdentifierType @__IssuerID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IdentifierType @__IssueNumberID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CV2ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public IdentifierType @__CV2ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CardChipCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public CodeType @__CardChipCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChipApplicationID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IdentifierType @__ChipApplicationID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HolderName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public NameType @__HolderName;
        
    /// <summary>
    /// An identifier of the card (e.g., the Primary Account Number (PAN)).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Primary_ Account Number. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTermQualifier: Primary
    /// <para />PropertyTerm: Account Number
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>4558 XXXX XXXX XXXX (a real card number)</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType PrimaryAccountNumberID
    {
        get
        {
            if (__PrimaryAccountNumberID == null) { __PrimaryAccountNumberID = new IdentifierType(); }
            return __PrimaryAccountNumberID;
        }
        set
        {
            __PrimaryAccountNumberID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the financial service network provider of the card.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Network. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Network
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>VISA, MasterCard, American Express</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType NetworkID
    {
        get
        {
            if (__NetworkID == null) { __NetworkID = new IdentifierType(); }
            return __NetworkID;
        }
        set
        {
            __NetworkID = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code signifying the type of card. Examples of types are &quot;debit&quot;, &quot;credit&quot; and &quot;purchasing&quot;
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Card Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Card Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Debit Card, Credit Card, Procurement Card</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CardTypeCode
    {
        get
        {
            if (__CardTypeCode == null) { __CardTypeCode = new CodeType(); }
            return __CardTypeCode;
        }
        set
        {
            __CardTypeCode = value;
        }
    }

        
    /// <summary>
    /// The date from which the card is valid.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Validity Start Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Validity Start Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ValidityStartDate
    {
        get
        {
            if (__ValidityStartDate == null) { __ValidityStartDate = new DateType(); }
            return __ValidityStartDate;
        }
        set
        {
            __ValidityStartDate = value;
        }
    }

        
    /// <summary>
    /// The date on which the card expires.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Expiry Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Expiry Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ExpiryDate
    {
        get
        {
            if (__ExpiryDate == null) { __ExpiryDate = new DateType(); }
            return __ExpiryDate;
        }
        set
        {
            __ExpiryDate = value;
        }
    }

        
    /// <summary>
    /// An identifier for the institution issuing the card.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Issuer. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Issuer
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType IssuerID
    {
        get
        {
            if (__IssuerID == null) { __IssuerID = new IdentifierType(); }
            return __IssuerID;
        }
        set
        {
            __IssuerID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the card, specified by the issuer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Issue Number. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Issue Number
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType IssueNumberID
    {
        get
        {
            if (__IssueNumberID == null) { __IssueNumberID = new IdentifierType(); }
            return __IssueNumberID;
        }
        set
        {
            __IssueNumberID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the Card Verification Value (often found on the reverse of the card itself).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. CV2. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: CV2
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType CV2ID
    {
        get
        {
            if (__CV2ID == null) { __CV2ID = new IdentifierType(); }
            return __CV2ID;
        }
        set
        {
            __CV2ID = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code to distinguish between CHIP and MAG STRIPE cards.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Card Chip Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Card Chip Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Chip
    /// <para />DataType: Chip_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CardChipCode
    {
        get
        {
            if (__CardChipCode == null) { __CardChipCode = new CodeType(); }
            return __CardChipCode;
        }
        set
        {
            __CardChipCode = value;
        }
    }

        
    /// <summary>
    /// An identifier on the chip card for the application that provides the quoted information; an AID (application ID).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Chip_ Application. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTermQualifier: Chip
    /// <para />PropertyTerm: Application
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ChipApplicationID
    {
        get
        {
            if (__ChipApplicationID == null) { __ChipApplicationID = new IdentifierType(); }
            return __ChipApplicationID;
        }
        set
        {
            __ChipApplicationID = value;
        }
    }

        
    /// <summary>
    /// The name of the cardholder.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Card Account. Holder. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Card Account
    /// <para />PropertyTerm: Holder
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType HolderName
    {
        get
        {
            if (__HolderName == null) { __HolderName = new NameType(); }
            return __HolderName;
        }
        set
        {
            __HolderName = value;
        }
    }

}