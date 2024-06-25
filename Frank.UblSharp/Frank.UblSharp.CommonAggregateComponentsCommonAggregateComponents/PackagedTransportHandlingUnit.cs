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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a uniquely identifiable unit consisting of one or more packages, goods items, or pieces of transport equipment.</ccts:Definition><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:AlternativeBusinessTerms>Logistics Unit, Handling Unit, THU</ccts:AlternativeBusinessTerms></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlRootAttribute("PackagedTransportHandlingUnit", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class PackagedTransportHandlingUnit : TransportHandlingUnitType
    {
    }
}
