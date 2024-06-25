using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to provide information about the preselection of a short list of economic operators for consideration as possible candidates in a tendering process.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Economic Operator Short List. Details
/// <para />ObjectClass: Economic Operator Short List
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EconomicOperatorShortList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EconomicOperatorShortList", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EconomicOperatorShortListType
{
        
    private System.Collections.Generic.List<TextType> _limitationDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LimitationDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType[] @__LimitationDescription
    {
        get
        {
            return _limitationDescription?.ToArray();
        }
        set
        {
            _limitationDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpectedQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public QuantityType @__ExpectedQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public QuantityType @__MaximumQuantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public QuantityType @__MinimumQuantity;
        
    private System.Collections.Generic.List<PartyType> _preSelectedParty;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreSelectedParty", Order=4)]
    public PartyType[] @__PreSelectedParty
    {
        get
        {
            return _preSelectedParty?.ToArray();
        }
        set
        {
            _preSelectedParty = value == null ? null : new System.Collections.Generic.List<PartyType>(value);
        }
    }
        
    /// <summary>
    /// Text describing the criteria used to restrict the number of candidates.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Economic Operator Short List. Limitation_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Economic Operator Short List
    /// <para />PropertyTermQualifier: Limitation
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> LimitationDescription
    {
        get { return _limitationDescription ?? (_limitationDescription = new System.Collections.Generic.List<TextType>()); }
        set { _limitationDescription = value; }
    }

        
    /// <summary>
    /// The parties pre-selected allowed to submit tenders in a negotiated procedure. Negotiated procedure is a type of procedure where the contracting authorities can set the parties to be invited in the procurement project
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Economic Operator Short List. Pre Selected_ Party. Party
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Economic Operator Short List
    /// <para />PropertyTermQualifier: Pre Selected
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PartyType> PreSelectedParty
    {
        get { return _preSelectedParty ?? (_preSelectedParty = new System.Collections.Generic.List<PartyType>()); }
        set { _preSelectedParty = value; }
    }

        
    /// <summary>
    /// The number of economic operators expected to be on the short list.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Economic Operator Short List. Expected_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Economic Operator Short List
    /// <para />PropertyTermQualifier: Expected
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType ExpectedQuantity
    {
        get
        {
            if (__ExpectedQuantity == null) { __ExpectedQuantity = new QuantityType(); }
            return __ExpectedQuantity;
        }
        set
        {
            __ExpectedQuantity = value;
        }
    }

        
    /// <summary>
    /// The maximum number of economic operators on the short list.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Economic Operator Short List. Maximum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Economic Operator Short List
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MaximumQuantity
    {
        get
        {
            if (__MaximumQuantity == null) { __MaximumQuantity = new QuantityType(); }
            return __MaximumQuantity;
        }
        set
        {
            __MaximumQuantity = value;
        }
    }

        
    /// <summary>
    /// The minimum number of economic operators on the short list.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Economic Operator Short List. Minimum_ Quantity. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Economic Operator Short List
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType MinimumQuantity
    {
        get
        {
            if (__MinimumQuantity == null) { __MinimumQuantity = new QuantityType(); }
            return __MinimumQuantity;
        }
        set
        {
            __MinimumQuantity = value;
        }
    }

}