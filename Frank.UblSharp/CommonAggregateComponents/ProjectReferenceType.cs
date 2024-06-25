using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to a procurement project.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Project Reference. Details
/// <para />ObjectClass: Project Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ProjectReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ProjectReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ProjectReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__IssueDate;
        
    private System.Collections.Generic.List<WorkPhaseReferenceType> _workPhaseReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WorkPhaseReference", Order=3)]
    public WorkPhaseReferenceType[] @__WorkPhaseReference
    {
        get
        {
            return _workPhaseReference?.ToArray();
        }
        set
        {
            _workPhaseReference = value == null ? null : new System.Collections.Generic.List<WorkPhaseReferenceType>(value);
        }
    }
        
    /// <summary>
    /// A specific phase of work in the referenced project.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Project Reference. Work Phase Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Project Reference
    /// <para />PropertyTerm: Work Phase Reference
    /// <para />AssociatedObjectClass: Work Phase Reference
    /// <para />RepresentationTerm: Work Phase Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<WorkPhaseReferenceType> WorkPhaseReference
    {
        get { return _workPhaseReference ?? (_workPhaseReference = new System.Collections.Generic.List<WorkPhaseReferenceType>()); }
        set { _workPhaseReference = value; }
    }

        
    /// <summary>
    /// An identifier for the referenced project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Project Reference. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Project Reference
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
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
    /// A universally unique identifier for the referenced project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Project Reference. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Project Reference
    /// <para />PropertyTerm: UUID
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType UUID
    {
        get
        {
            if (__UUID == null) { __UUID = new IdentifierType(); }
            return __UUID;
        }
        set
        {
            __UUID = value;
        }
    }

        
    /// <summary>
    /// The date on which the referenced project was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Project Reference. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Project Reference
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

}