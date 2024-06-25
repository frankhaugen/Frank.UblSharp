using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an attached document. An attachment can refer to an external document or be included with the document being exchanged.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Attachment. Details
/// <para />ObjectClass: Attachment
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("Attachment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AttachmentType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmbeddedDocumentBinaryObject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public BinaryObjectType @__EmbeddedDocumentBinaryObject;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExternalReference", Order=1)]
    public ExternalReferenceType @__ExternalReference;
        
    /// <summary>
    /// A binary large object containing an attached document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Attachment. Embedded_ Document. Binary Object
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Attachment
    /// <para />PropertyTermQualifier: Embedded
    /// <para />PropertyTerm: Document
    /// <para />RepresentationTerm: Binary Object
    /// <para />DataType: Binary Object. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public BinaryObjectType EmbeddedDocumentBinaryObject
    {
        get
        {
            if (__EmbeddedDocumentBinaryObject == null) { __EmbeddedDocumentBinaryObject = new BinaryObjectType(); }
            return __EmbeddedDocumentBinaryObject;
        }
        set
        {
            __EmbeddedDocumentBinaryObject = value;
        }
    }

        
    /// <summary>
    /// A reference to an attached document that is external to the document(s) being exchanged.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Attachment. External Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Attachment
    /// <para />PropertyTerm: External Reference
    /// <para />AssociatedObjectClass: External Reference
    /// <para />RepresentationTerm: External Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public ExternalReferenceType ExternalReference
    {
        get
        {
            if (__ExternalReference == null) { __ExternalReference = new ExternalReferenceType(); }
            return __ExternalReference;
        }
        set
        {
            __ExternalReference = value;
        }
    }

}