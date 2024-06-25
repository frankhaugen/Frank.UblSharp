using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to a line in a document.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Line Reference. Details
/// <para />ObjectClass: Line Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CallForTendersLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CallForTendersLineReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class LineReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__LineID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LineStatusCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__LineStatusCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Order=3)]
    public DocumentReferenceType @__DocumentReference;
        
    /// <summary>
    /// Identifies the referenced line in the document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Reference. Line Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Line Reference
    /// <para />PropertyTerm: Line Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LineID
    {
        get
        {
            if (__LineID == null) { __LineID = new IdentifierType(); }
            return __LineID;
        }
        set
        {
            __LineID = value;
        }
    }

        
    /// <summary>
    /// A universally unique identifier for this line reference.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Reference. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Reference
    /// <para />PropertyTerm: UUID
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType UUID
    {
        get
        {
            if (__UUID == null) { __UUID = new IdentifierType(); }
            return __UUID;
        }
        set
        {
            __UUID = value;
        }
    }

        
    /// <summary>
    /// A code signifying the status of the referenced line with respect to its original state.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Line Reference. Line Status Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Reference
    /// <para />PropertyTerm: Line Status Code
    /// <para />RepresentationTerm: Code
    /// <para />DataTypeQualifier: Line Status
    /// <para />DataType: Line Status_ Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LineStatusCode
    {
        get
        {
            if (__LineStatusCode == null) { __LineStatusCode = new CodeType(); }
            return __LineStatusCode;
        }
        set
        {
            __LineStatusCode = value;
        }
    }

        
    /// <summary>
    /// A reference to the document containing the referenced line.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Line Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Line Reference
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType DocumentReference
    {
        get
        {
            if (__DocumentReference == null) { __DocumentReference = new DocumentReferenceType(); }
            return __DocumentReference;
        }
        set
        {
            __DocumentReference = value;
        }
    }

}