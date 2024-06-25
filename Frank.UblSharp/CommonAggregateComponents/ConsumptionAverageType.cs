using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define an average consumption as a monetary amount.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Consumption Average. Details
/// <para />ObjectClass: Consumption Average
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ConsumptionAverage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ConsumptionAverage", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ConsumptionAverageType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AverageAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__AverageAmount;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
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
        
    /// <summary>
    /// A description of the average consumed.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Average. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Consumption Average
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Average price incl. value added tax per kilowatt-hour in the billing period.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// The average monetary amount of the consumption.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Consumption Average. Average_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Consumption Average
    /// <para />PropertyTermQualifier: Average
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>1.65</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType AverageAmount
    {
        get
        {
            if (__AverageAmount == null) { __AverageAmount = new AmountType(); }
            return __AverageAmount;
        }
        set
        {
            __AverageAmount = value;
        }
    }

}