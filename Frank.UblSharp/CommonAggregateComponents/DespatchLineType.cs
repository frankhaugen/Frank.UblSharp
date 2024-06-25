using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Despatch Advice.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Despatch Line. Details
/// <para />ObjectClass: Despatch Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DespatchLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DespatchLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DespatchLineType
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
    [System.Xml.Serialization.XmlElementAttribute("LineStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__LineStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveredQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__DeliveredQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BackorderQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public QuantityType @__BackorderQuantity;
        
    private System.Collections.Generic.List<TextType> _backorderReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BackorderReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType[] @__BackorderReason
    {
        get
        {
            return _backorderReason?.ToArray();
        }
        set
        {
            _backorderReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OutstandingQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public QuantityType @__OutstandingQuantity;
        
    private System.Collections.Generic.List<TextType> _outstandingReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OutstandingReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType[] @__OutstandingReason
    {
        get
        {
            return _outstandingReason?.ToArray();
        }
        set
        {
            _outstandingReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OversupplyQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public QuantityType @__OversupplyQuantity;
        
    private System.Collections.Generic.List<OrderLineReferenceType> _orderLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderLineReference", Order=10)]
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
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=11)]
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
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=12)]
    public ItemType @__Item;
        
    private System.Collections.Generic.List<ShipmentType> _shipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Shipment", Order=13)]
    public ShipmentType[] @__Shipment
    {
        get
        {
            return _shipment?.ToArray();
        }
        set
        {
            _shipment = value == null ? null : new System.Collections.Generic.List<ShipmentType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Despatch Line
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
    /// The reason for the back order.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Backorder_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTermQualifier: Backorder
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> BackorderReason
    {
        get { return _backorderReason ?? (_backorderReason = new System.Collections.Generic.List<TextType>()); }
        set { _backorderReason = value; }
    }

        
    /// <summary>
    /// The reason for the outstanding quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Outstanding_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTermQualifier: Outstanding
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> OutstandingReason
    {
        get { return _outstandingReason ?? (_outstandingReason = new System.Collections.Generic.List<TextType>()); }
        set { _outstandingReason = value; }
    }

        
    /// <summary>
    /// A reference to an order line associated with this despatch line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch Line. Order Line Reference
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Despatch Line
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
    /// A reference to a document associated with this despatch line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Despatch Line
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
    /// A shipment associated with this despatch line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch Line. Shipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTerm: Shipment
    /// <para />AssociatedObjectClass: Shipment
    /// <para />RepresentationTerm: Shipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ShipmentType> Shipment
    {
        get { return _shipment ?? (_shipment = new System.Collections.Generic.List<ShipmentType>()); }
        set { _shipment = value; }
    }

        
    /// <summary>
    /// An identifier for this despatch line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Despatch Line
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
    /// A universally unique identifier for this despatch line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch Line
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
    /// A code signifying the status of this despatch line with respect to its original state.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Line Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTerm: Line Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Line Status
    /// <para />DataType: Line Status_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LineStatusCode
    {
        get
        {
            if (__LineStatusCode == null) { __LineStatusCode = new CodeType(); }
            return __LineStatusCode;
        }
        set
        {
            __LineStatusCode = value;
        }
    }

        
    /// <summary>
    /// The quantity despatched (picked up).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Delivered_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTermQualifier: Delivered
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType DeliveredQuantity
    {
        get
        {
            if (__DeliveredQuantity == null) { __DeliveredQuantity = new QuantityType(); }
            return __DeliveredQuantity;
        }
        set
        {
            __DeliveredQuantity = value;
        }
    }

        
    /// <summary>
    /// The quantity on back order at the supplier.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Backorder_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTermQualifier: Backorder
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType BackorderQuantity
    {
        get
        {
            if (__BackorderQuantity == null) { __BackorderQuantity = new QuantityType(); }
            return __BackorderQuantity;
        }
        set
        {
            __BackorderQuantity = value;
        }
    }

        
    /// <summary>
    /// The quantity outstanding (which will follow in a later despatch).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Outstanding_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTermQualifier: Outstanding
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType OutstandingQuantity
    {
        get
        {
            if (__OutstandingQuantity == null) { __OutstandingQuantity = new QuantityType(); }
            return __OutstandingQuantity;
        }
        set
        {
            __OutstandingQuantity = value;
        }
    }

        
    /// <summary>
    /// The quantity over-supplied, i.e., the quantity over and above that ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Despatch Line. Oversupply_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTermQualifier: Oversupply
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType OversupplyQuantity
    {
        get
        {
            if (__OversupplyQuantity == null) { __OversupplyQuantity = new QuantityType(); }
            return __OversupplyQuantity;
        }
        set
        {
            __OversupplyQuantity = value;
        }
    }

        
    /// <summary>
    /// The item associated with this despatch line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Despatch Line. Item
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Despatch Line
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ItemType Item
    {
        get
        {
            if (__Item == null) { __Item = new ItemType(); }
            return __Item;
        }
        set
        {
            __Item = value;
        }
    }

}