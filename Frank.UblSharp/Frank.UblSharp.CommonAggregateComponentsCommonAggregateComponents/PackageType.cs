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
    [XmlTypeAttribute("PackageType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(ActualPackage))]
    [XmlIncludeAttribute(typeof(ContainedPackage))]
    [XmlIncludeAttribute(typeof(ContainingPackage))]
    [XmlIncludeAttribute(typeof(Package))]
    [XmlIncludeAttribute(typeof(ReferencedPackage))]
    public partial class PackageType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this package.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of items contained in this package.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Quantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityType Quantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Returnable Material_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that the packaging material is returnable (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTermQualifier>Returnable Material</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ReturnableMaterialIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReturnableMaterialIndicatorType ReturnableMaterialIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Package Level Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying a level of packaging.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Package Level Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PackageLevelCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackageLevelCodeType PackageLevelCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Packaging Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying a type of packaging.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Packaging Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataTypeQualifier>Packaging Type</ccts:DataTypeQualifier><ccts:DataType>Packaging Type_ Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Package classification code</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PackagingTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackagingTypeCodeType PackagingTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackingMaterialType> _packingMaterial;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Packing Material. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the packaging material.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Packing Material</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("PackingMaterial", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackingMaterialType> PackingMaterial
        {
            get
            {
                return _packingMaterial;
            }
            set
            {
                _packingMaterial = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PackingMaterial-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PackingMaterial collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PackingMaterialSpecified
        {
            get
            {
                return ((this.PackingMaterial != null) 
                            && (this.PackingMaterial.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Trace_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for use in tracing this package, such as the EPC number used in RFID.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTermQualifier>Trace</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TraceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TraceIdType TraceId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PackageType> _containedPackage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Contained_ Package. Package</ccts:DictionaryEntryName><ccts:Definition>A package contained within this package.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTermQualifier>Contained</ccts:PropertyTermQualifier><ccts:PropertyTerm>Package</ccts:PropertyTerm><ccts:AssociatedObjectClass>Package</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Package</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ContainedPackage")]
        public List<PackageType> ContainedPackage
        {
            get
            {
                return _containedPackage;
            }
            set
            {
                _containedPackage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ContainedPackage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ContainedPackage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ContainedPackageSpecified
        {
            get
            {
                return ((this.ContainedPackage != null) 
                            && (this.ContainedPackage.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Containing_ Transport Equipment. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>The piece of transport equipment containing this package.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTermQualifier>Containing</ccts:PropertyTermQualifier><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ContainingTransportEquipment")]
        public TransportEquipmentType ContainingTransportEquipment { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<GoodsItemType> _goodsItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Goods Item</ccts:DictionaryEntryName><ccts:Definition>A goods item included in this package.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Goods Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Goods Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Goods Item</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("GoodsItem")]
        public List<GoodsItemType> GoodsItem
        {
            get
            {
                return _goodsItem;
            }
            set
            {
                _goodsItem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die GoodsItem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the GoodsItem collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool GoodsItemSpecified
        {
            get
            {
                return ((this.GoodsItem != null) 
                            && (this.GoodsItem.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DimensionType> _measurementDimension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>A measurable dimension (length, mass, weight, or volume) of this package.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTermQualifier>Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MeasurementDimension")]
        public List<DimensionType> MeasurementDimension
        {
            get
            {
                return _measurementDimension;
            }
            set
            {
                _measurementDimension = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeasurementDimension-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MeasurementDimension collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MeasurementDimensionSpecified
        {
            get
            {
                return ((this.MeasurementDimension != null) 
                            && (this.MeasurementDimension.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DeliveryUnitType> _deliveryUnit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Delivery Unit</ccts:DictionaryEntryName><ccts:Definition>A delivery unit within this package.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Delivery Unit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery Unit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery Unit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DeliveryUnit")]
        public List<DeliveryUnitType> DeliveryUnit
        {
            get
            {
                return _deliveryUnit;
            }
            set
            {
                _deliveryUnit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DeliveryUnit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DeliveryUnit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DeliveryUnitSpecified
        {
            get
            {
                return ((this.DeliveryUnit != null) 
                            && (this.DeliveryUnit.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Delivery</ccts:DictionaryEntryName><ccts:Definition>The delivery of this package.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Delivery</ccts:PropertyTerm><ccts:AssociatedObjectClass>Delivery</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Delivery</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Delivery")]
        public DeliveryType Delivery {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Pickup</ccts:DictionaryEntryName><ccts:Definition>The pickup of this package.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Pickup</ccts:PropertyTerm><ccts:AssociatedObjectClass>Pickup</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Pickup</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Pickup")]
        public PickupType Pickup { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Package. Despatch</ccts:DictionaryEntryName><ccts:Definition>The despatch of this package.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Package</ccts:ObjectClass><ccts:PropertyTerm>Despatch</ccts:PropertyTerm><ccts:AssociatedObjectClass>Despatch</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Despatch</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Despatch")]
        public DespatchType Despatch { get; set; }
    }
}
