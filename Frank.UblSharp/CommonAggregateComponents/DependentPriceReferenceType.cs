using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define the price of an item as a percentage of the price of a different item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Dependent Price Reference. Details
/// <para />ObjectClass: Dependent Price Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DependentPriceReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DependentPriceReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DependentPriceReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Percent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public PercentType @__Percent;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LocationAddress", Order=1)]
    public AddressType @__LocationAddress;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DependentLineReference", Order=2)]
    public LineReferenceType @__DependentLineReference;
        
    /// <summary>
    /// The percentage by which the price of the different item is multiplied to calculate the price of the item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Dependent Price Reference. Percent
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Dependent Price Reference
    /// <para />PropertyTerm: Percent
    /// <para />RepresentationTerm: Percent
    /// <para />DataType: Percent. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PercentType Percent
    {
        get
        {
            if (__Percent == null) { __Percent = new PercentType(); }
            return __Percent;
        }
        set
        {
            __Percent = value;
        }
    }

        
    /// <summary>
    /// The reference location for this dependent price reference.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Dependent Price Reference. Location_ Address. Address
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Dependent Price Reference
    /// <para />PropertyTermQualifier: Location
    /// <para />PropertyTerm: Address
    /// <para />AssociatedObjectClass: Address
    /// <para />RepresentationTerm: Address
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AddressType LocationAddress
    {
        get
        {
            if (__LocationAddress == null) { __LocationAddress = new AddressType(); }
            return __LocationAddress;
        }
        set
        {
            __LocationAddress = value;
        }
    }

        
    /// <summary>
    /// A reference to a line that the price is depended of.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Dependent Price Reference. Dependent_ Line Reference. Line Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Dependent Price Reference
    /// <para />PropertyTermQualifier: Dependent
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineReferenceType DependentLineReference
    {
        get
        {
            if (__DependentLineReference == null) { __DependentLineReference = new LineReferenceType(); }
            return __DependentLineReference;
        }
        set
        {
            __DependentLineReference = value;
        }
    }

}