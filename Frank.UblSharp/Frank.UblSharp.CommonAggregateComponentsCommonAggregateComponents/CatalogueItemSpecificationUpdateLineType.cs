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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Item Specification Update Line. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a line describing the transaction that updates the specification of an item in a catalogue.</ccts:Definition><ccts:ObjectClass>Catalogue Item Specification Update Line</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CatalogueItemSpecificationUpdateLineType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("CatalogueItemSpecificationUpdateLine", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CatalogueItemSpecificationUpdateLineType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Item Specification Update Line. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the line to be updated in a catalogue.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Catalogue Item Specification Update Line</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>1 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Item Specification Update Line. Contractor_ Customer Party. Customer Party</ccts:DictionaryEntryName><ccts:Definition>The customer responsible for the contract associated with the catalogue item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Item Specification Update Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Contractor</ccts:PropertyTermQualifier><ccts:PropertyTerm>Customer Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customer Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customer Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractorCustomerParty")]
        public CustomerPartyType ContractorCustomerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Item Specification Update Line. Seller_ Supplier Party. Supplier Party</ccts:DictionaryEntryName><ccts:Definition>The seller/supplier responsible for the contract associated with the catalogue item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Catalogue Item Specification Update Line</ccts:ObjectClass><ccts:PropertyTermQualifier>Seller</ccts:PropertyTermQualifier><ccts:PropertyTerm>Supplier Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Supplier Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Supplier Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SellerSupplierParty")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Catalogue Item Specification Update Line. Item</ccts:DictionaryEntryName><ccts:Definition>The catalogue item to be updated.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Catalogue Item Specification Update Line</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Item")]
        public ItemType Item { get; set; }
    }
}
