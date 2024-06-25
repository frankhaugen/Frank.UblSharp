using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// The charging rate used for both call charging and time dependent charging
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Duty. Details
/// <para />ObjectClass: Duty
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CallDuty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CallDuty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DutyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Duty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__Duty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DutyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__DutyCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TaxCategory", Order=3)]
    public TaxCategoryType @__TaxCategory;
        
    /// <summary>
    /// The amount of this duty.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Duty. Amount
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Duty
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    /// <example>88.23</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType Amount
    {
        get
        {
            if (__Amount == null) { __Amount = new AmountType(); }
            return __Amount;
        }
        set
        {
            __Amount = value;
        }
    }

        
    /// <summary>
    /// Text describing this duty.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Duty. Duty. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Duty
    /// <para />PropertyTerm: Duty
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>ConnectionFee</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Duty
    {
        get
        {
            if (__Duty == null) { __Duty = new TextType(); }
            return __Duty;
        }
        set
        {
            __Duty = value;
        }
    }

        
    /// <summary>
    /// The type of this charge rate, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Duty. Duty Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Duty
    /// <para />PropertyTerm: Duty Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>ConnectionFee</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType DutyCode
    {
        get
        {
            if (__DutyCode == null) { __DutyCode = new CodeType(); }
            return __DutyCode;
        }
        set
        {
            __DutyCode = value;
        }
    }

        
    /// <summary>
    /// The tax category applicable to this duty.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Duty. Tax Category
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Duty
    /// <para />PropertyTerm: Tax Category
    /// <para />AssociatedObjectClass: Tax Category
    /// <para />RepresentationTerm: Tax Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TaxCategoryType TaxCategory
    {
        get
        {
            if (__TaxCategory == null) { __TaxCategory = new TaxCategoryType(); }
            return __TaxCategory;
        }
        set
        {
            __TaxCategory = value;
        }
    }

}