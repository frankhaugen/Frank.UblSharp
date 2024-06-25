using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to identify a specific aircraft used for transportation.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Air Transport. Details
/// <para />ObjectClass: Air Transport
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("AirTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("AirTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class AirTransportType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AircraftID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__AircraftID;
        
    /// <summary>
    /// An identifer for a specific aircraft.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Air Transport. Aircraft Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Air Transport
    /// <para />PropertyTerm: Aircraft Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType AircraftID
    {
        get
        {
            if (__AircraftID == null) { __AircraftID = new IdentifierType(); }
            return __AircraftID;
        }
        set
        {
            __AircraftID = value;
        }
    }

}