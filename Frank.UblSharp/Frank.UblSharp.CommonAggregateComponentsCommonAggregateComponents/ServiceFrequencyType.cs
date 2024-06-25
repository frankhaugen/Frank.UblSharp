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
    [XmlTypeAttribute("ServiceFrequencyType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ScheduledServiceFrequency))]
    [XmlIncludeAttribute(typeof(ServiceFrequency))]
    public partial class ServiceFrequencyType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Service Frequency. Week Day. Code</ccts:DictionaryEntryName><ccts:Definition>A day of the week, expressed as code.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Service Frequency</ccts:ObjectClass><ccts:PropertyTerm>Week Day</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Week Day</ccts:DataTypeQualifier><ccts:DataType>Week Day_ Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("WeekDayCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WeekDayCodeType WeekDayCode { get; set; }
    }
}