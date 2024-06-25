using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a taxation scheme (e.g., VAT, State tax, County tax).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tax Scheme. Details
/// <para />ObjectClass: Tax Scheme
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TaxScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TaxSchemeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__TaxTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__CurrencyCode;
        
    private System.Collections.Generic.List<AddressType> _jurisdictionRegionAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("JurisdictionRegionAddress", Order=4)]
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
    /// A geographic area in which this taxation scheme applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tax Scheme. Jurisdiction Region_ Address. Address
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tax Scheme
    /// <para />PropertyTermQualifier: Jurisdiction Region
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AddressType> JurisdictionRegionAddress
    {
        get { return _jurisdictionRegionAddress ?? (_jurisdictionRegionAddress = new System.Collections.Generic.List<AddressType>()); }
        set { _jurisdictionRegionAddress = value; }
    }

        
    /// <summary>
    /// An identifier for this taxation scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Scheme. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Scheme
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>http://www.unece.org/uncefact/codelist/standard/EDIFICASEU_TaxExemptionReason_D09B.xsd</example>
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
    /// The name of this taxation scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Scheme. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Scheme
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Value Added Tax , Wholesale Tax , Sales Tax , State Tax</example>
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
    /// A code signifying the type of tax.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Scheme. Tax Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Scheme
    /// <para />PropertyTerm: Tax Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Consumption , Sales</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TaxTypeCode
    {
        get
        {
            if (__TaxTypeCode == null) { __TaxTypeCode = new CodeType(); }
            return __TaxTypeCode;
        }
        set
        {
            __TaxTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the currency in which the tax is collected and reported.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tax Scheme. Currency Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tax Scheme
    /// <para />PropertyTerm: Currency Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Currency
    /// <para />DataType: Currency_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CurrencyCode
    {
        get
        {
            if (__CurrencyCode == null) { __CurrencyCode = new CodeType(); }
            return __CurrencyCode;
        }
        set
        {
            __CurrencyCode = value;
        }
    }

}