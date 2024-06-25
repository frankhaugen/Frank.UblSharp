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
    [XmlTypeAttribute("TenderedProjectType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(AwardedTenderedProject))]
    [XmlIncludeAttribute(typeof(TenderedProject))]
    public partial class TenderedProjectType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Variant. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this variant of a tendered project.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Variant</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("VariantID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.VariantIdType VariantId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Fee. Amount</ccts:DictionaryEntryName><ccts:Definition>The fee amount for tendered projects.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Fee</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FeeAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FeeAmountType FeeAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FeeDescriptionType> _feeDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Fee_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the fee amount for tendered projects.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Fee</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("FeeDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FeeDescriptionType> FeeDescription
        {
            get
            {
                return _feeDescription;
            }
            set
            {
                _feeDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FeeDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FeeDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool FeeDescriptionSpecified
        {
            get
            {
                return ((this.FeeDescription != null) 
                            && (this.FeeDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Tender Envelope Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the tender envelope this tendered project belongs to.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Tender Envelope Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TenderEnvelopeID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderEnvelopeIdType TenderEnvelopeId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Tender Envelope Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of tender envelope this tendered project belongs to.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Tender Envelope Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TenderEnvelopeTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Procurement Project Lot</ccts:DictionaryEntryName><ccts:Definition>The procurement project lot to which this Tender Line refers to. If there are no lots, this should not be defined.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Procurement Project Lot</ccts:PropertyTerm><ccts:AssociatedObjectClass>Procurement Project Lot</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Procurement Project Lot</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProcurementProjectLot")]
        public ProcurementProjectLotType ProcurementProjectLot { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _evidenceDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Evidence_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a non-structured evidentiary document supporting this tendered project.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Evidence</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("EvidenceDocumentReference")]
        public List<DocumentReferenceType> EvidenceDocumentReference
        {
            get
            {
                return _evidenceDocumentReference;
            }
            set
            {
                _evidenceDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EvidenceDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EvidenceDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool EvidenceDocumentReferenceSpecified
        {
            get
            {
                return ((this.EvidenceDocumentReference != null) 
                            && (this.EvidenceDocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TaxTotalType> _taxTotal;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Tax Total</ccts:DictionaryEntryName><ccts:Definition>A total amount of taxes of a particular kind applicable to the monetary total for this tendered project.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Tax Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Total</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TaxTotal")]
        public List<TaxTotalType> TaxTotal
        {
            get
            {
                return _taxTotal;
            }
            set
            {
                _taxTotal = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TaxTotal-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TaxTotal collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxTotalSpecified
        {
            get
            {
                return ((this.TaxTotal != null) 
                            && (this.TaxTotal.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Legal_ Monetary Total. Monetary Total</ccts:DictionaryEntryName><ccts:Definition>The total amount for this tendered project.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTermQualifier>Legal</ccts:PropertyTermQualifier><ccts:PropertyTerm>Monetary Total</ccts:PropertyTerm><ccts:AssociatedObjectClass>Monetary Total</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Monetary Total</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LegalMonetaryTotal")]
        public MonetaryTotalType LegalMonetaryTotal { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TenderLineType> _tenderLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Tender Line</ccts:DictionaryEntryName><ccts:Definition>A line in the tender for this tendered project.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Tender Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tender Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tender Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TenderLine")]
        public List<TenderLineType> TenderLine
        {
            get
            {
                return _tenderLine;
            }
            set
            {
                _tenderLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TenderLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TenderLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TenderLineSpecified
        {
            get
            {
                return ((this.TenderLine != null) 
                            && (this.TenderLine.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<AwardingCriterionResponseType> _awardingCriterionResponse;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tendered Project. Awarding Criterion Response</ccts:DictionaryEntryName><ccts:Definition>An association to an Awarding Criterion Response.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tendered Project</ccts:ObjectClass><ccts:PropertyTerm>Awarding Criterion Response</ccts:PropertyTerm><ccts:AssociatedObjectClass>Awarding Criterion Response</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Awarding Criterion Response</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AwardingCriterionResponse")]
        public List<AwardingCriterionResponseType> AwardingCriterionResponse
        {
            get
            {
                return _awardingCriterionResponse;
            }
            set
            {
                _awardingCriterionResponse = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AwardingCriterionResponse-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AwardingCriterionResponse collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AwardingCriterionResponseSpecified
        {
            get
            {
                return ((this.AwardingCriterionResponse != null) 
                            && (this.AwardingCriterionResponse.Count != 0));
            }
        }
    }
}
