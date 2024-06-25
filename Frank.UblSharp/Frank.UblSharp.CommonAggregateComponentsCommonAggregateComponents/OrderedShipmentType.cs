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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Ordered Shipment. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe an ordered shipment.</ccts:Definition><ccts:ObjectClass>Ordered Shipment</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("OrderedShipmentType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("OrderedShipment", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class OrderedShipmentType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Ordered Shipment. Shipment</ccts:DictionaryEntryName><ccts:Definition>The ordered shipment.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Ordered Shipment</ccts:ObjectClass><ccts:PropertyTerm>Shipment</ccts:PropertyTerm><ccts:AssociatedObjectClass>Shipment</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Shipment</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Shipment")]
        public ShipmentType Shipment { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PackageType> _package;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Ordered Shipment. Package</ccts:DictionaryEntryName><ccts:Definition>A package in this ordered shipment.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Ordered Shipment</ccts:ObjectClass><ccts:PropertyTerm>Package</ccts:PropertyTerm><ccts:AssociatedObjectClass>Package</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Package</ccts:RepresentationTerm></ccts:Component></para>
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
