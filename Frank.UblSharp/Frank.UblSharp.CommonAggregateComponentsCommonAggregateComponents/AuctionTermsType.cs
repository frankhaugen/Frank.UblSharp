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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe the terms to be fulfilled by tenderers if an auction is to be executed before the awarding of a tender.</ccts:Definition><ccts:ObjectClass>Auction Terms</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("AuctionTermsType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("AuctionTerms", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class AuctionTermsType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Auction_ Constraint. Indicator</ccts:DictionaryEntryName><ccts:Definition>Indicates whether an electronic auction will be used before the awarding of a contract (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Auction Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Auction</ccts:PropertyTermQualifier><ccts:PropertyTerm>Constraint</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AuctionConstraintIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AuctionConstraintIndicatorType AuctionConstraintIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.JustificationDescriptionType> _justificationDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Justification_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing a justification for the use of an auction in awarding the tender.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Auction Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Justification</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("JustificationDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.JustificationDescriptionType> JustificationDescription
        {
            get
            {
                return _justificationDescription;
            }
            set
            {
                _justificationDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die JustificationDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the JustificationDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool JustificationDescriptionSpecified
        {
            get
            {
                return ((this.JustificationDescription != null) 
                            && (this.JustificationDescription.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> _description;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text for tenderers describing terms governing the auction.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Auction Terms</ccts:ObjectClass><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Description", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionType> Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Description-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Description collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool DescriptionSpecified
        {
            get
            {
                return ((this.Description != null) 
                            && (this.Description.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcessDescriptionType> _processDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Process_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the auction process.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Auction Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Process</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ProcessDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcessDescriptionType> ProcessDescription
        {
            get
            {
                return _processDescription;
            }
            set
            {
                _processDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ProcessDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ProcessDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ProcessDescriptionSpecified
        {
            get
            {
                return ((this.ProcessDescription != null) 
                            && (this.ProcessDescription.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConditionsDescriptionType> _conditionsDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Conditions_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing the conditions under which the tenderers will be able to bid as part of the auction.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Auction Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Conditions</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ConditionsDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConditionsDescriptionType> ConditionsDescription
        {
            get
            {
                return _conditionsDescription;
            }
            set
            {
                _conditionsDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ConditionsDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ConditionsDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ConditionsDescriptionSpecified
        {
            get
            {
                return ((this.ConditionsDescription != null) 
                            && (this.ConditionsDescription.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ElectronicDeviceDescriptionType> _electronicDeviceDescription;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Electronic Device_ Description. Text</ccts:DictionaryEntryName><ccts:Definition>Text describing an electronic device used for the auction, including associated connectivity specifications.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Auction Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Electronic Device</ccts:PropertyTermQualifier><ccts:PropertyTerm>Description</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("ElectronicDeviceDescription", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ElectronicDeviceDescriptionType> ElectronicDeviceDescription
        {
            get
            {
                return _electronicDeviceDescription;
            }
            set
            {
                _electronicDeviceDescription = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ElectronicDeviceDescription-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ElectronicDeviceDescription collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ElectronicDeviceDescriptionSpecified
        {
            get
            {
                return ((this.ElectronicDeviceDescription != null) 
                            && (this.ElectronicDeviceDescription.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Auction Terms. Auction_ URI. Identifier</ccts:DictionaryEntryName><ccts:Definition>The Uniform Resource Identifier (URI) of the electronic device used for the auction.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Auction Terms</ccts:ObjectClass><ccts:PropertyTermQualifier>Auction</ccts:PropertyTermQualifier><ccts:PropertyTerm>URI</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AuctionURI", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AuctionUriType AuctionUri { get; set; }
    }
}