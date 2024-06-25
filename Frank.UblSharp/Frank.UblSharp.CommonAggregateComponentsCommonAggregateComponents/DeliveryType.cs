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
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("DeliveryType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ContractualDelivery))]
    [XmlIncludeAttribute(typeof(Delivery))]
    public partial class DeliveryType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of items, child consignments, shipments in this delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Minimum_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The minimum quantity of items, child consignments, shipments in this delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumQuantityType MinimumQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Maximum_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The maximum quantity of items, child consignments, shipments in this delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumQuantityType MaximumQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Actual_ Delivery Date. Date</ccts:DictionaryEntryName><ccts:Definition>The actual date of delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualDeliveryDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ActualDeliveryDateType ActualDeliveryDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Actual_ Delivery Time. Time</ccts:DictionaryEntryName><ccts:Definition>The actual time of delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActualDeliveryTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ActualDeliveryTimeType ActualDeliveryTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Latest_ Delivery Date. Date</ccts:DictionaryEntryName><ccts:Definition>The latest date of delivery allowed by the buyer.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatestDeliveryDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestDeliveryDateType LatestDeliveryDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Latest_ Delivery Time. Time</ccts:DictionaryEntryName><ccts:Definition>The latest time of delivery allowed by the buyer.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatestDeliveryTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestDeliveryTimeType LatestDeliveryTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Release. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier used for approval of access to delivery locations (e.g., port terminals).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTerm>Release</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReleaseID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReleaseIdType ReleaseId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Tracking Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>The delivery Tracking ID (for transport tracking).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTerm>Tracking Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TrackingID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TrackingIdType TrackingId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Delivery_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>The delivery address.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryAddress")]
        public AddressType DeliveryAddress { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Delivery_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The delivery location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryLocation")]
        public LocationType DeliveryLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Alternative Delivery_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>An alternative delivery location.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Alternative Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AlternativeDeliveryLocation")]
        public LocationType AlternativeDeliveryLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Requested Delivery_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period requested for delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Requested Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RequestedDeliveryPeriod")]
        public PeriodType RequestedDeliveryPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Promised Delivery_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period promised for delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Promised Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PromisedDeliveryPeriod")]
        public PeriodType PromisedDeliveryPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Estimated Delivery_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period estimated for delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedDeliveryPeriod")]
        public PeriodType EstimatedDeliveryPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Carrier_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party responsible for delivering the goods.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Carrier</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CarrierParty")]
        public PartyType CarrierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Delivery_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party to whom the goods are delivered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryParty")]
        public PartyType DeliveryParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PartyType> _notifyParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Notify_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A party to be notified of this delivery.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Notify</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NotifyParty")]
        public List<PartyType> NotifyParty
        {
            get
            {
                return _notifyParty;
            }
            set
            {
                _notifyParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NotifyParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NotifyParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NotifyPartySpecified
        {
            get
            {
                return ((this.NotifyParty != null) 
                            && (this.NotifyParty.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Despatch</ccts:DictionaryEntryName><ccts:Definition>The despatch (pickup) associated with this delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTerm>Despatch</ccts:PropertyTerm><ccts:AssociatedObjectClass>Despatch</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Despatch</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Despatch")]
        public DespatchType Despatch { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryTermsType> _deliveryTerms;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Delivery Terms</ccts:DictionaryEntryName><ccts:Definition>Terms and conditions relating to the delivery.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTerm>Delivery Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Terms</ccts:RepresentationTerm></ccts:Component></para>
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Minimum_ Delivery Unit. Delivery Unit</ccts:DictionaryEntryName><ccts:Definition>The minimum delivery unit for this delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Unit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Unit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Unit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumDeliveryUnit")]
        public DeliveryUnitType MinimumDeliveryUnit { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Maximum_ Delivery Unit. Delivery Unit</ccts:DictionaryEntryName><ccts:Definition>The maximum delivery unit for this delivery.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivery Unit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Unit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Unit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumDeliveryUnit")]
        public DeliveryUnitType MaximumDeliveryUnit { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Delivery. Shipment</ccts:DictionaryEntryName><ccts:Definition>The shipment being delivered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Delivery</ccts:ObjectClass><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Shipment")]
        public ShipmentType Shipment { get; set; }
    }
}
