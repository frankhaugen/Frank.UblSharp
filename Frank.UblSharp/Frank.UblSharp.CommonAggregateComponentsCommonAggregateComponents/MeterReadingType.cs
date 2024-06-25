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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a meter reading.</ccts:Definition><ccts:ObjectClass>Meter Reading</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("MeterReadingType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("MeterReading", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class MeterReadingType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this meter reading.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>7411013716x</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Meter Reading Type. Text</ccts:DictionaryEntryName><ccts:Definition>The type of this meter reading, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTerm>Meter Reading Type</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Electricity</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MeterReadingType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterReadingTypeType MeterReadingTypeProperty { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Meter Reading Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>The type of this meter reading, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTerm>Meter Reading Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Electricity</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MeterReadingTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterReadingTypeCodeType MeterReadingTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Previous_ Meter Reading Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date of the previous meter reading.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous</ccts:PropertyTermQualifier><ccts:PropertyTerm>Meter Reading Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType><ccts:Examples>2006-09-01</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PreviousMeterReadingDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousMeterReadingDateType PreviousMeterReadingDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Previous_ Meter Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of the previous meter reading.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous</ccts:PropertyTermQualifier><ccts:PropertyTerm>Meter Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>122604.00</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("PreviousMeterQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousMeterQuantityType PreviousMeterQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Latest_ Meter Reading Date. Date</ccts:DictionaryEntryName><ccts:Definition>The date of the latest meter reading.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest</ccts:PropertyTermQualifier><ccts:PropertyTerm>Meter Reading Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType><ccts:Examples>2006-09-01</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("LatestMeterReadingDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestMeterReadingDateType LatestMeterReadingDate { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Latest_ Meter Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>The quantity of the latest meter reading.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest</ccts:PropertyTermQualifier><ccts:PropertyTerm>Meter Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType><ccts:Examples>128365.00</ccts:Examples></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("LatestMeterQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestMeterQuantityType LatestMeterQuantity { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Previous Meter Reading_ Method. Text</ccts:DictionaryEntryName><ccts:Definition>The method used for the previous meter reading, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous Meter Reading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Method</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Manuel</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreviousMeterReadingMethod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousMeterReadingMethodType PreviousMeterReadingMethod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Previous Meter Reading_ Method Code. Code</ccts:DictionaryEntryName><ccts:Definition>The method used for the previous meter reading, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous Meter Reading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Method Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Estimated</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreviousMeterReadingMethodCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousMeterReadingMethodCodeType PreviousMeterReadingMethodCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Latest Meter Reading_ Method. Text</ccts:DictionaryEntryName><ccts:Definition>The method used for the latest meter reading, expressed as text.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest Meter Reading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Method</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>Manuel</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatestMeterReadingMethod", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestMeterReadingMethodType LatestMeterReadingMethod { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Latest Meter Reading_ Method Code. Code</ccts:DictionaryEntryName><ccts:Definition>The method used for the latest meter reading, expressed as a code.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Latest Meter Reading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Method Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>Estimated</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LatestMeterReadingMethodCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestMeterReadingMethodCodeType LatestMeterReadingMethodCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterReadingCommentsType> _meterReadingComments;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Meter Reading_ Comments. Text</ccts:DictionaryEntryName><ccts:Definition>Text containing comments on this meter reading.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Meter Reading</ccts:PropertyTermQualifier><ccts:PropertyTerm>Comments</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>The last stated meterstand is estimated</ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("MeterReadingComments", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterReadingCommentsType> MeterReadingComments
        {
            get
            {
                return _meterReadingComments;
            }
            set
            {
                _meterReadingComments = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeterReadingComments-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MeterReadingComments collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool MeterReadingCommentsSpecified
        {
            get
            {
                return ((this.MeterReadingComments != null) 
                            && (this.MeterReadingComments.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Meter Reading. Delivered_ Quantity. Quantity</ccts:DictionaryEntryName><ccts:Definition>Consumption in the period from PreviousMeterReadingDate to LatestMeterReadingDate.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Meter Reading</ccts:ObjectClass><ccts:PropertyTermQualifier>Delivered</ccts:PropertyTermQualifier><ccts:PropertyTerm>Quantity</ccts:PropertyTerm><ccts:RepresentationTerm>Quantity</ccts:RepresentationTerm><ccts:DataType>Quantity. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("DeliveredQuantity", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeliveredQuantityType DeliveredQuantity { get; set; }
    }
}
