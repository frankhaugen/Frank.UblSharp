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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. Details</ccts:DictionaryEntryName><ccts:Definition>A class that refers to a phase of work. Used for instance to specify what part of the contract the billing is referring to.</ccts:Definition><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("WorkPhaseReferenceType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("WorkPhaseReference", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class WorkPhaseReferenceType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this phase of work.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. Work Phase Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying this phase of work.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass><ccts:PropertyTerm>Work Phase Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WorkPhaseCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WorkPhaseCodeType WorkPhaseCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WorkPhaseType> _workPhase;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. Work Phase. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this phase of work.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass><ccts:PropertyTerm>Work Phase</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("WorkPhase", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WorkPhaseType> WorkPhase
        {
            get
            {
                return _workPhase;
            }
            set
            {
                _workPhase = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die WorkPhase-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the WorkPhase collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WorkPhaseSpecified
        {
            get
            {
                return ((this.WorkPhase != null) 
                            && (this.WorkPhase.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. Progress Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The progress percentage of the work phase.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass><ccts:PropertyTerm>Progress Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProgressPercent", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProgressPercentType ProgressPercent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. Start Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this phase of work begins.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass><ccts:PropertyTerm>Start Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StartDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.StartDateType StartDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. End Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date on which this phase of work ends.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass><ccts:PropertyTerm>End Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EndDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EndDateType EndDate { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _workOrderDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Work Phase Reference. Work Order_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a document regarding the work order for the project in which this phase of work takes place.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Work Phase Reference</ccts:ObjectClass><ccts:PropertyTermQualifier>Work Order</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("WorkOrderDocumentReference")]
        public List<DocumentReferenceType> WorkOrderDocumentReference
        {
            get
            {
                return _workOrderDocumentReference;
            }
            set
            {
                _workOrderDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die WorkOrderDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the WorkOrderDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool WorkOrderDocumentReferenceSpecified
        {
            get
            {
                return ((this.WorkOrderDocumentReference != null) 
                            && (this.WorkOrderDocumentReference.Count != 0));
            }
        }
    }
}
