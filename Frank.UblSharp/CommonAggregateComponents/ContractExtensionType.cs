using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe possible extensions to a contract.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Contract Extension. Details
/// <para />ObjectClass: Contract Extension
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ContractExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ContractExtension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ContractExtensionType
{
        
    private System.Collections.Generic.List<TextType> _optionsDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OptionsDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType[] @__OptionsDescription
    {
        get
        {
            return _optionsDescription?.ToArray();
        }
        set
        {
            _optionsDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumNumberNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NumericType @__MinimumNumberNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumNumberNumeric", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public NumericType @__MaximumNumberNumeric;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OptionValidityPeriod", Order=3)]
    public PeriodType @__OptionValidityPeriod;
        
    private System.Collections.Generic.List<RenewalType> _renewal;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Renewal", Order=4)]
    public RenewalType[] @__Renewal
    {
        get
        {
            return _renewal?.ToArray();
        }
        set
        {
            _renewal = value == null ? null : new System.Collections.Generic.List<RenewalType>(value);
        }
    }
        
    /// <summary>
    /// A description for the possible options that can be carried out during the execution of the contract.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract Extension. Options Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contract Extension
    /// <para />PropertyTerm: Options Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> OptionsDescription
    {
        get { return _optionsDescription ?? (_optionsDescription = new System.Collections.Generic.List<TextType>()); }
        set { _optionsDescription = value; }
    }

        
    /// <summary>
    /// The period allowed for each contract extension.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contract Extension. Renewal
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contract Extension
    /// <para />PropertyTerm: Renewal
    /// <para />AssociatedObjectClass: Renewal
    /// <para />RepresentationTerm: Renewal
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<RenewalType> Renewal
    {
        get { return _renewal ?? (_renewal = new System.Collections.Generic.List<RenewalType>()); }
        set { _renewal = value; }
    }

        
    /// <summary>
    /// The fixed minimum number of contract extensions or renewals.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract Extension. Minimum_ Number. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract Extension
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Number
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType MinimumNumberNumeric
    {
        get
        {
            if (__MinimumNumberNumeric == null) { __MinimumNumberNumeric = new NumericType(); }
            return __MinimumNumberNumeric;
        }
        set
        {
            __MinimumNumberNumeric = value;
        }
    }

        
    /// <summary>
    /// The maximum allowed number of contract extensions.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contract Extension. Maximum_ Number. Numeric
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract Extension
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Number
    /// <para />RepresentationTerm: Numeric
    /// <para />DataType: Numeric. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NumericType MaximumNumberNumeric
    {
        get
        {
            if (__MaximumNumberNumeric == null) { __MaximumNumberNumeric = new NumericType(); }
            return __MaximumNumberNumeric;
        }
        set
        {
            __MaximumNumberNumeric = value;
        }
    }

        
    /// <summary>
    /// The period during which the option for extending the contract is available.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contract Extension. Option Validity_ Period. Period
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contract Extension
    /// <para />PropertyTermQualifier: Option Validity
    /// <para />PropertyTerm: Period
    /// <para />AssociatedObjectClass: Period
    /// <para />RepresentationTerm: Period
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PeriodType OptionValidityPeriod
    {
        get
        {
            if (__OptionValidityPeriod == null) { __OptionValidityPeriod = new PeriodType(); }
            return __OptionValidityPeriod;
        }
        set
        {
            __OptionValidityPeriod = value;
        }
    }

}