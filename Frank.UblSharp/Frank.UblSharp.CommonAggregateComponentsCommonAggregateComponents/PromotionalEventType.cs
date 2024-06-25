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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event. Details</ccts:DictionaryEntryName><ccts:Definition>Agree can be renamed as PromotionalEvents</ccts:Definition><ccts:ObjectClass>Promotional Event</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PromotionalEventType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("PromotionalEvent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PromotionalEventType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event. Promotional Event Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this promotional event. Examples can be: Holiday, Seasonal Event, Store Closing, Trade Item Introduction</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Promotional Event</ccts:ObjectClass><ccts:PropertyTerm>Promotional Event Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PromotionalEventTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PromotionalEventTypeCodeType PromotionalEventTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event. Submission. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which a proposal for this promotional event was submitted.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Promotional Event</ccts:ObjectClass><ccts:PropertyTerm>Submission</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubmissionDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubmissionDateType SubmissionDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event. First Shipment Availibility Date. Date</ccts:DictionaryEntryName><ccts:Definition>The first day that products will be available to ship from buyer to seller if the proposal for this promotional event is accepted.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Promotional Event</ccts:ObjectClass><ccts:PropertyTerm>First Shipment Availibility Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FirstShipmentAvailibilityDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FirstShipmentAvailibilityDateType FirstShipmentAvailibilityDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event. Latest_ Proposal Acceptance Date. Date</ccts:DictionaryEntryName><ccts:Definition>The deadline for acceptance of this promotional event.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Promotional Event</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest</ccts:PropertyTermQualifier><ccts:PropertyTerm>Proposal Acceptance Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatestProposalAcceptanceDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestProposalAcceptanceDateType LatestProposalAcceptanceDate { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PromotionalSpecificationType> _promotionalSpecification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event. Promotional Specification</ccts:DictionaryEntryName><ccts:Definition>A specification for a promotional event.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Promotional Event</ccts:ObjectClass><ccts:PropertyTerm>Promotional Specification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Promotional Specification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Promotional Specification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PromotionalSpecification")]
        public List<PromotionalSpecificationType> PromotionalSpecification
        {
            get
            {
                return _promotionalSpecification;
            }
            set
            {
                _promotionalSpecification = value;
            }
        }
    }
}
