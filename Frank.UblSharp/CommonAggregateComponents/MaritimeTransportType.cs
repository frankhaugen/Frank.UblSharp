using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a vessel used for transport by water (including sea, river, and canal).
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Maritime Transport. Details
/// <para />ObjectClass: Maritime Transport
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("MaritimeTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("MaritimeTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class MaritimeTransportType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VesselID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__VesselID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("VesselName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public NameType @__VesselName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RadioCallSignID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public IdentifierType @__RadioCallSignID;
        
    private System.Collections.Generic.List<TextType> _shipsRequirements;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ShipsRequirements", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__ShipsRequirements
    {
        get
        {
            return _shipsRequirements?.ToArray();
        }
        set
        {
            _shipsRequirements = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("GrossTonnageMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public MeasureType @__GrossTonnageMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetTonnageMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public MeasureType @__NetTonnageMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistryCertificateDocumentReference", Order=6)]
    public DocumentReferenceType @__RegistryCertificateDocumentReference;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RegistryPortLocation", Order=7)]
    public LocationType @__RegistryPortLocation;
        
    /// <summary>
    /// Information about what services a vessel will require when it arrives at a port, such as refueling, maintenance, waste disposal etc.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Maritime Transport. Ships Requirements. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTerm: Ships Requirements
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ShipsRequirements
    {
        get { return _shipsRequirements ?? (_shipsRequirements = new System.Collections.Generic.List<TextType>()); }
        set { _shipsRequirements = value; }
    }

        
    /// <summary>
    /// An identifier for a specific vessel.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Maritime Transport. Vessel Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTerm: Vessel Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Lloyds Number, Registration Number (WCO ID 167)
    /// </summary>
    /// <example>International Maritime Organisation number of a vessel</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType VesselID
    {
        get
        {
            if (__VesselID == null) { __VesselID = new IdentifierType(); }
            return __VesselID;
        }
        set
        {
            __VesselID = value;
        }
    }

        
    /// <summary>
    /// The name of the vessel.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Maritime Transport. Vessel Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTerm: Vessel Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// <para />AlternativeBusinessTerms: Ships Name
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType VesselName
    {
        get
        {
            if (__VesselName == null) { __VesselName = new NameType(); }
            return __VesselName;
        }
        set
        {
            __VesselName = value;
        }
    }

        
    /// <summary>
    /// The radio call sign of the vessel.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Maritime Transport. Radio Call Sign Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTerm: Radio Call Sign Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>NES</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType RadioCallSignID
    {
        get
        {
            if (__RadioCallSignID == null) { __RadioCallSignID = new IdentifierType(); }
            return __RadioCallSignID;
        }
        set
        {
            __RadioCallSignID = value;
        }
    }

        
    /// <summary>
    /// Gross tonnage is calculated by measuring a ship&apos;s volume (from keel to funnel, to the outside of the hull framing) and applying a mathematical formula and is used to determine things such as a ship&apos;s manning regulations, safety rules, registration fees and port dues.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Maritime Transport. Gross Tonnage. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTerm: Gross Tonnage
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType GrossTonnageMeasure
    {
        get
        {
            if (__GrossTonnageMeasure == null) { __GrossTonnageMeasure = new MeasureType(); }
            return __GrossTonnageMeasure;
        }
        set
        {
            __GrossTonnageMeasure = value;
        }
    }

        
    /// <summary>
    /// Net tonnage is calculated by measuring a ship&apos;s internal volume and applying a mathematical formula and is used to calculate the port duties.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Maritime Transport. Net Tonnage. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTerm: Net Tonnage
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType NetTonnageMeasure
    {
        get
        {
            if (__NetTonnageMeasure == null) { __NetTonnageMeasure = new MeasureType(); }
            return __NetTonnageMeasure;
        }
        set
        {
            __NetTonnageMeasure = value;
        }
    }

        
    /// <summary>
    /// The certificate issued to the ship by the ships registry in a given flag state.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Maritime Transport. Registry Certificate_ Document Reference. Document Reference
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTermQualifier: Registry Certificate
    /// <para />PropertyTerm: Document Reference
    /// <para />AssociatedObjectClass: Document Reference
    /// <para />RepresentationTerm: Document Reference
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public DocumentReferenceType RegistryCertificateDocumentReference
    {
        get
        {
            if (__RegistryCertificateDocumentReference == null) { __RegistryCertificateDocumentReference = new DocumentReferenceType(); }
            return __RegistryCertificateDocumentReference;
        }
        set
        {
            __RegistryCertificateDocumentReference = value;
        }
    }

        
    /// <summary>
    /// The port in which a vessel is registered or permanently based.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Maritime Transport. Registry Port_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Maritime Transport
    /// <para />PropertyTermQualifier: Registry Port
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType RegistryPortLocation
    {
        get
        {
            if (__RegistryPortLocation == null) { __RegistryPortLocation = new LocationType(); }
            return __RegistryPortLocation;
        }
        set
        {
            __RegistryPortLocation = value;
        }
    }

}