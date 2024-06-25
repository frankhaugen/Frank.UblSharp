using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a line in a Receipt Advice.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Receipt Line. Details
/// <para />ObjectClass: Receipt Line
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ReceiptLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ReceiptLineType
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
    [System.Xml.Serialization.XmlElementAttribute("ReceivedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__ReceivedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShortQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__ShortQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShortageActionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__ShortageActionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RejectedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public QuantityType @__RejectedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RejectReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__RejectReasonCode;
        
    private System.Collections.Generic.List<TextType> _rejectReason;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RejectReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType[] @__RejectReason
    {
        get
        {
            return _rejectReason?.ToArray();
        }
        set
        {
            _rejectReason = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RejectActionCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public CodeType @__RejectActionCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("QuantityDiscrepancyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public CodeType @__QuantityDiscrepancyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OversupplyQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public QuantityType @__OversupplyQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReceivedDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public DateType @__ReceivedDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TimingComplaintCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public CodeType @__TimingComplaintCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TimingComplaint", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public TextType @__TimingComplaint;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderLineReference", Order=15)]
    public OrderLineReferenceType @__OrderLineReference;
        
    private System.Collections.Generic.List<LineReferenceType> _despatchLineReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DespatchLineReference", Order=16)]
    public LineReferenceType[] @__DespatchLineReference
    {
        get
        {
            return _despatchLineReference?.ToArray();
        }
        set
        {
            _despatchLineReference = value == null ? null : new System.Collections.Generic.List<LineReferenceType>(value);
        }
    }
        
    private System.Collections.Generic.List<DocumentReferenceType> _documentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=17)]
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
        
    private System.Collections.Generic.List<ItemType> _item;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Item", Order=18)]
    public ItemType[] @__Item
    {
        get
        {
            return _item?.ToArray();
        }
        set
        {
            _item = value == null ? null : new System.Collections.Generic.List<ItemType>(value);
        }
    }
        
    private System.Collections.Generic.List<ShipmentType> _shipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Shipment", Order=19)]
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
    /// <para />DictionaryEntryName: Receipt Line. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Receipt Line
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
    /// The reason for a rejection, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Reject_ Reason. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTermQualifier: Reject
    /// <para />PropertyTerm: Reason
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> RejectReason
    {
        get { return _rejectReason ?? (_rejectReason = new System.Collections.Generic.List<TextType>()); }
        set { _rejectReason = value; }
    }

        
    /// <summary>
    /// A reference to a despatch line associated with this receipt line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Receipt Line. Despatch_ Line Reference. Line Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTermQualifier: Despatch
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<LineReferenceType> DespatchLineReference
    {
        get { return _despatchLineReference ?? (_despatchLineReference = new System.Collections.Generic.List<LineReferenceType>()); }
        set { _despatchLineReference = value; }
    }

        
    /// <summary>
    /// A reference to a document associated with this receipt line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Receipt Line. Document Reference
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Receipt Line
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
    /// An item associated with this receipt line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Receipt Line. Item
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Item
    /// <para />AssociatedObjectClass: Item
    /// <para />RepresentationTerm: Item
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemType> Item
    {
        get { return _item ?? (_item = new System.Collections.Generic.List<ItemType>()); }
        set { _item = value; }
    }

        
    /// <summary>
    /// A shipment associated with this receipt line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Receipt Line. Shipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Receipt Line
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
    /// An identifier for this receipt line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Receipt Line
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
    /// A universally unique identifier for this receipt line.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
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
    /// The quantity received.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Received_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTermQualifier: Received
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ReceivedQuantity
    {
        get
        {
            if (__ReceivedQuantity == null) { __ReceivedQuantity = new QuantityType(); }
            return __ReceivedQuantity;
        }
        set
        {
            __ReceivedQuantity = value;
        }
    }

        
    /// <summary>
    /// The quantity received short; the difference between the quantity reported despatched and the quantity actually received.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Short_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTermQualifier: Short
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ShortQuantity
    {
        get
        {
            if (__ShortQuantity == null) { __ShortQuantity = new QuantityType(); }
            return __ShortQuantity;
        }
        set
        {
            __ShortQuantity = value;
        }
    }

        
    /// <summary>
    /// A code signifying the action that the delivery party wishes the despatch party to take as the result of a shortage.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Shortage Action Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Shortage Action Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ShortageActionCode
    {
        get
        {
            if (__ShortageActionCode == null) { __ShortageActionCode = new CodeType(); }
            return __ShortageActionCode;
        }
        set
        {
            __ShortageActionCode = value;
        }
    }

        
    /// <summary>
    /// The quantity rejected.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Rejected_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTermQualifier: Rejected
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType RejectedQuantity
    {
        get
        {
            if (__RejectedQuantity == null) { __RejectedQuantity = new QuantityType(); }
            return __RejectedQuantity;
        }
        set
        {
            __RejectedQuantity = value;
        }
    }

        
    /// <summary>
    /// The reason for a rejection, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Reject Reason Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Reject Reason Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType RejectReasonCode
    {
        get
        {
            if (__RejectReasonCode == null) { __RejectReasonCode = new CodeType(); }
            return __RejectReasonCode;
        }
        set
        {
            __RejectReasonCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the action that the delivery party wishes the despatch party to take as the result of a rejection.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Reject Action Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Reject Action Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType RejectActionCode
    {
        get
        {
            if (__RejectActionCode == null) { __RejectActionCode = new CodeType(); }
            return __RejectActionCode;
        }
        set
        {
            __RejectActionCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of a discrepancy in quantity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Quantity Discrepancy Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Quantity Discrepancy Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType QuantityDiscrepancyCode
    {
        get
        {
            if (__QuantityDiscrepancyCode == null) { __QuantityDiscrepancyCode = new CodeType(); }
            return __QuantityDiscrepancyCode;
        }
        set
        {
            __QuantityDiscrepancyCode = value;
        }
    }

        
    /// <summary>
    /// The quantity over-supplied, i.e., the quantity over and above the quantity ordered.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Oversupply_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
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
    /// The date on which the goods or services were received.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Received_ Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTermQualifier: Received
    /// <para />PropertyTerm: Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ReceivedDate
    {
        get
        {
            if (__ReceivedDate == null) { __ReceivedDate = new DateType(); }
            return __ReceivedDate;
        }
        set
        {
            __ReceivedDate = value;
        }
    }

        
    /// <summary>
    /// A complaint about the timing of delivery, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Timing Complaint Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Timing Complaint Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TimingComplaintCode
    {
        get
        {
            if (__TimingComplaintCode == null) { __TimingComplaintCode = new CodeType(); }
            return __TimingComplaintCode;
        }
        set
        {
            __TimingComplaintCode = value;
        }
    }

        
    /// <summary>
    /// A complaint about the timing of delivery, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Receipt Line. Timing Complaint. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Timing Complaint
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TimingComplaint
    {
        get
        {
            if (__TimingComplaint == null) { __TimingComplaint = new TextType(); }
            return __TimingComplaint;
        }
        set
        {
            __TimingComplaint = value;
        }
    }

        
    /// <summary>
    /// A reference to the order line associated with this receipt line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Receipt Line. Order Line Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Receipt Line
    /// <para />PropertyTerm: Order Line Reference
    /// <para />AssociatedObjectClass: Order Line Reference
    /// <para />RepresentationTerm: Order Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public OrderLineReferenceType OrderLineReference
    {
        get
        {
            if (__OrderLineReference == null) { __OrderLineReference = new OrderLineReferenceType(); }
            return __OrderLineReference;
        }
        set
        {
            __OrderLineReference = value;
        }
    }

}