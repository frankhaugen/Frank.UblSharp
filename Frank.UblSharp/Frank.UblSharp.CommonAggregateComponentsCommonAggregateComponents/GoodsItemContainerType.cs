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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item Container. Details</ccts:DictionaryEntryName><ccts:Definition>A class defining how goods items are split across transport equipment.</ccts:Definition><ccts:ObjectClass>Goods Item Container</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("GoodsItemContainerType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("GoodsItemContainer", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class GoodsItemContainerType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item Container. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this goods item container.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Goods Item Container</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item Container. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of goods items loaded into or onto one piece of transport equipment as a total consignment or part of a consignment.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Goods Item Container</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Number of packages stuffed</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentType> _transportEquipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Goods Item Container. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>A piece of transport equipment used to contain a single goods item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Goods Item Container</ccts:ObjectClass><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportEquipment")]
        public List<TransportEquipmentType> TransportEquipment
        {
            get
            {
                return _transportEquipment;
            }
            set
            {
                _transportEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportEquipmentSpecified
        {
            get
            {
                return ((this.TransportEquipment != null) 
                            && (this.TransportEquipment.Count != 0));
            }
        }
    }
}