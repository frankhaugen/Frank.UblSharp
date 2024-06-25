namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an ordered shipment.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Ordered Shipment. Details
/// <para />ObjectClass: Ordered Shipment
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("OrderedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("OrderedShipment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class OrderedShipmentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Shipment", Order=0)]
    public ShipmentType @__Shipment;
        
    private System.Collections.Generic.List<PackageType> _package;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Package", Order=1)]
    public PackageType[] @__Package
    {
        get
        {
            return _package?.ToArray();
        }
        set
        {
            _package = value == null ? null : new System.Collections.Generic.List<PackageType>(value);
        }
    }
        
    /// <summary>
    /// A package in this ordered shipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Ordered Shipment. Package
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Ordered Shipment
    /// <para />PropertyTerm: Package
    /// <para />AssociatedObjectClass: Package
    /// <para />RepresentationTerm: Package
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PackageType> Package
    {
        get { return _package ?? (_package = new System.Collections.Generic.List<PackageType>()); }
        set { _package = value; }
    }

        
    /// <summary>
    /// The ordered shipment.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Ordered Shipment. Shipment
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Ordered Shipment
    /// <para />PropertyTerm: Shipment
    /// <para />AssociatedObjectClass: Shipment
    /// <para />RepresentationTerm: Shipment
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ShipmentType Shipment
    {
        get
        {
            if (__Shipment == null) { __Shipment = new ShipmentType(); }
            return __Shipment;
        }
        set
        {
            __Shipment = value;
        }
    }

}