namespace Frank.UblSharp.CoreComponentTypes
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
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000018</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">CCT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">A counted number of non-monetary units possibly including fractions.</ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">decimal</ccts:PrimitiveType></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("QuantityType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlRootAttribute("QuantityType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ActualTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BackorderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BaseQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BasicConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.BatchQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChargeableQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChildConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsignmentQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumerUnitQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumptionEnergyQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumptionWaterQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContentUnitQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CreditedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CrewQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomsTariffQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DebitedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DifferenceTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmployeeQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EstimatedConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EstimatedOverallContractQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpectedOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpectedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GasPressureQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InvoicedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestMeterQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumOperatorQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumVariantQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumBackorderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumOrderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MultipleOrderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NormalTemperatureReductionQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OperatingYearsQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OutstandingQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OversupplyQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PassengerQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PerformanceValueQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousMeterQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes.QuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceivedElectronicTenderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceivedForeignTenderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceivedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceivedTenderQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RejectedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReturnableQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SharesNumberQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ShortQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TargetInventoryQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ThresholdQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TimeDeltaDaysQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalConsumedQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalDeliveredQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalGoodsItemQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalMeteredQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalPackageQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalPackagesQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalTransportHandlingUnitQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ValueQuantityType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.VarianceQuantityType))]
    public partial class QuantityType
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft den Text ab oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [XmlTextAttribute()]
        public decimal Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000018-SC2</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity. Unit. Code</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The unit of the quantity</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Unit Code</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("unitCode")]
        public string UnitCode { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000018-SC3</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity Unit. Code List. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The quantity unit code list.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity Unit</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("unitCodeListID")]
        public string UnitCodeListId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000018-SC4</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity Unit. Code List Agency. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The identification of the agency that maintains the quantity unit code list</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity Unit</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List Agency</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// <para xml:lang="en"><ccts:UsageRule xmlns:ccts="urn:un:unece:uncefact:documentation:2">Defaults to the UN/EDIFACT data element 3055 code list.</ccts:UsageRule></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("unitCodeListAgencyID")]
        public string UnitCodeListAgencyId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000018-SC5</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity Unit. Code List Agency Name. Text</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The name of the agency which maintains the quantity unit code list.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Quantity Unit</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List Agency Name</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Text</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("unitCodeListAgencyName")]
        public string UnitCodeListAgencyName { get; set; }
    }
}
