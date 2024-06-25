using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe one of the parts of a procurement project that is being subdivided to allow the contracting party to award different lots to different economic operators under different contracts.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Procurement Project Lot. Details
/// <para />ObjectClass: Procurement Project Lot
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("InterestedProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("InterestedProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ProcurementProjectLotType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderingTerms", Order=1)]
    public TenderingTermsType @__TenderingTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcurementProject", Order=2)]
    public ProcurementProjectType @__ProcurementProject;
        
    /// <summary>
    /// An identifier for this procurement project lot.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project Lot. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Procurement Project Lot
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
    /// Tendering terms for this procurement project lot.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project Lot. Tendering Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project Lot
    /// <para />PropertyTerm: Tendering Terms
    /// <para />AssociatedObjectClass: Tendering Terms
    /// <para />RepresentationTerm: Tendering Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TenderingTermsType TenderingTerms
    {
        get
        {
            if (__TenderingTerms == null) { __TenderingTerms = new TenderingTermsType(); }
            return __TenderingTerms;
        }
        set
        {
            __TenderingTerms = value;
        }
    }

        
    /// <summary>
    /// A description of the procurement project to be divided.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project Lot. Procurement Project
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project Lot
    /// <para />PropertyTerm: Procurement Project
    /// <para />AssociatedObjectClass: Procurement Project
    /// <para />RepresentationTerm: Procurement Project
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ProcurementProjectType ProcurementProject
    {
        get
        {
            if (__ProcurementProject == null) { __ProcurementProject = new ProcurementProjectType(); }
            return __ProcurementProject;
        }
        set
        {
            __ProcurementProject = value;
        }
    }

}