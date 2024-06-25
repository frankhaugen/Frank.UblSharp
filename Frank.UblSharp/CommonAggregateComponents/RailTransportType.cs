using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class defining details about a train wagon used as a means of transport.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Rail Transport. Details
/// <para />ObjectClass: Rail Transport
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("RailTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("RailTransport", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class RailTransportType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TrainID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__TrainID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("RailCarID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public IdentifierType @__RailCarID;
        
    /// <summary>
    /// An identifier for the train used as the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Rail Transport. Train Identifier. Identifier
    /// <para />Cardinality: 1
    /// <para />ObjectClass: Rail Transport
    /// <para />PropertyTerm: Train Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Train Number (WCO ID 167)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType TrainID
    {
        get
        {
            if (__TrainID == null) { __TrainID = new IdentifierType(); }
            return __TrainID;
        }
        set
        {
            __TrainID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the rail car on the train used as the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Rail Transport. Rail Car Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Rail Transport
    /// <para />PropertyTerm: Rail Car Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType RailCarID
    {
        get
        {
            if (__RailCarID == null) { __RailCarID = new IdentifierType(); }
            return __RailCarID;
        }
        set
        {
            __RailCarID = value;
        }
    }

}