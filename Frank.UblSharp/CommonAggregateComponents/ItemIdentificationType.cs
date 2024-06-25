using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class for assigning identifying information to an item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Item Identification. Details
/// <para />ObjectClass: Item Identification
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalItemIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ItemIdentificationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExtendedID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__ExtendedID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BarcodeSymbologyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__BarcodeSymbologyID;
        
    private System.Collections.Generic.List<PhysicalAttributeType> _physicalAttribute;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PhysicalAttribute", Order=3)]
    public PhysicalAttributeType[] @__PhysicalAttribute
    {
        get
        {
            return _physicalAttribute?.ToArray();
        }
        set
        {
            _physicalAttribute = value == null ? null : new System.Collections.Generic.List<PhysicalAttributeType>(value);
        }
    }
        
    private System.Collections.Generic.List<DimensionType> _measurementDimension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MeasurementDimension", Order=4)]
    public DimensionType[] @__MeasurementDimension
    {
        get
        {
            return _measurementDimension?.ToArray();
        }
        set
        {
            _measurementDimension = value == null ? null : new System.Collections.Generic.List<DimensionType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssuerParty", Order=5)]
    public PartyType @__IssuerParty;
        
    /// <summary>
    /// A physical attribute of the item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Identification. Physical Attribute
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Identification
    /// <para />PropertyTerm: Physical Attribute
    /// <para />AssociatedObjectClass: Physical Attribute
    /// <para />RepresentationTerm: Physical Attribute
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PhysicalAttributeType> PhysicalAttribute
    {
        get { return _physicalAttribute ?? (_physicalAttribute = new System.Collections.Generic.List<PhysicalAttributeType>()); }
        set { _physicalAttribute = value; }
    }

        
    /// <summary>
    /// A measurable dimension (length, mass, weight, or volume) of the item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Identification. Measurement_ Dimension. Dimension
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Item Identification
    /// <para />PropertyTermQualifier: Measurement
    /// <para />PropertyTerm: Dimension
    /// <para />AssociatedObjectClass: Dimension
    /// <para />RepresentationTerm: Dimension
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DimensionType> MeasurementDimension
    {
        get { return _measurementDimension ?? (_measurementDimension = new System.Collections.Generic.List<DimensionType>()); }
        set { _measurementDimension = value; }
    }

        
    /// <summary>
    /// An identifier for the item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Identification. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Item Identification
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>CUST001 3333-44-123</example>
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
    /// An extended identifier for the item that identifies the item with specific properties, e.g., Item 123 = Chair / Item 123 Ext 45 = brown chair. Two chairs can have the same item number, but one is brown. The other is white.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Identification. Extended_ Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Identification
    /// <para />PropertyTermQualifier: Extended
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ExtendedID
    {
        get
        {
            if (__ExtendedID == null) { __ExtendedID = new IdentifierType(); }
            return __ExtendedID;
        }
        set
        {
            __ExtendedID = value;
        }
    }

        
    /// <summary>
    /// An identifier for a system of barcodes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Item Identification. Barcode_ Symbology Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Identification
    /// <para />PropertyTermQualifier: Barcode
    /// <para />PropertyTerm: Symbology Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType BarcodeSymbologyID
    {
        get
        {
            if (__BarcodeSymbologyID == null) { __BarcodeSymbologyID = new IdentifierType(); }
            return __BarcodeSymbologyID;
        }
        set
        {
            __BarcodeSymbologyID = value;
        }
    }

        
    /// <summary>
    /// The party that issued this item identification.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Item Identification. Issuer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Item Identification
    /// <para />PropertyTermQualifier: Issuer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType IssuerParty
    {
        get
        {
            if (__IssuerParty == null) { __IssuerParty = new PartyType(); }
            return __IssuerParty;
        }
        set
        {
            __IssuerParty = value;
        }
    }

}