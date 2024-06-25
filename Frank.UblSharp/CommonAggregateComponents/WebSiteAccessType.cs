using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe access to a web site.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Web Site Access. Details
/// <para />ObjectClass: Web Site Access
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("WebSiteAccess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("WebSiteAccess", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class WebSiteAccessType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("URI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__URI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Password", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__Password;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Login", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__Login;
        
    /// <summary>
    /// The Uniform Resource Identifier (URI) for this web site; i.e., its Uniform Resource Locator (URL).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Web Site Access. URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Web Site Access
    /// <para />PropertyTerm: URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType URI
    {
        get
        {
            if (__URI == null) { __URI = new IdentifierType(); }
            return __URI;
        }
        set
        {
            __URI = value;
        }
    }

        
    /// <summary>
    /// A password to the web site.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Web Site Access. Password. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Web Site Access
    /// <para />PropertyTerm: Password
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>confidence</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Password
    {
        get
        {
            if (__Password == null) { __Password = new TextType(); }
            return __Password;
        }
        set
        {
            __Password = value;
        }
    }

        
    /// <summary>
    /// Text describing login details.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Web Site Access. Login. Text
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Web Site Access
    /// <para />PropertyTerm: Login
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Utsuser</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Login
    {
        get
        {
            if (__Login == null) { __Login = new TextType(); }
            return __Login;
        }
        set
        {
            __Login = value;
        }
    }

}