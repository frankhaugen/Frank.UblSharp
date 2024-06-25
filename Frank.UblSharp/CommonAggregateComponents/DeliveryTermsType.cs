using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class for describing the terms and conditions applying to the delivery of goods.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Delivery Terms. Details
/// <para />ObjectClass: Delivery Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("DeliveryTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class DeliveryTermsType
{
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public IdentifierType @__ID;
        
    private System.Collections.Generic.List<TextType> _specialTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("SpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__SpecialTerms
    {
        get
        {
            return _specialTerms?.ToArray();
        }
        set
        {
            _specialTerms = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LossRiskResponsibilityCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public CodeType @__LossRiskResponsibilityCode;
        
    private System.Collections.Generic.List<TextType> _lossRisk;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("LossRisk", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=3)]
    public TextType[] @__LossRisk
    {
        get
        {
            return _lossRisk?.ToArray();
        }
        set
        {
            _lossRisk = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("Amount", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=4)]
    public AmountType @__Amount;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryLocation", Order=5)]
    public LocationType @__DeliveryLocation;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("AllowanceCharge", Order=6)]
    public AllowanceChargeType @__AllowanceCharge;
        
    /// <summary>
    /// A description of any terms or conditions relating to the delivery items.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Terms. Special_ Terms. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Delivery Terms
    /// <para />PropertyTermQualifier: Special
    /// <para />PropertyTerm: Terms
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> SpecialTerms
    {
        get { return _specialTerms ?? (_specialTerms = new System.Collections.Generic.List<TextType>()); }
        set { _specialTerms = value; }
    }

        
    /// <summary>
    /// A description of responsibility for risk of loss in execution of the delivery, expressed as text.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Terms. Loss Risk. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Delivery Terms
    /// <para />PropertyTerm: Loss Risk
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> LossRisk
    {
        get { return _lossRisk ?? (_lossRisk = new System.Collections.Generic.List<TextType>()); }
        set { _lossRisk = value; }
    }

        
    /// <summary>
    /// An identifier for this description of delivery terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Terms. Identifier
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery Terms
    /// <para />PropertyTerm: Identifier
    /// <para />RepresentationTerm: Identifier
    /// <para />DataType: Identifier. Type
    /// </summary>
    /// <example>CIF, FOB, or EXW from the INCOTERMS Terms of Delivery. (2000 version preferred.)</example>
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
    /// A code that identifies one of various responsibilities for loss risk in the execution of the delivery.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Terms. Loss Risk Responsibility Code. Code
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery Terms
    /// <para />PropertyTerm: Loss Risk Responsibility Code
    /// <para />RepresentationTerm: Code
    /// <para />DataType: Code. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public CodeType LossRiskResponsibilityCode
    {
        get
        {
            if (__LossRiskResponsibilityCode == null) { __LossRiskResponsibilityCode = new CodeType(); }
            return __LossRiskResponsibilityCode;
        }
        set
        {
            __LossRiskResponsibilityCode = value;
        }
    }

        
    /// <summary>
    /// The monetary amount covered by these delivery terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Delivery Terms. Amount
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery Terms
    /// <para />PropertyTerm: Amount
    /// <para />RepresentationTerm: Amount
    /// <para />DataType: Amount. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AmountType Amount
    {
        get
        {
            if (__Amount == null) { __Amount = new AmountType(); }
            return __Amount;
        }
        set
        {
            __Amount = value;
        }
    }

        
    /// <summary>
    /// The location for the contracted delivery.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery Terms. Delivery_ Location. Location
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery Terms
    /// <para />PropertyTermQualifier: Delivery
    /// <para />PropertyTerm: Location
    /// <para />AssociatedObjectClass: Location
    /// <para />RepresentationTerm: Location
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public LocationType DeliveryLocation
    {
        get
        {
            if (__DeliveryLocation == null) { __DeliveryLocation = new LocationType(); }
            return __DeliveryLocation;
        }
        set
        {
            __DeliveryLocation = value;
        }
    }

        
    /// <summary>
    /// An allowance or charge covered by these delivery terms.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Delivery Terms. Allowance Charge
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Delivery Terms
    /// <para />PropertyTerm: Allowance Charge
    /// <para />AssociatedObjectClass: Allowance Charge
    /// <para />RepresentationTerm: Allowance Charge
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public AllowanceChargeType AllowanceCharge
    {
        get
        {
            if (__AllowanceCharge == null) { __AllowanceCharge = new AllowanceChargeType(); }
            return __AllowanceCharge;
        }
        set
        {
            __AllowanceCharge = value;
        }
    }

}