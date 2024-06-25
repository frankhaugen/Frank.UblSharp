using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the condition or position of an object.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Status. Details
/// <para />ObjectClass: Status
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CurrentStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CurrentStatus", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class StatusType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConditionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__ConditionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__ReferenceDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__ReferenceTime;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
    [System.Xml.Serialization.XmlElementAttribute("StatusReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__StatusReasonCode;
        
    private System.Collections.Generic.List<TextType> _statusReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("StatusReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__StatusReason
    {
        get
        {
            return _statusReason?.ToArray();
        }
        set
        {
            _statusReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SequenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public IdentifierType @__SequenceID;
        
    private System.Collections.Generic.List<TextType> _text;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Text", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType[] @__Text
    {
        get
        {
            return _text?.ToArray();
        }
        set
        {
            _text = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IndicationIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IndicatorType @__IndicationIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public PercentType @__Percent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReliabilityPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public PercentType @__ReliabilityPercent;
        
    private System.Collections.Generic.List<ConditionType> _condition;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Condition", Order=11)]
    public ConditionType[] @__Condition
    {
        get
        {
            return _condition?.ToArray();
        }
        set
        {
            _condition = value == null ? null : new System.Collections.Generic.List<ConditionType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Status
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
    /// The reason for this status condition or position, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Status_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Status
    /// <para />PropertyTermQualifier: Status
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> StatusReason
    {
        get { return _statusReason ?? (_statusReason = new System.Collections.Generic.List<TextType>()); }
        set { _statusReason = value; }
    }

        
    /// <summary>
    /// Provides any textual information related to this status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Text
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Text
    {
        get { return _text ?? (_text = new System.Collections.Generic.List<TextType>()); }
        set { _text = value; }
    }

        
    /// <summary>
    /// Measurements that quantify the condition of the objects covered by the status.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Status. Condition
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Condition
    /// <para />AssociatedObjectClass: Condition
    /// <para />RepresentationTerm: Condition
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConditionType> Condition
    {
        get { return _condition ?? (_condition = new System.Collections.Generic.List<ConditionType>()); }
        set { _condition = value; }
    }

        
    /// <summary>
    /// Specifies the status condition of the related object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Condition Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Condition Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ConditionCode
    {
        get
        {
            if (__ConditionCode == null) { __ConditionCode = new CodeType(); }
            return __ConditionCode;
        }
        set
        {
            __ConditionCode = value;
        }
    }

        
    /// <summary>
    /// The reference date for this status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Reference Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Reference Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ReferenceDate
    {
        get
        {
            if (__ReferenceDate == null) { __ReferenceDate = new DateType(); }
            return __ReferenceDate;
        }
        set
        {
            __ReferenceDate = value;
        }
    }

        
    /// <summary>
    /// The reference time for this status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Reference Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Reference Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ReferenceTime
    {
        get
        {
            if (__ReferenceTime == null) { __ReferenceTime = new TimeType(); }
            return __ReferenceTime;
        }
        set
        {
            __ReferenceTime = value;
        }
    }

        
    /// <summary>
    /// The reason for this status condition or position, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Status Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Status Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType StatusReasonCode
    {
        get
        {
            if (__StatusReasonCode == null) { __StatusReasonCode = new CodeType(); }
            return __StatusReasonCode;
        }
        set
        {
            __StatusReasonCode = value;
        }
    }

        
    /// <summary>
    /// A sequence identifier for this status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Sequence Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Sequence Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SequenceID
    {
        get
        {
            if (__SequenceID == null) { __SequenceID = new IdentifierType(); }
            return __SequenceID;
        }
        set
        {
            __SequenceID = value;
        }
    }

        
    /// <summary>
    /// Specifies an indicator relevant to a specific status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Indication_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTermQualifier: Indication
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType IndicationIndicator
    {
        get
        {
            if (__IndicationIndicator == null) { __IndicationIndicator = new IndicatorType(); }
            return __IndicationIndicator;
        }
        set
        {
            __IndicationIndicator = value;
        }
    }

        
    /// <summary>
    /// A percentage meaningful in the context of this status.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType Percent
    {
        get
        {
            if (__Percent == null) { __Percent = new PercentType(); }
            return __Percent;
        }
        set
        {
            __Percent = value;
        }
    }

        
    /// <summary>
    /// The reliability of this status, expressed as a percentage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Status. Reliability Percent. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Status
    /// <para />PropertyTerm: Reliability Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType ReliabilityPercent
    {
        get
        {
            if (__ReliabilityPercent == null) { __ReliabilityPercent = new PercentType(); }
            return __ReliabilityPercent;
        }
        set
        {
            __ReliabilityPercent = value;
        }
    }

}