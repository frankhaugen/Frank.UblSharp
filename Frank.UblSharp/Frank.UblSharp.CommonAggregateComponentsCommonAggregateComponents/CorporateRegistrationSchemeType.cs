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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Corporate Registration Scheme. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a scheme for corporate registration.</ccts:Definition><ccts:ObjectClass>Corporate Registration Scheme</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CorporateRegistrationSchemeType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("CorporateRegistrationScheme", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class CorporateRegistrationSchemeType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Corporate Registration Scheme. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this registration scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Corporate Registration Scheme</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType><ccts:Examples>ASIC in Australia</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Corporate Registration Scheme. Name</ccts:DictionaryEntryName><ccts:Definition>The name of this registration scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Corporate Registration Scheme</ccts:ObjectClass><ccts:PropertyTerm>Name</ccts:PropertyTerm><ccts:RepresentationTerm>Name</ccts:RepresentationTerm><ccts:DataType>Name. Type</ccts:DataType><ccts:Examples>Australian Securities and Investment Commission in Australia</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Corporate Registration Scheme. Corporate Registration Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of this registration scheme.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Corporate Registration Scheme</ccts:ObjectClass><ccts:PropertyTerm>Corporate Registration Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:Examples>ACN </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CorporateRegistrationTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CorporateRegistrationTypeCodeType CorporateRegistrationTypeCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<AddressType> _jurisdictionRegionAddress;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Corporate Registration Scheme. Jurisdiction Region_ Address. Address</ccts:DictionaryEntryName><ccts:Definition>A geographic area in which this registration scheme applies.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Corporate Registration Scheme</ccts:ObjectClass><ccts:PropertyTermQualifier>Jurisdiction Region</ccts:PropertyTermQualifier><ccts:PropertyTerm>Address</ccts:PropertyTerm><ccts:AssociatedObjectClass>Address</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Address</ccts:RepresentationTerm><ccts:Examples>England , Wales </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("JurisdictionRegionAddress")]
        public List<AddressType> JurisdictionRegionAddress
        {
            get
            {
                return _jurisdictionRegionAddress;
            }
            set
            {
                _jurisdictionRegionAddress = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die JurisdictionRegionAddress-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the JurisdictionRegionAddress collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool JurisdictionRegionAddressSpecified
        {
            get
            {
                return ((this.JurisdictionRegionAddress != null) 
                            && (this.JurisdictionRegionAddress.Count != 0));
            }
        }
    }
}
