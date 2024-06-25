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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Lot Identification. Details</ccts:DictionaryEntryName><ccts:Definition>A class for defining a lot identifier (the identifier of a set of item instances that would be used in case of a recall of that item).</ccts:Definition><ccts:ObjectClass>Lot Identification</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("LotIdentificationType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("LotIdentification", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class LotIdentificationType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Lot Identification. Lot Number. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for the lot.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Lot Identification</ccts:ObjectClass><ccts:PropertyTerm>Lot Number</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("LotNumberID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LotNumberIdType LotNumberId { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Lot Identification. Expiry Date. Date</ccts:DictionaryEntryName><ccts:Definition>The expiry date of the lot.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Lot Identification</ccts:ObjectClass><ccts:PropertyTerm>Expiry Date</ccts:PropertyTerm><ccts:RepresentationTerm>Date</ccts:RepresentationTerm><ccts:DataType>Date. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExpiryDate", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpiryDateType ExpiryDate { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<ItemPropertyType> _additionalItemProperty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Lot Identification. Additional_ Item Property. Item Property</ccts:DictionaryEntryName><ccts:Definition>An additional property of the lot.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Lot Identification</ccts:ObjectClass><ccts:PropertyTermQualifier>Additional</ccts:PropertyTermQualifier><ccts:PropertyTerm>Item Property</ccts:PropertyTerm><ccts:AssociatedObjectClass>Item Property</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Item Property</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("AdditionalItemProperty")]
        public List<ItemPropertyType> AdditionalItemProperty
        {
            get
            {
                return _additionalItemProperty;
            }
            set
            {
                _additionalItemProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalItemProperty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalItemProperty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool AdditionalItemPropertySpecified
        {
            get
            {
                return ((this.AdditionalItemProperty != null) 
                            && (this.AdditionalItemProperty.Count != 0));
            }
        }
    }
}
