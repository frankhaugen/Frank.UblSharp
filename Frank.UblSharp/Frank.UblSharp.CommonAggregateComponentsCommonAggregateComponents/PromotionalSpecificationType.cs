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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Specification. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a promotional event as a set of item locations that share a set of promotional tactics.</ccts:Definition><ccts:ObjectClass>Promotional Specification</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PromotionalSpecificationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("PromotionalSpecification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PromotionalSpecificationType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Specification. Specification Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this promotional specification.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Promotional Specification</ccts:ObjectClass><ccts:PropertyTerm>Specification Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SpecificationID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecificationIdType SpecificationId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PromotionalEventLineItemType> _promotionalEventLineItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Specification. Promotional Event Line Item</ccts:DictionaryEntryName><ccts:Definition>A line item for a promotional event involving a specific product at a specific location; it describes the expected impacts associated with the event and specifies the promotional price of the item."</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Promotional Specification</ccts:ObjectClass><ccts:PropertyTerm>Promotional Event Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Promotional Event Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Promotional Event Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PromotionalEventLineItem")]
        public List<PromotionalEventLineItemType> PromotionalEventLineItem
        {
            get
            {
                return _promotionalEventLineItem;
            }
            set
            {
                _promotionalEventLineItem = value;
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<EventTacticType> _eventTactic;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Specification. Event Tactic</ccts:DictionaryEntryName><ccts:Definition>An event tactic associated with this promotion.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Promotional Specification</ccts:ObjectClass><ccts:PropertyTerm>Event Tactic</ccts:PropertyTerm><ccts:AssociatedObjectClass>Event Tactic</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Event Tactic</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EventTactic")]
        public List<EventTacticType> EventTactic
        {
            get
            {
                return _eventTactic;
            }
            set
            {
                _eventTactic = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EventTactic-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EventTactic collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EventTacticSpecified
        {
            get
            {
                return ((this.EventTactic != null) 
                            && (this.EventTactic.Count != 0));
            }
        }
    }
}