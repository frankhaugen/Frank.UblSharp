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
    [XmlTypeAttribute("ActivityDataLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ActivityDataLine))]
    [XmlIncludeAttribute(typeof(SupplyChainActivityDataLine))]
    public partial class ActivityDataLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this activity data line.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Supply Chain Activity Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of supply chain activity.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTerm>Supply Chain Activity Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SupplyChainActivityTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SupplyChainActivityTypeCodeType SupplyChainActivityTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Buyer_ Customer Party. Customer Party</ccts:DictionaryEntryName><ccts:Definition>The buyer of the item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Buyer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customer Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customer Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customer Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BuyerCustomerParty")]
        public CustomerPartyType BuyerCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Seller_ Supplier Party. Supplier Party</ccts:DictionaryEntryName><ccts:Definition>The seller of the item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Seller</ccts:PropertyTermQualifier><ccts:PropertyTerm>Supplier Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SellerSupplierParty")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Activity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which the activity is realized.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Activity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActivityPeriod")]
        public PeriodType ActivityPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Activity Origin_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>Either the location where the movement of goods is observed or the location from which the goods are moved.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Activity Origin</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ActivityOriginLocation")]
        public LocationType ActivityOriginLocation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Activity Final_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>The location to which the goods are moved.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Activity Final</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ActivityFinalLocation")]
        public LocationType ActivityFinalLocation { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<SalesItemType> _salesItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Data Line. Sales Item</ccts:DictionaryEntryName><ccts:Definition>Sales information for an item to which this line applies.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Activity Data Line</ccts:ObjectClass><ccts:PropertyTerm>Sales Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Sales Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Sales Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SalesItem")]
        public List<SalesItemType> SalesItem
        {
            get
            {
                return _salesItem;
            }
            set
            {
                _salesItem = value;
            }
        }
    }
}
