using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a taxation scheme applying to a party.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Party Tax Scheme. Details
/// <para />ObjectClass: Party Tax Scheme
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PartyTaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PartyTaxSchemeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NameType @__RegistrationName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompanyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__CompanyID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxLevelCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__TaxLevelCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExemptionReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__ExemptionReasonCode;
        
    private System.Collections.Generic.List<TextType> _exemptionReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExemptionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__ExemptionReason
    {
        get
        {
            return _exemptionReason?.ToArray();
        }
        set
        {
            _exemptionReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistrationAddress", Order=5)]
    public AddressType @__RegistrationAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxScheme", Order=6)]
    public TaxSchemeType @__TaxScheme;
        
    /// <summary>
    /// A reason for the party&apos;s exemption from tax, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Tax Scheme. Exemption_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Party Tax Scheme
    /// <para />PropertyTermQualifier: Exemption
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ExemptionReason
    {
        get { return _exemptionReason ?? (_exemptionReason = new System.Collections.Generic.List<TextType>()); }
        set { _exemptionReason = value; }
    }

        
    /// <summary>
    /// The name of the party as registered with the relevant fiscal authority.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Tax Scheme. Registration_ Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Tax Scheme
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
    /// An identifier for the party assigned for tax purposes by the taxation authority.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Tax Scheme. Company Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Tax Scheme
    /// <para />PropertyTerm: Company Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: VAT Number
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
    /// A code signifying the tax level applicable to the party within this taxation scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Tax Scheme. Tax Level Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Tax Scheme
    /// <para />PropertyTerm: Tax Level Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TaxLevelCode
    {
        get
        {
            if (__TaxLevelCode == null) { __TaxLevelCode = new CodeType(); }
            return __TaxLevelCode;
        }
        set
        {
            __TaxLevelCode = value;
        }
    }

        
    /// <summary>
    /// A reason for the party&apos;s exemption from tax, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Party Tax Scheme. Exemption Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Tax Scheme
    /// <para />PropertyTerm: Exemption Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ExemptionReasonCode
    {
        get
        {
            if (__ExemptionReasonCode == null) { __ExemptionReasonCode = new CodeType(); }
            return __ExemptionReasonCode;
        }
        set
        {
            __ExemptionReasonCode = value;
        }
    }

        
    /// <summary>
    /// The address of the party as registered for tax purposes.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party Tax Scheme. Registration_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Party Tax Scheme
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
    /// The taxation scheme applicable to the party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Party Tax Scheme. Tax Scheme
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Party Tax Scheme
    /// <para />PropertyTerm: Tax Scheme
    /// <para />AssociatedObjectClass: Tax Scheme
    /// <para />RepresentationTerm: Tax Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TaxSchemeType TaxScheme
    {
        get
        {
            if (__TaxScheme == null) { __TaxScheme = new TaxSchemeType(); }
            return __TaxScheme;
        }
        set
        {
            __TaxScheme = value;
        }
    }

}