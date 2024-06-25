using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a classification scheme, such as a taxonomy for classifying goods or services.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Classification Scheme. Details
/// <para />ObjectClass: Classification Scheme
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("BusinessClassificationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("BusinessClassificationScheme", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ClassificationSchemeType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LastRevisionDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__LastRevisionDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LastRevisionTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TimeType @__LastRevisionTime;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__Note
    {
        get
        {
            return _note?.ToArray();
        }
        set
        {
            _note = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public NameType @__Name;
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
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
    [System.Xml.Serialization.XmlElementAttribute("AgencyID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public IdentifierType @__AgencyID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AgencyName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public TextType @__AgencyName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IdentifierType @__VersionID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("URI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public IdentifierType @__URI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SchemeURI", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public IdentifierType @__SchemeURI;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LanguageID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public IdentifierType @__LanguageID;
        
    private System.Collections.Generic.List<ClassificationCategoryType> _classificationCategory;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ClassificationCategory", Order=13)]
    public ClassificationCategoryType[] @__ClassificationCategory
    {
        get
        {
            return _classificationCategory?.ToArray();
        }
        set
        {
            _classificationCategory = value == null ? null : new System.Collections.Generic.List<ClassificationCategoryType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Note
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Note
    {
        get { return _note ?? (_note = new System.Collections.Generic.List<TextType>()); }
        set { _note = value; }
    }

        
    /// <summary>
    /// Text describing this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Description
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>an open, global multi-sector standard for classification of products and services</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Description
    {
        get { return _description ?? (_description = new System.Collections.Generic.List<TextType>()); }
        set { _description = value; }
    }

        
    /// <summary>
    /// A description of a category within this classification scheme.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Classification Scheme. Classification Category
    /// <para />Cardinality: 1..n
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Classification Category
    /// <para />AssociatedObjectClass: Classification Category
    /// <para />RepresentationTerm: Classification Category
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<ClassificationCategoryType> ClassificationCategory
    {
        get { return _classificationCategory ?? (_classificationCategory = new System.Collections.Generic.List<ClassificationCategoryType>()); }
        set { _classificationCategory = value; }
    }

        
    /// <summary>
    /// An identifier for this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Classification Scheme
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
    /// A universally unique identifier for this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
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
    /// The date on which this classification scheme was last revised.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Last_ Revision Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTermQualifier: Last
    /// <para />PropertyTerm: Revision Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType LastRevisionDate
    {
        get
        {
            if (__LastRevisionDate == null) { __LastRevisionDate = new DateType(); }
            return __LastRevisionDate;
        }
        set
        {
            __LastRevisionDate = value;
        }
    }

        
    /// <summary>
    /// The time at which this classification scheme was last revised.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Last_ Revision Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTermQualifier: Last
    /// <para />PropertyTerm: Revision Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType LastRevisionTime
    {
        get
        {
            if (__LastRevisionTime == null) { __LastRevisionTime = new TimeType(); }
            return __LastRevisionTime;
        }
        set
        {
            __LastRevisionTime = value;
        }
    }

        
    /// <summary>
    /// The name of this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>UNSPSC</example>
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
    /// An identifier for the agency that maintains this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Agency Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Agency Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>Defaults to the UN/EDIFACT data element 3055 code list.</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType AgencyID
    {
        get
        {
            if (__AgencyID == null) { __AgencyID = new IdentifierType(); }
            return __AgencyID;
        }
        set
        {
            __AgencyID = value;
        }
    }

        
    /// <summary>
    /// The name of the agency that maintains the classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Agency Name. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Agency Name
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType AgencyName
    {
        get
        {
            if (__AgencyName == null) { __AgencyName = new TextType(); }
            return __AgencyName;
        }
        set
        {
            __AgencyName = value;
        }
    }

        
    /// <summary>
    /// An identifier for the version of this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Version. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Version
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType VersionID
    {
        get
        {
            if (__VersionID == null) { __VersionID = new IdentifierType(); }
            return __VersionID;
        }
        set
        {
            __VersionID = value;
        }
    }

        
    /// <summary>
    /// The Uniform Resource Identifier (URI) of the documentation for this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
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
    /// The Uniform Resource Identifier (URI) of this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Scheme_ URI. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTermQualifier: Scheme
    /// <para />PropertyTerm: URI
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType SchemeURI
    {
        get
        {
            if (__SchemeURI == null) { __SchemeURI = new IdentifierType(); }
            return __SchemeURI;
        }
        set
        {
            __SchemeURI = value;
        }
    }

        
    /// <summary>
    /// An identifier for the language of this classification scheme.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Classification Scheme. Language. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Classification Scheme
    /// <para />PropertyTerm: Language
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LanguageID
    {
        get
        {
            if (__LanguageID == null) { __LanguageID = new IdentifierType(); }
            return __LanguageID;
        }
        set
        {
            __LanguageID = value;
        }
    }

}