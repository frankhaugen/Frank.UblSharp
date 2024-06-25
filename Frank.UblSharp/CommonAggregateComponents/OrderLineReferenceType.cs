using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to an order line.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Order Line Reference. Details
/// <para />ObjectClass: Order Line Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("OrderLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class OrderLineReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__LineID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SalesOrderLineID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__SalesOrderLineID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__LineStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OrderReference", Order=4)]
    public OrderReferenceType @__OrderReference;
        
    /// <summary>
    /// An identifier for the referenced order line, assigned by the buyer.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Line Reference. Line Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Order Line Reference
    /// <para />PropertyTerm: Line Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LineID
    {
        get
        {
            if (__LineID == null) { __LineID = new IdentifierType(); }
            return __LineID;
        }
        set
        {
            __LineID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the referenced order line, assigned by the seller.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Line Reference. Sales Order_ Line Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Line Reference
    /// <para />PropertyTermQualifier: Sales Order
    /// <para />PropertyTerm: Line Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SalesOrderLineID
    {
        get
        {
            if (__SalesOrderLineID == null) { __SalesOrderLineID = new IdentifierType(); }
            return __SalesOrderLineID;
        }
        set
        {
            __SalesOrderLineID = value;
        }
    }

        
    /// <summary>
    /// A universally unique identifier for this order line reference.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Line Reference. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Line Reference
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
    /// A code signifying the status of the referenced order line with respect to its original state.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Order Line Reference. Line Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Line Reference
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
    /// A reference to the Order containing the referenced order line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Order Line Reference. Order Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Order Line Reference
    /// <para />PropertyTerm: Order Reference
    /// <para />AssociatedObjectClass: Order Reference
    /// <para />RepresentationTerm: Order Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public OrderReferenceType OrderReference
    {
        get
        {
            if (__OrderReference == null) { __OrderReference = new OrderReferenceType(); }
            return __OrderReference;
        }
        set
        {
            __OrderReference = value;
        }
    }

}