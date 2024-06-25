using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the acceptance or rejection of an economic operator in a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Qualification Resolution. Details
/// <para />ObjectClass: Qualification Resolution
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("QualificationResolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("QualificationResolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class QualificationResolutionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdmissionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__AdmissionCode;
        
    private System.Collections.Generic.List<TextType> _exclusionReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExclusionReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__ExclusionReason
    {
        get
        {
            return _exclusionReason?.ToArray();
        }
        set
        {
            _exclusionReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _resolution;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Resolution", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Resolution
    {
        get
        {
            return _resolution?.ToArray();
        }
        set
        {
            _resolution = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResolutionDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__ResolutionDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResolutionTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__ResolutionTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Order=5)]
    public ProcurementProjectLotType @__ProcurementProjectLot;
        
    /// <summary>
    /// Text describing a reason for an exclusion from the tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualification Resolution. Exclusion Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Qualification Resolution
    /// <para />PropertyTerm: Exclusion Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ExclusionReason
    {
        get { return _exclusionReason ?? (_exclusionReason = new System.Collections.Generic.List<TextType>()); }
        set { _exclusionReason = value; }
    }

        
    /// <summary>
    /// Text describing this qualification resolution.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualification Resolution. Resolution. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Qualification Resolution
    /// <para />PropertyTerm: Resolution
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Resolution
    {
        get { return _resolution ?? (_resolution = new System.Collections.Generic.List<TextType>()); }
        set { _resolution = value; }
    }

        
    /// <summary>
    /// An indicator that the economic operator has been accepted into the tendering process (true) or rejected from the tendering process (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualification Resolution. Admission Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Qualification Resolution
    /// <para />PropertyTerm: Admission Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AdmissionCode
    {
        get
        {
            if (__AdmissionCode == null) { __AdmissionCode = new CodeType(); }
            return __AdmissionCode;
        }
        set
        {
            __AdmissionCode = value;
        }
    }

        
    /// <summary>
    /// The date on which this qualification resolution was formalized.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualification Resolution. Resolution Date. Date
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Qualification Resolution
    /// <para />PropertyTerm: Resolution Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ResolutionDate
    {
        get
        {
            if (__ResolutionDate == null) { __ResolutionDate = new DateType(); }
            return __ResolutionDate;
        }
        set
        {
            __ResolutionDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this qualification resolution was formalized.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualification Resolution. Resolution Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualification Resolution
    /// <para />PropertyTerm: Resolution Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ResolutionTime
    {
        get
        {
            if (__ResolutionTime == null) { __ResolutionTime = new TimeType(); }
            return __ResolutionTime;
        }
        set
        {
            __ResolutionTime = value;
        }
    }

        
    /// <summary>
    /// The Procurement project lot to which this tenderer is accepted or rejected.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualification Resolution. Procurement Project Lot
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualification Resolution
    /// <para />PropertyTerm: Procurement Project Lot
    /// <para />AssociatedObjectClass: Procurement Project Lot
    /// <para />RepresentationTerm: Procurement Project Lot
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ProcurementProjectLotType ProcurementProjectLot
    {
        get
        {
            if (__ProcurementProjectLot == null) { __ProcurementProjectLot = new ProcurementProjectLotType(); }
            return __ProcurementProjectLot;
        }
        set
        {
            __ProcurementProjectLot = value;
        }
    }

}