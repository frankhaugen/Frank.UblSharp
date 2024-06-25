using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Quotation.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Quotation Line. Details
/// <para />ObjectClass: Quotation Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("QuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("QuotationLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class QuotationLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineExtensionAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public AmountType @__LineExtensionAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TotalTaxAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__TotalTaxAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestForQuotationLineID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public IdentifierType @__RequestForQuotationLineID;
        
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
        
    private System.Collections.Generic.List<LineItemType> _sellerProposedSubstituteLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem", Order=8)]
    public LineItemType[] @__SellerProposedSubstituteLineItem
    {
        get
        {
            return _sellerProposedSubstituteLineItem?.ToArray();
        }
        set
        {
            _sellerProposedSubstituteLineItem = value == null ? null : new System.Collections.Generic.List<LineItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<LineItemType> _alternativeLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AlternativeLineItem", Order=9)]
    public LineItemType[] @__AlternativeLineItem
    {
        get
        {
            return _alternativeLineItem?.ToArray();
        }
        set
        {
            _alternativeLineItem = value == null ? null : new System.Collections.Generic.List<LineItemType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RequestLineReference", Order=10)]
    public LineReferenceType @__RequestLineReference;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Quotation Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Quotation Line
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
    /// A reference to a document associated with this quotation line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Quotation Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Quotation Line
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
    /// An item proposed by the seller as a substitute for the item that is the subject of this quotation line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Quotation Line. Seller Proposed Substitute_ Line Item. Line Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Quotation Line
    /// <para />PropertyTermQualifier: Seller Proposed Substitute
    /// <para />PropertyTerm: Line Item
    /// <para />AssociatedObjectClass: Line Item
    /// <para />RepresentationTerm: Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineItemType> SellerProposedSubstituteLineItem
    {
        get { return _sellerProposedSubstituteLineItem ?? (_sellerProposedSubstituteLineItem = new System.Collections.Generic.List<LineItemType>()); }
        set { _sellerProposedSubstituteLineItem = value; }
    }

        
    /// <summary>
    /// An item proposed by the seller as an alternative to the item that is the subject of this quotation line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Quotation Line. Alternative_ Line Item. Line Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Quotation Line
    /// <para />PropertyTermQualifier: Alternative
    /// <para />PropertyTerm: Line Item
    /// <para />AssociatedObjectClass: Line Item
    /// <para />RepresentationTerm: Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineItemType> AlternativeLineItem
    {
        get { return _alternativeLineItem ?? (_alternativeLineItem = new System.Collections.Generic.List<LineItemType>()); }
        set { _alternativeLineItem = value; }
    }

        
    /// <summary>
    /// An identifier for this quotation line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Quotation Line. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Quotation Line
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
    /// The quantity of the item quoted.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Quotation Line. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Quotation Line
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// The total amount for this quotation line, including allowance charges but net of taxes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Quotation Line. Line Extension Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Quotation Line
    /// <para />PropertyTerm: Line Extension Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType LineExtensionAmount
    {
        get
        {
            if (__LineExtensionAmount == null) { __LineExtensionAmount = new AmountType(); }
            return __LineExtensionAmount;
        }
        set
        {
            __LineExtensionAmount = value;
        }
    }

        
    /// <summary>
    /// The total tax amount for this quotation line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Quotation Line. Total_ Tax Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Quotation Line
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Tax Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TotalTaxAmount
    {
        get
        {
            if (__TotalTaxAmount == null) { __TotalTaxAmount = new AmountType(); }
            return __TotalTaxAmount;
        }
        set
        {
            __TotalTaxAmount = value;
        }
    }

        
    /// <summary>
    /// An identifier for the line in the Request for Quotation to which this line is a response.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Quotation Line. Request For Quotation Line Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Quotation Line
    /// <para />PropertyTerm: Request For Quotation Line Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType RequestForQuotationLineID
    {
        get
        {
            if (__RequestForQuotationLineID == null) { __RequestForQuotationLineID = new IdentifierType(); }
            return __RequestForQuotationLineID;
        }
        set
        {
            __RequestForQuotationLineID = value;
        }
    }

        
    /// <summary>
    /// The item that is the subject of this quotation line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Quotation Line. Line Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Quotation Line
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

        
    /// <summary>
    /// A reference to the line in the Request for Quotation to which this line is a response.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Quotation Line. Request_ Line Reference. Line Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Quotation Line
    /// <para />PropertyTermQualifier: Request
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineReferenceType RequestLineReference
    {
        get
        {
            if (__RequestLineReference == null) { __RequestLineReference = new LineReferenceType(); }
            return __RequestLineReference;
        }
        set
        {
            __RequestLineReference = value;
        }
    }

}