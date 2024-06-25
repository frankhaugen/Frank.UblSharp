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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define an application for a Certificate of Origin (CoO).</ccts:Definition><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CertificateOfOriginApplicationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("CertificateOfOriginApplication", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CertificateOfOriginApplicationType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Reference. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for a reference as part of the CoO application.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Reference</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ReferenceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReferenceIdType ReferenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Certificate Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of CoO being applied for (Ordinary, Re-export, Commonwealth Preferential, etc.).</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Certificate Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("CertificateType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CertificateTypeType CertificateType { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Application Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the status of the application (revision, replacement, etc.).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Application Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ApplicationStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ApplicationStatusCodeType ApplicationStatusCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Original_ Job Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>The latest job number given to the CoO application. This is used by the system to keep track of amendments to or cancellation of any earlier applications.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Original</ccts:PropertyTermQualifier><ccts:PropertyTerm>Job Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("OriginalJobID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OriginalJobIdType OriginalJobId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Previous_ Job Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the previous job used in case the application requires query or change.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous</ccts:PropertyTermQualifier><ccts:PropertyTerm>Job Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreviousJobID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousJobIdType PreviousJobId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RemarksType> _remarks;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Remarks. Text</ccts:DictionaryEntryName><ccts:Definition>Remarks by the applicant for the CoO.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Remarks</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Remarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RemarksType> Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Remarks-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Remarks collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool RemarksSpecified
        {
            get
            {
                return ((this.Remarks != null) 
                            && (this.Remarks.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Shipment</ccts:DictionaryEntryName><ccts:Definition>The shipment of goods covered by the CoO.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Shipment")]
        public ShipmentType Shipment { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EndorserPartyType> _endorserParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Endorser Party</ccts:DictionaryEntryName><ccts:Definition>A party providing an endorsement to the CoO.</ccts:Definition><ccts:Cardinality>1..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Endorser Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Endorser Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Endorser Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("EndorserParty")]
        public List<EndorserPartyType> EndorserParty
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Preparation_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party (individual, group, or body) that prepared this CoO application.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Preparation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PreparationParty")]
        public PartyType PreparationParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Issuer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The organization authorized to issue the CoO requested by this application.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Issuer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("IssuerParty")]
        public PartyType IssuerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Exporter_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party making an export declaration, or on behalf of which the export declaration is made, and that is the owner of the goods or has similar right of disposal over them at the time when the declaration is accepted.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Exporter</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Exporter (WCO ID 41 and 42)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExporterParty")]
        public PartyType ExporterParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Importer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party making an import declaration, or on behalf of which a customs clearing agent or other authorized person makes an import declaration. This may include a person who has possession of the goods or to whom the goods are consigned.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Importer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm><ccts:AlternativeBusinessTerms>Importer (WCO ID 39 and 40)</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ImporterParty")]
        public PartyType ImporterParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Issuing_ Country. Country</ccts:DictionaryEntryName><ccts:Definition>The country where the requested CoO will be issued.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Issuing</ccts:PropertyTermQualifier><ccts:PropertyTerm>Country</ccts:PropertyTerm><ccts:AssociatedObjectClass>Country</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Country</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("IssuingCountry")]
        public CountryType IssuingCountry { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentDistributionType> _documentDistribution;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Document Distribution</ccts:DictionaryEntryName><ccts:Definition>An interested party to which the CoO is to be distributed.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Document Distribution</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Distribution</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Distribution</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentDistribution")]
        public List<DocumentDistributionType> DocumentDistribution
        {
            get
            {
                return _documentDistribution;
            }
            set
            {
                _documentDistribution = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentDistribution-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentDistribution collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentDistributionSpecified
        {
            get
            {
                return ((this.DocumentDistribution != null) 
                            && (this.DocumentDistribution.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _supportingDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Supporting_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document supporting this application.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTermQualifier>Supporting</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("SupportingDocumentReference")]
        public List<DocumentReferenceType> SupportingDocumentReference
        {
            get
            {
                return _supportingDocumentReference;
            }
            set
            {
                _supportingDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SupportingDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SupportingDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SupportingDocumentReferenceSpecified
        {
            get
            {
                return ((this.SupportingDocumentReference != null) 
                            && (this.SupportingDocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<SignatureType> _signature;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Certificate Of Origin Application. Signature</ccts:DictionaryEntryName><ccts:Definition>A signature applied to this application.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Certificate Of Origin Application</ccts:ObjectClass><ccts:PropertyTerm>Signature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Signature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Signature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Signature")]
        public List<SignatureType> Signature
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
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Signature-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Signature collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool SignatureSpecified
        {
            get
            {
                return ((this.Signature != null) 
                            && (this.Signature.Count != 0));
            }
        }
    }
}
