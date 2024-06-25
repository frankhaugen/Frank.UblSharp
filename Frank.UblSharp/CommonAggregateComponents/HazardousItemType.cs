using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe a hazardous item.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Hazardous Item. Details
/// <para />ObjectClass: Hazardous Item
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("HazardousItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("HazardousItem", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class HazardousItemType
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
        
    private System.Collections.Generic.List<TextType> _additionalInformation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalInformation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__AdditionalInformation
    {
        get
        {
            return _additionalInformation?.ToArray();
        }
        set
        {
            _additionalInformation = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UNDGCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public CodeType @__UNDGCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmergencyProceduresCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=5)]
    public CodeType @__EmergencyProceduresCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MedicalFirstAidGuideCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=6)]
    public CodeType @__MedicalFirstAidGuideCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TechnicalName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=7)]
    public NameType @__TechnicalName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CategoryName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=8)]
    public NameType @__CategoryName;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousCategoryCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=9)]
    public CodeType @__HazardousCategoryCode;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("UpperOrangeHazardPlacardID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=10)]
    public IdentifierType @__UpperOrangeHazardPlacardID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LowerOrangeHazardPlacardID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=11)]
    public IdentifierType @__LowerOrangeHazardPlacardID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("MarkingID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=12)]
    public IdentifierType @__MarkingID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardClassID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=13)]
    public IdentifierType @__HazardClassID;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetWeightMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=14)]
    public MeasureType @__NetWeightMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NetVolumeMeasure", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=15)]
    public MeasureType @__NetVolumeMeasure;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Quantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=16)]
    public QuantityType @__Quantity;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ContactParty", Order=17)]
    public PartyType @__ContactParty;
        
    private System.Collections.Generic.List<SecondaryHazardType> _secondaryHazard;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SecondaryHazard", Order=18)]
    public SecondaryHazardType[] @__SecondaryHazard
    {
        get
        {
            return _secondaryHazard?.ToArray();
        }
        set
        {
            _secondaryHazard = value == null ? null : new System.Collections.Generic.List<SecondaryHazardType>(value);
        }
    }
        
    private System.Collections.Generic.List<HazardousGoodsTransitType> _hazardousGoodsTransit;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("HazardousGoodsTransit", Order=19)]
    public HazardousGoodsTransitType[] @__HazardousGoodsTransit
    {
        get
        {
            return _hazardousGoodsTransit?.ToArray();
        }
        set
        {
            _hazardousGoodsTransit = value == null ? null : new System.Collections.Generic.List<HazardousGoodsTransitType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EmergencyTemperature", Order=20)]
    public TemperatureType @__EmergencyTemperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("FlashpointTemperature", Order=21)]
    public TemperatureType @__FlashpointTemperature;
        
    private System.Collections.Generic.List<TemperatureType> _additionalTemperature;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AdditionalTemperature", Order=22)]
    public TemperatureType[] @__AdditionalTemperature
    {
        get
        {
            return _additionalTemperature?.ToArray();
        }
        set
        {
            _additionalTemperature = value == null ? null : new System.Collections.Generic.List<TemperatureType>(value);
        }
    }
        
    /// <summary>
    /// Text providing further information about the hazardous substance.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Additional_ Information. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Information
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    /// <example>Must be stored away from flammable materials N.O.S. or a Waste Characteristics Code in conjunction with an EPA Waste Stream code</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> AdditionalInformation
    {
        get { return _additionalInformation ?? (_additionalInformation = new System.Collections.Generic.List<TextType>()); }
        set { _additionalInformation = value; }
    }

        
    /// <summary>
    /// A secondary hazard associated with this hazardous item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Item. Secondary Hazard
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Secondary Hazard
    /// <para />AssociatedObjectClass: Secondary Hazard
    /// <para />RepresentationTerm: Secondary Hazard
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<SecondaryHazardType> SecondaryHazard
    {
        get { return _secondaryHazard ?? (_secondaryHazard = new System.Collections.Generic.List<SecondaryHazardType>()); }
        set { _secondaryHazard = value; }
    }

        
    /// <summary>
    /// Information related to the transit of this kind of hazardous goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Item. Hazardous Goods Transit
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Hazardous Goods Transit
    /// <para />AssociatedObjectClass: Hazardous Goods Transit
    /// <para />RepresentationTerm: Hazardous Goods Transit
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<HazardousGoodsTransitType> HazardousGoodsTransit
    {
        get { return _hazardousGoodsTransit ?? (_hazardousGoodsTransit = new System.Collections.Generic.List<HazardousGoodsTransitType>()); }
        set { _hazardousGoodsTransit = value; }
    }

        
    /// <summary>
    /// Another temperature relevant to the handling of this hazardous item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Item. Additional_ Temperature. Temperature
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Additional
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TemperatureType> AdditionalTemperature
    {
        get { return _additionalTemperature ?? (_additionalTemperature = new System.Collections.Generic.List<TemperatureType>()); }
        set { _additionalTemperature = value; }
    }

        
    /// <summary>
    /// An identifier for this hazardous item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>Round Up</example>
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
    /// Text of the placard notation corresponding to the hazard class of this hazardous item. Can also be the hazard identification number of the orange placard (upper part) required on the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Placard Notation. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
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
    /// Text of the placard endorsement that is to be shown on the shipping papers for this hazardous item. Can also be used for the number of the orange placard (lower part) required on the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Placard Endorsement. Text
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
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
    /// The UN code for this kind of hazardous item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. UNDG Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: UNDG Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: UN Code
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType UNDGCode
    {
        get
        {
            if (__UNDGCode == null) { __UNDGCode = new CodeType(); }
            return __UNDGCode;
        }
        set
        {
            __UNDGCode = value;
        }
    }

        
    /// <summary>
    /// A code signifying the emergency procedures for this hazardous item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Emergency Procedures Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
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

        
    /// <summary>
    /// A code signifying a medical first aid guide appropriate to this hazardous item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Medical First Aid Guide Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Medical First Aid Guide Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: MFAG page number
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType MedicalFirstAidGuideCode
    {
        get
        {
            if (__MedicalFirstAidGuideCode == null) { __MedicalFirstAidGuideCode = new CodeType(); }
            return __MedicalFirstAidGuideCode;
        }
        set
        {
            __MedicalFirstAidGuideCode = value;
        }
    }

        
    /// <summary>
    /// The full technical name of a specific hazardous substance contained in this goods item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Technical_ Name. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Technical
    /// <para />PropertyTerm: Name
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    /// <example>Granular Sodium Chlorate WeedKiller</example>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType TechnicalName
    {
        get
        {
            if (__TechnicalName == null) { __TechnicalName = new NameType(); }
            return __TechnicalName;
        }
        set
        {
            __TechnicalName = value;
        }
    }

        
    /// <summary>
    /// The name of the category of hazard that applies to the Item.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Category. Name
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Category
    /// <para />RepresentationTerm: Name
    /// <para />DataType: Name. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public NameType CategoryName
    {
        get
        {
            if (__CategoryName == null) { __CategoryName = new NameType(); }
            return __CategoryName;
        }
        set
        {
            __CategoryName = value;
        }
    }

        
    /// <summary>
    /// A code signifying a kind of hazard for a material.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Hazardous Category Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Hazardous Category Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// <para />AlternativeBusinessTerms: Hazardous material class code
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType HazardousCategoryCode
    {
        get
        {
            if (__HazardousCategoryCode == null) { __HazardousCategoryCode = new CodeType(); }
            return __HazardousCategoryCode;
        }
        set
        {
            __HazardousCategoryCode = value;
        }
    }

        
    /// <summary>
    /// The number for the upper part of the orange hazard placard required on the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Upper_ Orange Hazard Placard Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Upper
    /// <para />PropertyTerm: Orange Hazard Placard Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Hazard identification number (upper part)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType UpperOrangeHazardPlacardID
    {
        get
        {
            if (__UpperOrangeHazardPlacardID == null) { __UpperOrangeHazardPlacardID = new IdentifierType(); }
            return __UpperOrangeHazardPlacardID;
        }
        set
        {
            __UpperOrangeHazardPlacardID = value;
        }
    }

        
    /// <summary>
    /// The number for the lower part of the orange hazard placard required on the means of transport.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Lower_ Orange Hazard Placard Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Lower
    /// <para />PropertyTerm: Orange Hazard Placard Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Substance identification number (lower part)
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType LowerOrangeHazardPlacardID
    {
        get
        {
            if (__LowerOrangeHazardPlacardID == null) { __LowerOrangeHazardPlacardID = new IdentifierType(); }
            return __LowerOrangeHazardPlacardID;
        }
        set
        {
            __LowerOrangeHazardPlacardID = value;
        }
    }

        
    /// <summary>
    /// An identifier to the marking of the Hazardous Item
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Marking Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Marking Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: Dangerous goods label marking
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType MarkingID
    {
        get
        {
            if (__MarkingID == null) { __MarkingID = new IdentifierType(); }
            return __MarkingID;
        }
        set
        {
            __MarkingID = value;
        }
    }

        
    /// <summary>
    /// An identifier for the hazard class applicable to this hazardous item as defined by the relevant regulation authority (e.g., the IMDG Class Number of the SOLAS Convention of IMO and the ADR/RID Class Number for the road/rail environment).
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Hazard Class Identifier. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Hazard Class Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// <para />AlternativeBusinessTerms: IMDG Class Number, ADR/RID Class Number
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public IdentifierType HazardClassID
    {
        get
        {
            if (__HazardClassID == null) { __HazardClassID = new IdentifierType(); }
            return __HazardClassID;
        }
        set
        {
            __HazardClassID = value;
        }
    }

        
    /// <summary>
    /// The net weight of this hazardous item, excluding packaging.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Net_ Weight. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Net
    /// <para />PropertyTerm: Weight
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType NetWeightMeasure
    {
        get
        {
            if (__NetWeightMeasure == null) { __NetWeightMeasure = new MeasureType(); }
            return __NetWeightMeasure;
        }
        set
        {
            __NetWeightMeasure = value;
        }
    }

        
    /// <summary>
    /// The volume of this hazardous item, excluding packaging and transport equipment.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Net_ Volume. Measure
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Net
    /// <para />PropertyTerm: Volume
    /// <para />RepresentationTerm: Measure
    /// <para />DataType: Measure. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public MeasureType NetVolumeMeasure
    {
        get
        {
            if (__NetVolumeMeasure == null) { __NetVolumeMeasure = new MeasureType(); }
            return __NetVolumeMeasure;
        }
        set
        {
            __NetVolumeMeasure = value;
        }
    }

        
    /// <summary>
    /// The quantity of goods items in this hazardous item that are hazardous.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Hazardous Item. Quantity
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTerm: Quantity
    /// <para />RepresentationTerm: Quantity
    /// <para />DataType: Quantity. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public QuantityType Quantity
    {
        get
        {
            if (__Quantity == null) { __Quantity = new QuantityType(); }
            return __Quantity;
        }
        set
        {
            __Quantity = value;
        }
    }

        
    /// <summary>
    /// The individual, group, or body to be contacted in case of a hazardous incident associated with this item.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Item. Contact_ Party. Party
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Contact
    /// <para />PropertyTerm: Party
    /// <para />AssociatedObjectClass: Party
    /// <para />RepresentationTerm: Party
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PartyType ContactParty
    {
        get
        {
            if (__ContactParty == null) { __ContactParty = new PartyType(); }
            return __ContactParty;
        }
        set
        {
            __ContactParty = value;
        }
    }

        
    /// <summary>
    /// The threshold temperature at which emergency procedures apply in the handling of temperature-controlled goods.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Item. Emergency_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Emergency
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TemperatureType EmergencyTemperature
    {
        get
        {
            if (__EmergencyTemperature == null) { __EmergencyTemperature = new TemperatureType(); }
            return __EmergencyTemperature;
        }
        set
        {
            __EmergencyTemperature = value;
        }
    }

        
    /// <summary>
    /// The flashpoint temperature of this hazardous item; i.e., the lowest temperature at which vapors above a volatile combustible substance ignite in air when exposed to flame.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Hazardous Item. Flashpoint_ Temperature. Temperature
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Hazardous Item
    /// <para />PropertyTermQualifier: Flashpoint
    /// <para />PropertyTerm: Temperature
    /// <para />AssociatedObjectClass: Temperature
    /// <para />RepresentationTerm: Temperature
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public TemperatureType FlashpointTemperature
    {
        get
        {
            if (__FlashpointTemperature == null) { __FlashpointTemperature = new TemperatureType(); }
            return __FlashpointTemperature;
        }
        set
        {
            __FlashpointTemperature = value;
        }
    }

}