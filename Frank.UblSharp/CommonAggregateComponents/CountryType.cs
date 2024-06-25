using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a country.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Country. Details
/// <para />ObjectClass: Country
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CountryType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IdentificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__IdentificationCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    /// <summary>
    /// A code signifying this country.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Country. Identification Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Country
    /// <para />PropertyTerm: Identification Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Country Identification
    /// <para />DataType: Country Identification_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType IdentificationCode
    {
        get
        {
            if (__IdentificationCode == null) { __IdentificationCode = new CodeType(); }
            return __IdentificationCode;
        }
        set
        {
            __IdentificationCode = value;
        }
    }

        
    /// <summary>
    /// The name of this country.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Country. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Country
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>SOUTH AFRICA</example>
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

}