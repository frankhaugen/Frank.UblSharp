using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe the classification of a commodity.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Commodity Classification. Details
/// <para />ObjectClass: Commodity Classification
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AdditionalCommodityClassification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AdditionalCommodityClassification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CommodityClassificationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NatureCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__NatureCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CargoTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__CargoTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CommodityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__CommodityCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ItemClassificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__ItemClassificationCode;
        
    /// <summary>
    /// A code defined by a specific maintenance agency signifying the high-level nature of the commodity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Commodity Classification. Nature Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Commodity Classification
    /// <para />PropertyTerm: Nature Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>wooden products</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType NatureCode
    {
        get
        {
            if (__NatureCode == null) { __NatureCode = new CodeType(); }
            return __NatureCode;
        }
        set
        {
            __NatureCode = value;
        }
    }

        
    /// <summary>
    /// A mutually agreed code signifying the type of cargo for purposes of commodity classification.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Commodity Classification. Cargo Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Commodity Classification
    /// <para />PropertyTerm: Cargo Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>Refrigerated</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CargoTypeCode
    {
        get
        {
            if (__CargoTypeCode == null) { __CargoTypeCode = new CodeType(); }
            return __CargoTypeCode;
        }
        set
        {
            __CargoTypeCode = value;
        }
    }

        
    /// <summary>
    /// The harmonized international commodity code for cross border and regulatory (customs and trade statistics) purposes.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Commodity Classification. Commodity Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Commodity Classification
    /// <para />PropertyTerm: Commodity Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Harmonized Code
    /// </summary>
    /// <example>1102222883</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CommodityCode
    {
        get
        {
            if (__CommodityCode == null) { __CommodityCode = new CodeType(); }
            return __CommodityCode;
        }
        set
        {
            __CommodityCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the trade classification of the commodity.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Commodity Classification. Item Classification Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Commodity Classification
    /// <para />PropertyTerm: Item Classification Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: UN/SPSC Code
    /// </summary>
    /// <example>3440234</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ItemClassificationCode
    {
        get
        {
            if (__ItemClassificationCode == null) { __ItemClassificationCode = new CodeType(); }
            return __ItemClassificationCode;
        }
        set
        {
            __ItemClassificationCode = value;
        }
    }

}