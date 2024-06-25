using Frank.UblSharp.UnqualifiedDataTypes;

namespace Frank.UblSharp.CommonAggregateComponents;

/// <summary>
/// A class to describe terms applying to a transport execution plan.
/// <para />ComponentType: ABIE
/// <para />DictionaryEntryName: Transport Execution Terms. Details
/// <para />ObjectClass: Transport Execution Terms
/// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.Xml.Serialization.XmlTypeAttribute("TransportExecutionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
[System.Xml.Serialization.XmlRootAttribute("TransportExecutionTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2", IsNullable=false)]
public partial class TransportExecutionTermsType
{
        
    private System.Collections.Generic.List<TextType> _transportUserSpecialTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportUserSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=0)]
    public TextType[] @__TransportUserSpecialTerms
    {
        get
        {
            return _transportUserSpecialTerms?.ToArray();
        }
        set
        {
            _transportUserSpecialTerms = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _transportServiceProviderSpecialTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderSpecialTerms", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=1)]
    public TextType[] @__TransportServiceProviderSpecialTerms
    {
        get
        {
            return _transportServiceProviderSpecialTerms?.ToArray();
        }
        set
        {
            _transportServiceProviderSpecialTerms = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<TextType> _changeConditions;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ChangeConditions", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2", Order=2)]
    public TextType[] @__ChangeConditions
    {
        get
        {
            return _changeConditions?.ToArray();
        }
        set
        {
            _changeConditions = value == null ? null : new System.Collections.Generic.List<TextType>(value);
        }
    }
        
    private System.Collections.Generic.List<PaymentTermsType> _paymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PaymentTerms", Order=3)]
    public PaymentTermsType[] @__PaymentTerms
    {
        get
        {
            return _paymentTerms?.ToArray();
        }
        set
        {
            _paymentTerms = value == null ? null : new System.Collections.Generic.List<PaymentTermsType>(value);
        }
    }
        
    private System.Collections.Generic.List<DeliveryTermsType> _deliveryTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("DeliveryTerms", Order=4)]
    public DeliveryTermsType[] @__DeliveryTerms
    {
        get
        {
            return _deliveryTerms?.ToArray();
        }
        set
        {
            _deliveryTerms = value == null ? null : new System.Collections.Generic.List<DeliveryTermsType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("BonusPaymentTerms", Order=5)]
    public PaymentTermsType @__BonusPaymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("CommissionPaymentTerms", Order=6)]
    public PaymentTermsType @__CommissionPaymentTerms;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("PenaltyPaymentTerms", Order=7)]
    public PaymentTermsType @__PenaltyPaymentTerms;
        
    private System.Collections.Generic.List<EnvironmentalEmissionType> _environmentalEmission;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("EnvironmentalEmission", Order=8)]
    public EnvironmentalEmissionType[] @__EnvironmentalEmission
    {
        get
        {
            return _environmentalEmission?.ToArray();
        }
        set
        {
            _environmentalEmission = value == null ? null : new System.Collections.Generic.List<EnvironmentalEmissionType>(value);
        }
    }
        
    private System.Collections.Generic.List<NotificationRequirementType> _notificationRequirement;
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("NotificationRequirement", Order=9)]
    public NotificationRequirementType[] @__NotificationRequirement
    {
        get
        {
            return _notificationRequirement?.ToArray();
        }
        set
        {
            _notificationRequirement = value == null ? null : new System.Collections.Generic.List<NotificationRequirementType>(value);
        }
    }
        
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Xml.Serialization.XmlElementAttribute("ServiceChargePaymentTerms", Order=10)]
    public PaymentTermsType @__ServiceChargePaymentTerms;
        
    /// <summary>
    /// Text describing special terms specified by the transport user.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Transport User_ Special Terms. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTermQualifier: Transport User
    /// <para />PropertyTerm: Special Terms
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> TransportUserSpecialTerms
    {
        get { return _transportUserSpecialTerms ?? (_transportUserSpecialTerms = new System.Collections.Generic.List<TextType>()); }
        set { _transportUserSpecialTerms = value; }
    }

        
    /// <summary>
    /// Text describing special terms specified by the transport service provider.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Transport Service Provider_ Special Terms. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTermQualifier: Transport Service Provider
    /// <para />PropertyTerm: Special Terms
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> TransportServiceProviderSpecialTerms
    {
        get { return _transportServiceProviderSpecialTerms ?? (_transportServiceProviderSpecialTerms = new System.Collections.Generic.List<TextType>()); }
        set { _transportServiceProviderSpecialTerms = value; }
    }

        
    /// <summary>
    /// Text describing conditions applying to a change of these transport execution terms.
    /// <para />ComponentType: BBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Change Conditions. Text
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTerm: Change Conditions
    /// <para />RepresentationTerm: Text
    /// <para />DataType: Text. Type
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<TextType> ChangeConditions
    {
        get { return _changeConditions ?? (_changeConditions = new System.Collections.Generic.List<TextType>()); }
        set { _changeConditions = value; }
    }

        
    /// <summary>
    /// Payment terms associated with the transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Payment Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<PaymentTermsType> PaymentTerms
    {
        get { return _paymentTerms ?? (_paymentTerms = new System.Collections.Generic.List<PaymentTermsType>()); }
        set { _paymentTerms = value; }
    }

        
    /// <summary>
    /// Delivery terms (e.g., Incoterms) associated with the transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Delivery Terms
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTerm: Delivery Terms
    /// <para />AssociatedObjectClass: Delivery Terms
    /// <para />RepresentationTerm: Delivery Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<DeliveryTermsType> DeliveryTerms
    {
        get { return _deliveryTerms ?? (_deliveryTerms = new System.Collections.Generic.List<DeliveryTermsType>()); }
        set { _deliveryTerms = value; }
    }

        
    /// <summary>
    /// An environmental emission resulting from the transportation service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Environmental Emission
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTerm: Environmental Emission
    /// <para />AssociatedObjectClass: Environmental Emission
    /// <para />RepresentationTerm: Environmental Emission
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<EnvironmentalEmissionType> EnvironmentalEmission
    {
        get { return _environmentalEmission ?? (_environmentalEmission = new System.Collections.Generic.List<EnvironmentalEmissionType>()); }
        set { _environmentalEmission = value; }
    }

        
    /// <summary>
    /// A notification requirement related to the transportation service; e.g., a requirement that the transport user should be notified when goods are ready for pickup.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Notification Requirement
    /// <para />Cardinality: 0..n
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTerm: Notification Requirement
    /// <para />AssociatedObjectClass: Notification Requirement
    /// <para />RepresentationTerm: Notification Requirement
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public System.Collections.Generic.List<NotificationRequirementType> NotificationRequirement
    {
        get { return _notificationRequirement ?? (_notificationRequirement = new System.Collections.Generic.List<NotificationRequirementType>()); }
        set { _notificationRequirement = value; }
    }

        
    /// <summary>
    /// Terms relating to payment of applicable bonuses associated with the transport service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Bonus_ Payment Terms. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTermQualifier: Bonus
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType BonusPaymentTerms
    {
        get
        {
            if (__BonusPaymentTerms == null) { __BonusPaymentTerms = new PaymentTermsType(); }
            return __BonusPaymentTerms;
        }
        set
        {
            __BonusPaymentTerms = value;
        }
    }

        
    /// <summary>
    /// Terms of payment applying to a commission specified in the transport execution plan.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Commission_ Payment Terms. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTermQualifier: Commission
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType CommissionPaymentTerms
    {
        get
        {
            if (__CommissionPaymentTerms == null) { __CommissionPaymentTerms = new PaymentTermsType(); }
            return __CommissionPaymentTerms;
        }
        set
        {
            __CommissionPaymentTerms = value;
        }
    }

        
    /// <summary>
    /// Terms of payment applying to a penalty specified in the transport execution plan.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Penalty_ Payment Terms. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTermQualifier: Penalty
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType PenaltyPaymentTerms
    {
        get
        {
            if (__PenaltyPaymentTerms == null) { __PenaltyPaymentTerms = new PaymentTermsType(); }
            return __PenaltyPaymentTerms;
        }
        set
        {
            __PenaltyPaymentTerms = value;
        }
    }

        
    /// <summary>
    /// Payment terms for the service charge associated with the transport service.
    /// <para />ComponentType: ASBIE
    /// <para />DictionaryEntryName: Transport Execution Terms. Service Charge_ Payment Terms. Payment Terms
    /// <para />Cardinality: 0..1
    /// <para />ObjectClass: Transport Execution Terms
    /// <para />PropertyTermQualifier: Service Charge
    /// <para />PropertyTerm: Payment Terms
    /// <para />AssociatedObjectClass: Payment Terms
    /// <para />RepresentationTerm: Payment Terms
    /// </summary>
    [System.Xml.Serialization.XmlIgnoreAttribute]
    public PaymentTermsType ServiceChargePaymentTerms
    {
        get
        {
            if (__ServiceChargePaymentTerms == null) { __ServiceChargePaymentTerms = new PaymentTermsType(); }
            return __ServiceChargePaymentTerms;
        }
        set
        {
            __ServiceChargePaymentTerms = value;
        }
    }

}