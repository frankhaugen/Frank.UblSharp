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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event Line Item. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a line item associated with a promotional event.</ccts:Definition><ccts:ObjectClass>Promotional Event Line Item</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PromotionalEventLineItemType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("PromotionalEventLineItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PromotionalEventLineItemType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event Line Item. Amount</ccts:DictionaryEntryName><ccts:Definition>The amount associated with this promotional event line item.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Promotional Event Line Item</ccts:ObjectClass><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Amount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AmountType Amount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Promotional Event Line Item. Event Line Item</ccts:DictionaryEntryName><ccts:Definition>A line item describing the expected impacts associated with this promotional event for a specific product at a specific location.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Promotional Event Line Item</ccts:ObjectClass><ccts:PropertyTerm>Event Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Event Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Event Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("EventLineItem")]
        public EventLineItemType EventLineItem { get; set; }
    }
}