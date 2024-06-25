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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Event Line Item. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a line item describing the expected impacts associated with a retail event involving a specific product at a specific location.</ccts:Definition><ccts:ObjectClass>Event Line Item</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("EventLineItemType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("EventLineItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EventLineItemType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Event Line Item. Line Number. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of this event line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Event Line Item</ccts:ObjectClass><ccts:PropertyTerm>Line Number</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LineNumberNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LineNumberNumericType LineNumberNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Event Line Item. Participating Locations_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location of the stores involved in the event described in this line item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Event Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Participating Locations</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ParticipatingLocationsLocation")]
        public LocationType ParticipatingLocationsLocation { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<RetailPlannedImpactType> _retailPlannedImpact;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Event Line Item. Retail Planned Impact</ccts:DictionaryEntryName><ccts:Definition>A planned impact of the event described in this line item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Event Line Item</ccts:ObjectClass><ccts:PropertyTerm>Retail Planned Impact</ccts:PropertyTerm><ccts:AssociatedObjectClass>Retail Planned Impact</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Retail Planned Impact</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RetailPlannedImpact")]
        public List<RetailPlannedImpactType> RetailPlannedImpact
        {
            get
            {
                return _retailPlannedImpact;
            }
            set
            {
                _retailPlannedImpact = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RetailPlannedImpact-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RetailPlannedImpact collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RetailPlannedImpactSpecified
        {
            get
            {
                return ((this.RetailPlannedImpact != null) 
                            && (this.RetailPlannedImpact.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Event Line Item. Supply_ Item. Item</ccts:DictionaryEntryName><ccts:Definition>The product with which the event is associated.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Event Line Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Supply</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SupplyItem")]
        public ItemType SupplyItem { get; set; }
    }
}
