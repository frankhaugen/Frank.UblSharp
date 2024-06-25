using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe directions for preparing a tender.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tender Preparation. Details
/// <para />ObjectClass: Tender Preparation
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TenderPreparation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TenderPreparation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TenderPreparationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderEnvelopeID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__TenderEnvelopeID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderEnvelopeTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__TenderEnvelopeTypeCode;
        
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
    [System.Xml.Serialization.XmlElementAttribute("OpenTenderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IdentifierType @__OpenTenderID;
        
    private System.Collections.Generic.List<ProcurementProjectLotType> _procurementProjectLot;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Order=4)]
    public ProcurementProjectLotType[] @__ProcurementProjectLot
    {
        get
        {
            return _procurementProjectLot?.ToArray();
        }
        set
        {
            _procurementProjectLot = value == null ? null : new System.Collections.Generic.List<ProcurementProjectLotType>(value);
        }
    }
        
    private System.Collections.Generic.List<TenderRequirementType> _documentTenderRequirement;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentTenderRequirement", Order=5)]
    public TenderRequirementType[] @__DocumentTenderRequirement
    {
        get
        {
            return _documentTenderRequirement?.ToArray();
        }
        set
        {
            _documentTenderRequirement = value == null ? null : new System.Collections.Generic.List<TenderRequirementType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the tender envelope.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Preparation. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Preparation
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
    /// The procurement project lot associated with a particular tenderer.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Preparation. Procurement Project Lot
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Preparation
    /// <para />PropertyTerm: Procurement Project Lot
    /// <para />AssociatedObjectClass: Procurement Project Lot
    /// <para />RepresentationTerm: Procurement Project Lot
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ProcurementProjectLotType> ProcurementProjectLot
    {
        get { return _procurementProjectLot ?? (_procurementProjectLot = new System.Collections.Generic.List<ProcurementProjectLotType>()); }
        set { _procurementProjectLot = value; }
    }

        
    /// <summary>
    /// A reference to the template for a required document in a tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tender Preparation. Document_ Tender Requirement. Tender Requirement
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tender Preparation
    /// <para />PropertyTermQualifier: Document
    /// <para />PropertyTerm: Tender Requirement
    /// <para />AssociatedObjectClass: Tender Requirement
    /// <para />RepresentationTerm: Tender Requirement
    /// </summary>
    /// <example>Curricula required, Experience required, ....</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TenderRequirementType> DocumentTenderRequirement
    {
        get { return _documentTenderRequirement ?? (_documentTenderRequirement = new System.Collections.Generic.List<TenderRequirementType>()); }
        set { _documentTenderRequirement = value; }
    }

        
    /// <summary>
    /// An identifier for the tender envelope to be used with the tender.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Preparation. Tender Envelope Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Tender Preparation
    /// <para />PropertyTerm: Tender Envelope Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TenderEnvelopeID
    {
        get
        {
            if (__TenderEnvelopeID == null) { __TenderEnvelopeID = new IdentifierType(); }
            return __TenderEnvelopeID;
        }
        set
        {
            __TenderEnvelopeID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of tender envelope (economical or objective criteria versus technical or subjective criteria).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Preparation. Tender Envelope Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Preparation
    /// <para />PropertyTerm: Tender Envelope Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TenderEnvelopeTypeCode
    {
        get
        {
            if (__TenderEnvelopeTypeCode == null) { __TenderEnvelopeTypeCode = new CodeType(); }
            return __TenderEnvelopeTypeCode;
        }
        set
        {
            __TenderEnvelopeTypeCode = value;
        }
    }

        
    /// <summary>
    /// An identifier for the open tender associated with this tender preparation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tender Preparation. Open Tender Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tender Preparation
    /// <para />PropertyTerm: Open Tender Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType OpenTenderID
    {
        get
        {
            if (__OpenTenderID == null) { __OpenTenderID = new IdentifierType(); }
            return __OpenTenderID;
        }
        set
        {
            __OpenTenderID = value;
        }
    }

}