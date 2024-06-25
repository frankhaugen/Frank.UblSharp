using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class for identifying a vehicle used for road transport.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Road Transport. Details
/// <para />ObjectClass: Road Transport
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RoadTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RoadTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RoadTransportType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LicensePlateID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__LicensePlateID;
        
    /// <summary>
    /// The license plate identifier of this vehicle.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Road Transport. License Plate Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Road Transport
    /// <para />PropertyTerm: License Plate Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Vehicle registration number (WCO ID 167)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LicensePlateID
    {
        get
        {
            if (__LicensePlateID == null) { __LicensePlateID = new IdentifierType(); }
            return __LicensePlateID;
        }
        set
        {
            __LicensePlateID = value;
        }
    }

}