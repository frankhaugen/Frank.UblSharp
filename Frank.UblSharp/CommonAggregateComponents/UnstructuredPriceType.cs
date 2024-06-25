using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A simplified version of the Price class intended for applications such as telephone billing.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Unstructured Price. Details
/// <para />ObjectClass: Unstructured Price
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("UnstructuredPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("UnstructuredPrice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class UnstructuredPriceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PriceAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__PriceAmount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TimeAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__TimeAmount;
        
    /// <summary>
    /// The price amount.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Unstructured Price. Price Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Unstructured Price
    /// <para />PropertyTerm: Price Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>23.45</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType PriceAmount
    {
        get
        {
            if (__PriceAmount == null) { __PriceAmount = new AmountType(); }
            return __PriceAmount;
        }
        set
        {
            __PriceAmount = value;
        }
    }

        
    /// <summary>
    /// The usage time upon which the price is based.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Unstructured Price. Time Amount. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Unstructured Price
    /// <para />PropertyTerm: Time Amount
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TimeAmount
    {
        get
        {
            if (__TimeAmount == null) { __TimeAmount = new TextType(); }
            return __TimeAmount;
        }
        set
        {
            __TimeAmount = value;
        }
    }

}