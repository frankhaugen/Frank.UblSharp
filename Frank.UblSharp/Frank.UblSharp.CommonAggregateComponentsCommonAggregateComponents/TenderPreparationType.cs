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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Preparation. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe directions for preparing a tender.</ccts:Definition><ccts:ObjectClass>Tender Preparation</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TenderPreparationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("TenderPreparation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class TenderPreparationType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Preparation. Tender Envelope Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the tender envelope to be used with the tender.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Tender Preparation</ccts:ObjectClass><ccts:PropertyTerm>Tender Envelope Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("TenderEnvelopeID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderEnvelopeIdType TenderEnvelopeId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Preparation. Tender Envelope Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of tender envelope (economical or objective criteria versus technical or subjective criteria).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Preparation</ccts:ObjectClass><ccts:PropertyTerm>Tender Envelope Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TenderEnvelopeTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderEnvelopeTypeCodeType TenderEnvelopeTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Preparation. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the tender envelope.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Preparation</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Preparation. Open Tender Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the open tender associated with this tender preparation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tender Preparation</ccts:ObjectClass><ccts:PropertyTerm>Open Tender Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OpenTenderID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OpenTenderIdType OpenTenderId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ProcurementProjectLotType> _procurementProjectLot;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Preparation. Procurement Project Lot</ccts:DictionaryEntryName><ccts:Definition>The procurement project lot associated with a particular tenderer.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Preparation</ccts:ObjectClass><ccts:PropertyTerm>Procurement Project Lot</ccts:PropertyTerm><ccts:AssociatedObjectClass>Procurement Project Lot</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Procurement Project Lot</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProcurementProjectLot")]
        public List<ProcurementProjectLotType> ProcurementProjectLot
        {
            get
            {
                return _procurementProjectLot;
            }
            set
            {
                _procurementProjectLot = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ProcurementProjectLot-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ProcurementProjectLot collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ProcurementProjectLotSpecified
        {
            get
            {
                return ((this.ProcurementProjectLot != null) 
                            && (this.ProcurementProjectLot.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TenderRequirementType> _documentTenderRequirement;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tender Preparation. Document_ Tender Requirement. Tender Requirement</ccts:DictionaryEntryName><ccts:Definition>A reference to the template for a required document in a tendering process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tender Preparation</ccts:ObjectClass><ccts:PropertyTermQualifier>Document</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tender Requirement</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tender Requirement</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tender Requirement</ccts:RepresentationTerm><ccts:Examples>Curricula required, Experience required, ....</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DocumentTenderRequirement")]
        public List<TenderRequirementType> DocumentTenderRequirement
        {
            get
            {
                return _documentTenderRequirement;
            }
            set
            {
                _documentTenderRequirement = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DocumentTenderRequirement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DocumentTenderRequirement collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DocumentTenderRequirementSpecified
        {
            get
            {
                return ((this.DocumentTenderRequirement != null) 
                            && (this.DocumentTenderRequirement.Count != 0));
            }
        }
    }
}