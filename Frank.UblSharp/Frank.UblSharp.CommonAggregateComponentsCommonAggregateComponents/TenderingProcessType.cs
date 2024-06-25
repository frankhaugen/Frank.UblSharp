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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the process of a formal offer and response to execute work or supply goods at a stated price.</ccts:Definition><ccts:ObjectClass>Tendering Process</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TenderingProcessType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TenderingProcess", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderingProcessType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Original_ Contracting System. Identifier</ccts:DictionaryEntryName><ccts:Definition>When reopening a tendering process, the identifier of the original framework agreement or dynamic purchasing system.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Original</ccts:PropertyTermQualifier><ccts:PropertyTerm>Contracting System</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OriginalContractingSystemID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OriginalContractingSystemIdType OriginalContractingSystemId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
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
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Description-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NegotiationDescriptionType> _negotiationDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Negotiation_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the negotiation to be followed during the tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Negotiation</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NegotiationDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NegotiationDescriptionType> NegotiationDescription
        {
            get
            {
                return _negotiationDescription;
            }
            set
            {
                _negotiationDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NegotiationDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NegotiationDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NegotiationDescriptionSpecified
        {
            get
            {
                return ((this.NegotiationDescription != null) 
                            && (this.NegotiationDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Procedure Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this tendering procedure.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Procedure Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Open, Restricted, Negotiated</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProcedureCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcedureCodeType ProcedureCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Urgency Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the urgency of this tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Urgency Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Urgent, Normal, Emergency</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("UrgencyCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UrgencyCodeType UrgencyCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Expense Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of expense for this tendering process.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Expense Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Normal, Anticipated</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExpenseCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpenseCodeType ExpenseCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Part Presentation Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of presentation of tenders required (e.g., one lot, multiple lots, or all the lots).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Part Presentation Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>One Lot, Multiple Lots, All Lots</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PartPresentationCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PartPresentationCodeType PartPresentationCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Contracting System Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of contracting system (e.g., framework agreement, dynamic purchasing system). If the procedure is individual (nonrepetitive), this code should be omitted.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Contracting System Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Framework Agreement, Dynamic Purchasing System</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContractingSystemCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContractingSystemCodeType ContractingSystemCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Submission Method Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the method to be followed in submitting tenders.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Submission Method Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Manual, Electronically, etc.</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubmissionMethodCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubmissionMethodCodeType SubmissionMethodCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Candidate Reduction_ Constraint. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that the number of candidates participating in this process has been reduced (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Candidate Reduction</ccts:PropertyTermQualifier><ccts:PropertyTerm>Constraint</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CandidateReductionConstraintIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CandidateReductionConstraintIndicatorType CandidateReductionConstraintIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Government Agreement_ Constraint. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that the project associated with this tendering process is constrained by a government procurement agreement (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Government Agreement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Constraint</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("GovernmentAgreementConstraintIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GovernmentAgreementConstraintIndicatorType GovernmentAgreementConstraintIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Document Availability_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which documents relating to this tendering process must be completed.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Document Availability</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("DocumentAvailabilityPeriod")]
        public PeriodType DocumentAvailabilityPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Tender Submission Deadline_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which tenders must be delivered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Tender Submission Deadline</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TenderSubmissionDeadlinePeriod")]
        public PeriodType TenderSubmissionDeadlinePeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Invitation Submission_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which invitations to tender must be completed and delivered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Invitation Submission</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("InvitationSubmissionPeriod")]
        public PeriodType InvitationSubmissionPeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Participation Request Reception_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which requests for participation must be completed and delivered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Participation Request Reception</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ParticipationRequestReceptionPeriod")]
        public PeriodType ParticipationRequestReceptionPeriod { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _noticeDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Notice_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a notice pertaining to this tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Notice</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NoticeDocumentReference")]
        public List<DocumentReferenceType> NoticeDocumentReference
        {
            get
            {
                return _noticeDocumentReference;
            }
            set
            {
                _noticeDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NoticeDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NoticeDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NoticeDocumentReferenceSpecified
        {
            get
            {
                return ((this.NoticeDocumentReference != null) 
                            && (this.NoticeDocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _additionalDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Additional_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to an additional document.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalDocumentReference")]
        public List<DocumentReferenceType> AdditionalDocumentReference
        {
            get
            {
                return _additionalDocumentReference;
            }
            set
            {
                _additionalDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalDocumentReferenceSpecified
        {
            get
            {
                return ((this.AdditionalDocumentReference != null) 
                            && (this.AdditionalDocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ProcessJustificationType> _processJustification;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Process Justification</ccts:DictionaryEntryName><ccts:Definition>A justification for the selection of this tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Process Justification</ccts:PropertyTerm><ccts:AssociatedObjectClass>Process Justification</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Process Justification</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProcessJustification")]
        public List<ProcessJustificationType> ProcessJustification
        {
            get
            {
                return _processJustification;
            }
            set
            {
                _processJustification = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ProcessJustification-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ProcessJustification collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ProcessJustificationSpecified
        {
            get
            {
                return ((this.ProcessJustification != null) 
                            && (this.ProcessJustification.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Economic Operator Short List</ccts:DictionaryEntryName><ccts:Definition>A set of criteria used to create a short list of candidates.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Economic Operator Short List</ccts:PropertyTerm><ccts:AssociatedObjectClass>Economic Operator Short List</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Economic Operator Short List</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EconomicOperatorShortList")]
        public EconomicOperatorShortListType EconomicOperatorShortList { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<EventType> _openTenderEvent;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Open Tender_ Event. Event</ccts:DictionaryEntryName><ccts:Definition>Textual description of the legal form required for potential tenderers.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTermQualifier>Open Tender</ccts:PropertyTermQualifier><ccts:PropertyTerm>Event</ccts:PropertyTerm><ccts:AssociatedObjectClass>Event</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Event</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("OpenTenderEvent")]
        public List<EventType> OpenTenderEvent
        {
            get
            {
                return _openTenderEvent;
            }
            set
            {
                _openTenderEvent = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OpenTenderEvent-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OpenTenderEvent collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool OpenTenderEventSpecified
        {
            get
            {
                return ((this.OpenTenderEvent != null) 
                            && (this.OpenTenderEvent.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Auction Terms</ccts:DictionaryEntryName><ccts:Definition>The terms to be fulfilled by tenderers if an auction is to be executed before the awarding of a tender.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Auction Terms</ccts:PropertyTerm><ccts:AssociatedObjectClass>Auction Terms</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Auction Terms</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AuctionTerms")]
        public AuctionTermsType AuctionTerms { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendering Process. Framework Agreement</ccts:DictionaryEntryName><ccts:Definition>A tendering framework agreement.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendering Process</ccts:ObjectClass><ccts:PropertyTerm>Framework Agreement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Framework Agreement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Framework Agreement</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FrameworkAgreement")]
        public FrameworkAgreementType FrameworkAgreement { get; set; }
    }
}