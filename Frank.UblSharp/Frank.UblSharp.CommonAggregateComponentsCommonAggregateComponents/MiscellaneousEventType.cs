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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Miscellaneous Event. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a miscellaneous event associated with a retail event.</ccts:Definition><ccts:ObjectClass>Miscellaneous Event</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("MiscellaneousEventType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("MiscellaneousEvent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MiscellaneousEventType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Miscellaneous Event. Miscellaneous Event Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this miscellaneous event. Examples are: ASSORTMENT_CHARGE DISASTER FORECAST_DECREASE FORECAST_INCREASE FREIGHT_FLOW_ALLOCATION INVENTORY_POLICY_CHANGE LOCATION_CLOSING LOCATION_OPENING OTHER OUT_OF_STOCK PACKAGING_LABELING_CHANGE PRICE_DECREASE PRICE_INCREASE STORE_FORMAT_OR_PLANOGRAM_CHANGE TEST_MARKET WEATHER</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Miscellaneous Event</ccts:ObjectClass><ccts:PropertyTerm>Miscellaneous Event Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("MiscellaneousEventTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MiscellaneousEventTypeCodeType MiscellaneousEventTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EventLineItemType> _eventLineItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Miscellaneous Event. Event Line Item</ccts:DictionaryEntryName><ccts:Definition>An event line item for this miscellaneous retail event.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Miscellaneous Event</ccts:ObjectClass><ccts:PropertyTerm>Event Line Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Event Line Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Event Line Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("EventLineItem")]
        public List<EventLineItemType> EventLineItem
        {
            get
            {
                return _eventLineItem;
            }
            set
            {
                _eventLineItem = value;
            }
        }
    }
}