using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// Agree can be renamed as PromotionalEvents
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Promotional Event. Details
/// <para />ObjectClass: Promotional Event
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("PromotionalEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("PromotionalEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class PromotionalEventType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PromotionalEventTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__PromotionalEventTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubmissionDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__SubmissionDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FirstShipmentAvailibilityDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__FirstShipmentAvailibilityDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LatestProposalAcceptanceDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__LatestProposalAcceptanceDate;
        
    private System.Collections.Generic.List<PromotionalSpecificationType> _promotionalSpecification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PromotionalSpecification", Order=4)]
    public PromotionalSpecificationType[] @__PromotionalSpecification
    {
        get
        {
            return _promotionalSpecification?.ToArray();
        }
        set
        {
            _promotionalSpecification = value == null ? null : new System.Collections.Generic.List<PromotionalSpecificationType>(value);
        }
    }
        
    /// <summary>
    /// A specification for a promotional event.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Promotional Event. Promotional Specification
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Promotional Event
    /// <para />PropertyTerm: Promotional Specification
    /// <para />AssociatedObjectClass: Promotional Specification
    /// <para />RepresentationTerm: Promotional Specification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PromotionalSpecificationType> PromotionalSpecification
    {
        get { return _promotionalSpecification ?? (_promotionalSpecification = new System.Collections.Generic.List<PromotionalSpecificationType>()); }
        set { _promotionalSpecification = value; }
    }

        
    /// <summary>
    /// A code signifying the type of this promotional event. Examples can be: Holiday, Seasonal Event, Store Closing, Trade Item Introduction
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Promotional Event. Promotional Event Type Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Promotional Event
    /// <para />PropertyTerm: Promotional Event Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PromotionalEventTypeCode
    {
        get
        {
            if (__PromotionalEventTypeCode == null) { __PromotionalEventTypeCode = new CodeType(); }
            return __PromotionalEventTypeCode;
        }
        set
        {
            __PromotionalEventTypeCode = value;
        }
    }

        
    /// <summary>
    /// The date on which a proposal for this promotional event was submitted.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Promotional Event. Submission. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Promotional Event
    /// <para />PropertyTerm: Submission
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType SubmissionDate
    {
        get
        {
            if (__SubmissionDate == null) { __SubmissionDate = new DateType(); }
            return __SubmissionDate;
        }
        set
        {
            __SubmissionDate = value;
        }
    }

        
    /// <summary>
    /// The first day that products will be available to ship from buyer to seller if the proposal for this promotional event is accepted.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Promotional Event. First Shipment Availibility Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Promotional Event
    /// <para />PropertyTerm: First Shipment Availibility Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType FirstShipmentAvailibilityDate
    {
        get
        {
            if (__FirstShipmentAvailibilityDate == null) { __FirstShipmentAvailibilityDate = new DateType(); }
            return __FirstShipmentAvailibilityDate;
        }
        set
        {
            __FirstShipmentAvailibilityDate = value;
        }
    }

        
    /// <summary>
    /// The deadline for acceptance of this promotional event.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Promotional Event. Latest_ Proposal Acceptance Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Promotional Event
    /// <para />PropertyTermQualifier: Latest
    /// <para />PropertyTerm: Proposal Acceptance Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType LatestProposalAcceptanceDate
    {
        get
        {
            if (__LatestProposalAcceptanceDate == null) { __LatestProposalAcceptanceDate = new DateType(); }
            return __LatestProposalAcceptanceDate;
        }
        set
        {
            __LatestProposalAcceptanceDate = value;
        }
    }

}