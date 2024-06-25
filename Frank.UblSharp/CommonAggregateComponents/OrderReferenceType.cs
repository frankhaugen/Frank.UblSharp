using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to an Order.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Order Reference. Details
/// <para />ObjectClass: Order Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class OrderReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SalesOrderID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__SalesOrderID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IndicatorType @__CopyIndicator;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TimeType @__IssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CustomerReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public TextType @__CustomerReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__OrderTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=8)]
    public DocumentReferenceType @__DocumentReference;
        
    /// <summary>
    /// An identifier for this order reference, assigned by the buyer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>PO-001 3333-44-123</example>
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
    /// An identifier for this order reference, assigned by the seller.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. Sales_ Order Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTermQualifier: Sales
    /// <para />PropertyTerm: Order Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SalesOrderID
    {
        get
        {
            if (__SalesOrderID == null) { __SalesOrderID = new IdentifierType(); }
            return __SalesOrderID;
        }
        set
        {
            __SalesOrderID = value;
        }
    }

        
    /// <summary>
    /// Indicates whether the referenced Order is a copy (true) or the original (false).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. Copy_ Indicator. Indicator
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTermQualifier: Copy
    /// <para />PropertyTerm: Indicator
    /// <para />RepresentationTerm: Indicator
    /// <para />DataType: Indicator. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IndicatorType CopyIndicator
    {
        get
        {
            if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
            return __CopyIndicator;
        }
        set
        {
            __CopyIndicator = value;
        }
    }

        
    /// <summary>
    /// A universally unique identifier for this order reference.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
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
    /// The date on which the referenced Order was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTerm: Issue Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType IssueDate
    {
        get
        {
            if (__IssueDate == null) { __IssueDate = new DateType(); }
            return __IssueDate;
        }
        set
        {
            __IssueDate = value;
        }
    }

        
    /// <summary>
    /// The time at which the referenced Order was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTerm: Issue Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType IssueTime
    {
        get
        {
            if (__IssueTime == null) { __IssueTime = new TimeType(); }
            return __IssueTime;
        }
        set
        {
            __IssueTime = value;
        }
    }

        
    /// <summary>
    /// Text used for tagging purchasing card transactions.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. Customer_ Reference. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTermQualifier: Customer
    /// <para />PropertyTerm: Reference
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType CustomerReference
    {
        get
        {
            if (__CustomerReference == null) { __CustomerReference = new TextType(); }
            return __CustomerReference;
        }
        set
        {
            __CustomerReference = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of the referenced Order.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Reference. Order Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTerm: Order Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType OrderTypeCode
    {
        get
        {
            if (__OrderTypeCode == null) { __OrderTypeCode = new CodeType(); }
            return __OrderTypeCode;
        }
        set
        {
            __OrderTypeCode = value;
        }
    }

        
    /// <summary>
    /// A document associated with this reference to an Order.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Reference
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType DocumentReference
    {
        get
        {
            if (__DocumentReference == null) { __DocumentReference = new DocumentReferenceType(); }
            return __DocumentReference;
        }
        set
        {
            __DocumentReference = value;
        }
    }

}