namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the qualifications of a tenderer party.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tenderer Party Qualification. Details
/// <para />ObjectClass: Tenderer Party Qualification
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TendererPartyQualification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TendererPartyQualification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TendererPartyQualificationType
{
        
    private System.Collections.Generic.List<ProcurementProjectLotType> _interestedProcurementProjectLot;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InterestedProcurementProjectLot", Order=0)]
    public ProcurementProjectLotType[] @__InterestedProcurementProjectLot
    {
        get
        {
            return _interestedProcurementProjectLot?.ToArray();
        }
        set
        {
            _interestedProcurementProjectLot = value == null ? null : new System.Collections.Generic.List<ProcurementProjectLotType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MainQualifyingParty", Order=1)]
    public QualifyingPartyType @__MainQualifyingParty;
        
    private System.Collections.Generic.List<QualifyingPartyType> _additionalQualifyingParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalQualifyingParty", Order=2)]
    public QualifyingPartyType[] @__AdditionalQualifyingParty
    {
        get
        {
            return _additionalQualifyingParty?.ToArray();
        }
        set
        {
            _additionalQualifyingParty = value == null ? null : new System.Collections.Generic.List<QualifyingPartyType>(value);
        }
    }
        
    /// <summary>
    /// The procurement project lot the party is interested in.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Party Qualification. Interested_ Procurement Project Lot. Procurement Project Lot
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Party Qualification
    /// <para />PropertyTermQualifier: Interested
    /// <para />PropertyTerm: Procurement Project Lot
    /// <para />AssociatedObjectClass: Procurement Project Lot
    /// <para />RepresentationTerm: Procurement Project Lot
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ProcurementProjectLotType> InterestedProcurementProjectLot
    {
        get { return _interestedProcurementProjectLot ?? (_interestedProcurementProjectLot = new System.Collections.Generic.List<ProcurementProjectLotType>()); }
        set { _interestedProcurementProjectLot = value; }
    }

        
    /// <summary>
    /// The qualifications of a tenderer party other than the main tenderer party when bidding as a consortium.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Party Qualification. Additional_ Qualifying Party. Qualifying Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Party Qualification
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Qualifying Party
    /// <para />AssociatedObjectClass: Qualifying Party
    /// <para />RepresentationTerm: Qualifying Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<QualifyingPartyType> AdditionalQualifyingParty
    {
        get { return _additionalQualifyingParty ?? (_additionalQualifyingParty = new System.Collections.Generic.List<QualifyingPartyType>()); }
        set { _additionalQualifyingParty = value; }
    }

        
    /// <summary>
    /// The qualifications of the main tenderer party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Party Qualification. Main_ Qualifying Party. Qualifying Party
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Tenderer Party Qualification
    /// <para />PropertyTermQualifier: Main
    /// <para />PropertyTerm: Qualifying Party
    /// <para />AssociatedObjectClass: Qualifying Party
    /// <para />RepresentationTerm: Qualifying Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QualifyingPartyType MainQualifyingParty
    {
        get
        {
            if (__MainQualifyingParty == null) { __MainQualifyingParty = new QualifyingPartyType(); }
            return __MainQualifyingParty;
        }
        set
        {
            __MainQualifyingParty = value;
        }
    }

}