using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a tendering framework agreement.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Framework Agreement. Details
/// <para />ObjectClass: Framework Agreement
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("FrameworkAgreement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("FrameworkAgreement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class FrameworkAgreementType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpectedOperatorQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public QuantityType @__ExpectedOperatorQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumOperatorQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__MaximumOperatorQuantity;
        
    private System.Collections.Generic.List<TextType> _justification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Justification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__Justification
    {
        get
        {
            return _justification?.ToArray();
        }
        set
        {
            _justification = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _frequency;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Frequency", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__Frequency
    {
        get
        {
            return _frequency?.ToArray();
        }
        set
        {
            _frequency = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DurationPeriod", Order=4)]
    public PeriodType @__DurationPeriod;
        
    private System.Collections.Generic.List<TenderRequirementType> _subsequentProcessTenderRequirement;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubsequentProcessTenderRequirement", Order=5)]
    public TenderRequirementType[] @__SubsequentProcessTenderRequirement
    {
        get
        {
            return _subsequentProcessTenderRequirement?.ToArray();
        }
        set
        {
            _subsequentProcessTenderRequirement = value == null ? null : new System.Collections.Generic.List<TenderRequirementType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the justification for this framework agreement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Framework Agreement. Justification. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Framework Agreement
    /// <para />PropertyTerm: Justification
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Justification
    {
        get { return _justification ?? (_justification = new System.Collections.Generic.List<TextType>()); }
        set { _justification = value; }
    }

        
    /// <summary>
    /// Text describing the frequency with which subsequent contracts will be awarded.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Framework Agreement. Frequency. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Framework Agreement
    /// <para />PropertyTerm: Frequency
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Frequency
    {
        get { return _frequency ?? (_frequency = new System.Collections.Generic.List<TextType>()); }
        set { _frequency = value; }
    }

        
    /// <summary>
    /// A tender requirement intended for consumption by downstream tendering processes derived from the establishment of this framework agreement.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Framework Agreement. Subsequent Process_ Tender Requirement. Tender Requirement
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Framework Agreement
    /// <para />PropertyTermQualifier: Subsequent Process
    /// <para />PropertyTerm: Tender Requirement
    /// <para />AssociatedObjectClass: Tender Requirement
    /// <para />RepresentationTerm: Tender Requirement
    /// </summary>
    /// <example>Curricula required</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TenderRequirementType> SubsequentProcessTenderRequirement
    {
        get { return _subsequentProcessTenderRequirement ?? (_subsequentProcessTenderRequirement = new System.Collections.Generic.List<TenderRequirementType>()); }
        set { _subsequentProcessTenderRequirement = value; }
    }

        
    /// <summary>
    /// The number of economic operators expected to participate in this framework agreement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Framework Agreement. Expected_ Operator. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Framework Agreement
    /// <para />PropertyTermQualifier: Expected
    /// <para />PropertyTerm: Operator
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ExpectedOperatorQuantity
    {
        get
        {
            if (__ExpectedOperatorQuantity == null) { __ExpectedOperatorQuantity = new QuantityType(); }
            return __ExpectedOperatorQuantity;
        }
        set
        {
            __ExpectedOperatorQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum number of economic operators allowed to participate in this framework agreement.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Framework Agreement. Maximum_ Operator. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Framework Agreement
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Operator
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumOperatorQuantity
    {
        get
        {
            if (__MaximumOperatorQuantity == null) { __MaximumOperatorQuantity = new QuantityType(); }
            return __MaximumOperatorQuantity;
        }
        set
        {
            __MaximumOperatorQuantity = value;
        }
    }

        
    /// <summary>
    /// The period during which this framework agreement applies.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Framework Agreement. Duration_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Framework Agreement
    /// <para />PropertyTermQualifier: Duration
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType DurationPeriod
    {
        get
        {
            if (__DurationPeriod == null) { __DurationPeriod = new PeriodType(); }
            return __DurationPeriod;
        }
        set
        {
            __DurationPeriod = value;
        }
    }

}