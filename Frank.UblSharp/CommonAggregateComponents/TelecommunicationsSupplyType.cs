using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class describing the supply of a telecommunication service, e.g., providing telephone calls.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Telecommunications Supply. Details
/// <para />ObjectClass: Telecommunications Supply
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TelecommunicationsSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TelecommunicationsSupply", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TelecommunicationsSupplyType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__TelecommunicationsSupplyType1;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__TelecommunicationsSupplyTypeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PrivacyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__PrivacyCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
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
    [System.Xml.Serialization.XmlElementAttribute("TotalAmount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__TotalAmount;
        
    private System.Collections.Generic.List<TelecommunicationsSupplyLineType> _telecommunicationsSupplyLine;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TelecommunicationsSupplyLine", Order=5)]
    public TelecommunicationsSupplyLineType[] @__TelecommunicationsSupplyLine
    {
        get
        {
            return _telecommunicationsSupplyLine?.ToArray();
        }
        set
        {
            _telecommunicationsSupplyLine = value == null ? null : new System.Collections.Generic.List<TelecommunicationsSupplyLineType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the telecommunications supply.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Telecommunications Supply
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Extended conversation Statement January quarter 2008.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Outlines the provided telecommunication supply
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Telecommunications Supply. Telecommunications Supply Line
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Telecommunications Supply
    /// <para />PropertyTerm: Telecommunications Supply Line
    /// <para />AssociatedObjectClass: Telecommunications Supply Line
    /// <para />RepresentationTerm: Telecommunications Supply Line
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TelecommunicationsSupplyLineType> TelecommunicationsSupplyLine
    {
        get { return _telecommunicationsSupplyLine ?? (_telecommunicationsSupplyLine = new System.Collections.Generic.List<TelecommunicationsSupplyLineType>()); }
        set { _telecommunicationsSupplyLine = value; }
    }

        
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType TelecommunicationsSupplyType1
    {
        get
        {
            if (__TelecommunicationsSupplyType1 == null) { __TelecommunicationsSupplyType1 = new TextType(); }
            return __TelecommunicationsSupplyType1;
        }
        set
        {
            __TelecommunicationsSupplyType1 = value;
        }
    }

        
    /// <summary>
    /// The type of telecommunications supply, expressed as a code.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply. Telecommunications Supply Type Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Supply
    /// <para />PropertyTerm: Telecommunications Supply Type Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>TeleExtended</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TelecommunicationsSupplyTypeCode
    {
        get
        {
            if (__TelecommunicationsSupplyTypeCode == null) { __TelecommunicationsSupplyTypeCode = new CodeType(); }
            return __TelecommunicationsSupplyTypeCode;
        }
        set
        {
            __TelecommunicationsSupplyTypeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the level of confidentiality of this information for this telecommunication supply.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply. Privacy Code. Code
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Telecommunications Supply
    /// <para />PropertyTerm: Privacy Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    /// <example>CompanyLevel</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PrivacyCode
    {
        get
        {
            if (__PrivacyCode == null) { __PrivacyCode = new CodeType(); }
            return __PrivacyCode;
        }
        set
        {
            __PrivacyCode = value;
        }
    }

        
    /// <summary>
    /// The total amount associated with this telecommunications supply.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Telecommunications Supply. Total_ Amount. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Telecommunications Supply
    /// <para />PropertyTermQualifier: Total
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType TotalAmount
    {
        get
        {
            if (__TotalAmount == null) { __TotalAmount = new AmountType(); }
            return __TotalAmount;
        }
        set
        {
            __TotalAmount = value;
        }
    }

}