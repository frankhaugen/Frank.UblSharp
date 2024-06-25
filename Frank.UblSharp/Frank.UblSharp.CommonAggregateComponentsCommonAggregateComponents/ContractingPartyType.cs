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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Contracting Party. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe an individual, a group, or a body having a procurement role in a tendering process.</ccts:Definition><ccts:ObjectClass>Contracting Party</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("ContractingPartyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ContractingParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ContractingPartyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contracting Party. Buyer Profile_ URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The buyer profile is typically located on a web site where the contracting party publishes its procurement opportunities</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Contracting Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Buyer Profile</ccts:PropertyTermQualifier><ccts:PropertyTerm>URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Buyer Profile</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BuyerProfileURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BuyerProfileUriType BuyerProfileUri { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ContractingPartyTypeType> _contractingPartyTypeProperty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contracting Party. Contracting Party Type</ccts:DictionaryEntryName><ccts:Definition>The type of contracting party that is independent of its role.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Contracting Party</ccts:ObjectClass><ccts:PropertyTerm>Contracting Party Type</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contracting Party Type</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contracting Party Type</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContractingPartyType")]
        public List<ContractingPartyTypeType> ContractingPartyTypeProperty
        {
            get
            {
                return _contractingPartyTypeProperty;
            }
            set
            {
                _contractingPartyTypeProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContractingPartyTypeProperty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContractingPartyTypeProperty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContractingPartyTypePropertySpecified
        {
            get
            {
                return ((this.ContractingPartyTypeProperty != null) 
                            && (this.ContractingPartyTypeProperty.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ContractingActivityType> _contractingActivity;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contracting Party. Contracting Activity</ccts:DictionaryEntryName><ccts:Definition>The nature of the type of business of the organization</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Contracting Party</ccts:ObjectClass><ccts:PropertyTerm>Contracting Activity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contracting Activity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contracting Activity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContractingActivity")]
        public List<ContractingActivityType> ContractingActivity
        {
            get
            {
                return _contractingActivity;
            }
            set
            {
                _contractingActivity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContractingActivity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContractingActivity collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContractingActivitySpecified
        {
            get
            {
                return ((this.ContractingActivity != null) 
                            && (this.ContractingActivity.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Contracting Party. Party</ccts:DictionaryEntryName><ccts:Definition>The contracting party itself.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Contracting Party</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Party")]
        public PartyType Party {get;set;}
    }
}
