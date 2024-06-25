using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a project to procure goods, works, or services.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Procurement Project. Details
/// <para />ObjectClass: Procurement Project
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ProcurementProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ProcurementProjectType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<NameType> _name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType[] @__Name
    {
        get
        {
            return _name?.ToArray();
        }
        set
        {
            _name = value == null ? null : new System.Collections.Generic.List<NameType>(value);
        }
    }
        
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
    [System.Xml.Serialization.XmlElementAttribute("ProcurementTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__ProcurementTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcurementSubTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__ProcurementSubTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("QualityControlCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__QualityControlCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequiredFeeAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public AmountType @__RequiredFeeAmount;
        
    private System.Collections.Generic.List<TextType> _feeDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public TextType[] @__FeeDescription
    {
        get
        {
            return _feeDescription?.ToArray();
        }
        set
        {
            _feeDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedDeliveryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public DateType @__RequestedDeliveryDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EstimatedOverallContractQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__EstimatedOverallContractQuantity;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public TextType[] @__Note
    {
        get
        {
            return _note?.ToArray();
        }
        set
        {
            _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestedTenderTotal", Order=11)]
    public RequestedTenderTotalType @__RequestedTenderTotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MainCommodityClassification", Order=12)]
    public CommodityClassificationType @__MainCommodityClassification;
        
    private System.Collections.Generic.List<CommodityClassificationType> _additionalCommodityClassification;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalCommodityClassification", Order=13)]
    public CommodityClassificationType[] @__AdditionalCommodityClassification
    {
        get
        {
            return _additionalCommodityClassification?.ToArray();
        }
        set
        {
            _additionalCommodityClassification = value == null ? null : new System.Collections.Generic.List<CommodityClassificationType>(value);
        }
    }
        
    private System.Collections.Generic.List<LocationType> _realizedLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RealizedLocation", Order=14)]
    public LocationType[] @__RealizedLocation
    {
        get
        {
            return _realizedLocation?.ToArray();
        }
        set
        {
            _realizedLocation = value == null ? null : new System.Collections.Generic.List<LocationType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlannedPeriod", Order=15)]
    public PeriodType @__PlannedPeriod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContractExtension", Order=16)]
    public ContractExtensionType @__ContractExtension;
        
    private System.Collections.Generic.List<RequestForTenderLineType> _requestForTenderLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestForTenderLine", Order=17)]
    public RequestForTenderLineType[] @__RequestForTenderLine
    {
        get
        {
            return _requestForTenderLine?.ToArray();
        }
        set
        {
            _requestForTenderLine = value == null ? null : new System.Collections.Generic.List<RequestForTenderLineType>(value);
        }
    }
        
    /// <summary>
    /// A name of this procurement project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Name
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<NameType> Name
    {
        get { return _name ?? (_name = new System.Collections.Generic.List<NameType>()); }
        set { _name = value; }
    }

        
    /// <summary>
    /// Text describing this procurement project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Procurement Project
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
    /// Text describing the reimbursement fee for concession procurement projects.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Fee_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Fee
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> FeeDescription
    {
        get { return _feeDescription ?? (_feeDescription = new System.Collections.Generic.List<TextType>()); }
        set { _feeDescription = value; }
    }

        
    /// <summary>
    /// Free-form text applying to the Procurement Project. This element may contain additional information about the lot/contract that is not contained explicitly in another structure.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// An association to additional classification categories for the deliverable requested.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project. Additional_ Commodity Classification. Commodity Classification
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Commodity Classification
    /// <para />AssociatedObjectClass: Commodity Classification
    /// <para />RepresentationTerm: Commodity Classification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CommodityClassificationType> AdditionalCommodityClassification
    {
        get { return _additionalCommodityClassification ?? (_additionalCommodityClassification = new System.Collections.Generic.List<CommodityClassificationType>()); }
        set { _additionalCommodityClassification = value; }
    }

        
    /// <summary>
    /// A place where this procurement project will be physically realized.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project. Realized_ Location. Location
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Realized
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LocationType> RealizedLocation
    {
        get { return _realizedLocation ?? (_realizedLocation = new System.Collections.Generic.List<LocationType>()); }
        set { _realizedLocation = value; }
    }

        
    /// <summary>
    /// A good or service this project is intended to procure.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project. Request For Tender Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTerm: Request For Tender Line
    /// <para />AssociatedObjectClass: Request For Tender Line
    /// <para />RepresentationTerm: Request For Tender Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RequestForTenderLineType> RequestForTenderLine
    {
        get { return _requestForTenderLine ?? (_requestForTenderLine = new System.Collections.Generic.List<RequestForTenderLineType>()); }
        set { _requestForTenderLine = value; }
    }

        
    /// <summary>
    /// An identifier for this procurement project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
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
    /// A code signifying the type of procurement project (e.g., goods, works, services).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Procurement_ Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Procurement
    /// <para />PropertyTerm: Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ProcurementTypeCode
    {
        get
        {
            if (__ProcurementTypeCode == null) { __ProcurementTypeCode = new CodeType(); }
            return __ProcurementTypeCode;
        }
        set
        {
            __ProcurementTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the subcategory of the type of work for this project (e.g., land surveying, IT consulting).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Procurement Sub_ Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Procurement Sub
    /// <para />PropertyTerm: Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ProcurementSubTypeCode
    {
        get
        {
            if (__ProcurementSubTypeCode == null) { __ProcurementSubTypeCode = new CodeType(); }
            return __ProcurementSubTypeCode;
        }
        set
        {
            __ProcurementSubTypeCode = value;
        }
    }

        
    /// <summary>
    /// The indication of whether or not the control quality is included in the works project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Quality Control Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTerm: Quality Control Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType QualityControlCode
    {
        get
        {
            if (__QualityControlCode == null) { __QualityControlCode = new CodeType(); }
            return __QualityControlCode;
        }
        set
        {
            __QualityControlCode = value;
        }
    }

        
    /// <summary>
    /// The amount of the reimbursement fee for concession procurement projects.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Required_ Fee. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Required
    /// <para />PropertyTerm: Fee
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType RequiredFeeAmount
    {
        get
        {
            if (__RequiredFeeAmount == null) { __RequiredFeeAmount = new AmountType(); }
            return __RequiredFeeAmount;
        }
        set
        {
            __RequiredFeeAmount = value;
        }
    }

        
    /// <summary>
    /// The requested delivery date for this procurement project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Requested_ Delivery Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Requested
    /// <para />PropertyTerm: Delivery Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType RequestedDeliveryDate
    {
        get
        {
            if (__RequestedDeliveryDate == null) { __RequestedDeliveryDate = new DateType(); }
            return __RequestedDeliveryDate;
        }
        set
        {
            __RequestedDeliveryDate = value;
        }
    }

        
    /// <summary>
    /// The estimated overall quantity for this procurement project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Procurement Project. Estimated_ Overall Contract. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Estimated
    /// <para />PropertyTerm: Overall Contract
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType EstimatedOverallContractQuantity
    {
        get
        {
            if (__EstimatedOverallContractQuantity == null) { __EstimatedOverallContractQuantity = new QuantityType(); }
            return __EstimatedOverallContractQuantity;
        }
        set
        {
            __EstimatedOverallContractQuantity = value;
        }
    }

        
    /// <summary>
    /// Budget monetary amounts for the project as whole.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project. Requested Tender Total
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTerm: Requested Tender Total
    /// <para />AssociatedObjectClass: Requested Tender Total
    /// <para />RepresentationTerm: Requested Tender Total
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public RequestedTenderTotalType RequestedTenderTotal
    {
        get
        {
            if (__RequestedTenderTotal == null) { __RequestedTenderTotal = new RequestedTenderTotalType(); }
            return __RequestedTenderTotal;
        }
        set
        {
            __RequestedTenderTotal = value;
        }
    }

        
    /// <summary>
    /// An association to the main classification category for the deliverable requested.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project. Main_ Commodity Classification. Commodity Classification
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Main
    /// <para />PropertyTerm: Commodity Classification
    /// <para />AssociatedObjectClass: Commodity Classification
    /// <para />RepresentationTerm: Commodity Classification
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CommodityClassificationType MainCommodityClassification
    {
        get
        {
            if (__MainCommodityClassification == null) { __MainCommodityClassification = new CommodityClassificationType(); }
            return __MainCommodityClassification;
        }
        set
        {
            __MainCommodityClassification = value;
        }
    }

        
    /// <summary>
    /// The period during which this procurement project is planned to take place.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project. Planned_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTermQualifier: Planned
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType PlannedPeriod
    {
        get
        {
            if (__PlannedPeriod == null) { __PlannedPeriod = new PeriodType(); }
            return __PlannedPeriod;
        }
        set
        {
            __PlannedPeriod = value;
        }
    }

        
    /// <summary>
    /// The contract extension for this tendering process.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Procurement Project. Contract Extension
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Procurement Project
    /// <para />PropertyTerm: Contract Extension
    /// <para />AssociatedObjectClass: Contract Extension
    /// <para />RepresentationTerm: Contract Extension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContractExtensionType ContractExtension
    {
        get
        {
            if (__ContractExtension == null) { __ContractExtension = new ContractExtensionType(); }
            return __ContractExtension;
        }
        set
        {
            __ContractExtension = value;
        }
    }

}