using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an immobilized security to be used as a guarantee.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Immobilized Security. Details
/// <para />ObjectClass: Immobilized Security
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ImmobilizedSecurity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ImmobilizedSecurity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ImmobilizedSecurityType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ImmobilizationCertificateID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ImmobilizationCertificateID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SecurityID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__SecurityID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FaceValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__FaceValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MarketValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__MarketValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SharesNumberQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__SharesNumberQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuerParty", Order=6)]
    public PartyType @__IssuerParty;
        
    /// <summary>
    /// An identifier for the certificate of this immobilized security.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Immobilized Security. Immobilization Certificate Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Immobilized Security
    /// <para />PropertyTerm: Immobilization Certificate Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ImmobilizationCertificateID
    {
        get
        {
            if (__ImmobilizationCertificateID == null) { __ImmobilizationCertificateID = new IdentifierType(); }
            return __ImmobilizationCertificateID;
        }
        set
        {
            __ImmobilizationCertificateID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the security being immobilized.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Immobilized Security. Security Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Immobilized Security
    /// <para />PropertyTerm: Security Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SecurityID
    {
        get
        {
            if (__SecurityID == null) { __SecurityID = new IdentifierType(); }
            return __SecurityID;
        }
        set
        {
            __SecurityID = value;
        }
    }

        
    /// <summary>
    /// The date on which this immobilized security was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Immobilized Security. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Immobilized Security
    /// <para />PropertyTerm: Issue Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType IssueDate
    {
        get
        {
            if (__IssueDate == null) { __IssueDate = new DateType(); }
            return __IssueDate;
        }
        set
        {
            __IssueDate = value;
        }
    }

        
    /// <summary>
    /// The value of the security on the day it was immobilized.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Immobilized Security. Face Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Immobilized Security
    /// <para />PropertyTerm: Face Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType FaceValueAmount
    {
        get
        {
            if (__FaceValueAmount == null) { __FaceValueAmount = new AmountType(); }
            return __FaceValueAmount;
        }
        set
        {
            __FaceValueAmount = value;
        }
    }

        
    /// <summary>
    /// The current market value of the immobilized security.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Immobilized Security. Market Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Immobilized Security
    /// <para />PropertyTerm: Market Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MarketValueAmount
    {
        get
        {
            if (__MarketValueAmount == null) { __MarketValueAmount = new AmountType(); }
            return __MarketValueAmount;
        }
        set
        {
            __MarketValueAmount = value;
        }
    }

        
    /// <summary>
    /// The number of shares immobilized.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Immobilized Security. Shares Number. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Immobilized Security
    /// <para />PropertyTerm: Shares Number
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType SharesNumberQuantity
    {
        get
        {
            if (__SharesNumberQuantity == null) { __SharesNumberQuantity = new QuantityType(); }
            return __SharesNumberQuantity;
        }
        set
        {
            __SharesNumberQuantity = value;
        }
    }

        
    /// <summary>
    /// The party issuing the immobilized security certificate.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Immobilized Security. Issuer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Immobilized Security
    /// <para />PropertyTermQualifier: Issuer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType IssuerParty
    {
        get
        {
            if (__IssuerParty == null) { __IssuerParty = new PartyType(); }
            return __IssuerParty;
        }
        set
        {
            __IssuerParty = value;
        }
    }

}