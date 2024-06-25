using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class defining the required criterion for a tenderer to be elligible in a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Evaluation Criterion. Details
/// <para />ObjectClass: Evaluation Criterion
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EvaluationCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EvaluationCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EvaluationCriterionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EvaluationCriterionTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__EvaluationCriterionTypeCode;
        
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
    [System.Xml.Serialization.XmlElementAttribute("ThresholdAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public AmountType @__ThresholdAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ThresholdQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__ThresholdQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpressionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__ExpressionCode;
        
    private System.Collections.Generic.List<TextType> _expression;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Expression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__Expression
    {
        get
        {
            return _expression?.ToArray();
        }
        set
        {
            _expression = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DurationPeriod", Order=6)]
    public PeriodType @__DurationPeriod;
        
    private System.Collections.Generic.List<EvidenceType> _suggestedEvidence;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SuggestedEvidence", Order=7)]
    public EvidenceType[] @__SuggestedEvidence
    {
        get
        {
            return _suggestedEvidence?.ToArray();
        }
        set
        {
            _suggestedEvidence = value == null ? null : new System.Collections.Generic.List<EvidenceType>(value);
        }
    }
        
    /// <summary>
    /// A description of the criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Evaluation Criterion
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
    /// The expression that will be used to evaluate the criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Expression. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Evaluation Criterion
    /// <para />PropertyTerm: Expression
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Expression
    {
        get { return _expression ?? (_expression = new System.Collections.Generic.List<TextType>()); }
        set { _expression = value; }
    }

        
    /// <summary>
    /// Describes any evidences that should be used to satisfy the criterion.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Suggested_ Evidence. Evidence
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Evaluation Criterion
    /// <para />PropertyTermQualifier: Suggested
    /// <para />PropertyTerm: Evidence
    /// <para />AssociatedObjectClass: Evidence
    /// <para />RepresentationTerm: Evidence
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EvidenceType> SuggestedEvidence
    {
        get { return _suggestedEvidence ?? (_suggestedEvidence = new System.Collections.Generic.List<EvidenceType>()); }
        set { _suggestedEvidence = value; }
    }

        
    /// <summary>
    /// A code that specifies the criterion; it may be financial, technical or organizational.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Evaluation Criterion Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evaluation Criterion
    /// <para />PropertyTerm: Evaluation Criterion Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType EvaluationCriterionTypeCode
    {
        get
        {
            if (__EvaluationCriterionTypeCode == null) { __EvaluationCriterionTypeCode = new CodeType(); }
            return __EvaluationCriterionTypeCode;
        }
        set
        {
            __EvaluationCriterionTypeCode = value;
        }
    }

        
    /// <summary>
    /// Estimated monetary amount of the threshold for the criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Threshold_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evaluation Criterion
    /// <para />PropertyTermQualifier: Threshold
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType ThresholdAmount
    {
        get
        {
            if (__ThresholdAmount == null) { __ThresholdAmount = new AmountType(); }
            return __ThresholdAmount;
        }
        set
        {
            __ThresholdAmount = value;
        }
    }

        
    /// <summary>
    /// Estimated quantity of the threshold for the criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Threshold_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evaluation Criterion
    /// <para />PropertyTermQualifier: Threshold
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ThresholdQuantity
    {
        get
        {
            if (__ThresholdQuantity == null) { __ThresholdQuantity = new QuantityType(); }
            return __ThresholdQuantity;
        }
        set
        {
            __ThresholdQuantity = value;
        }
    }

        
    /// <summary>
    /// A code identifying the expression that will be used to evaluate the criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Expression Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evaluation Criterion
    /// <para />PropertyTerm: Expression Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ExpressionCode
    {
        get
        {
            if (__ExpressionCode == null) { __ExpressionCode = new CodeType(); }
            return __ExpressionCode;
        }
        set
        {
            __ExpressionCode = value;
        }
    }

        
    /// <summary>
    /// Describes the period for which the evaluation criterion is valid.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Evaluation Criterion. Duration_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Evaluation Criterion
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