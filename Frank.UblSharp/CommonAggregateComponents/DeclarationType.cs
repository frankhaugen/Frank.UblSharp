using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a declaration by an economic operator of certain characteristics or capabilities in fulfilment of requirements specified in a call for tenders.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Declaration. Details
/// <para />ObjectClass: Declaration
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Declaration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Declaration", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DeclarationType
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
    [System.Xml.Serialization.XmlElementAttribute("DeclarationTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__DeclarationTypeCode;
        
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
        
    private System.Collections.Generic.List<EvidenceSuppliedType> _evidenceSupplied;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EvidenceSupplied", Order=3)]
    public EvidenceSuppliedType[] @__EvidenceSupplied
    {
        get
        {
            return _evidenceSupplied?.ToArray();
        }
        set
        {
            _evidenceSupplied = value == null ? null : new System.Collections.Generic.List<EvidenceSuppliedType>(value);
        }
    }
        
    /// <summary>
    /// The name of this declaration.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Declaration. Name
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Declaration
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
    /// Text describing this declaration.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Declaration. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Declaration
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
    /// The evidence supporting this declaration.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Declaration. Evidence Supplied
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Declaration
    /// <para />PropertyTerm: Evidence Supplied
    /// <para />AssociatedObjectClass: Evidence Supplied
    /// <para />RepresentationTerm: Evidence Supplied
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EvidenceSuppliedType> EvidenceSupplied
    {
        get { return _evidenceSupplied ?? (_evidenceSupplied = new System.Collections.Generic.List<EvidenceSuppliedType>()); }
        set { _evidenceSupplied = value; }
    }

        
    /// <summary>
    /// A code signifying the type of this declaration.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Declaration. Declaration Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Declaration
    /// <para />PropertyTerm: Declaration Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DeclarationTypeCode
    {
        get
        {
            if (__DeclarationTypeCode == null) { __DeclarationTypeCode = new CodeType(); }
            return __DeclarationTypeCode;
        }
        set
        {
            __DeclarationTypeCode = value;
        }
    }

}