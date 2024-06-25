using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a regulation.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Regulation. Details
/// <para />ObjectClass: Regulation
/// </summary>
/// <example>Points to regulation at atomic level</example>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ApplicableRegulation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ApplicableRegulation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RegulationType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LegalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__LegalReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OntologyURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__OntologyURI;
        
    /// <summary>
    /// A name for this regulation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Regulation. Name
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Regulation
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType Name
    {
        get
        {
            if (__Name == null) { __Name = new NameType(); }
            return __Name;
        }
        set
        {
            __Name = value;
        }
    }

        
    /// <summary>
    /// Text describing a legal reference.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Regulation. Legal Reference. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Regulation
    /// <para />PropertyTerm: Legal Reference
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Art. 45 2 b</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType LegalReference
    {
        get
        {
            if (__LegalReference == null) { __LegalReference = new TextType(); }
            return __LegalReference;
        }
        set
        {
            __LegalReference = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) of an ontology related to this regulation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Regulation. Ontology URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Regulation
    /// <para />PropertyTerm: Ontology URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType OntologyURI
    {
        get
        {
            if (__OntologyURI == null) { __OntologyURI = new IdentifierType(); }
            return __OntologyURI;
        }
        set
        {
            __OntologyURI = value;
        }
    }

}