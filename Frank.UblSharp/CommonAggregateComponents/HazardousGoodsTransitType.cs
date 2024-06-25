using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe hazardous goods in transit.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Hazardous Goods Transit. Details
/// <para />ObjectClass: Hazardous Goods Transit
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("HazardousGoodsTransit", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class HazardousGoodsTransitType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportEmergencyCardCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public CodeType @__TransportEmergencyCardCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PackingCriteriaCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public CodeType @__PackingCriteriaCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousRegulationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__HazardousRegulationCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("InhalationToxicityZoneCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public CodeType @__InhalationToxicityZoneCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportAuthorizationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__TransportAuthorizationCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MaximumTemperature", Order=5)]
    public TemperatureType @__MaximumTemperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MinimumTemperature", Order=6)]
    public TemperatureType @__MinimumTemperature;
        
    /// <summary>
    /// An identifier for a transport emergency card describing the actions to be taken in an emergency in transporting the hazardous goods. It may be the identity number of a hazardous emergency response plan assigned by the appropriate authority.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Goods Transit. Transport Emergency Card Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Goods Transit
    /// <para />PropertyTerm: Transport Emergency Card Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: TREM card
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportEmergencyCardCode
    {
        get
        {
            if (__TransportEmergencyCardCode == null) { __TransportEmergencyCardCode = new CodeType(); }
            return __TransportEmergencyCardCode;
        }
        set
        {
            __TransportEmergencyCardCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the packaging requirement for transportation of the hazardous goods as assigned by IATA, IMDB, ADR, RID etc.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Goods Transit. Packing Criteria Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Goods Transit
    /// <para />PropertyTerm: Packing Criteria Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Packing Group
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType PackingCriteriaCode
    {
        get
        {
            if (__PackingCriteriaCode == null) { __PackingCriteriaCode = new CodeType(); }
            return __PackingCriteriaCode;
        }
        set
        {
            __PackingCriteriaCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the set of legal regulations governing the transportation of the hazardous goods.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Goods Transit. Hazardous Regulation Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Goods Transit
    /// <para />PropertyTerm: Hazardous Regulation Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType HazardousRegulationCode
    {
        get
        {
            if (__HazardousRegulationCode == null) { __HazardousRegulationCode = new CodeType(); }
            return __HazardousRegulationCode;
        }
        set
        {
            __HazardousRegulationCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the Inhalation Toxicity Hazard Zone for the hazardous goods, as defined by the US Department of Transportation.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Goods Transit. Inhalation Toxicity Zone Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Goods Transit
    /// <para />PropertyTerm: Inhalation Toxicity Zone Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType InhalationToxicityZoneCode
    {
        get
        {
            if (__InhalationToxicityZoneCode == null) { __InhalationToxicityZoneCode = new CodeType(); }
            return __InhalationToxicityZoneCode;
        }
        set
        {
            __InhalationToxicityZoneCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying authorization for the transportation of hazardous cargo.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Goods Transit. Transport Authorization Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Goods Transit
    /// <para />PropertyTerm: Transport Authorization Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Permission for Transport
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType TransportAuthorizationCode
    {
        get
        {
            if (__TransportAuthorizationCode == null) { __TransportAuthorizationCode = new CodeType(); }
            return __TransportAuthorizationCode;
        }
        set
        {
            __TransportAuthorizationCode = value;
        }
    }

        
    /// <summary>
    /// The maximum temperature at which the hazardous goods can safely be transported.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Goods Transit. Maximum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Goods Transit
    /// <para />PropertyTermQualifier: Maximum
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TemperatureType MaximumTemperature
    {
        get
        {
            if (__MaximumTemperature == null) { __MaximumTemperature = new TemperatureType(); }
            return __MaximumTemperature;
        }
        set
        {
            __MaximumTemperature = value;
        }
    }

        
    /// <summary>
    /// The minimum temperature at which the hazardous goods can safely be transported.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Goods Transit. Minimum_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Goods Transit
    /// <para />PropertyTermQualifier: Minimum
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TemperatureType MinimumTemperature
    {
        get
        {
            if (__MinimumTemperature == null) { __MinimumTemperature = new TemperatureType(); }
            return __MinimumTemperature;
        }
        set
        {
            __MinimumTemperature = value;
        }
    }

}