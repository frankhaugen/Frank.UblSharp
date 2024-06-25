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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Segment. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe one segment or leg in a transportation service.</ccts:Definition><ccts:ObjectClass>Transportation Segment</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TransportationSegmentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TransportationSegment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TransportationSegmentType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Segment. Sequence. Numeric</ccts:DictionaryEntryName><ccts:Definition>A number indicating the order of this segment in the sequence of transportation segments making up a transportation service.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Transportation Segment</ccts:ObjectClass><ccts:PropertyTerm>Sequence</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType><ccts:Examples>1, 2, 3, 4, etc.</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SequenceNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SequenceNumericType SequenceNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Segment. Transport Execution Plan Reference. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the transport execution plan governing this transportation segment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Segment</ccts:ObjectClass><ccts:PropertyTerm>Transport Execution Plan Reference</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportExecutionPlanReferenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportExecutionPlanReferenceIdType TransportExecutionPlanReferenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Segment. Transportation Service</ccts:DictionaryEntryName><ccts:Definition>The transportation service used in this transportation segment.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Transportation Segment</ccts:ObjectClass><ccts:PropertyTerm>Transportation Service</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transportation Service</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transportation Service</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("TransportationService")]
        public TransportationServiceType TransportationService { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Segment. Transport Service Provider_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The transport service provider responsible for carrying out transportation services in this transportation segment.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Transportation Segment</ccts:ObjectClass><ccts:PropertyTermQualifier>Transport Service Provider</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("TransportServiceProviderParty")]
        public PartyType TransportServiceProviderParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Segment. Referenced_ Consignment. Consignment</ccts:DictionaryEntryName><ccts:Definition>A consignment referenced in this transportation segment. Such a consignment may have different identifiers than the consignment identifiers being used in the transportation service agreed between the transport user and the transport service provider.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transportation Segment</ccts:ObjectClass><ccts:PropertyTermQualifier>Referenced</ccts:PropertyTermQualifier><ccts:PropertyTerm>Consignment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Consignment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Consignment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReferencedConsignment")]
        public ConsignmentType ReferencedConsignment { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentStageType> _shipmentStage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transportation Segment. Shipment Stage</ccts:DictionaryEntryName><ccts:Definition>The shipment stage associated with this transportation segment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transportation Segment</ccts:ObjectClass><ccts:PropertyTerm>Shipment Stage</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment Stage</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment Stage</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShipmentStage")]
        public List<ShipmentStageType> ShipmentStage
        {
            get
            {
                return _shipmentStage;
            }
            set
            {
                _shipmentStage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ShipmentStage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ShipmentStage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShipmentStageSpecified
        {
            get
            {
                return ((this.ShipmentStage != null) 
                            && (this.ShipmentStage.Count != 0));
            }
        }
    }
}
