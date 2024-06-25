using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class defining how goods items are split across transport equipment.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Goods Item Container. Details
/// <para />ObjectClass: Goods Item Container
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("GoodsItemContainer", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("GoodsItemContainer", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class GoodsItemContainerType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__Quantity;
        
    private System.Collections.Generic.List<TransportEquipmentType> _transportEquipment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEquipment", Order=2)]
    public TransportEquipmentType[] @__TransportEquipment
    {
        get
        {
            return _transportEquipment?.ToArray();
        }
        set
        {
            _transportEquipment = value == null ? null : new System.Collections.Generic.List<TransportEquipmentType>(value);
        }
    }
        
    /// <summary>
    /// A piece of transport equipment used to contain a single goods item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Goods Item Container. Transport Equipment
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Goods Item Container
    /// <para />PropertyTerm: Transport Equipment
    /// <para />AssociatedObjectClass: Transport Equipment
    /// <para />RepresentationTerm: Transport Equipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TransportEquipmentType> TransportEquipment
    {
        get { return _transportEquipment ?? (_transportEquipment = new System.Collections.Generic.List<TransportEquipmentType>()); }
        set { _transportEquipment = value; }
    }

        
    /// <summary>
    /// An identifier for this goods item container.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item Container. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Goods Item Container
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
    /// The number of goods items loaded into or onto one piece of transport equipment as a total consignment or part of a consignment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Goods Item Container. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Goods Item Container
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// <para />AlternativeBusinessTerms: Number of packages stuffed
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

}