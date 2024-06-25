using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the tenderer contracting role.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Economic Operator Role. Details
/// <para />ObjectClass: Economic Operator Role
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EconomicOperatorRole", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EconomicOperatorRole", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EconomicOperatorRoleType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RoleCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__RoleCode;
        
    private System.Collections.Generic.List<TextType> _roleDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RoleDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__RoleDescription
    {
        get
        {
            return _roleDescription?.ToArray();
        }
        set
        {
            _roleDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    /// <summary>
    /// A textual description of the party role.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Economic Operator Role. Role Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Economic Operator Role
    /// <para />PropertyTerm: Role Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> RoleDescription
    {
        get { return _roleDescription ?? (_roleDescription = new System.Collections.Generic.List<TextType>()); }
        set { _roleDescription = value; }
    }

        
    /// <summary>
    /// A code specifying the role of the party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Economic Operator Role. Role Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Economic Operator Role
    /// <para />PropertyTerm: Role Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType RoleCode
    {
        get
        {
            if (__RoleCode == null) { __RoleCode = new CodeType(); }
            return __RoleCode;
        }
        set
        {
            __RoleCode = value;
        }
    }

}