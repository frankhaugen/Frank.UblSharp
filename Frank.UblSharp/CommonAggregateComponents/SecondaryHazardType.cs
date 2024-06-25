using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a secondary hazard associated with a hazardous item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Secondary Hazard. Details
/// <para />ObjectClass: Secondary Hazard
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("SecondaryHazard", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("SecondaryHazard", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class SecondaryHazardType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlacardNotation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType @__PlacardNotation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PlacardEndorsement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType @__PlacardEndorsement;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmergencyProceduresCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__EmergencyProceduresCode;
        
    private System.Collections.Generic.List<TextType> _extension;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Extension", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public TextType[] @__Extension
    {
        get
        {
            return _extension?.ToArray();
        }
        set
        {
            _extension = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    /// <summary>
    /// Additional information about the hazardous substance, which can be used (for example) to specify the type of regulatory requirements that apply to this secondary hazard.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Secondary Hazard. Extension. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Secondary Hazard
    /// <para />PropertyTerm: Extension
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>N.O.S. or a Waste Characteristics Code in conjunction with an EPA Waste Stream code</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> Extension
    {
        get { return _extension ?? (_extension = new System.Collections.Generic.List<TextType>()); }
        set { _extension = value; }
    }

        
    /// <summary>
    /// An identifier for this secondary hazard.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Secondary Hazard. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Secondary Hazard
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
    /// Text of the placard notation corresponding to the hazard class of this secondary hazard. Can also be the hazard identification number of the orange placard (upper part) required on the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Secondary Hazard. Placard Notation. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Secondary Hazard
    /// <para />PropertyTerm: Placard Notation
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>5.1</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PlacardNotation
    {
        get
        {
            if (__PlacardNotation == null) { __PlacardNotation = new TextType(); }
            return __PlacardNotation;
        }
        set
        {
            __PlacardNotation = value;
        }
    }

        
    /// <summary>
    /// Text of the placard endorsement for this secondary hazard that is to be shown on the shipping papers for a hazardous item. Can also be used for the number of the orange placard (lower part) required on the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Secondary Hazard. Placard Endorsement. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Secondary Hazard
    /// <para />PropertyTerm: Placard Endorsement
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>2</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TextType PlacardEndorsement
    {
        get
        {
            if (__PlacardEndorsement == null) { __PlacardEndorsement = new TextType(); }
            return __PlacardEndorsement;
        }
        set
        {
            __PlacardEndorsement = value;
        }
    }

        
    /// <summary>
    /// A code signifying the emergency procedures for this secondary hazard.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Secondary Hazard. Emergency Procedures Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Secondary Hazard
    /// <para />PropertyTerm: Emergency Procedures Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: EMG code, EMS Page Number
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType EmergencyProceduresCode
    {
        get
        {
            if (__EmergencyProceduresCode == null) { __EmergencyProceduresCode = new CodeType(); }
            return __EmergencyProceduresCode;
        }
        set
        {
            __EmergencyProceduresCode = value;
        }
    }

}