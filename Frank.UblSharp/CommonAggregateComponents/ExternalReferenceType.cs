using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe an external object, such as a document stored at a remote location.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: External Reference. Details
/// <para />ObjectClass: External Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("ExternalReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ExternalReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("URI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__URI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DocumentHash", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__DocumentHash;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HashAlgorithmMethod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__HashAlgorithmMethod;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpiryDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public DateType @__ExpiryDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ExpiryTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TimeType @__ExpiryTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MimeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__MimeCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FormatCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__FormatCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EncodingCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public CodeType @__EncodingCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CharacterSetCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public CodeType @__CharacterSetCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FileName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public NameType @__FileName;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
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
        
    /// <summary>
    /// Text describing the external object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>computer accessories for laptops</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) that identifies the external object as an Internet resource.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
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
    /// A hash value for the externally stored object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Document Hash. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Document Hash
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType DocumentHash
    {
        get
        {
            if (__DocumentHash == null) { __DocumentHash = new TextType(); }
            return __DocumentHash;
        }
        set
        {
            __DocumentHash = value;
        }
    }

        
    /// <summary>
    /// A hash algorithm used to calculate the hash value of the externally stored object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Hash Algorithm Method. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Hash Algorithm Method
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType HashAlgorithmMethod
    {
        get
        {
            if (__HashAlgorithmMethod == null) { __HashAlgorithmMethod = new TextType(); }
            return __HashAlgorithmMethod;
        }
        set
        {
            __HashAlgorithmMethod = value;
        }
    }

        
    /// <summary>
    /// The date on which availability of the resource can no longer be relied upon.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Expiry Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Expiry Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType ExpiryDate
    {
        get
        {
            if (__ExpiryDate == null) { __ExpiryDate = new DateType(); }
            return __ExpiryDate;
        }
        set
        {
            __ExpiryDate = value;
        }
    }

        
    /// <summary>
    /// The time after which availability of the resource can no longer be relied upon.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Expiry Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Expiry Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType ExpiryTime
    {
        get
        {
            if (__ExpiryTime == null) { __ExpiryTime = new TimeType(); }
            return __ExpiryTime;
        }
        set
        {
            __ExpiryTime = value;
        }
    }

        
    /// <summary>
    /// A code signifying the mime type of the external object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Mime Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Mime Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType MimeCode
    {
        get
        {
            if (__MimeCode == null) { __MimeCode = new CodeType(); }
            return __MimeCode;
        }
        set
        {
            __MimeCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the format of the external object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Format Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Format Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType FormatCode
    {
        get
        {
            if (__FormatCode == null) { __FormatCode = new CodeType(); }
            return __FormatCode;
        }
        set
        {
            __FormatCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the encoding/decoding algorithm used with the external object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Encoding Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Encoding Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType EncodingCode
    {
        get
        {
            if (__EncodingCode == null) { __EncodingCode = new CodeType(); }
            return __EncodingCode;
        }
        set
        {
            __EncodingCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the character set of an external document.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. Character Set Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: Character Set Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType CharacterSetCode
    {
        get
        {
            if (__CharacterSetCode == null) { __CharacterSetCode = new CodeType(); }
            return __CharacterSetCode;
        }
        set
        {
            __CharacterSetCode = value;
        }
    }

        
    /// <summary>
    /// The file name of the external object.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: External Reference. File Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: External Reference
    /// <para />PropertyTerm: File Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType FileName
    {
        get
        {
            if (__FileName == null) { __FileName = new NameType(); }
            return __FileName;
        }
        set
        {
            __FileName = value;
        }
    }

}