using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a tendered project or project lot.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Tendered Project. Details
/// <para />ObjectClass: Tendered Project
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AwardedTenderedProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AwardedTenderedProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TenderedProjectType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VariantID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__VariantID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FeeAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public AmountType @__FeeAmount;
        
    private System.Collections.Generic.List<TextType> _feeDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FeeDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute("TenderEnvelopeID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IdentifierType @__TenderEnvelopeID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderEnvelopeTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__TenderEnvelopeTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Order=5)]
    public ProcurementProjectLotType @__ProcurementProjectLot;
        
    private System.Collections.Generic.List<DocumentReferenceType> _evidenceDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EvidenceDocumentReference", Order=6)]
    public DocumentReferenceType[] @__EvidenceDocumentReference
    {
        get
        {
            return _evidenceDocumentReference?.ToArray();
        }
        set
        {
            _evidenceDocumentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<TaxTotalType> _taxTotal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Order=7)]
    public TaxTotalType[] @__TaxTotal
    {
        get
        {
            return _taxTotal?.ToArray();
        }
        set
        {
            _taxTotal = value == null ? null : new System.Collections.Generic.List<TaxTotalType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LegalMonetaryTotal", Order=8)]
    public MonetaryTotalType @__LegalMonetaryTotal;
        
    private System.Collections.Generic.List<TenderLineType> _tenderLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TenderLine", Order=9)]
    public TenderLineType[] @__TenderLine
    {
        get
        {
            return _tenderLine?.ToArray();
        }
        set
        {
            _tenderLine = value == null ? null : new System.Collections.Generic.List<TenderLineType>(value);
        }
    }
        
    private System.Collections.Generic.List<AwardingCriterionResponseType> _awardingCriterionResponse;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionResponse", Order=10)]
    public AwardingCriterionResponseType[] @__AwardingCriterionResponse
    {
        get
        {
            return _awardingCriterionResponse?.ToArray();
        }
        set
        {
            _awardingCriterionResponse = value == null ? null : new System.Collections.Generic.List<AwardingCriterionResponseType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the fee amount for tendered projects.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendered Project. Fee_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendered Project
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
    /// A reference to a non-structured evidentiary document supporting this tendered project.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendered Project. Evidence_ Document Reference. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTermQualifier: Evidence
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> EvidenceDocumentReference
    {
        get { return _evidenceDocumentReference ?? (_evidenceDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _evidenceDocumentReference = value; }
    }

        
    /// <summary>
    /// A total amount of taxes of a particular kind applicable to the monetary total for this tendered project.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendered Project. Tax Total
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Tax Total
    /// <para />AssociatedObjectClass: Tax Total
    /// <para />RepresentationTerm: Tax Total
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TaxTotalType> TaxTotal
    {
        get { return _taxTotal ?? (_taxTotal = new System.Collections.Generic.List<TaxTotalType>()); }
        set { _taxTotal = value; }
    }

        
    /// <summary>
    /// A line in the tender for this tendered project.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendered Project. Tender Line
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Tender Line
    /// <para />AssociatedObjectClass: Tender Line
    /// <para />RepresentationTerm: Tender Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TenderLineType> TenderLine
    {
        get { return _tenderLine ?? (_tenderLine = new System.Collections.Generic.List<TenderLineType>()); }
        set { _tenderLine = value; }
    }

        
    /// <summary>
    /// An association to an Awarding Criterion Response.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendered Project. Awarding Criterion Response
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Awarding Criterion Response
    /// <para />AssociatedObjectClass: Awarding Criterion Response
    /// <para />RepresentationTerm: Awarding Criterion Response
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AwardingCriterionResponseType> AwardingCriterionResponse
    {
        get { return _awardingCriterionResponse ?? (_awardingCriterionResponse = new System.Collections.Generic.List<AwardingCriterionResponseType>()); }
        set { _awardingCriterionResponse = value; }
    }

        
    /// <summary>
    /// An identifier for this variant of a tendered project.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendered Project. Variant. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Variant
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType VariantID
    {
        get
        {
            if (__VariantID == null) { __VariantID = new IdentifierType(); }
            return __VariantID;
        }
        set
        {
            __VariantID = value;
        }
    }

        
    /// <summary>
    /// The fee amount for tendered projects.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendered Project. Fee. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Fee
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType FeeAmount
    {
        get
        {
            if (__FeeAmount == null) { __FeeAmount = new AmountType(); }
            return __FeeAmount;
        }
        set
        {
            __FeeAmount = value;
        }
    }

        
    /// <summary>
    /// An identifier for the tender envelope this tendered project belongs to.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendered Project. Tender Envelope Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Tender Envelope Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TenderEnvelopeID
    {
        get
        {
            if (__TenderEnvelopeID == null) { __TenderEnvelopeID = new IdentifierType(); }
            return __TenderEnvelopeID;
        }
        set
        {
            __TenderEnvelopeID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of tender envelope this tendered project belongs to.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Tendered Project. Tender Envelope Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Tender Envelope Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TenderEnvelopeTypeCode
    {
        get
        {
            if (__TenderEnvelopeTypeCode == null) { __TenderEnvelopeTypeCode = new CodeType(); }
            return __TenderEnvelopeTypeCode;
        }
        set
        {
            __TenderEnvelopeTypeCode = value;
        }
    }

        
    /// <summary>
    /// The procurement project lot to which this Tender Line refers to. If there are no lots, this should not be defined.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendered Project. Procurement Project Lot
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTerm: Procurement Project Lot
    /// <para />AssociatedObjectClass: Procurement Project Lot
    /// <para />RepresentationTerm: Procurement Project Lot
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ProcurementProjectLotType ProcurementProjectLot
    {
        get
        {
            if (__ProcurementProjectLot == null) { __ProcurementProjectLot = new ProcurementProjectLotType(); }
            return __ProcurementProjectLot;
        }
        set
        {
            __ProcurementProjectLot = value;
        }
    }

        
    /// <summary>
    /// The total amount for this tendered project.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Tendered Project. Legal_ Monetary Total. Monetary Total
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Tendered Project
    /// <para />PropertyTermQualifier: Legal
    /// <para />PropertyTerm: Monetary Total
    /// <para />AssociatedObjectClass: Monetary Total
    /// <para />RepresentationTerm: Monetary Total
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MonetaryTotalType LegalMonetaryTotal
    {
        get
        {
            if (__LegalMonetaryTotal == null) { __LegalMonetaryTotal = new MonetaryTotalType(); }
            return __LegalMonetaryTotal;
        }
        set
        {
            __LegalMonetaryTotal = value;
        }
    }

}