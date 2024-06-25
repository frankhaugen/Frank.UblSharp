using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a specific capability of an organization.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Capability. Details
/// <para />ObjectClass: Capability
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Capability", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Capability", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CapabilityType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CapabilityTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__CapabilityTypeCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute("ValueAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__ValueAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValueQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__ValueQuantity;
        
    private System.Collections.Generic.List<EvidenceSuppliedType> _evidenceSupplied;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EvidenceSupplied", Order=4)]
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
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Order=5)]
    public PeriodType @__ValidityPeriod;
        
    /// <summary>
    /// Text describing this capability.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Capability. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Capability
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
    /// The evidence that supports the capability claim.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Capability. Evidence Supplied
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Capability
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
    /// This class can be used as Financial or Technical capabilities. For instance, &quot;Turnover&quot; or &quot;Qualified Engineers&quot; are two possible codes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Capability. Capability Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Capability
    /// <para />PropertyTerm: Capability Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CapabilityTypeCode
    {
        get
        {
            if (__CapabilityTypeCode == null) { __CapabilityTypeCode = new CodeType(); }
            return __CapabilityTypeCode;
        }
        set
        {
            __CapabilityTypeCode = value;
        }
    }

        
    /// <summary>
    /// A monetary amount as a measure of this capability.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Capability. Value. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Capability
    /// <para />PropertyTerm: Value
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType ValueAmount
    {
        get
        {
            if (__ValueAmount == null) { __ValueAmount = new AmountType(); }
            return __ValueAmount;
        }
        set
        {
            __ValueAmount = value;
        }
    }

        
    /// <summary>
    /// A quantity as a measure of this capability.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Capability. Value_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Capability
    /// <para />PropertyTermQualifier: Value
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ValueQuantity
    {
        get
        {
            if (__ValueQuantity == null) { __ValueQuantity = new QuantityType(); }
            return __ValueQuantity;
        }
        set
        {
            __ValueQuantity = value;
        }
    }

        
    /// <summary>
    /// The period of time for which this capability is (or has been) valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Capability. Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Capability
    /// <para />PropertyTermQualifier: Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType ValidityPeriod
    {
        get
        {
            if (__ValidityPeriod == null) { __ValidityPeriod = new PeriodType(); }
            return __ValidityPeriod;
        }
        set
        {
            __ValidityPeriod = value;
        }
    }

}