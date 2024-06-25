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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Sales Item. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe information related to an item in a sales context</ccts:Definition><ccts:ObjectClass>Sales Item</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("SalesItemType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("SalesItem", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SalesItemType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Sales Item. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity the given information are related to</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Sales Item</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ActivityPropertyType> _activityProperty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Sales Item. Activity Property</ccts:DictionaryEntryName><ccts:Definition>A class to describe the activity (for example "sales", "movement", ...) related to the item.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Sales Item</ccts:ObjectClass><ccts:PropertyTerm>Activity Property</ccts:PropertyTerm><ccts:AssociatedObjectClass>Activity Property</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Activity Property</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ActivityProperty")]
        public List<ActivityPropertyType> ActivityProperty
        {
            get
            {
                return _activityProperty;
            }
            set
            {
                _activityProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ActivityProperty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ActivityProperty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ActivityPropertySpecified
        {
            get
            {
                return ((this.ActivityProperty != null) 
                            && (this.ActivityProperty.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PriceType> _taxExclusivePrice;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Sales Item. Tax Exclusive_ Price. Price</ccts:DictionaryEntryName><ccts:Definition>A price for this sales item, exclusive of tax.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Sales Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Tax Exclusive</ccts:PropertyTermQualifier><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TaxExclusivePrice")]
        public List<PriceType> TaxExclusivePrice
        {
            get
            {
                return _taxExclusivePrice;
            }
            set
            {
                _taxExclusivePrice = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TaxExclusivePrice-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TaxExclusivePrice collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxExclusivePriceSpecified
        {
            get
            {
                return ((this.TaxExclusivePrice != null) 
                            && (this.TaxExclusivePrice.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PriceType> _taxInclusivePrice;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Sales Item. Tax Inclusive_ Price. Price</ccts:DictionaryEntryName><ccts:Definition>A price for this sales item, including tax.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Sales Item</ccts:ObjectClass><ccts:PropertyTermQualifier>Tax Inclusive</ccts:PropertyTermQualifier><ccts:PropertyTerm>Price</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TaxInclusivePrice")]
        public List<PriceType> TaxInclusivePrice
        {
            get
            {
                return _taxInclusivePrice;
            }
            set
            {
                _taxInclusivePrice = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TaxInclusivePrice-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TaxInclusivePrice collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxInclusivePriceSpecified
        {
            get
            {
                return ((this.TaxInclusivePrice != null) 
                            && (this.TaxInclusivePrice.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Sales Item. Item</ccts:DictionaryEntryName><ccts:Definition>The sales item itself.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Sales Item</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Item")]
        public ItemType Item { get; set; }
    }
}
