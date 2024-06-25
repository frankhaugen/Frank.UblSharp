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
    [XmlTypeAttribute("TransportHandlingUnitType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(PackagedTransportHandlingUnit))]
    [XmlIncludeAttribute(typeof(TransportHandlingUnit))]
    public partial class TransportHandlingUnitType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Transport Handling Unit Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Transport Handling Unit Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TransportHandlingUnitTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportHandlingUnitTypeCodeType TransportHandlingUnitTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Handling Code. Code</ccts:DictionaryEntryName><ccts:Definition>The handling required for this transport handling unit, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Handling Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Special Handling</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HandlingCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingCodeType HandlingCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingInstructionsType> _handlingInstructions;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Handling_ Instructions. Text</ccts:DictionaryEntryName><ccts:Definition>The handling required for this transport handling unit, expressed as text.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Handling</ccts:PropertyTermQualifier><ccts:PropertyTerm>Instructions</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HandlingInstructions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingInstructionsType> HandlingInstructions
        {
            get
            {
                return _handlingInstructions;
            }
            set
            {
                _handlingInstructions = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HandlingInstructions-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HandlingInstructions collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HandlingInstructionsSpecified
        {
            get
            {
                return ((this.HandlingInstructions != null) 
                            && (this.HandlingInstructions.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Hazardous Risk_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that the materials contained in this transport handling unit are subject to an international regulation concerning the carriage of dangerous goods (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Hazardous Risk</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>Default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("HazardousRiskIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousRiskIndicatorType HazardousRiskIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Total_ Goods Item Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of goods items in this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Goods Item Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalGoodsItemQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalGoodsItemQuantityType TotalGoodsItemQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Total_ Package Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The total number of packages in this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Package Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalPackageQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalPackageQuantityType TotalPackageQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DamageRemarksType> _damageRemarks;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Damage_ Remarks. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing damage associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Damage</ccts:PropertyTermQualifier><ccts:PropertyTerm>Remarks</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("DamageRemarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DamageRemarksType> DamageRemarks
        {
            get
            {
                return _damageRemarks;
            }
            set
            {
                _damageRemarks = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DamageRemarks-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DamageRemarks collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DamageRemarksSpecified
        {
            get
            {
                return ((this.DamageRemarks != null) 
                            && (this.DamageRemarks.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ShippingMarksType> _shippingMarks;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Shipping_ Marks. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the marks and numbers on this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Shipping</ccts:PropertyTermQualifier><ccts:PropertyTerm>Marks</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:AlternativeBusinessTerms>Marks and Numbers, Shipping Marks</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShippingMarks", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ShippingMarksType> ShippingMarks
        {
            get
            {
                return _shippingMarks;
            }
            set
            {
                _shippingMarks = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ShippingMarks-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ShippingMarks collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShippingMarksSpecified
        {
            get
            {
                return ((this.ShippingMarks != null) 
                            && (this.ShippingMarks.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Trace_ Identifier. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for use in tracing this transport handling unit, such as the EPC number used in RFID.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Trace</ccts:PropertyTermQualifier><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TraceID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TraceIdType TraceId { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DespatchLineType> _handlingUnitDespatchLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Handling Unit_ Despatch Line. Despatch Line</ccts:DictionaryEntryName><ccts:Definition>A despatch line associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Handling Unit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Despatch Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Despatch Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Despatch Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HandlingUnitDespatchLine")]
        public List<DespatchLineType> HandlingUnitDespatchLine
        {
            get
            {
                return _handlingUnitDespatchLine;
            }
            set
            {
                _handlingUnitDespatchLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HandlingUnitDespatchLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HandlingUnitDespatchLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HandlingUnitDespatchLineSpecified
        {
            get
            {
                return ((this.HandlingUnitDespatchLine != null) 
                            && (this.HandlingUnitDespatchLine.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PackageType> _actualPackage;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Actual_ Package. Package</ccts:DictionaryEntryName><ccts:Definition>A package contained in this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Actual</ccts:PropertyTermQualifier><ccts:PropertyTerm>Package</ccts:PropertyTerm><ccts:AssociatedObjectClass>Package</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Package</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ActualPackage")]
        public List<PackageType> ActualPackage
        {
            get
            {
                return _actualPackage;
            }
            set
            {
                _actualPackage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ActualPackage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ActualPackage collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ActualPackageSpecified
        {
            get
            {
                return ((this.ActualPackage != null) 
                            && (this.ActualPackage.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ReceiptLineType> _receivedHandlingUnitReceiptLine;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Received Handling Unit_ Receipt Line. Receipt Line</ccts:DictionaryEntryName><ccts:Definition>A receipt line associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Received Handling Unit</ccts:PropertyTermQualifier><ccts:PropertyTerm>Receipt Line</ccts:PropertyTerm><ccts:AssociatedObjectClass>Receipt Line</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Receipt Line</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReceivedHandlingUnitReceiptLine")]
        public List<ReceiptLineType> ReceivedHandlingUnitReceiptLine
        {
            get
            {
                return _receivedHandlingUnitReceiptLine;
            }
            set
            {
                _receivedHandlingUnitReceiptLine = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReceivedHandlingUnitReceiptLine-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReceivedHandlingUnitReceiptLine collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReceivedHandlingUnitReceiptLineSpecified
        {
            get
            {
                return ((this.ReceivedHandlingUnitReceiptLine != null) 
                            && (this.ReceivedHandlingUnitReceiptLine.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportEquipmentType> _transportEquipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Transport Equipment</ccts:DictionaryEntryName><ccts:Definition>A piece of transport equipment associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Transport Equipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Equipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Equipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportEquipment")]
        public List<TransportEquipmentType> TransportEquipment
        {
            get
            {
                return _transportEquipment;
            }
            set
            {
                _transportEquipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportEquipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportEquipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportEquipmentSpecified
        {
            get
            {
                return ((this.TransportEquipment != null) 
                            && (this.TransportEquipment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<TransportMeansType> _transportMeans;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Transport Means</ccts:DictionaryEntryName><ccts:Definition>A means of transport associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Transport Means</ccts:PropertyTerm><ccts:AssociatedObjectClass>Transport Means</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Transport Means</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TransportMeans")]
        public List<TransportMeansType> TransportMeans
        {
            get
            {
                return _transportMeans;
            }
            set
            {
                _transportMeans = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransportMeans-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransportMeans collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TransportMeansSpecified
        {
            get
            {
                return ((this.TransportMeans != null) 
                            && (this.TransportMeans.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<HazardousGoodsTransitType> _hazardousGoodsTransit;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Hazardous Goods Transit</ccts:DictionaryEntryName><ccts:Definition>Transit-related information regarding a type of hazardous goods contained in this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Hazardous Goods Transit</ccts:PropertyTerm><ccts:AssociatedObjectClass>Hazardous Goods Transit</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Hazardous Goods Transit</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("HazardousGoodsTransit")]
        public List<HazardousGoodsTransitType> HazardousGoodsTransit
        {
            get
            {
                return _hazardousGoodsTransit;
            }
            set
            {
                _hazardousGoodsTransit = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HazardousGoodsTransit-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HazardousGoodsTransit collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool HazardousGoodsTransitSpecified
        {
            get
            {
                return ((this.HazardousGoodsTransit != null) 
                            && (this.HazardousGoodsTransit.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<DimensionType> _measurementDimension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>A measurable dimension (length, mass, weight, or volume) of this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Minimum_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>The minimum required operating temperature of this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumTemperature")]
        public TemperatureType MinimumTemperature { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Maximum_ Temperature. Temperature</ccts:DictionaryEntryName><ccts:Definition>The maximum allowable operating temperature of this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Temperature</ccts:PropertyTerm><ccts:AssociatedObjectClass>Temperature</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Temperature</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumTemperature")]
        public TemperatureType MaximumTemperature { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<GoodsItemType> _goodsItem;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Goods Item</ccts:DictionaryEntryName><ccts:Definition>A goods item contained in this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Goods Item</ccts:PropertyTerm><ccts:AssociatedObjectClass>Goods Item</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Goods Item</ccts:RepresentationTerm></ccts:Component></para>
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
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Floor Space Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>The floor space measurement dimension associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Floor Space Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("FloorSpaceMeasurementDimension")]
        public DimensionType FloorSpaceMeasurementDimension { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Pallet Space Measurement_ Dimension. Dimension</ccts:DictionaryEntryName><ccts:Definition>The pallet space measurement dimension associated to this transport handling unit.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Pallet Space Measurement</ccts:PropertyTermQualifier><ccts:PropertyTerm>Dimension</ccts:PropertyTerm><ccts:AssociatedObjectClass>Dimension</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Dimension</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PalletSpaceMeasurementDimension")]
        public DimensionType PalletSpaceMeasurementDimension { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<DocumentReferenceType> _shipmentDocumentReference;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Shipment_ Document Reference. Document Reference</ccts:DictionaryEntryName><ccts:Definition>A reference to a shipping document associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Shipment</ccts:PropertyTermQualifier><ccts:PropertyTerm>Document Reference</ccts:PropertyTerm><ccts:AssociatedObjectClass>Document Reference</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Document Reference</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ShipmentDocumentReference")]
        public List<DocumentReferenceType> ShipmentDocumentReference
        {
            get
            {
                return _shipmentDocumentReference;
            }
            set
            {
                _shipmentDocumentReference = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ShipmentDocumentReference-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ShipmentDocumentReference collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ShipmentDocumentReferenceSpecified
        {
            get
            {
                return ((this.ShipmentDocumentReference != null) 
                            && (this.ShipmentDocumentReference.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<StatusType> _status;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Status</ccts:DictionaryEntryName><ccts:Definition>The status of this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Status</ccts:PropertyTerm><ccts:AssociatedObjectClass>Status</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Status</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Status")]
        public List<StatusType> Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Status-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Status collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return ((this.Status != null) 
                            && (this.Status.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<CustomsDeclarationType> _customsDeclaration;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Customs Declaration</ccts:DictionaryEntryName><ccts:Definition>Describes identifiers or references relating to customs procedures.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Customs Declaration</ccts:PropertyTerm><ccts:AssociatedObjectClass>Customs Declaration</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Customs Declaration</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("CustomsDeclaration")]
        public List<CustomsDeclarationType> CustomsDeclaration
        {
            get
            {
                return _customsDeclaration;
            }
            set
            {
                _customsDeclaration = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CustomsDeclaration-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CustomsDeclaration collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CustomsDeclarationSpecified
        {
            get
            {
                return ((this.CustomsDeclaration != null) 
                            && (this.CustomsDeclaration.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<ShipmentType> _referencedShipment;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Referenced_ Shipment. Shipment</ccts:DictionaryEntryName><ccts:Definition>A shipment associated with this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTermQualifier>Referenced</ccts:PropertyTermQualifier><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ReferencedShipment")]
        public List<ShipmentType> ReferencedShipment
        {
            get
            {
                return _referencedShipment;
            }
            set
            {
                _referencedShipment = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReferencedShipment-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ReferencedShipment collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ReferencedShipmentSpecified
        {
            get
            {
                return ((this.ReferencedShipment != null) 
                            && (this.ReferencedShipment.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PackageType> _package;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Transport Handling Unit. Package</ccts:DictionaryEntryName><ccts:Definition>A package contained in this transport handling unit.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Transport Handling Unit</ccts:ObjectClass><ccts:PropertyTerm>Package</ccts:PropertyTerm><ccts:AssociatedObjectClass>Package</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Package</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Package")]
        public List<PackageType> Package
        {
            get
            {
                return _package;
            }
            set
            {
                _package = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Package-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Package collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool PackageSpecified
        {
            get
            {
                return ((this.Package != null) 
                            && (this.Package.Count != 0));
            }
        }
    }
}
