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
    [XmlTypeAttribute("AttachmentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(Attachment))]
    [XmlIncludeAttribute(typeof(DigitalSignatureAttachment))]
    public partial class AttachmentType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Attachment. Embedded_ Document. Binary Object</ccts:DictionaryEntryName><ccts:Definition>A binary large object containing an attached document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Attachment</ccts:ObjectClass><ccts:PropertyTermQualifier>Embedded</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document</ccts:PropertyTerm><ccts:RepresentationTerm>Binary Object</ccts:RepresentationTerm><ccts:DataType>Binary Object. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmbeddedDocumentBinaryObject", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmbeddedDocumentBinaryObjectType EmbeddedDocumentBinaryObject { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Attachment. External Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to an attached document that is external to the document(s) being exchanged.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Attachment</ccts:ObjectClass><ccts:PropertyTerm>External Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>External Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>External Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExternalReference")]
        public ExternalReferenceType ExternalReference { get; set; }
    }
}