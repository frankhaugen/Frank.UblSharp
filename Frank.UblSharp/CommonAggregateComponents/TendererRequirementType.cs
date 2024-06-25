using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an action or statement required of an economic operator participating in a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tenderer Requirement. Details
/// <para />ObjectClass: Tenderer Requirement
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SpecificTendererRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SpecificTendererRequirement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TendererRequirementType
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
    [System.Xml.Serialization.XmlElementAttribute("TendererRequirementTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__TendererRequirementTypeCode;
        
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LegalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__LegalReference;
        
    private System.Collections.Generic.List<EvidenceType> _suggestedEvidence;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SuggestedEvidence", Order=4)]
    public EvidenceType[] @__SuggestedEvidence
    {
        get
        {
            return _suggestedEvidence?.ToArray();
        }
        set
        {
            _suggestedEvidence = value == null ? null : new System.Collections.Generic.List<EvidenceType>(value);
        }
    }
        
    /// <summary>
    /// A name of this tenderer requirement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Requirement. Name
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Requirement
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
    /// <para />DictionaryEntryName: Tenderer Requirement. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Requirement
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
    /// An item of evidence that should be submitted to satisfy this requirement.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Requirement. Suggested_ Evidence. Evidence
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Requirement
    /// <para />PropertyTermQualifier: Suggested
    /// <para />PropertyTerm: Evidence
    /// <para />AssociatedObjectClass: Evidence
    /// <para />RepresentationTerm: Evidence
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EvidenceType> SuggestedEvidence
    {
        get { return _suggestedEvidence ?? (_suggestedEvidence = new System.Collections.Generic.List<EvidenceType>()); }
        set { _suggestedEvidence = value; }
    }

        
    /// <summary>
    /// A code signifying this requirement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Requirement. Tenderer Requirement_ Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tenderer Requirement
    /// <para />PropertyTermQualifier: Tenderer Requirement
    /// <para />PropertyTerm: Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TendererRequirementTypeCode
    {
        get
        {
            if (__TendererRequirementTypeCode == null) { __TendererRequirementTypeCode = new CodeType(); }
            return __TendererRequirementTypeCode;
        }
        set
        {
            __TendererRequirementTypeCode = value;
        }
    }

        
    /// <summary>
    /// The legal reference of the exclusion criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Requirement. Legal Reference. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tenderer Requirement
    /// <para />PropertyTerm: Legal Reference
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Art. 45 2 b</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType LegalReference
    {
        get
        {
            if (__LegalReference == null) { __LegalReference = new TextType(); }
            return __LegalReference;
        }
        set
        {
            __LegalReference = value;
        }
    }

}