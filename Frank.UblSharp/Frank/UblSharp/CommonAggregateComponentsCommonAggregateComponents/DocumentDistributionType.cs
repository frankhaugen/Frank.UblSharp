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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the distribution of a document to an interested party.</ccts:Definition><ccts:ObjectClass>Document Distribution</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the distribution of a document to an interested party.</ccts:Definition><ccts:ObjectClass>Document Distribution</ccts:ObjectClass></ccts:Component>")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("DocumentDistributionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("DocumentDistribution", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class DocumentDistributionType
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Print_ Qualifier. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the interested party's distribution rights.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Distribution</ccts:ObjectClass><ccts:PropertyTermQualifier>Print</ccts:PropertyTermQualifier><ccts:PropertyTerm>Qualifier</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Print_ Qualifier. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the interested party's distribution rights.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Distribution</ccts:ObjectClass><ccts:PropertyTermQualifier>Print</ccts:PropertyTermQualifier><ccts:PropertyTerm>Qualifier</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PrintQualifier", Order=0, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PrintQualifierType PrintQualifier { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Maximum_ Copies. Numeric</ccts:DictionaryEntryName><ccts:Definition>The maximum number of printed copies of the document that the interested party is allowed to make.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Distribution</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Copies</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Maximum_ Copies. Numeric</ccts:DictionaryEntryName><ccts:Definition>The maximum number of printed copies of the document that the interested party is allowed to make.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Distribution</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Copies</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("MaximumCopiesNumeric", Order=1, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumCopiesNumericType MaximumCopiesNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Party</ccts:DictionaryEntryName><ccts:Definition>The interested party to which the document should be distributed.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Distribution</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Document Distribution. Party</ccts:DictionaryEntryName><ccts:Definition>The interested party to which the document should be distributed.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Document Distribution</ccts:ObjectClass><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Party", Order=2)]
        public PartyType Party { get; set; }
    }
}
