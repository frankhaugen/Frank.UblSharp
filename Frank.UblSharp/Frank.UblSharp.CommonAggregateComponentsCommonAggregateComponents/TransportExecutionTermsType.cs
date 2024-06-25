namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe terms applying to a transport execution plan.</ccts:Definition><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TransportExecutionTermsType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TransportExecutionTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportExecutionTermsType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportUserSpecialTermsType> _transportUserSpecialTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Transport User_ Special Terms. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing special terms specified by the transport user.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Transport User</ccts:PropertyTermQualifier><ccts:PropertyTerm>Special Terms</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportUserSpecialTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportUserSpecialTermsType> TransportUserSpecialTerms
        {
            get
            {
                return _transportUserSpecialTerms;
            }
            set
            {
                _transportUserSpecialTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportUserSpecialTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportUserSpecialTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportUserSpecialTermsSpecified
        {
            get
            {
                return ((this.TransportUserSpecialTerms != null) 
                            && (this.TransportUserSpecialTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportServiceProviderSpecialTermsType> _transportServiceProviderSpecialTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Transport Service Provider_ Special Terms. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing special terms specified by the transport service provider.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Transport Service Provider</ccts:PropertyTermQualifier><ccts:PropertyTerm>Special Terms</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportServiceProviderSpecialTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportServiceProviderSpecialTermsType> TransportServiceProviderSpecialTerms
        {
            get
            {
                return _transportServiceProviderSpecialTerms;
            }
            set
            {
                _transportServiceProviderSpecialTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportServiceProviderSpecialTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportServiceProviderSpecialTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportServiceProviderSpecialTermsSpecified
        {
            get
            {
                return ((this.TransportServiceProviderSpecialTerms != null) 
                            && (this.TransportServiceProviderSpecialTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChangeConditionsType> _changeConditions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Change Conditions. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing conditions applying to a change of these transport execution terms.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTerm>Change Conditions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ChangeConditions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChangeConditionsType> ChangeConditions
        {
            get
            {
                return _changeConditions;
            }
            set
            {
                _changeConditions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ChangeConditions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ChangeConditions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ChangeConditionsSpecified
        {
            get
            {
                return ((this.ChangeConditions != null) 
                            && (this.ChangeConditions.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PaymentTermsType> _paymentTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>Payment terms associated with the transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PaymentTerms")]
        public List<PaymentTermsType> PaymentTerms
        {
            get
            {
                return _paymentTerms;
            }
            set
            {
                _paymentTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PaymentTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PaymentTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PaymentTermsSpecified
        {
            get
            {
                return ((this.PaymentTerms != null) 
                            && (this.PaymentTerms.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryTermsType> _deliveryTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Delivery Terms</ccts:DictionaryEntryName><ccts:Definition>Delivery terms (e.g., Incoterms) associated with the transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTerm>Delivery Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeliveryTerms")]
        public List<DeliveryTermsType> DeliveryTerms
        {
            get
            {
                return _deliveryTerms;
            }
            set
            {
                _deliveryTerms = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryTerms-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DeliveryTerms collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliveryTermsSpecified
        {
            get
            {
                return ((this.DeliveryTerms != null) 
                            && (this.DeliveryTerms.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Bonus_ Payment Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>Terms relating to payment of applicable bonuses associated with the transport service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Bonus</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BonusPaymentTerms")]
        public PaymentTermsType BonusPaymentTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Commission_ Payment Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>Terms of payment applying to a commission specified in the transport execution plan.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Commission</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CommissionPaymentTerms")]
        public PaymentTermsType CommissionPaymentTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Penalty_ Payment Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>Terms of payment applying to a penalty specified in the transport execution plan.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Penalty</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PenaltyPaymentTerms")]
        public PaymentTermsType PenaltyPaymentTerms { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EnvironmentalEmissionType> _environmentalEmission;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Environmental Emission</ccts:DictionaryEntryName><ccts:Definition>An environmental emission resulting from the transportation service.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTerm>Environmental Emission</ccts:PropertyTerm><ccts:AssociatedObjectClass>Environmental Emission</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Environmental Emission</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EnvironmentalEmission")]
        public List<EnvironmentalEmissionType> EnvironmentalEmission
        {
            get
            {
                return _environmentalEmission;
            }
            set
            {
                _environmentalEmission = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EnvironmentalEmission-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EnvironmentalEmission collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EnvironmentalEmissionSpecified
        {
            get
            {
                return ((this.EnvironmentalEmission != null) 
                            && (this.EnvironmentalEmission.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<NotificationRequirementType> _notificationRequirement;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Notification Requirement</ccts:DictionaryEntryName><ccts:Definition>A notification requirement related to the transportation service; e.g., a requirement that the transport user should be notified when goods are ready for pickup.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTerm>Notification Requirement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Notification Requirement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Notification Requirement</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NotificationRequirement")]
        public List<NotificationRequirementType> NotificationRequirement
        {
            get
            {
                return _notificationRequirement;
            }
            set
            {
                _notificationRequirement = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NotificationRequirement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NotificationRequirement collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NotificationRequirementSpecified
        {
            get
            {
                return ((this.NotificationRequirement != null) 
                            && (this.NotificationRequirement.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Execution Terms. Service Charge_ Payment Terms. Payment Terms</ccts:DictionaryEntryName><ccts:Definition>Payment terms for the service charge associated with the transport service.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Execution Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Service Charge</ccts:PropertyTermQualifier><ccts:PropertyTerm>Payment Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Payment Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Payment Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ServiceChargePaymentTerms")]
        public PaymentTermsType ServiceChargePaymentTerms { get; set; }
    }
}
