using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an application-level response to a document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Response. Details
/// <para />ObjectClass: Response
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DiscrepancyResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ResponseType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ReferenceID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ReferenceID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ResponseCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__ResponseCode;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
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
    [System.Xml.Serialization.XmlElementAttribute("EffectiveDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__EffectiveDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EffectiveTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__EffectiveTime;
        
    private System.Collections.Generic.List<StatusType> _status;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Status", Order=5)]
    public StatusType[] @__Status
    {
        get
        {
            return _status?.ToArray();
        }
        set
        {
            _status = value == null ? null : new System.Collections.Generic.List<StatusType>(value);
        }
    }
        
    /// <summary>
    /// Text describing this response.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Response. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Response
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
    /// A status report associated with this response.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Response. Status
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Response
    /// <para />PropertyTerm: Status
    /// <para />AssociatedObjectClass: Status
    /// <para />RepresentationTerm: Status
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<StatusType> Status
    {
        get { return _status ?? (_status = new System.Collections.Generic.List<StatusType>()); }
        set { _status = value; }
    }

        
    /// <summary>
    /// An identifier for the section (or line) of the document to which this response applies.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Response. Reference. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Response
    /// <para />PropertyTerm: Reference
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType ReferenceID
    {
        get
        {
            if (__ReferenceID == null) { __ReferenceID = new IdentifierType(); }
            return __ReferenceID;
        }
        set
        {
            __ReferenceID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the type of response.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Response. Response Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Response
    /// <para />PropertyTerm: Response Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType ResponseCode
    {
        get
        {
            if (__ResponseCode == null) { __ResponseCode = new CodeType(); }
            return __ResponseCode;
        }
        set
        {
            __ResponseCode = value;
        }
    }

        
    /// <summary>
    /// The date upon which this response is valid.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Response. Effective Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Response
    /// <para />PropertyTerm: Effective Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType EffectiveDate
    {
        get
        {
            if (__EffectiveDate == null) { __EffectiveDate = new DateType(); }
            return __EffectiveDate;
        }
        set
        {
            __EffectiveDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this response is valid.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Response. Effective Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Response
    /// <para />PropertyTerm: Effective Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType EffectiveTime
    {
        get
        {
            if (__EffectiveTime == null) { __EffectiveTime = new TimeType(); }
            return __EffectiveTime;
        }
        set
        {
            __EffectiveTime = value;
        }
    }

}