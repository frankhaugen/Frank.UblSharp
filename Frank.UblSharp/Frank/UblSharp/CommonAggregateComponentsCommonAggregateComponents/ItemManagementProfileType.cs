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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a management profile for an item.</ccts:Definition><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Details</ccts:DictionaryEntryName><ccts:Definition>A class to define a management profile for an item.</ccts:Definition><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass></ccts:Component>")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("ItemManagementProfileType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("ItemManagementProfile", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class ItemManagementProfileType
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
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Frozen Period Days. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of days in the future that an order forecast quantity automatically becomes a confirmed order for a product.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Frozen Period Days</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Frozen Period Days. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of days in the future that an order forecast quantity automatically becomes a confirmed order for a product.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Frozen Period Days</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FrozenPeriodDaysNumeric", Order=0, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FrozenPeriodDaysNumericType FrozenPeriodDaysNumeric { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Minimum_ Inventory Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of the item that should trigger a replenishment order to avoid depleting the safety stock.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Inventory Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Minimum_ Inventory Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of the item that should trigger a replenishment order to avoid depleting the safety stock.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Inventory Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumInventoryQuantity", Order=1, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumInventoryQuantityType MinimumInventoryQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Multiple_ Order Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The order quantity multiples in which the product may be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Multiple</ccts:PropertyTermQualifier><ccts:PropertyTerm>Order Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Multiple_ Order Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The order quantity multiples in which the product may be ordered.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Multiple</ccts:PropertyTermQualifier><ccts:PropertyTerm>Order Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MultipleOrderQuantity", Order=2, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MultipleOrderQuantityType MultipleOrderQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Order Interval Days. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of days between regular replenishment orders for the product.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Order Interval Days</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Order Interval Days. Numeric</ccts:DictionaryEntryName><ccts:Definition>The number of days between regular replenishment orders for the product.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Order Interval Days</ccts:PropertyTerm><ccts:RepresentationTerm>Numeric</ccts:RepresentationTerm><ccts:DataType>Numeric. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("OrderIntervalDaysNumeric", Order=3, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderIntervalDaysNumericType OrderIntervalDaysNumeric { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReplenishmentOwnerDescriptionType> _replenishmentOwnerDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Replenishment Owner Description. Text</ccts:DictionaryEntryName><ccts:Definition>The trading partner maintaining this item management profile.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Replenishment Owner Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Replenishment Owner Description. Text</ccts:DictionaryEntryName><ccts:Definition>The trading partner maintaining this item management profile.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Replenishment Owner Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("ReplenishmentOwnerDescription", Order=4, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReplenishmentOwnerDescriptionType> ReplenishmentOwnerDescription
        {
            get
            {
                return _replenishmentOwnerDescription;
            }
            set
            {
                _replenishmentOwnerDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ReplenishmentOwnerDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ReplenishmentOwnerDescriptionSpecified
        {
            get
            {
                return ((this.ReplenishmentOwnerDescription != null) 
                            && (this.ReplenishmentOwnerDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Target Service Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The Unit Service Level the trading partners expect to be maintained, expressed as a percentage. Unite Service Level (USL) is a term used in Inventory Management, which is sometimes known as "fill rate", counts the average number of units short expressed as the percentage of the order quantity.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Target Service Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Target Service Percent. Percent</ccts:DictionaryEntryName><ccts:Definition>The Unit Service Level the trading partners expect to be maintained, expressed as a percentage. Unite Service Level (USL) is a term used in Inventory Management, which is sometimes known as ""fill rate"", counts the average number of units short expressed as the percentage of the order quantity.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Target Service Percent</ccts:PropertyTerm><ccts:RepresentationTerm>Percent</ccts:RepresentationTerm><ccts:DataType>Percent. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TargetServicePercent", Order=5, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TargetServicePercentType TargetServicePercent { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Target_ Inventory Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The target inventory quantity.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Target</ccts:PropertyTermQualifier><ccts:PropertyTerm>Inventory Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Target_ Inventory Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The target inventory quantity.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Target</ccts:PropertyTermQualifier><ccts:PropertyTerm>Inventory Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TargetInventoryQuantity", Order=6, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TargetInventoryQuantityType TargetInventoryQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Effective_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which this profile is effective.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Effective</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Effective_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>The period during which this profile is effective.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTermQualifier>Effective</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("EffectivePeriod", Order=7)]
        public PeriodType EffectivePeriod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with this item management profile.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Item</ccts:DictionaryEntryName><ccts:Definition>The item associated with this item management profile.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item</ccts:RepresentationTerm></ccts:Component>")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Item", Order=8)]
        public ItemType Item { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Item Location Quantity</ccts:DictionaryEntryName><ccts:Definition>A set of location-specific properties (e.g., price and quantity) associated with the item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Item Location Quantity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Location Quantity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Location Quantity</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Item Management Profile. Item Location Quantity</ccts:DictionaryEntryName><ccts:Definition>A set of location-specific properties (e.g., price and quantity) associated with the item.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Item Management Profile</ccts:ObjectClass><ccts:PropertyTerm>Item Location Quantity</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Location Quantity</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Location Quantity</ccts:RepresentationTerm></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ItemLocationQuantity", Order=9)]
        public ItemLocationQuantityType ItemLocationQuantity { get; set; }
    }
}
