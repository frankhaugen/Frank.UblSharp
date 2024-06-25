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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Pricing Update Line. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a line describing a pricing update to a catalogue line.</ccts:Definition><ccts:ObjectClass>Catalogue Pricing Update Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CataloguePricingUpdateLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("CataloguePricingUpdateLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CataloguePricingUpdateLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Pricing Update Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the catalogue line to be updated.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Catalogue Pricing Update Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>1 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Pricing Update Line. Contractor_ Customer Party. Customer Party</ccts:DictionaryEntryName><ccts:Definition>The customer responsible for the contract associated with the catalogue line being updated.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Pricing Update Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Contractor</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customer Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customer Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customer Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractorCustomerParty")]
        public CustomerPartyType ContractorCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Pricing Update Line. Seller_ Supplier Party. Supplier Party</ccts:DictionaryEntryName><ccts:Definition>The seller/supplier responsible for the contract associated with the catalogue line being updated.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Pricing Update Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Seller</ccts:PropertyTermQualifier><ccts:PropertyTerm>Supplier Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SellerSupplierParty")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemLocationQuantityType> _requiredItemLocationQuantity;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Pricing Update Line. Required_ Item Location Quantity. Item Location Quantity</ccts:DictionaryEntryName><ccts:Definition>Updated properties of the item in this catalogue line that are dependent on location and quantity.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Catalogue Pricing Update Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Required</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Location Quantity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Location Quantity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Location Quantity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("RequiredItemLocationQuantity")]
        public List<ItemLocationQuantityType> RequiredItemLocationQuantity
        {
            get
            {
                return _requiredItemLocationQuantity;
            }
            set
            {
                _requiredItemLocationQuantity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RequiredItemLocationQuantity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RequiredItemLocationQuantity collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RequiredItemLocationQuantitySpecified
        {
            get
            {
                return ((this.RequiredItemLocationQuantity != null) 
                            && (this.RequiredItemLocationQuantity.Count != 0));
            }
        }
    }
}
