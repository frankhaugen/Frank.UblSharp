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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorser Party. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the party endorsing a document.</ccts:Definition><ccts:ObjectClass>Endorser Party</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("EndorserPartyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("EndorserParty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class EndorserPartyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorser Party. Role Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code specifying the role of the party providing the endorsement (e.g., issuer, embassy, insurance, etc.).</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Endorser Party</ccts:ObjectClass><ccts:PropertyTerm>Role Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("RoleCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RoleCodeType RoleCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorser Party. Sequence. Numeric</ccts:DictionaryEntryName><ccts:Definition>A number indicating the order of the endorsement provided by this party in the sequence in which endorsements are to be applied.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Endorser Party</ccts:ObjectClass><ccts:PropertyTerm>Sequence</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SequenceNumeric", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SequenceNumericType SequenceNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorser Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party endorsing the application.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Endorser Party</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Party")]
        public PartyType Party { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Endorser Party. Signatory_ Contact. Contact</ccts:DictionaryEntryName><ccts:Definition>The individual representing the exporter who signs the Certificate of Origin application before submitting it to the issuer party.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Endorser Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Signatory</ccts:PropertyTermQualifier><ccts:PropertyTerm>Contact</ccts:PropertyTerm><ccts:AssociatedObjectClass>Contact</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Contact</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("SignatoryContact")]
        public ContactType SignatoryContact { get; set; }
    }
}