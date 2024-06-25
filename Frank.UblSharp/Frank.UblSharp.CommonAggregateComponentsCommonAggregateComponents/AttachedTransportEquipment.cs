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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Equipment. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a piece of equipment used to transport goods.</ccts:Definition><ccts:ObjectClass>Transport Equipment</ccts:ObjectClass><ccts:AlternativeBusinessTerms>Shipping Container, Sea Container, Rail Wagon, Pallet, Trailer, Unit Load Device, ULD</ccts:AlternativeBusinessTerms></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlRootAttribute("AttachedTransportEquipment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AttachedTransportEquipment : TransportEquipmentType
    {
    }
}
