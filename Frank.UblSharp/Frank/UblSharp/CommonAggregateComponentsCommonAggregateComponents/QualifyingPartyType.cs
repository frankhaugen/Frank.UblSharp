//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
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
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("QualifyingPartyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlIncludeAttribute(typeof(AdditionalQualifyingParty))]
    [XmlIncludeAttribute(typeof(MainQualifyingParty))]
    [XmlIncludeAttribute(typeof(QualifyingParty))]
    public partial class QualifyingPartyType
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Participation. Percent</ccts:DictionaryEntryName><ccts:Definition>The extent to which this party is expected to participate in the tendering process, expressed as a percentage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Participation</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Participation. Percent</ccts:DictionaryEntryName><ccts:Definition>The extent to which this party is expected to participate in the tendering process, expressed as a percentage.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Participation</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ParticipationPercent", Order=0, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ParticipationPercentType ParticipationPercent { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PersonalSituationType> _personalSituation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Personal Situation. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the personal situation of the qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Personal Situation</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Personal Situation. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the personal situation of the qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Personal Situation</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("PersonalSituation", Order=1, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PersonalSituationType> PersonalSituation
        {
            get
            {
                return _personalSituation;
            }
            set
            {
                _personalSituation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the PersonalSituation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool PersonalSituationSpecified
        {
            get
            {
                return ((this.PersonalSituation != null) 
                            && (this.PersonalSituation.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Operating Years. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of years that this qualifying party has been in operation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Operating Years</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Operating Years. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of years that this qualifying party has been in operation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Operating Years</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OperatingYearsQuantity", Order=2, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OperatingYearsQuantityType OperatingYearsQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Employee. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of people employed by this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Employee</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Employee. Quantity</ccts:DictionaryEntryName><ccts:Definition>The number of people employed by this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Employee</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmployeeQuantity", Order=3, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmployeeQuantityType EmployeeQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business Classification Evidence. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for an item of evidence to support the classification of this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Business Classification Evidence</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business Classification Evidence. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for an item of evidence to support the classification of this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Business Classification Evidence</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BusinessClassificationEvidenceID", Order=4, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BusinessClassificationEvidenceIdType BusinessClassificationEvidenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business Identity Evidence. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for an item of evidence to support the business identity of this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Business Identity Evidence</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business Identity Evidence. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for an item of evidence to support the business identity of this qualifying party.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Business Identity Evidence</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BusinessIdentityEvidenceID", Order=5, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BusinessIdentityEvidenceIdType BusinessIdentityEvidenceId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Tenderer Role Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code stating the Tenderer Role.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Tenderer Role Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Tenderer Role Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code stating the Tenderer Role.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Tenderer Role Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TendererRoleCode", Order=6, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TendererRoleCodeType TendererRoleCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business_ Classification Scheme. Classification Scheme</ccts:DictionaryEntryName><ccts:Definition>The classification scheme used for the business profile.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Business</ccts:PropertyTermQualifier><ccts:PropertyTerm>Classification Scheme</ccts:PropertyTerm><ccts:AssociatedObjectClass>Classification Scheme</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Classification Scheme</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Business_ Classification Scheme. Classification Scheme</ccts:DictionaryEntryName><ccts:Definition>The classification scheme used for the business profile.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Business</ccts:PropertyTermQualifier><ccts:PropertyTerm>Classification Scheme</ccts:PropertyTerm><ccts:AssociatedObjectClass>Classification Scheme</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Classification Scheme</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("BusinessClassificationScheme", Order=7)]
        public ClassificationSchemeType BusinessClassificationScheme { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<CapabilityType> _technicalCapability;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Technical_ Capability. Capability</ccts:DictionaryEntryName><ccts:Definition>A technical capability of this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Technical</ccts:PropertyTermQualifier><ccts:PropertyTerm>Capability</ccts:PropertyTerm><ccts:AssociatedObjectClass>Capability</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Capability</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Technical_ Capability. Capability</ccts:DictionaryEntryName><ccts:Definition>A technical capability of this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Technical</ccts:PropertyTermQualifier><ccts:PropertyTerm>Capability</ccts:PropertyTerm><ccts:AssociatedObjectClass>Capability</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Capability</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("TechnicalCapability", Order=8)]
        public List<CapabilityType> TechnicalCapability
        {
            get
            {
                return _technicalCapability;
            }
            set
            {
                _technicalCapability = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the TechnicalCapability collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool TechnicalCapabilitySpecified
        {
            get
            {
                return ((this.TechnicalCapability != null) 
                            && (this.TechnicalCapability.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CapabilityType> _financialCapability;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Financial_ Capability. Capability</ccts:DictionaryEntryName><ccts:Definition>A financial capability of this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Financial</ccts:PropertyTermQualifier><ccts:PropertyTerm>Capability</ccts:PropertyTerm><ccts:AssociatedObjectClass>Capability</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Capability</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Financial_ Capability. Capability</ccts:DictionaryEntryName><ccts:Definition>A financial capability of this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTermQualifier>Financial</ccts:PropertyTermQualifier><ccts:PropertyTerm>Capability</ccts:PropertyTerm><ccts:AssociatedObjectClass>Capability</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Capability</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("FinancialCapability", Order=9)]
        public List<CapabilityType> FinancialCapability
        {
            get
            {
                return _financialCapability;
            }
            set
            {
                _financialCapability = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the FinancialCapability collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool FinancialCapabilitySpecified
        {
            get
            {
                return ((this.FinancialCapability != null) 
                            && (this.FinancialCapability.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CompletedTaskType> _completedTask;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Completed Task</ccts:DictionaryEntryName><ccts:Definition>A former task completed by this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Completed Task</ccts:PropertyTerm><ccts:AssociatedObjectClass>Completed Task</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Completed Task</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Completed Task</ccts:DictionaryEntryName><ccts:Definition>A former task completed by this qualifying party.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Completed Task</ccts:PropertyTerm><ccts:AssociatedObjectClass>Completed Task</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Completed Task</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("CompletedTask", Order=10)]
        public List<CompletedTaskType> CompletedTask
        {
            get
            {
                return _completedTask;
            }
            set
            {
                _completedTask = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CompletedTask collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool CompletedTaskSpecified
        {
            get
            {
                return ((this.CompletedTask != null) 
                            && (this.CompletedTask.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DeclarationType> _declaration;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Declaration</ccts:DictionaryEntryName><ccts:Definition>A declaration by this qualifying party. of certain characteristics or capabilities in fulfilment of requirements specified in a call for tenders.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Declaration</ccts:PropertyTerm><ccts:AssociatedObjectClass>Declaration</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Declaration</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Declaration</ccts:DictionaryEntryName><ccts:Definition>A declaration by this qualifying party. of certain characteristics or capabilities in fulfilment of requirements specified in a call for tenders.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Declaration</ccts:PropertyTerm><ccts:AssociatedObjectClass>Declaration</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Declaration</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("Declaration", Order=11)]
        public List<DeclarationType> Declaration
        {
            get
            {
                return _declaration;
            }
            set
            {
                _declaration = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Declaration collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DeclarationSpecified
        {
            get
            {
                return ((this.Declaration != null) 
                            && (this.Declaration.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Party</ccts:DictionaryEntryName><ccts:Definition>The qualifying party itself.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Party</ccts:DictionaryEntryName><ccts:Definition>The qualifying party itself.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Party", Order=12)]
        public PartyType Party { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Economic Operator Role</ccts:DictionaryEntryName><ccts:Definition>A class to describe the tenderer contracting role.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Economic Operator Role</ccts:PropertyTerm><ccts:AssociatedObjectClass>Economic Operator Role</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Economic Operator Role</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Qualifying Party. Economic Operator Role</ccts:DictionaryEntryName><ccts:Definition>A class to describe the tenderer contracting role.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Qualifying Party</ccts:ObjectClass><ccts:PropertyTerm>Economic Operator Role</ccts:PropertyTerm><ccts:AssociatedObjectClass>Economic Operator Role</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Economic Operator Role</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EconomicOperatorRole", Order=13)]
        public EconomicOperatorRoleType EconomicOperatorRole { get; set; }
    }
}
