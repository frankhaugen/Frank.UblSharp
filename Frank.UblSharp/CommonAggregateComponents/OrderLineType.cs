using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in an order document (e.g., Order, Order Change, or Order Response) describing an item being ordered.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Order Line. Details
/// <para />ObjectClass: Order Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("OrderLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class OrderLineType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubstitutionStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__SubstitutionStatusCode;
        
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
    [System.Xml.Serialization.XmlElementAttribute("LineItem", Order=2)]
    public LineItemType @__LineItem;
        
    private System.Collections.Generic.List<LineItemType> _sellerProposedSubstituteLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerProposedSubstituteLineItem", Order=3)]
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
        
    private System.Collections.Generic.List<LineItemType> _sellerSubstitutedLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SellerSubstitutedLineItem", Order=4)]
    public LineItemType[] @__SellerSubstitutedLineItem
    {
        get
        {
            return _sellerSubstitutedLineItem?.ToArray();
        }
        set
        {
            _sellerSubstitutedLineItem = value == null ? null : new System.Collections.Generic.List<LineItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<LineItemType> _buyerProposedSubstituteLineItem;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BuyerProposedSubstituteLineItem", Order=5)]
    public LineItemType[] @__BuyerProposedSubstituteLineItem
    {
        get
        {
            return _buyerProposedSubstituteLineItem?.ToArray();
        }
        set
        {
            _buyerProposedSubstituteLineItem = value == null ? null : new System.Collections.Generic.List<LineItemType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CatalogueLineReference", Order=6)]
    public LineReferenceType @__CatalogueLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("QuotationLineReference", Order=7)]
    public LineReferenceType @__QuotationLineReference;
        
    private System.Collections.Generic.List<OrderLineReferenceType> _orderLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderLineReference", Order=8)]
    public OrderLineReferenceType[] @__OrderLineReference
    {
        get
        {
            return _orderLineReference?.ToArray();
        }
        set
        {
            _orderLineReference = value == null ? null : new System.Collections.Generic.List<OrderLineReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=9)]
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
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Order Line
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
    /// In Order Response, a line item proposed by the seller describing a product that might substitute for the product described in this order line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Seller Proposed Substitute_ Line Item. Line Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Order Line
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
    /// In Order Response, a line item that has replaced the original order line item. The specified quantity and pricing may differ from those in the original line item, but when a line item is substituted by the seller, it is assumed that other information, such as shipment details, will remain the same.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Seller Substituted_ Line Item. Line Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Order Line
    /// <para />PropertyTermQualifier: Seller Substituted
    /// <para />PropertyTerm: Line Item
    /// <para />AssociatedObjectClass: Line Item
    /// <para />RepresentationTerm: Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineItemType> SellerSubstitutedLineItem
    {
        get { return _sellerSubstitutedLineItem ?? (_sellerSubstitutedLineItem = new System.Collections.Generic.List<LineItemType>()); }
        set { _sellerSubstitutedLineItem = value; }
    }

        
    /// <summary>
    /// A description of an item proposed by the buyer as a possible alternative to the item associated with this order line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Buyer Proposed Substitute_ Line Item. Line Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Order Line
    /// <para />PropertyTermQualifier: Buyer Proposed Substitute
    /// <para />PropertyTerm: Line Item
    /// <para />AssociatedObjectClass: Line Item
    /// <para />RepresentationTerm: Line Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineItemType> BuyerProposedSubstituteLineItem
    {
        get { return _buyerProposedSubstituteLineItem ?? (_buyerProposedSubstituteLineItem = new System.Collections.Generic.List<LineItemType>()); }
        set { _buyerProposedSubstituteLineItem = value; }
    }

        
    /// <summary>
    /// A reference to another order line, such as in a replacement order or another line on the same order that is related.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Order Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Order Line
    /// <para />PropertyTerm: Order Line Reference
    /// <para />AssociatedObjectClass: Order Line Reference
    /// <para />RepresentationTerm: Order Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<OrderLineReferenceType> OrderLineReference
    {
        get { return _orderLineReference ?? (_orderLineReference = new System.Collections.Generic.List<OrderLineReferenceType>()); }
        set { _orderLineReference = value; }
    }

        
    /// <summary>
    /// A reference to a document associated with this order line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Order Line
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
    /// A code signifying the substitution status of the item on this order line. The order line may indicate that the substitute is proposed by the buyer (in Order) or by the seller (in Order Response) or that a substitution has been made by the seller (in Order Response).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Line. Substitution Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Line
    /// <para />PropertyTerm: Substitution Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Substitution Status
    /// <para />DataType: Substitution Status_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType SubstitutionStatusCode
    {
        get
        {
            if (__SubstitutionStatusCode == null) { __SubstitutionStatusCode = new CodeType(); }
            return __SubstitutionStatusCode;
        }
        set
        {
            __SubstitutionStatusCode = value;
        }
    }

        
    /// <summary>
    /// The line item itself.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Line Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Order Line
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
    /// A reference to a catalogue line associated with this order line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Catalogue_ Line Reference. Line Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Line
    /// <para />PropertyTermQualifier: Catalogue
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineReferenceType CatalogueLineReference
    {
        get
        {
            if (__CatalogueLineReference == null) { __CatalogueLineReference = new LineReferenceType(); }
            return __CatalogueLineReference;
        }
        set
        {
            __CatalogueLineReference = value;
        }
    }

        
    /// <summary>
    /// A reference to a quotation line associated with this order line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line. Quotation_ Line Reference. Line Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Line
    /// <para />PropertyTermQualifier: Quotation
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineReferenceType QuotationLineReference
    {
        get
        {
            if (__QuotationLineReference == null) { __QuotationLineReference = new LineReferenceType(); }
            return __QuotationLineReference;
        }
        set
        {
            __QuotationLineReference = value;
        }
    }

}