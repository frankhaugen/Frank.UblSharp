using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to define a reference to a catalogue.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Catalogue Reference. Details
/// <para />ObjectClass: Catalogue Reference
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("CatalogueReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("CatalogueReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class CatalogueReferenceType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UUID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__UUID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public DateType @__IssueDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TimeType @__IssueTime;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RevisionDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public DateType @__RevisionDate;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RevisionTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public TimeType @__RevisionTime;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
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
        
    private System.Collections.Generic.List<TextType> _description;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
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
    [System.Xml.Serialization.XmlElementAttribute("VersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public IdentifierType @__VersionID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PreviousVersionID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public IdentifierType @__PreviousVersionID;
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Reference
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
    /// Text describing the catalogue.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Description. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Catalogue Reference
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
    /// An identifier for a specific catalogue.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Catalogue Reference
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
    /// A universally unique identifier for a specific catalogue.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. UUID. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Reference
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
    /// The date on which the catalogue was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Issue Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Reference
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
    /// The time at which the catalogue was issued.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Issue Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Reference
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

        
    /// <summary>
    /// The date on which the information in the catalogue was last revised.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Revision Date. Date
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Reference
    /// <para />PropertyTerm: Revision Date
    /// <para />RepresentationTerm: Date
    /// <para />DataType: Date. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DateType RevisionDate
    {
        get
        {
            if (__RevisionDate == null) { __RevisionDate = new DateType(); }
            return __RevisionDate;
        }
        set
        {
            __RevisionDate = value;
        }
    }

        
    /// <summary>
    /// The time at which the information in the catalogue was last revised.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Revision Time. Time
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Reference
    /// <para />PropertyTerm: Revision Time
    /// <para />RepresentationTerm: Time
    /// <para />DataType: Time. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TimeType RevisionTime
    {
        get
        {
            if (__RevisionTime == null) { __RevisionTime = new TimeType(); }
            return __RevisionTime;
        }
        set
        {
            __RevisionTime = value;
        }
    }

        
    /// <summary>
    /// An identifier for the current version of the catalogue.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Version. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Reference
    /// <para />PropertyTerm: Version
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1.1</example>
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
    /// An identifier for the previous version of the catalogue that is superseded by this version.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Catalogue Reference. Previous_ Version. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Catalogue Reference
    /// <para />PropertyTermQualifier: Previous
    /// <para />PropertyTerm: Version
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>1.0</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType PreviousVersionID
    {
        get
        {
            if (__PreviousVersionID == null) { __PreviousVersionID = new IdentifierType(); }
            return __PreviousVersionID;
        }
        set
        {
            __PreviousVersionID = value;
        }
    }

}