using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Request for Quotation.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Request For Quotation Line. Details
/// <para />ObjectClass: Request For Quotation Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RequestForQuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RequestForQuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RequestForQuotationLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__UUID;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute("OptionalLineItemIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IndicatorType @__OptionalLineItemIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrivacyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__PrivacyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SecurityClassificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__SecurityClassificationCode;
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=6)]
    public DocumentReferenceType[] @__DocumentReference
    {
        get
        {
            return _documentReference?.ToArray();
        }
        set
        {
            _documentReference = value == null ? null : new System.Collections.Generic.List<DocumentReferenceType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineItem", Order=7)]
    public LineItemType @__LineItem;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Request For Quotation Line
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
    /// A document associated with this request for quotation line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Request For Quotation Line
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DocumentReferenceType> DocumentReference
    {
        get { return _documentReference ?? (_documentReference = new System.Collections.Generic.List<DocumentReferenceType>()); }
        set { _documentReference = value; }
    }

        
    /// <summary>
    /// An identifier for this line in the request for quotation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Quotation Line
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
    /// A universally unique identifier for this line in the request for quotation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Quotation Line
    /// <para />PropertyTerm: UUID
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType UUID
    {
        get
        {
            if (__UUID == null) { __UUID = new IdentifierType(); }
            return __UUID;
        }
        set
        {
            __UUID = value;
        }
    }

        
    /// <summary>
    /// An indication whether this line is optional (true) or not (false) for purposes of this request for quotation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. Optional_ Line Item Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Quotation Line
    /// <para />PropertyTermQualifier: Optional
    /// <para />PropertyTerm: Line Item Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType OptionalLineItemIndicator
    {
        get
        {
            if (__OptionalLineItemIndicator == null) { __OptionalLineItemIndicator = new IndicatorType(); }
            return __OptionalLineItemIndicator;
        }
        set
        {
            __OptionalLineItemIndicator = value;
        }
    }

        
    /// <summary>
    /// A code signifying the level of confidentiality of this request for quotation line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. Privacy Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Quotation Line
    /// <para />PropertyTerm: Privacy Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PrivacyCode
    {
        get
        {
            if (__PrivacyCode == null) { __PrivacyCode = new CodeType(); }
            return __PrivacyCode;
        }
        set
        {
            __PrivacyCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the security classification of this request for quotation line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. Security Classification Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Request For Quotation Line
    /// <para />PropertyTerm: Security Classification Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SecurityClassificationCode
    {
        get
        {
            if (__SecurityClassificationCode == null) { __SecurityClassificationCode = new CodeType(); }
            return __SecurityClassificationCode;
        }
        set
        {
            __SecurityClassificationCode = value;
        }
    }

        
    /// <summary>
    /// A description of the item for which a quotation is requested.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Request For Quotation Line. Line Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Request For Quotation Line
    /// <para />PropertyTerm: Line Item
    /// <para />AssociatedObjectClass: Line Item
    /// <para />RepresentationTerm: Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineItemType LineItem
    {
        get
        {
            if (__LineItem == null) { __LineItem = new LineItemType(); }
            return __LineItem;
        }
        set
        {
            __LineItem = value;
        }
    }

}