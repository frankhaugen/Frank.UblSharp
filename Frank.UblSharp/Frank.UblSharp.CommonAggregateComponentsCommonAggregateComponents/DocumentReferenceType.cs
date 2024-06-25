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
    [XmlTypeAttribute("DocumentReferenceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AdditionalDocumentReference))]
    [XmlIncludeAttribute(typeof(CallForTendersDocumentReference))]
    [XmlIncludeAttribute(typeof(CatalogueDocumentReference))]
    [XmlIncludeAttribute(typeof(ContractDocumentReference))]
    [XmlIncludeAttribute(typeof(ContractualDocumentReference))]
    [XmlIncludeAttribute(typeof(CreditNoteDocumentReference))]
    [XmlIncludeAttribute(typeof(DebitNoteDocumentReference))]
    [XmlIncludeAttribute(typeof(DespatchDocumentReference))]
    [XmlIncludeAttribute(typeof(DocumentReference))]
    [XmlIncludeAttribute(typeof(EmploymentLegislationDocumentReference))]
    [XmlIncludeAttribute(typeof(EnvironmentalLegislationDocumentReference))]
    [XmlIncludeAttribute(typeof(EvidenceDocumentReference))]
    [XmlIncludeAttribute(typeof(FiscalLegislationDocumentReference))]
    [XmlIncludeAttribute(typeof(GuaranteeDocumentReference))]
    [XmlIncludeAttribute(typeof(GuidanceDocumentReference))]
    [XmlIncludeAttribute(typeof(IdentityDocumentReference))]
    [XmlIncludeAttribute(typeof(InvoiceDocumentReference))]
    [XmlIncludeAttribute(typeof(ItemSpecificationDocumentReference))]
    [XmlIncludeAttribute(typeof(LegalDocumentReference))]
    [XmlIncludeAttribute(typeof(MandateDocumentReference))]
    [XmlIncludeAttribute(typeof(MinutesDocumentReference))]
    [XmlIncludeAttribute(typeof(NoticeDocumentReference))]
    [XmlIncludeAttribute(typeof(OrderDocumentReference))]
    [XmlIncludeAttribute(typeof(OriginalDocumentReference))]
    [XmlIncludeAttribute(typeof(OriginatorDocumentReference))]
    [XmlIncludeAttribute(typeof(ParentDocumentReference))]
    [XmlIncludeAttribute(typeof(PreviousDocumentReference))]
    [XmlIncludeAttribute(typeof(ProcurementLegislationDocumentReference))]
    [XmlIncludeAttribute(typeof(QuotationDocumentReference))]
    [XmlIncludeAttribute(typeof(ReceiptDocumentReference))]
    [XmlIncludeAttribute(typeof(RegistryCertificateDocumentReference))]
    [XmlIncludeAttribute(typeof(ReminderDocumentReference))]
    [XmlIncludeAttribute(typeof(ReplacedNoticeDocumentReference))]
    [XmlIncludeAttribute(typeof(RequestedDocumentReference))]
    [XmlIncludeAttribute(typeof(RequestForQuotationDocumentReference))]
    [XmlIncludeAttribute(typeof(ResolutionDocumentReference))]
    [XmlIncludeAttribute(typeof(SelfBilledCreditNoteDocumentReference))]
    [XmlIncludeAttribute(typeof(SelfBilledInvoiceDocumentReference))]
    [XmlIncludeAttribute(typeof(ShipmentDocumentReference))]
    [XmlIncludeAttribute(typeof(StatementDocumentReference))]
    [XmlIncludeAttribute(typeof(SupportingDocumentReference))]
    [XmlIncludeAttribute(typeof(TechnicalDocumentReference))]
    [XmlIncludeAttribute(typeof(TemplateDocumentReference))]
    [XmlIncludeAttribute(typeof(TenderDocumentReference))]
    [XmlIncludeAttribute(typeof(TendererQualificationDocumentReference))]
    [XmlIncludeAttribute(typeof(TransportationStatusRequestDocumentReference))]
    [XmlIncludeAttribute(typeof(TransportExecutionPlanDocumentReference))]
    [XmlIncludeAttribute(typeof(TransportExecutionPlanRequestDocumentReference))]
    [XmlIncludeAttribute(typeof(TransportProgressStatusRequestDocumentReference))]
    [XmlIncludeAttribute(typeof(TransportServiceDescriptionDocumentReference))]
    [XmlIncludeAttribute(typeof(TransportServiceDescriptionRequestDocumentReference))]
    [XmlIncludeAttribute(typeof(WorkOrderDocumentReference))]
    public partial class DocumentReferenceType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the referenced document.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>PO-001 3333-44-123 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Copy_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that the referenced document is a copy (true) or the original (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Copy</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CopyIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CopyIndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. UUID. Identifier</ccts:DictionaryEntryName><ccts:Definition>A universally unique identifier for this document reference.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>UUID</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UUID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UuidType Uuid { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Issue Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date, assigned by the sender of the referenced document, on which the document was issued.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Issue Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IssueDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IssueDateType IssueDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Issue Time. Time</ccts:DictionaryEntryName><ccts:Definition>The time, assigned by the sender of the referenced document, at which the document was issued.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Issue Time</ccts:PropertyTerm><ccts:RepresentationTerm>Time</ccts:RepresentationTerm><ccts:DataType>Time. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IssueTime", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IssueTimeType IssueTime { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Document Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of document being referenced, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Document Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DocumentTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentTypeCodeType DocumentTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Document Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of document being referenced, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Document Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DocumentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentTypeType DocumentType { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.XPathType> _xPath;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. XPath. Text</ccts:DictionaryEntryName><ccts:Definition>A reference to another place in the same XML document instance in which DocumentReference appears.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>XPath</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("XPath", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.XPathType> XPath
        {
            get
            {
                return _xPath;
            }
            set
            {
                _xPath = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die XPath-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the XPath collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool XPathSpecified
        {
            get
            {
                return ((this.XPath != null) 
                            && (this.XPath.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Language. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the language used in the referenced document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Language</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LanguageID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LanguageIdType LanguageId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Locale Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the locale in which the language in the referenced document is used.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Locale Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LocaleCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LocaleCodeType LocaleCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Version. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the current version of the referenced document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Version</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>1.1 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("VersionID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.VersionIdType VersionId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Document Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the status of the reference document with respect to its original state.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Document Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Document Status</ccts:DataTypeQualifier><ccts:DataType>Document Status_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DocumentStatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentStatusCodeType DocumentStatusCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentDescriptionType> _documentDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Document_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the referenced document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Document</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>stock no longer provided </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentDescriptionType> DocumentDescription
        {
            get
            {
                return _documentDescription;
            }
            set
            {
                _documentDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentDescriptionSpecified
        {
            get
            {
                return ((this.DocumentDescription != null) 
                            && (this.DocumentDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Attachment</ccts:DictionaryEntryName><ccts:Definition>The referenced document as an attachment to the document from which it is referenced.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Attachment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Attachment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Attachment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Attachment")]
        public AttachmentType Attachment { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period for which this document reference is valid.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ValidityPeriod")]
        public PeriodType ValidityPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Issuer_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>The party who issued the referenced document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Issuer</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("IssuerParty")]
        public PartyType IssuerParty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Reference. Result Of Verification</ccts:DictionaryEntryName><ccts:Definition>The result of an attempt to verify a signature associated with the referenced document.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Document Reference</ccts:ObjectClass><ccts:PropertyTerm>Result Of Verification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Result Of Verification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Result Of Verification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ResultOfVerification")]
        public ResultOfVerificationType ResultOfVerification { get; set; }
    }
}
