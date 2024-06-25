using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a requirement for execution of a contract.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Contract Execution Requirement. Details
/// <para />ObjectClass: Contract Execution Requirement
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ContractExecutionRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractExecutionRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ContractExecutionRequirementType
{
        
    private System.Collections.Generic.List<NameType> _name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NameType[] @__Name
    {
        get
        {
            return _name?.ToArray();
        }
        set
        {
            _name = value == null ? null : new System.Collections.Generic.List<NameType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExecutionRequirementCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ExecutionRequirementCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    /// <summary>
    /// A name for this requirement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract Execution Requirement. Name
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contract Execution Requirement
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<NameType> Name
    {
        get { return _name ?? (_name = new System.Collections.Generic.List<NameType>()); }
        set { _name = value; }
    }

        
    /// <summary>
    /// Text describing this requirement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract Execution Requirement. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contract Execution Requirement
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// A code signifying the type of party independent of its role.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract Execution Requirement. Execution Requirement Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract Execution Requirement
    /// <para />PropertyTerm: Execution Requirement Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ExecutionRequirementCode
    {
        get
        {
            if (__ExecutionRequirementCode == null) { __ExecutionRequirementCode = new CodeType(); }
            return __ExecutionRequirementCode;
        }
        set
        {
            __ExecutionRequirementCode = value;
        }
    }

}