using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The evaluation that the Contracting Authority party requests to fulfill to the tenderers.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tenderer Qualification Request. Details
/// <para />ObjectClass: Tenderer Qualification Request
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TendererQualificationRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TendererQualificationRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TendererQualificationRequestType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompanyLegalFormCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__CompanyLegalFormCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompanyLegalForm", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__CompanyLegalForm;
        
    private System.Collections.Generic.List<TextType> _personalSituation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__PersonalSituation
    {
        get
        {
            return _personalSituation?.ToArray();
        }
        set
        {
            _personalSituation = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OperatingYearsQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__OperatingYearsQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmployeeQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__EmployeeQuantity;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
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
        
    private System.Collections.Generic.List<ClassificationSchemeType> _requiredBusinessClassificationScheme;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredBusinessClassificationScheme", Order=6)]
    public ClassificationSchemeType[] @__RequiredBusinessClassificationScheme
    {
        get
        {
            return _requiredBusinessClassificationScheme?.ToArray();
        }
        set
        {
            _requiredBusinessClassificationScheme = value == null ? null : new System.Collections.Generic.List<ClassificationSchemeType>(value);
        }
    }
        
    private System.Collections.Generic.List<EvaluationCriterionType> _technicalEvaluationCriterion;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TechnicalEvaluationCriterion", Order=7)]
    public EvaluationCriterionType[] @__TechnicalEvaluationCriterion
    {
        get
        {
            return _technicalEvaluationCriterion?.ToArray();
        }
        set
        {
            _technicalEvaluationCriterion = value == null ? null : new System.Collections.Generic.List<EvaluationCriterionType>(value);
        }
    }
        
    private System.Collections.Generic.List<EvaluationCriterionType> _financialEvaluationCriterion;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinancialEvaluationCriterion", Order=8)]
    public EvaluationCriterionType[] @__FinancialEvaluationCriterion
    {
        get
        {
            return _financialEvaluationCriterion?.ToArray();
        }
        set
        {
            _financialEvaluationCriterion = value == null ? null : new System.Collections.Generic.List<EvaluationCriterionType>(value);
        }
    }
        
    private System.Collections.Generic.List<TendererRequirementType> _specificTendererRequirement;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecificTendererRequirement", Order=9)]
    public TendererRequirementType[] @__SpecificTendererRequirement
    {
        get
        {
            return _specificTendererRequirement?.ToArray();
        }
        set
        {
            _specificTendererRequirement = value == null ? null : new System.Collections.Generic.List<TendererRequirementType>(value);
        }
    }
        
    private System.Collections.Generic.List<EconomicOperatorRoleType> _economicOperatorRole;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EconomicOperatorRole", Order=10)]
    public EconomicOperatorRoleType[] @__EconomicOperatorRole
    {
        get
        {
            return _economicOperatorRole?.ToArray();
        }
        set
        {
            _economicOperatorRole = value == null ? null : new System.Collections.Generic.List<EconomicOperatorRoleType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the personal situation of the economic operators in this tendering process.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Personal Situation. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTerm: Personal Situation
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> PersonalSituation
    {
        get { return _personalSituation ?? (_personalSituation = new System.Collections.Generic.List<TextType>()); }
        set { _personalSituation = value; }
    }

        
    /// <summary>
    /// Text describing the evaluation requirements for this tenderer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Qualification Request
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
    /// A classification scheme for the business profile.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Required Business_ Classification Scheme. Classification Scheme
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTermQualifier: Required Business
    /// <para />PropertyTerm: Classification Scheme
    /// <para />AssociatedObjectClass: Classification Scheme
    /// <para />RepresentationTerm: Classification Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ClassificationSchemeType> RequiredBusinessClassificationScheme
    {
        get { return _requiredBusinessClassificationScheme ?? (_requiredBusinessClassificationScheme = new System.Collections.Generic.List<ClassificationSchemeType>()); }
        set { _requiredBusinessClassificationScheme = value; }
    }

        
    /// <summary>
    /// A technical evaluation criterion required for an economic operator in a tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Technical_ Evaluation Criterion. Evaluation Criterion
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTermQualifier: Technical
    /// <para />PropertyTerm: Evaluation Criterion
    /// <para />AssociatedObjectClass: Evaluation Criterion
    /// <para />RepresentationTerm: Evaluation Criterion
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EvaluationCriterionType> TechnicalEvaluationCriterion
    {
        get { return _technicalEvaluationCriterion ?? (_technicalEvaluationCriterion = new System.Collections.Generic.List<EvaluationCriterionType>()); }
        set { _technicalEvaluationCriterion = value; }
    }

        
    /// <summary>
    /// A financial evaluation criterion required for an economic operator in a tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Financial_ Evaluation Criterion. Evaluation Criterion
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTermQualifier: Financial
    /// <para />PropertyTerm: Evaluation Criterion
    /// <para />AssociatedObjectClass: Evaluation Criterion
    /// <para />RepresentationTerm: Evaluation Criterion
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EvaluationCriterionType> FinancialEvaluationCriterion
    {
        get { return _financialEvaluationCriterion ?? (_financialEvaluationCriterion = new System.Collections.Generic.List<EvaluationCriterionType>()); }
        set { _financialEvaluationCriterion = value; }
    }

        
    /// <summary>
    /// A requirement to be met by a tenderer.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Specific_ Tenderer Requirement. Tenderer Requirement
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTermQualifier: Specific
    /// <para />PropertyTerm: Tenderer Requirement
    /// <para />AssociatedObjectClass: Tenderer Requirement
    /// <para />RepresentationTerm: Tenderer Requirement
    /// </summary>
    /// <example>Preregistration in a Business Registry</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TendererRequirementType> SpecificTendererRequirement
    {
        get { return _specificTendererRequirement ?? (_specificTendererRequirement = new System.Collections.Generic.List<TendererRequirementType>()); }
        set { _specificTendererRequirement = value; }
    }

        
    /// <summary>
    /// A class to describe the tenderer contracting role.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Economic Operator Role
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTerm: Economic Operator Role
    /// <para />AssociatedObjectClass: Economic Operator Role
    /// <para />RepresentationTerm: Economic Operator Role
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EconomicOperatorRoleType> EconomicOperatorRole
    {
        get { return _economicOperatorRole ?? (_economicOperatorRole = new System.Collections.Generic.List<EconomicOperatorRoleType>()); }
        set { _economicOperatorRole = value; }
    }

        
    /// <summary>
    /// The legal status requested for potential tenderers, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Company Legal Form Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTerm: Company Legal Form Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CompanyLegalFormCode
    {
        get
        {
            if (__CompanyLegalFormCode == null) { __CompanyLegalFormCode = new CodeType(); }
            return __CompanyLegalFormCode;
        }
        set
        {
            __CompanyLegalFormCode = value;
        }
    }

        
    /// <summary>
    /// The legal status requested for potential tenderers, expressed as text
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Company Legal Form. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTerm: Company Legal Form
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CompanyLegalForm
    {
        get
        {
            if (__CompanyLegalForm == null) { __CompanyLegalForm = new TextType(); }
            return __CompanyLegalForm;
        }
        set
        {
            __CompanyLegalForm = value;
        }
    }

        
    /// <summary>
    /// Textual description of the legal form required for potential tenderers.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Operating Years. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTerm: Operating Years
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType OperatingYearsQuantity
    {
        get
        {
            if (__OperatingYearsQuantity == null) { __OperatingYearsQuantity = new QuantityType(); }
            return __OperatingYearsQuantity;
        }
        set
        {
            __OperatingYearsQuantity = value;
        }
    }

        
    /// <summary>
    /// Textual description of the legal form required for potential tenderers.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tenderer Qualification Request. Employee. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tenderer Qualification Request
    /// <para />PropertyTerm: Employee
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType EmployeeQuantity
    {
        get
        {
            if (__EmployeeQuantity == null) { __EmployeeQuantity = new QuantityType(); }
            return __EmployeeQuantity;
        }
        set
        {
            __EmployeeQuantity = value;
        }
    }

}