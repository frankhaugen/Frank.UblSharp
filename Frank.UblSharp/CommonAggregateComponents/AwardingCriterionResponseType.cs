using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// Defines the response for an awarding criterion from the tendering party.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Awarding Criterion Response. Details
/// <para />ObjectClass: Awarding Criterion Response
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AwardingCriterionResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AwardingCriterionResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AwardingCriterionResponseType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__AwardingCriterionID;
        
    private System.Collections.Generic.List<TextType> _awardingCriterionDescription;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AwardingCriterionDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__AwardingCriterionDescription
    {
        get
        {
            return _awardingCriterionDescription?.ToArray();
        }
        set
        {
            _awardingCriterionDescription = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
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
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public AmountType @__Amount;
        
    private System.Collections.Generic.List<AwardingCriterionResponseType> _subordinateAwardingCriterionResponse;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SubordinateAwardingCriterionResponse", Order=6)]
    public AwardingCriterionResponseType[] @__SubordinateAwardingCriterionResponse
    {
        get
        {
            return _subordinateAwardingCriterionResponse?.ToArray();
        }
        set
        {
            _subordinateAwardingCriterionResponse = value == null ? null : new System.Collections.Generic.List<AwardingCriterionResponseType>(value);
        }
    }
        
    /// <summary>
    /// Describes the awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion Response. Awarding Criterion_ Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion Response
    /// <para />PropertyTermQualifier: Awarding Criterion
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> AwardingCriterionDescription
    {
        get { return _awardingCriterionDescription ?? (_awardingCriterionDescription = new System.Collections.Generic.List<TextType>()); }
        set { _awardingCriterionDescription = value; }
    }

        
    /// <summary>
    /// Describes the awarding criterion response.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion Response. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion Response
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// Defines responses to any subsidiary awarding criterion.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Awarding Criterion Response. Subordinate_ Awarding Criterion Response. Awarding Criterion Response
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Awarding Criterion Response
    /// <para />PropertyTermQualifier: Subordinate
    /// <para />PropertyTerm: Awarding Criterion Response
    /// <para />AssociatedObjectClass: Awarding Criterion Response
    /// <para />RepresentationTerm: Awarding Criterion Response
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<AwardingCriterionResponseType> SubordinateAwardingCriterionResponse
    {
        get { return _subordinateAwardingCriterionResponse ?? (_subordinateAwardingCriterionResponse = new System.Collections.Generic.List<AwardingCriterionResponseType>()); }
        set { _subordinateAwardingCriterionResponse = value; }
    }

        
    /// <summary>
    /// An identification of this awarding criterion response.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion Response. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion Response
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ID
    {
        get
        {
            if (__ID == null) { __ID = new IdentifierType(); }
            return __ID;
        }
        set
        {
            __ID = value;
        }
    }

        
    /// <summary>
    /// An identifer of the awarding criterion being referred to.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion Response. Awarding Criterion Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion Response
    /// <para />PropertyTerm: Awarding Criterion Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType AwardingCriterionID
    {
        get
        {
            if (__AwardingCriterionID == null) { __AwardingCriterionID = new IdentifierType(); }
            return __AwardingCriterionID;
        }
        set
        {
            __AwardingCriterionID = value;
        }
    }

        
    /// <summary>
    /// Specifies the quantity tendered for this awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion Response. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion Response
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// Specifies the monetary amount tendered for this awarding criterion.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Awarding Criterion Response. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Awarding Criterion Response
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
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

}