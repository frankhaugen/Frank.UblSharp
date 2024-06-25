//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.SignatureAggregateComponentsSignatureAggregateComponents
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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Signature Information. Details</ccts:DictionaryEntryName><ccts:Definition>This class captures a single signature and optionally associates to a signature in the document with the corresponding identifier.</ccts:Definition><ccts:ObjectClass>Signature Information</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("SignatureInformationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
    [XmlRootAttribute("SignatureInformation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureAggregateComponents-2")]
    public partial class SignatureInformationType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Signature Information. Identifier</ccts:DictionaryEntryName><ccts:Definition>This specifies the identifier of the signature distinguishing it from other signatures.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Signature Information</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Signature Information. Referenced Signature Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>This associates this signature with the identifier of a signature business object in the document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Signature Information</ccts:ObjectClass><ccts:PropertyTerm>Referenced Signature Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReferencedSignatureID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:SignatureBasicComponents-2")]
        public Frank.UblSharp.SignatureBasicComponentsSignatureBasicComponents.ReferencedSignatureIdType ReferencedSignatureId { get; set; }
        
        /// <summary>
        /// <para>This is a single digital signature as defined by the W3C specification.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public Frank.UblSharp.CoreComponentTypes.SignatureType Signature { get; set; }
    }
}
