using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class that refers to a phase of work. Used for instance to specify what part of the contract the billing is referring to.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Work Phase Reference. Details
/// <para />ObjectClass: Work Phase Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("WorkPhaseReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("WorkPhaseReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class WorkPhaseReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WorkPhaseCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__WorkPhaseCode;
        
    private System.Collections.Generic.List<TextType> _workPhase;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WorkPhase", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__WorkPhase
    {
        get
        {
            return _workPhase?.ToArray();
        }
        set
        {
            _workPhase = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProgressPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public PercentType @__ProgressPercent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StartDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__StartDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EndDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public DateType @__EndDate;
        
    private System.Collections.Generic.List<DocumentReferenceType> _workOrderDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("WorkOrderDocumentReference", Order=6)]
    public DocumentReferenceType[] @__WorkOrderDocumentReference
    {
        get
        {
            return _workOrderDocumentReference?.ToArray();
        }
        set
        {
            _workOrderDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this phase of work.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Work Phase Reference. Work Phase. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Work Phase Reference
    /// <para />PropertyTerm: Work Phase
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> WorkPhase
    {
        get { return _workPhase ?? (_workPhase = new System.Collections.Generic.List<TextType>()); }
        set { _workPhase = value; }
    }

        
    /// <summary>
    /// A reference to a document regarding the work order for the project in which this phase of work takes place.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Work Phase Reference. Work Order_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Work Phase Reference
    /// <para />PropertyTermQualifier: Work Order
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> WorkOrderDocumentReference
    {
        get { return _workOrderDocumentReference ?? (_workOrderDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _workOrderDocumentReference = value; }
    }

        
    /// <summary>
    /// An identifier for this phase of work.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Work Phase Reference. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Work Phase Reference
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
    /// A code signifying this phase of work.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Work Phase Reference. Work Phase Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Work Phase Reference
    /// <para />PropertyTerm: Work Phase Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType WorkPhaseCode
    {
        get
        {
            if (__WorkPhaseCode == null) { __WorkPhaseCode = new CodeType(); }
            return __WorkPhaseCode;
        }
        set
        {
            __WorkPhaseCode = value;
        }
    }

        
    /// <summary>
    /// The progress percentage of the work phase.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Work Phase Reference. Progress Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Work Phase Reference
    /// <para />PropertyTerm: Progress Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType ProgressPercent
    {
        get
        {
            if (__ProgressPercent == null) { __ProgressPercent = new PercentType(); }
            return __ProgressPercent;
        }
        set
        {
            __ProgressPercent = value;
        }
    }

        
    /// <summary>
    /// The date on which this phase of work begins.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Work Phase Reference. Start Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Work Phase Reference
    /// <para />PropertyTerm: Start Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType StartDate
    {
        get
        {
            if (__StartDate == null) { __StartDate = new DateType(); }
            return __StartDate;
        }
        set
        {
            __StartDate = value;
        }
    }

        
    /// <summary>
    /// The date on which this phase of work ends.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Work Phase Reference. End Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Work Phase Reference
    /// <para />PropertyTerm: End Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType EndDate
    {
        get
        {
            if (__EndDate == null) { __EndDate = new DateType(); }
            return __EndDate;
        }
        set
        {
            __EndDate = value;
        }
    }

}