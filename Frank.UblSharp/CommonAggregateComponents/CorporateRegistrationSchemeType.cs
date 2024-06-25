using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a scheme for corporate registration.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Corporate Registration Scheme. Details
/// <para />ObjectClass: Corporate Registration Scheme
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CorporateRegistrationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CorporateRegistrationSchemeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CorporateRegistrationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__CorporateRegistrationTypeCode;
        
    private System.Collections.Generic.List<AddressType> _jurisdictionRegionAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("JurisdictionRegionAddress", Order=3)]
    public AddressType[] @__JurisdictionRegionAddress
    {
        get
        {
            return _jurisdictionRegionAddress?.ToArray();
        }
        set
        {
            _jurisdictionRegionAddress = value == null ? null : new System.Collections.Generic.List<AddressType>(value);
        }
    }
        
    /// <summary>
    /// A geographic area in which this registration scheme applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Corporate Registration Scheme. Jurisdiction Region_ Address. Address
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Corporate Registration Scheme
    /// <para />PropertyTermQualifier: Jurisdiction Region
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    /// <example>England , Wales</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AddressType> JurisdictionRegionAddress
    {
        get { return _jurisdictionRegionAddress ?? (_jurisdictionRegionAddress = new System.Collections.Generic.List<AddressType>()); }
        set { _jurisdictionRegionAddress = value; }
    }

        
    /// <summary>
    /// An identifier for this registration scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Corporate Registration Scheme. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Corporate Registration Scheme
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>ASIC in Australia</example>
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
    /// The name of this registration scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Corporate Registration Scheme. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Corporate Registration Scheme
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Australian Securities and Investment Commission in Australia</example>
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
    /// A code signifying the type of this registration scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Corporate Registration Scheme. Corporate Registration Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Corporate Registration Scheme
    /// <para />PropertyTerm: Corporate Registration Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>ACN</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CorporateRegistrationTypeCode
    {
        get
        {
            if (__CorporateRegistrationTypeCode == null) { __CorporateRegistrationTypeCode = new CodeType(); }
            return __CorporateRegistrationTypeCode;
        }
        set
        {
            __CorporateRegistrationTypeCode = value;
        }
    }

}