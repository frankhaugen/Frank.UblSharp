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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Secondary Hazard. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a secondary hazard associated with a hazardous item.</ccts:Definition><ccts:ObjectClass>Secondary Hazard</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("SecondaryHazardType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("SecondaryHazard", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class SecondaryHazardType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Secondary Hazard. Identifier</ccts:DictionaryEntryName><ccts:Definition>An identifier for this secondary hazard.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Secondary Hazard</ccts:ObjectClass><ccts:PropertyTerm>Identifier</ccts:PropertyTerm><ccts:RepresentationTerm>Identifier</ccts:RepresentationTerm><ccts:DataType>Identifier. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Secondary Hazard. Placard Notation. Text</ccts:DictionaryEntryName><ccts:Definition>Text of the placard notation corresponding to the hazard class of this secondary hazard. Can also be the hazard identification number of the orange placard (upper part) required on the means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Secondary Hazard</ccts:ObjectClass><ccts:PropertyTerm>Placard Notation</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>5.1 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlacardNotation", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PlacardNotationType PlacardNotation { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Secondary Hazard. Placard Endorsement. Text</ccts:DictionaryEntryName><ccts:Definition>Text of the placard endorsement for this secondary hazard that is to be shown on the shipping papers for a hazardous item. Can also be used for the number of the orange placard (lower part) required on the means of transport.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Secondary Hazard</ccts:ObjectClass><ccts:PropertyTerm>Placard Endorsement</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>2 </ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PlacardEndorsement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PlacardEndorsementType PlacardEndorsement { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Secondary Hazard. Emergency Procedures Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the emergency procedures for this secondary hazard.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Secondary Hazard</ccts:ObjectClass><ccts:PropertyTerm>Emergency Procedures Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType><ccts:AlternativeBusinessTerms>EMG code, EMS Page Number</ccts:AlternativeBusinessTerms></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EmergencyProceduresCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmergencyProceduresCodeType EmergencyProceduresCode { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExtensionType> _extension;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Secondary Hazard. Extension. Text</ccts:DictionaryEntryName><ccts:Definition>Additional information about the hazardous substance, which can be used (for example) to specify the type of regulatory requirements that apply to this secondary hazard.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Secondary Hazard</ccts:ObjectClass><ccts:PropertyTerm>Extension</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType><ccts:Examples>N.O.S. or a Waste Characteristics Code in conjunction with an EPA Waste Stream code </ccts:Examples></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("Extension", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExtensionType> Extension
        {
            get
            {
                return _extension;
            }
            set
            {
                _extension = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Extension-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Extension collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ExtensionSpecified
        {
            get
            {
                return ((this.Extension != null) 
                            && (this.Extension.Count != 0));
            }
        }
    }
}
