using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define comments about a retail event.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Event Comment. Details
/// <para />ObjectClass: Event Comment
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("EventComment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("EventComment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class EventCommentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Comment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType @__Comment;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TimeType @__IssueTime;
        
    /// <summary>
    /// Text commenting on the event.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Comment. Comment. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Event Comment
    /// <para />PropertyTerm: Comment
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Comment
    {
        get
        {
            if (__Comment == null) { __Comment = new TextType(); }
            return __Comment;
        }
        set
        {
            __Comment = value;
        }
    }

        
    /// <summary>
    /// The date on which this comment was made.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Comment. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Comment
    /// <para />PropertyTerm: Issue Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType IssueDate
    {
        get
        {
            if (__IssueDate == null) { __IssueDate = new DateType(); }
            return __IssueDate;
        }
        set
        {
            __IssueDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this comment was made.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Event Comment. Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Event Comment
    /// <para />PropertyTerm: Issue Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType IssueTime
    {
        get
        {
            if (__IssueTime == null) { __IssueTime = new TimeType(); }
            return __IssueTime;
        }
        set
        {
            __IssueTime = value;
        }
    }

}