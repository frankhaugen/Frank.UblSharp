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
    [XmlTypeAttribute("MeterType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(Meter))]
    [XmlIncludeAttribute(typeof(UtilityMeter))]
    public partial class MeterType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter. Meter Number. Text</ccts:DictionaryEntryName><ccts:Definition>The meter number, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter</ccts:ObjectClass><ccts:PropertyTerm>Meter Number</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>61722x</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MeterNumber", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterNumberType MeterNumber { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter. Meter Name. Text</ccts:DictionaryEntryName><ccts:Definition>The name of this meter, which serves as an identifier to distinguish a main meter from a submeter.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter</ccts:ObjectClass><ccts:PropertyTerm>Meter Name</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MeterName", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterNameType MeterName { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter. Meter Constant. Text</ccts:DictionaryEntryName><ccts:Definition>The factor by which readings of this meter must be multiplied to calculate consumption, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter</ccts:ObjectClass><ccts:PropertyTerm>Meter Constant</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>1.000</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MeterConstant", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterConstantType MeterConstant { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter. Meter Constant Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the formula to be used in applying the meter constant.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter</ccts:ObjectClass><ccts:PropertyTerm>Meter Constant Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Factor</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MeterConstantCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterConstantCodeType MeterConstantCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter. Total_ Delivered Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity delivered; the total quantity consumed as calculated from the meter readings.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Delivered Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>5761.00</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalDeliveredQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalDeliveredQuantityType TotalDeliveredQuantity { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<MeterReadingType> _meterReading;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter. Meter Reading</ccts:DictionaryEntryName><ccts:Definition>A reading of this meter.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Meter</ccts:ObjectClass><ccts:PropertyTerm>Meter Reading</ccts:PropertyTerm><ccts:AssociatedObjectClass>Meter Reading</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Meter Reading</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MeterReading")]
        public List<MeterReadingType> MeterReading
        {
            get
            {
                return _meterReading;
            }
            set
            {
                _meterReading = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeterReading-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MeterReading collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MeterReadingSpecified
        {
            get
            {
                return ((this.MeterReading != null) 
                            && (this.MeterReading.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<MeterPropertyType> _meterProperty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter. Meter Property</ccts:DictionaryEntryName><ccts:Definition>A property of this meter.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Meter</ccts:ObjectClass><ccts:PropertyTerm>Meter Property</ccts:PropertyTerm><ccts:AssociatedObjectClass>Meter Property</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Meter Property</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MeterProperty")]
        public List<MeterPropertyType> MeterProperty
        {
            get
            {
                return _meterProperty;
            }
            set
            {
                _meterProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeterProperty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MeterProperty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MeterPropertySpecified
        {
            get
            {
                return ((this.MeterProperty != null) 
                            && (this.MeterProperty.Count != 0));
            }
        }
    }
}
