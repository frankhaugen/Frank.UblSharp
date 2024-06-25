using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class for defining a lot identifier (the identifier of a set of item instances that would be used in case of a recall of that item).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Lot Identification. Details
/// <para />ObjectClass: Lot Identification
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("LotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("LotIdentification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class LotIdentificationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LotNumberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__LotNumberID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpiryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__ExpiryDate;
        
    private System.Collections.Generic.List<ItemPropertyType> _additionalItemProperty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalItemProperty", Order=2)]
    public ItemPropertyType[] @__AdditionalItemProperty
    {
        get
        {
            return _additionalItemProperty?.ToArray();
        }
        set
        {
            _additionalItemProperty = value == null ? null : new System.Collections.Generic.List<ItemPropertyType>(value);
        }
    }
        
    /// <summary>
    /// An additional property of the lot.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Lot Identification. Additional_ Item Property. Item Property
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Lot Identification
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Item Property
    /// <para />AssociatedObjectClass: Item Property
    /// <para />RepresentationTerm: Item Property
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ItemPropertyType> AdditionalItemProperty
    {
        get { return _additionalItemProperty ?? (_additionalItemProperty = new System.Collections.Generic.List<ItemPropertyType>()); }
        set { _additionalItemProperty = value; }
    }

        
    /// <summary>
    /// An identifier for the lot.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Lot Identification. Lot Number. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Lot Identification
    /// <para />PropertyTerm: Lot Number
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LotNumberID
    {
        get
        {
            if (__LotNumberID == null) { __LotNumberID = new IdentifierType(); }
            return __LotNumberID;
        }
        set
        {
            __LotNumberID = value;
        }
    }

        
    /// <summary>
    /// The expiry date of the lot.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Lot Identification. Expiry Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Lot Identification
    /// <para />PropertyTerm: Expiry Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ExpiryDate
    {
        get
        {
            if (__ExpiryDate == null) { __ExpiryDate = new DateType(); }
            return __ExpiryDate;
        }
        set
        {
            __ExpiryDate = value;
        }
    }

}