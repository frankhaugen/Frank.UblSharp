using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a contactable person or department in an organization.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Contact. Details
/// <para />ObjectClass: Contact
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AccountingContact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AccountingContact", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class ContactType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__Name;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Telephone", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__Telephone;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Telefax", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType @__Telefax;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ElectronicMail", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType @__ElectronicMail;
        
    private System.Collections.Generic.List<TextType> _note;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
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
        
    private System.Collections.Generic.List<CommunicationType> _otherCommunication;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("OtherCommunication", Order=6)]
    public CommunicationType[] @__OtherCommunication
    {
        get
        {
            return _otherCommunication?.ToArray();
        }
        set
        {
            _otherCommunication = value == null ? null : new System.Collections.Generic.List<CommunicationType>(value);
        }
    }
        
    /// <summary>
    /// Free-form text conveying information that is not contained explicitly in other structures; in particular, a textual description of the circumstances under which this contact can be used (e.g., &quot;emergency&quot; or &quot;after hours&quot;).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contact. Note. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contact
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
    /// Another means of communication with this contact.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Contact. Other_ Communication. Communication
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Contact
    /// <para />PropertyTermQualifier: Other
    /// <para />PropertyTerm: Communication
    /// <para />AssociatedObjectClass: Communication
    /// <para />RepresentationTerm: Communication
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<CommunicationType> OtherCommunication
    {
        get { return _otherCommunication ?? (_otherCommunication = new System.Collections.Generic.List<CommunicationType>()); }
        set { _otherCommunication = value; }
    }

        
    /// <summary>
    /// An identifier for this contact.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contact. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contact
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>Receivals Clerk</example>
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
    /// The name of this contact. It is recommended that this be used for a functional name and not a personal name.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contact. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contact
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Delivery Dock</example>
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
    /// The primary telephone number of this contact.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contact. Telephone. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contact
    /// <para />PropertyTerm: Telephone
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Telephone
    {
        get
        {
            if (__Telephone == null) { __Telephone = new TextType(); }
            return __Telephone;
        }
        set
        {
            __Telephone = value;
        }
    }

        
    /// <summary>
    /// The primary fax number of this contact.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contact. Telefax. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contact
    /// <para />PropertyTerm: Telefax
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType Telefax
    {
        get
        {
            if (__Telefax == null) { __Telefax = new TextType(); }
            return __Telefax;
        }
        set
        {
            __Telefax = value;
        }
    }

        
    /// <summary>
    /// The primary email address of this contact.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Contact. Electronic_ Mail. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Contact
    /// <para />PropertyTermQualifier: Electronic
    /// <para />PropertyTerm: Mail
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType ElectronicMail
    {
        get
        {
            if (__ElectronicMail == null) { __ElectronicMail = new TextType(); }
            return __ElectronicMail;
        }
        set
        {
            __ElectronicMail = value;
        }
    }

}