//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.CertificateOfOrigin
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Details</ccts:DictionaryEntryName><ccts:Definition>A document that describes the Certificate of Origin.</ccts:Definition><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass></ccts:Component></para>
    /// <para>This element MUST be conveyed as the root element in any instance document based on this Schema expression</para>
    /// </summary>
    [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Details</ccts:DictionaryEntryName><ccts:Definition>A document that describes the Certificate of Origin.</ccts:Definition><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass></ccts:Component> This element MUST be conveyed as the root element in any instance document based on this Schema expression")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CertificateOfOriginType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CertificateOfOrigin-2")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("CertificateOfOrigin", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CertificateOfOrigin-2")]
    public partial class CertificateOfOriginType
    {
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonExtensionComponentsCommonExtensionComponents.UblExtensionType> _ublExtensions;
        
        /// <summary>
        /// <para>A container for all extensions present in the document.</para>
        /// </summary>
        [DescriptionAttribute("A container for all extensions present in the document.")]
        [XmlArrayAttribute("UBLExtensions", Order=0, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        [XmlArrayItemAttribute("UBLExtension", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
        public List<Frank.UblSharp.CommonExtensionComponentsCommonExtensionComponents.UblExtensionType> UblExtensions
        {
            get
            {
                return _ublExtensions;
            }
            set
            {
                _ublExtensions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UblExtensions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool UblExtensionsSpecified
        {
            get
            {
                return ((this.UblExtensions != null) 
                            && (this.UblExtensions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. UBL Version Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>UBL Version Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>2.0.5</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. UBL Version Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies the earliest version of the UBL 2 schema for this document type that defines all of the elements that might be encountered in the current instance.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>UBL Version Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>2.0.5</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UBLVersionID", Order=1, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UblVersionIdType UblVersionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Customization Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined customization of UBL for a specific use.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Customization Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>NES</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Customization Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined customization of UBL for a specific use.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Customization Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>NES</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CustomizationID", Order=2, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomizationIdType CustomizationId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Profile Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined profile of the customization of UBL being used.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Profile Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BasicProcurementProcess</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Profile Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies a user-defined profile of the customization of UBL being used.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Profile Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BasicProcurementProcess</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProfileID", Order=3, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProfileIdType ProfileId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Profile Execution Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies an instance of executing a profile, to associate all transactions in a collaboration.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Profile Execution Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BPP-1001</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Profile Execution Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies an instance of executing a profile, to associate all transactions in a collaboration.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Profile Execution Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>BPP-1001</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProfileExecutionID", Order=4, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProfileExecutionIdType ProfileExecutionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this document, assigned by the sender.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this document, assigned by the sender.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Order=5, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [KeyAttribute()]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for an instance of this document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for an instance of this document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UUID", Order=6, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Issue Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date, assigned by the sender, on which this document was issued.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Issue Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Issue Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date, assigned by the sender, on which this document was issued.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Issue Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IssueDate", Order=7, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IssueDateType IssueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Issue Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time, assigned by the sender, at which this document was issued.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Issue Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Issue Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time, assigned by the sender, at which this document was issued.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Issue Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IssueTime", Order=8, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IssueTimeType IssueTime { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Textual description of the document instance.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Textual description of the document instance.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("Description", Order=9, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> _note;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Note. Text</ccts:DictionaryEntryName><ccts:Definition>Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Note</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("Note", Order=10, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NoteType> Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Note collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool NoteSpecified
        {
            get
            {
                return ((this.Note != null) 
                            && (this.Note.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Version. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies the version of this Certificate of Origin.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Version</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Version. Identifier</ccts:DictionaryEntryName><ccts:Definition>Identifies the version of this Certificate of Origin.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Version</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("VersionID", Order=11, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.VersionIdType VersionId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.SignatureType> _signature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Signature</ccts:DictionaryEntryName><ccts:Definition>A signature applied to this document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Signature</ccts:DictionaryEntryName><ccts:Definition>A signature applied to this document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("Signature", Order=12, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.SignatureType> Signature
        {
            get
            {
                return _signature;
            }
            set
            {
                _signature = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Signature collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SignatureSpecified
        {
            get
            {
                return ((this.Signature != null) 
                            && (this.Signature.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Exporter_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The Party who makes the export declaration, or on whose behalf the export declaration is made, and who is the owner of the goods or has similar right of disposal over them at the time when the declaration is accepted.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Exporter</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Exporter (WCO ID 41 and 42)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Exporter_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The Party who makes the export declaration, or on whose behalf the export declaration is made, and who is the owner of the goods or has similar right of disposal over them at the time when the declaration is accepted.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Exporter</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Exporter (WCO ID 41 and 42)</ccts:AlternativeBusinessTerms></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExporterParty", Order=13, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.PartyType ExporterParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Importer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The Party who makes an import declaration, or on whose behalf a Customs clearing agent or other authorized person makes an import declaration. This may include a person who has possession of the goods or to whom the goods are consigned.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Importer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Importer (WCO ID 39 and 40)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Importer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The Party who makes an import declaration, or on whose behalf a Customs clearing agent or other authorized person makes an import declaration. This may include a person who has possession of the goods or to whom the goods are consigned.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Importer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Importer (WCO ID 39 and 40)</ccts:AlternativeBusinessTerms></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ImporterParty", Order=14, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.PartyType ImporterParty { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.EndorserPartyType> _endorserParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Endorser Party</ccts:DictionaryEntryName><ccts:Definition>The Party providing the endorsement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Endorser Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorser Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorser Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Endorser Party</ccts:DictionaryEntryName><ccts:Definition>The Party providing the endorsement.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Endorser Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorser Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorser Party</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("EndorserParty", Order=15, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public List<Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.EndorserPartyType> EndorserParty
        {
            get
            {
                return _endorserParty;
            }
            set
            {
                _endorserParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the EndorserParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool EndorserPartySpecified
        {
            get
            {
                return ((this.EndorserParty != null) 
                            && (this.EndorserParty.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Certificate Of Origin Application</ccts:DictionaryEntryName><ccts:Definition>Details of the application for a Certificate of Origin.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Certificate Of Origin Application</ccts:PropertyTerm><ccts:AssociatedObjectClass>Certificate Of Origin Application</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Certificate Of Origin Application</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Certificate Of Origin Application</ccts:DictionaryEntryName><ccts:Definition>Details of the application for a Certificate of Origin.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTerm>Certificate Of Origin Application</ccts:PropertyTerm><ccts:AssociatedObjectClass>Certificate Of Origin Application</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Certificate Of Origin Application</ccts:RepresentationTerm></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("CertificateOfOriginApplication", Order=16, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.CertificateOfOriginApplicationType CertificateOfOriginApplication { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Issuer_ Endorsement. Endorsement</ccts:DictionaryEntryName><ccts:Definition>Issuer Endorsement details.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Issuer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Endorsement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorsement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorsement</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Issuer_ Endorsement. Endorsement</ccts:DictionaryEntryName><ccts:Definition>Issuer Endorsement details.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Issuer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Endorsement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorsement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorsement</ccts:RepresentationTerm></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("IssuerEndorsement", Order=17, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.EndorsementType IssuerEndorsement { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Embassy_ Endorsement. Endorsement</ccts:DictionaryEntryName><ccts:Definition>Embassy Endorsement details.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Embassy</ccts:PropertyTermQualifier><ccts:PropertyTerm>Endorsement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorsement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorsement</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Embassy_ Endorsement. Endorsement</ccts:DictionaryEntryName><ccts:Definition>Embassy Endorsement details.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Embassy</ccts:PropertyTermQualifier><ccts:PropertyTerm>Endorsement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorsement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorsement</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmbassyEndorsement", Order=18, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.EndorsementType EmbassyEndorsement { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Insurance_ Endorsement. Endorsement</ccts:DictionaryEntryName><ccts:Definition>Insurance Endorsement details.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Insurance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Endorsement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorsement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorsement</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin. Insurance_ Endorsement. Endorsement</ccts:DictionaryEntryName><ccts:Definition>Insurance Endorsement details.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin</ccts:ObjectClass><ccts:PropertyTermQualifier>Insurance</ccts:PropertyTermQualifier><ccts:PropertyTerm>Endorsement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorsement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorsement</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InsuranceEndorsement", Order=19, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents.EndorsementType InsuranceEndorsement { get; set; }
    }
}
