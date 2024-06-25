namespace Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes
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
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UBLUDT0000016</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">UDT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Percent. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">Numeric information that is assigned or is determined by calculation, counting, or sequencing and is expressed as a percentage. It does not require a unit of quantity or unit of measure.</ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Percent</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("PercentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AirFlowPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HumidityPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PartecipationPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ParticipationPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PenaltySurchargePercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProgressPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReliabilityPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SettlementDiscountPercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TargetServicePercentType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TierRatePercentType))]
    public partial class PercentType : Frank.UblSharp.CoreComponentTypes.NumericType
    {
    }
}
