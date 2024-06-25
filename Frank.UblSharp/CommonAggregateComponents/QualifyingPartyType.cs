using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the distinctive features or characteristics qualifying an economic operator to be a party in a tendering process (e.g., number of employees, number of operating units, type of business, technical and financial capabilities, completed projects).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Qualifying Party. Details
/// <para />ObjectClass: Qualifying Party
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalQualifyingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalQualifyingParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class QualifyingPartyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ParticipationPercent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public PercentType @__ParticipationPercent;
        
    private System.Collections.Generic.List<TextType> _personalSituation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PersonalSituation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute("OperatingYearsQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__OperatingYearsQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmployeeQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__EmployeeQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BusinessClassificationEvidenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public IdentifierType @__BusinessClassificationEvidenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BusinessIdentityEvidenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IdentifierType @__BusinessIdentityEvidenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TendererRoleCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__TendererRoleCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BusinessClassificationScheme", Order=7)]
    public ClassificationSchemeType @__BusinessClassificationScheme;
        
    private System.Collections.Generic.List<CapabilityType> _technicalCapability;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TechnicalCapability", Order=8)]
    public CapabilityType[] @__TechnicalCapability
    {
        get
        {
            return _technicalCapability?.ToArray();
        }
        set
        {
            _technicalCapability = value == null ? null : new System.Collections.Generic.List<CapabilityType>(value);
        }
    }
        
    private System.Collections.Generic.List<CapabilityType> _financialCapability;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FinancialCapability", Order=9)]
    public CapabilityType[] @__FinancialCapability
    {
        get
        {
            return _financialCapability?.ToArray();
        }
        set
        {
            _financialCapability = value == null ? null : new System.Collections.Generic.List<CapabilityType>(value);
        }
    }
        
    private System.Collections.Generic.List<CompletedTaskType> _completedTask;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CompletedTask", Order=10)]
    public CompletedTaskType[] @__CompletedTask
    {
        get
        {
            return _completedTask?.ToArray();
        }
        set
        {
            _completedTask = value == null ? null : new System.Collections.Generic.List<CompletedTaskType>(value);
        }
    }
        
    private System.Collections.Generic.List<DeclarationType> _declaration;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Declaration", Order=11)]
    public DeclarationType[] @__Declaration
    {
        get
        {
            return _declaration?.ToArray();
        }
        set
        {
            _declaration = value == null ? null : new System.Collections.Generic.List<DeclarationType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Party", Order=12)]
    public PartyType @__Party;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EconomicOperatorRole", Order=13)]
    public EconomicOperatorRoleType @__EconomicOperatorRole;
        
    /// <summary>
    /// Text describing the personal situation of the qualifying party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualifying Party. Personal Situation. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Qualifying Party
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
    /// A technical capability of this qualifying party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualifying Party. Technical_ Capability. Capability
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTermQualifier: Technical
    /// <para />PropertyTerm: Capability
    /// <para />AssociatedObjectClass: Capability
    /// <para />RepresentationTerm: Capability
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CapabilityType> TechnicalCapability
    {
        get { return _technicalCapability ?? (_technicalCapability = new System.Collections.Generic.List<CapabilityType>()); }
        set { _technicalCapability = value; }
    }

        
    /// <summary>
    /// A financial capability of this qualifying party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualifying Party. Financial_ Capability. Capability
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTermQualifier: Financial
    /// <para />PropertyTerm: Capability
    /// <para />AssociatedObjectClass: Capability
    /// <para />RepresentationTerm: Capability
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CapabilityType> FinancialCapability
    {
        get { return _financialCapability ?? (_financialCapability = new System.Collections.Generic.List<CapabilityType>()); }
        set { _financialCapability = value; }
    }

        
    /// <summary>
    /// A former task completed by this qualifying party.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualifying Party. Completed Task
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Completed Task
    /// <para />AssociatedObjectClass: Completed Task
    /// <para />RepresentationTerm: Completed Task
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CompletedTaskType> CompletedTask
    {
        get { return _completedTask ?? (_completedTask = new System.Collections.Generic.List<CompletedTaskType>()); }
        set { _completedTask = value; }
    }

        
    /// <summary>
    /// A declaration by this qualifying party. of certain characteristics or capabilities in fulfilment of requirements specified in a call for tenders.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualifying Party. Declaration
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Declaration
    /// <para />AssociatedObjectClass: Declaration
    /// <para />RepresentationTerm: Declaration
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DeclarationType> Declaration
    {
        get { return _declaration ?? (_declaration = new System.Collections.Generic.List<DeclarationType>()); }
        set { _declaration = value; }
    }

        
    /// <summary>
    /// The extent to which this party is expected to participate in the tendering process, expressed as a percentage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualifying Party. Participation. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Participation
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType ParticipationPercent
    {
        get
        {
            if (__ParticipationPercent == null) { __ParticipationPercent = new PercentType(); }
            return __ParticipationPercent;
        }
        set
        {
            __ParticipationPercent = value;
        }
    }

        
    /// <summary>
    /// The number of years that this qualifying party has been in operation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualifying Party. Operating Years. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
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
    /// The number of people employed by this qualifying party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualifying Party. Employee. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
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

        
    /// <summary>
    /// An identifier for an item of evidence to support the classification of this qualifying party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualifying Party. Business Classification Evidence. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Business Classification Evidence
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType BusinessClassificationEvidenceID
    {
        get
        {
            if (__BusinessClassificationEvidenceID == null) { __BusinessClassificationEvidenceID = new IdentifierType(); }
            return __BusinessClassificationEvidenceID;
        }
        set
        {
            __BusinessClassificationEvidenceID = value;
        }
    }

        
    /// <summary>
    /// An identifier for an item of evidence to support the business identity of this qualifying party.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualifying Party. Business Identity Evidence. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Business Identity Evidence
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType BusinessIdentityEvidenceID
    {
        get
        {
            if (__BusinessIdentityEvidenceID == null) { __BusinessIdentityEvidenceID = new IdentifierType(); }
            return __BusinessIdentityEvidenceID;
        }
        set
        {
            __BusinessIdentityEvidenceID = value;
        }
    }

        
    /// <summary>
    /// A code stating the Tenderer Role.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Qualifying Party. Tenderer Role Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Tenderer Role Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TendererRoleCode
    {
        get
        {
            if (__TendererRoleCode == null) { __TendererRoleCode = new CodeType(); }
            return __TendererRoleCode;
        }
        set
        {
            __TendererRoleCode = value;
        }
    }

        
    /// <summary>
    /// The classification scheme used for the business profile.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualifying Party. Business_ Classification Scheme. Classification Scheme
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTermQualifier: Business
    /// <para />PropertyTerm: Classification Scheme
    /// <para />AssociatedObjectClass: Classification Scheme
    /// <para />RepresentationTerm: Classification Scheme
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ClassificationSchemeType BusinessClassificationScheme
    {
        get
        {
            if (__BusinessClassificationScheme == null) { __BusinessClassificationScheme = new ClassificationSchemeType(); }
            return __BusinessClassificationScheme;
        }
        set
        {
            __BusinessClassificationScheme = value;
        }
    }

        
    /// <summary>
    /// The qualifying party itself.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualifying Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType Party
    {
        get
        {
            if (__Party == null) { __Party = new PartyType(); }
            return __Party;
        }
        set
        {
            __Party = value;
        }
    }

        
    /// <summary>
    /// A class to describe the tenderer contracting role.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Qualifying Party. Economic Operator Role
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Qualifying Party
    /// <para />PropertyTerm: Economic Operator Role
    /// <para />AssociatedObjectClass: Economic Operator Role
    /// <para />RepresentationTerm: Economic Operator Role
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public EconomicOperatorRoleType EconomicOperatorRole
    {
        get
        {
            if (__EconomicOperatorRole == null) { __EconomicOperatorRole = new EconomicOperatorRoleType(); }
            return __EconomicOperatorRole;
        }
        set
        {
            __EconomicOperatorRole = value;
        }
    }

}