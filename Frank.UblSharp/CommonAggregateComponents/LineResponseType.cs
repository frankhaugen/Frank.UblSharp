namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe responses to a line in a document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Line Response. Details
/// <para />ObjectClass: Line Response
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("LineResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("LineResponse", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class LineResponseType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineReference", Order=0)]
    public LineReferenceType @__LineReference;
        
    private System.Collections.Generic.List<ResponseType> _response;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Response", Order=1)]
    public ResponseType[] @__Response
    {
        get
        {
            return _response?.ToArray();
        }
        set
        {
            _response = value == null ? null : new System.Collections.Generic.List<ResponseType>(value);
        }
    }
        
    /// <summary>
    /// A response to the referenced line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Response. Response
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Line Response
    /// <para />PropertyTerm: Response
    /// <para />AssociatedObjectClass: Response
    /// <para />RepresentationTerm: Response
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ResponseType> Response
    {
        get { return _response ?? (_response = new System.Collections.Generic.List<ResponseType>()); }
        set { _response = value; }
    }

        
    /// <summary>
    /// A reference to the line being responded to.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Response. Line Reference
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Line Response
    /// <para />PropertyTerm: Line Reference
    /// <para />AssociatedObjectClass: Line Reference
    /// <para />RepresentationTerm: Line Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LineReferenceType LineReference
    {
        get
        {
            if (__LineReference == null) { __LineReference = new LineReferenceType(); }
            return __LineReference;
        }
        set
        {
            __LineReference = value;
        }
    }

}