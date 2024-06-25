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
    [XmlTypeAttribute("CustomerPartyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AccountingCustomerParty))]
    [XmlIncludeAttribute(typeof(BuyerCustomerParty))]
    [XmlIncludeAttribute(typeof(ContractorCustomerParty))]
    [XmlIncludeAttribute(typeof(CustomerParty))]
    [XmlIncludeAttribute(typeof(DeliveryCustomerParty))]
    [XmlIncludeAttribute(typeof(OriginatorCustomerParty))]
    [XmlIncludeAttribute(typeof(RecipientCustomerParty))]
    [XmlIncludeAttribute(typeof(RetailerCustomerParty))]
    public partial class CustomerPartyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Customer Party. Customer Assigned_ Account Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the customer's account, assigned by the customer itself.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Customer Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Customer Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Account Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CustomerAssignedAccountID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomerAssignedAccountIdType CustomerAssignedAccountId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Customer Party. Supplier Assigned_ Account Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the customer's account, assigned by the supplier.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Customer Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Supplier Assigned</ccts:PropertyTermQualifier><ccts:PropertyTerm>Account Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SupplierAssignedAccountID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SupplierAssignedAccountIdType SupplierAssignedAccountId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalAccountIdType> _additionalAccountId;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Customer Party. Additional_ Account Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the customer's account, assigned by a third party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Customer Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Account Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalAccountID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdditionalAccountIdType> AdditionalAccountId
        {
            get
            {
                return _additionalAccountId;
            }
            set
            {
                _additionalAccountId = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalAccountId-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalAccountId collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalAccountIdSpecified
        {
            get
            {
                return ((this.AdditionalAccountId != null) 
                            && (this.AdditionalAccountId.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Customer Party. Party</ccts:DictionaryEntryName><ccts:Definition>The customer party itself.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Customer Party</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Party")]
        public PartyType Party { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Customer Party. Delivery_ Contact. Contact</ccts:DictionaryEntryName><ccts:Definition>A customer contact for deliveries.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Customer Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivery</ccts:PropertyTermQualifier><ccts:PropertyTerm>Contact</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contact</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contact</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DeliveryContact")]
        public ContactType DeliveryContact { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Customer Party. Accounting_ Contact. Contact</ccts:DictionaryEntryName><ccts:Definition>A customer contact for accounting.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Customer Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Accounting</ccts:PropertyTermQualifier><ccts:PropertyTerm>Contact</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contact</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contact</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AccountingContact")]
        public ContactType AccountingContact { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Customer Party. Buyer_ Contact. Contact</ccts:DictionaryEntryName><ccts:Definition>A customer contact for purchasing.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Customer Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Buyer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Contact</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contact</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contact</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BuyerContact")]
        public ContactType BuyerContact { get; set; }
    }
}
