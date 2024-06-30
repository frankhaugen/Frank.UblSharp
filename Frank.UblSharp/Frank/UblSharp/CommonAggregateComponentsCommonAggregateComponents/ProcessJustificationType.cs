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


    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a justification for the choice of tendering process.</ccts:Definition><ccts:ObjectClass>Process Justification</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a justification for the choice of tendering process.</ccts:Definition><ccts:ObjectClass>Process Justification</ccts:ObjectClass></ccts:Component>")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("ProcessJustificationType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("ProcessJustification", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ProcessJustificationType
    {

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Previous_ Cancellation Reason Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of the previous tendering process (which is now being cancelled).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous</ccts:PropertyTermQualifier><ccts:PropertyTerm>Cancellation Reason Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Previous_ Cancellation Reason Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of the previous tendering process (which is now being cancelled).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous</ccts:PropertyTermQualifier><ccts:PropertyTerm>Cancellation Reason Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreviousCancellationReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousCancellationReasonCodeType PreviousCancellationReasonCode { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Process_ Reason Code. Code</ccts:DictionaryEntryName><ccts:Definition>The reason why the contracting authority has followed a particular tendering procedure for the awarding of a contract, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTermQualifier>Process</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Process_ Reason Code. Code</ccts:DictionaryEntryName><ccts:Definition>The reason why the contracting authority has followed a particular tendering procedure for the awarding of a contract, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTermQualifier>Process</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ProcessReasonCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcessReasonCodeType ProcessReasonCode { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Process_ Reason. Text</ccts:DictionaryEntryName><ccts:Definition>The reason why the contracting authority has followed a particular tendering procedure for the awarding of a contract, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTermQualifier>Process</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Process_ Reason. Text</ccts:DictionaryEntryName><ccts:Definition>The reason why the contracting authority has followed a particular tendering procedure for the awarding of a contract, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTermQualifier>Process</ccts:PropertyTermQualifier><ccts:PropertyTerm>Reason</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("ProcessReason", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Collection<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcessReasonType> ProcessReason { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ProcessReason collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ProcessReasonSpecified
        {
            get
            {
                return ((this.ProcessReason != null)
                            && (this.ProcessReason.Count != 0));
            }
        }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text providing justification for the selection of this process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Process Justification. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text providing justification for the selection of this process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Process Justification</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Collection<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> Description { get; set; }

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
    }
}
