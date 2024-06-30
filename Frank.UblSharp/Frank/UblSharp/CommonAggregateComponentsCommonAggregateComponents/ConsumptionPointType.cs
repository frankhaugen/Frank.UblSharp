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
    [XmlTypeAttribute("ConsumptionPointType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlIncludeAttribute(typeof(ConsumptionPoint))]
    [XmlIncludeAttribute(typeof(UtilityConsumptionPoint))]
    public partial class ConsumptionPointType
    {

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this point of consumption.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>7411013716x</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this point of consumption.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>7411013716x</ccts:Examples></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlElementAttribute("ID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        [KeyAttribute()]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this consumption point.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Additional informations concerning the consumption point</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing this consumption point.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Additional informations concerning the consumption point</ccts:Examples></ccts:Component>")]
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

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Subscriber Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the subscriber responsible for the consumption at this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Subscriber Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>98143211</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Subscriber Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the subscriber responsible for the consumption at this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Subscriber Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>98143211</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubscriberID", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubscriberIdType SubscriberId { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Subscriber Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of subscriber, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Subscriber Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Subscriber Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of subscriber, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Subscriber Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubscriberType", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubscriberTypeType SubscriberType { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Subscriber Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of subscriber, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Subscriber Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>APL</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Subscriber Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of subscriber, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Subscriber Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>APL</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("SubscriberTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubscriberTypeCodeType SubscriberTypeCode { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Total_ Delivered Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total quantity delivered, calculated at this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivered Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>5761.00</ccts:Examples></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Total_ Delivered Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total quantity delivered, calculated at this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivered Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>5761.00</ccts:Examples></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalDeliveredQuantity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalDeliveredQuantityType TotalDeliveredQuantity { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Address</ccts:DictionaryEntryName><ccts:Definition>The address of this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Address</ccts:DictionaryEntryName><ccts:Definition>The address of this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Address")]
        public AddressType Address { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Web Site Access</ccts:DictionaryEntryName><ccts:Definition>Access information for the website of this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Web Site Access</ccts:PropertyTerm><ccts:AssociatedObjectClass>Web Site Access</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Web Site Access</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Web Site Access</ccts:DictionaryEntryName><ccts:Definition>Access information for the website of this consumption point.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTerm>Web Site Access</ccts:PropertyTerm><ccts:AssociatedObjectClass>Web Site Access</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Web Site Access</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("WebSiteAccess")]
        public WebSiteAccessType WebSiteAccess { get; set; }

        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Utility_ Meter. Meter</ccts:DictionaryEntryName><ccts:Definition>A meter at this consumption point.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTermQualifier>Utility</ccts:PropertyTermQualifier><ccts:PropertyTerm>Meter</ccts:PropertyTerm><ccts:AssociatedObjectClass>Meter</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Meter</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Consumption Point. Utility_ Meter. Meter</ccts:DictionaryEntryName><ccts:Definition>A meter at this consumption point.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Consumption Point</ccts:ObjectClass><ccts:PropertyTermQualifier>Utility</ccts:PropertyTermQualifier><ccts:PropertyTerm>Meter</ccts:PropertyTerm><ccts:AssociatedObjectClass>Meter</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Meter</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("UtilityMeter")]
        public Collection<MeterType> UtilityMeter { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the UtilityMeter collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool UtilityMeterSpecified
        {
            get
            {
                return ((this.UtilityMeter != null)
                            && (this.UtilityMeter.Count != 0));
            }
        }
    }
}
