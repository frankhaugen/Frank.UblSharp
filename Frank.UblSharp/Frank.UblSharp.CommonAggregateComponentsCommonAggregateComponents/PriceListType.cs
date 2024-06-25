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
    [XmlTypeAttribute("PriceListType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(PreviousPriceList))]
    [XmlIncludeAttribute(typeof(PriceList))]
    public partial class PriceListType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price List. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this price list.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price List</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id {get;set;}
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price List. Status Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying whether this price list is an original, copy, revision, or cancellation.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price List</ccts:ObjectClass><ccts:PropertyTerm>Status Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>new - announcement only , new and available , deleted - announcement only </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StatusCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.StatusCodeType StatusCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PeriodType> _validityPeriod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price List. Validity_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>A period during which this price list is valid.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Price List</ccts:ObjectClass><ccts:PropertyTermQualifier>Validity</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ValidityPeriod")]
        public List<PeriodType> ValidityPeriod
        {
            get
            {
                return _validityPeriod;
            }
            set
            {
                _validityPeriod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ValidityPeriod-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ValidityPeriod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ValidityPeriodSpecified
        {
            get
            {
                return ((this.ValidityPeriod != null) 
                            && (this.ValidityPeriod.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Price List. Previous_ Price List. Price List</ccts:DictionaryEntryName><ccts:Definition>The previous price list.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Price List</ccts:ObjectClass><ccts:PropertyTermQualifier>Previous</ccts:PropertyTermQualifier><ccts:PropertyTerm>Price List</ccts:PropertyTerm><ccts:AssociatedObjectClass>Price List</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Price List</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreviousPriceList")]
        public PriceListType PreviousPriceList { get; set; }
    }
}
