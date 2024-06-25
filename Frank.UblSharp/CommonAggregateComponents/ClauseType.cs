using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a clause (a distinct article or provision) in a contract, treaty, will, or other formal or legal written document requiring compliance.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Clause. Details
/// <para />ObjectClass: Clause
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Clause", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Clause", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ClauseType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _content;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Content", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__Content
    {
        get
        {
            return _content?.ToArray();
        }
        set
        {
            _content = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    /// <summary>
    /// The text of this clause.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Clause. Content. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Clause
    /// <para />PropertyTerm: Content
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Content
    {
        get { return _content ?? (_content = new System.Collections.Generic.List<TextType>()); }
        set { _content = value; }
    }

        
    /// <summary>
    /// An identifier for this clause.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Clause. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Clause
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

}