using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The consumption in case the consumption is for one and only one supplier.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Supplier Consumption. Details
/// <para />ObjectClass: Supplier Consumption
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SupplierConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class SupplierConsumptionType
{
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType[] @__Description
    {
        get
        {
            return _description?.ToArray();
        }
        set
        {
            _description = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UtilitySupplierParty", Order=1)]
    public PartyType @__UtilitySupplierParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UtilityCustomerParty", Order=2)]
    public PartyType @__UtilityCustomerParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Consumption", Order=3)]
    public ConsumptionType @__Consumption;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Contract", Order=4)]
    public ContractType @__Contract;
        
    private System.Collections.Generic.List<ConsumptionLineType> _consumptionLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ConsumptionLine", Order=5)]
    public ConsumptionLineType[] @__ConsumptionLine
    {
        get
        {
            return _consumptionLine?.ToArray();
        }
        set
        {
            _consumptionLine = value == null ? null : new System.Collections.Generic.List<ConsumptionLineType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Supplier Consumption. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Supplier Consumption
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>This is what you pay for electricity to DONG Energy North Utility</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// The consumption of a utility product.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Consumption. Consumption Line
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Supplier Consumption
    /// <para />PropertyTerm: Consumption Line
    /// <para />AssociatedObjectClass: Consumption Line
    /// <para />RepresentationTerm: Consumption Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ConsumptionLineType> ConsumptionLine
    {
        get { return _consumptionLine ?? (_consumptionLine = new System.Collections.Generic.List<ConsumptionLineType>()); }
        set { _consumptionLine = value; }
    }

        
    /// <summary>
    /// The party supplying the utility.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Consumption. Utility Supplier_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Consumption
    /// <para />PropertyTermQualifier: Utility Supplier
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType UtilitySupplierParty
    {
        get
        {
            if (__UtilitySupplierParty == null) { __UtilitySupplierParty = new PartyType(); }
            return __UtilitySupplierParty;
        }
        set
        {
            __UtilitySupplierParty = value;
        }
    }

        
    /// <summary>
    /// The utility customer.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Consumption. Utility Customer_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Consumption
    /// <para />PropertyTermQualifier: Utility Customer
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType UtilityCustomerParty
    {
        get
        {
            if (__UtilityCustomerParty == null) { __UtilityCustomerParty = new PartyType(); }
            return __UtilityCustomerParty;
        }
        set
        {
            __UtilityCustomerParty = value;
        }
    }

        
    /// <summary>
    /// The consumption regarding this supplier
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Consumption. Consumption
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Supplier Consumption
    /// <para />PropertyTerm: Consumption
    /// <para />AssociatedObjectClass: Consumption
    /// <para />RepresentationTerm: Consumption
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ConsumptionType Consumption
    {
        get
        {
            if (__Consumption == null) { __Consumption = new ConsumptionType(); }
            return __Consumption;
        }
        set
        {
            __Consumption = value;
        }
    }

        
    /// <summary>
    /// A contract setting forth conditions regulating the consumption.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Supplier Consumption. Contract
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Supplier Consumption
    /// <para />PropertyTerm: Contract
    /// <para />AssociatedObjectClass: Contract
    /// <para />RepresentationTerm: Contract
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ContractType Contract
    {
        get
        {
            if (__Contract == null) { __Contract = new ContractType(); }
            return __Contract;
        }
        set
        {
            __Contract = value;
        }
    }

}