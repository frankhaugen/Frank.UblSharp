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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Property. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a name/value pair for a property of an inventory planning activity.</ccts:Definition><ccts:ObjectClass>Activity Property</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("ActivityPropertyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("ActivityProperty", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ActivityPropertyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Property. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this activity property.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Activity Property</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Activity Property. Value. Text</ccts:DictionaryEntryName><ccts:Definition>The value of this activity property.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Activity Property</ccts:ObjectClass><ccts:PropertyTerm>Value</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Value", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ValueType Value { get; set; }
    }
}
