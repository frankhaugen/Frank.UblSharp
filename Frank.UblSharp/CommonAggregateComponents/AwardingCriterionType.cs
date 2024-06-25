using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a criterion from the contracting party that will be taken into account when awarding a contract. An awarding criterion can be objective, when it can be evaluated following a formula, or subjective, when human analysis is required.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Awarding Criterion. Details
/// <para />ObjectClass: Awarding Criterion
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AwardingCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AwardingCriterion", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AwardingCriterionType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__AwardingCriterionTypeCode;
        
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
    [System.Xml.Serialization.XmlElementAttribute("WeightNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public NumericType @__WeightNumeric;
        
    private System.Collections.Generic.List<TextType> _weight;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Weight", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__Weight
    {
        get
        {
            return _weight?.ToArray();
        }
        set
        {
            _weight = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _calculationExpression;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CalculationExpression", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TextType[] @__CalculationExpression
    {
        get
        {
            return _calculationExpression?.ToArray();
        }
        set
        {
            _calculationExpression = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CalculationExpressionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__CalculationExpressionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public QuantityType @__MinimumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public QuantityType @__MaximumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public AmountType @__MinimumAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public AmountType @__MaximumAmount;
        
    private System.Collections.Generic.List<TextType> _minimumImprovementBid;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumImprovementBid", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public TextType[] @__MinimumImprovementBid
    {
        get
        {
            return _minimumImprovementBid?.ToArray();
        }
        set
        {
            _minimumImprovementBid = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<AwardingCriterionType> _subordinateAwardingCriterion;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubordinateAwardingCriterion", Order=12)]
    public AwardingCriterionType[] @__SubordinateAwardingCriterion
    {
        get
        {
            return _subordinateAwardingCriterion?.ToArray();
        }
        set
        {
            _subordinateAwardingCriterion = value == null ? null : new System.Collections.Generic.List<AwardingCriterionType>(value);
        }
    }
        
    /// <summary>
    /// A description of the awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion
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
    /// A description of the comparative weighting for this awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Weight. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Weight
    {
        get { return _weight ?? (_weight = new System.Collections.Generic.List<TextType>()); }
        set { _weight = value; }
    }

        
    /// <summary>
    /// The mathematical expression that will be used to evaluate this criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Calculation Expression. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTerm: Calculation Expression
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> CalculationExpression
    {
        get { return _calculationExpression ?? (_calculationExpression = new System.Collections.Generic.List<TextType>()); }
        set { _calculationExpression = value; }
    }

        
    /// <summary>
    /// Describes the minimum improvement bid for this awarding criterion when used in an auction.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Minimum Improvement Bid. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTerm: Minimum Improvement Bid
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> MinimumImprovementBid
    {
        get { return _minimumImprovementBid ?? (_minimumImprovementBid = new System.Collections.Generic.List<TextType>()); }
        set { _minimumImprovementBid = value; }
    }

        
    /// <summary>
    /// Defines any subsidiary awarding criterion.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Subordinate_ Awarding Criterion. Awarding Criterion
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTermQualifier: Subordinate
    /// <para />PropertyTerm: Awarding Criterion
    /// <para />AssociatedObjectClass: Awarding Criterion
    /// <para />RepresentationTerm: Awarding Criterion
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AwardingCriterionType> SubordinateAwardingCriterion
    {
        get { return _subordinateAwardingCriterion ?? (_subordinateAwardingCriterion = new System.Collections.Generic.List<AwardingCriterionType>()); }
        set { _subordinateAwardingCriterion = value; }
    }

        
    /// <summary>
    /// Identifies a specific awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
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
    /// A code used to define this awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Awarding Criterion Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTerm: Awarding Criterion Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType AwardingCriterionTypeCode
    {
        get
        {
            if (__AwardingCriterionTypeCode == null) { __AwardingCriterionTypeCode = new CodeType(); }
            return __AwardingCriterionTypeCode;
        }
        set
        {
            __AwardingCriterionTypeCode = value;
        }
    }

        
    /// <summary>
    /// A number defining the comparative weighting assigned to this awarding criterion, to enable formulaic evaluation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Weight Numeric. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTerm: Weight Numeric
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType WeightNumeric
    {
        get
        {
            if (__WeightNumeric == null) { __WeightNumeric = new NumericType(); }
            return __WeightNumeric;
        }
        set
        {
            __WeightNumeric = value;
        }
    }

        
    /// <summary>
    /// A code identifying the mathematical expression that will be used to evaluate this criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Calculation Expression Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTerm: Calculation Expression Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CalculationExpressionCode
    {
        get
        {
            if (__CalculationExpressionCode == null) { __CalculationExpressionCode = new CodeType(); }
            return __CalculationExpressionCode;
        }
        set
        {
            __CalculationExpressionCode = value;
        }
    }

        
    /// <summary>
    /// The minimum quantity for an awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Minimum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumQuantity
    {
        get
        {
            if (__MinimumQuantity == null) { __MinimumQuantity = new QuantityType(); }
            return __MinimumQuantity;
        }
        set
        {
            __MinimumQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum quantity for an awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Maximum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumQuantity
    {
        get
        {
            if (__MaximumQuantity == null) { __MaximumQuantity = new QuantityType(); }
            return __MaximumQuantity;
        }
        set
        {
            __MaximumQuantity = value;
        }
    }

        
    /// <summary>
    /// The minimum monetary amount for an awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Minimum_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MinimumAmount
    {
        get
        {
            if (__MinimumAmount == null) { __MinimumAmount = new AmountType(); }
            return __MinimumAmount;
        }
        set
        {
            __MinimumAmount = value;
        }
    }

        
    /// <summary>
    /// The maximum monetary amount for an awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion. Maximum_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType MaximumAmount
    {
        get
        {
            if (__MaximumAmount == null) { __MaximumAmount = new AmountType(); }
            return __MaximumAmount;
        }
        set
        {
            __MaximumAmount = value;
        }
    }

}