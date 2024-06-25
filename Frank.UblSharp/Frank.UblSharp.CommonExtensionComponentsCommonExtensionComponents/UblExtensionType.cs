namespace Frank.UblSharp.CommonExtensionComponentsCommonExtensionComponents
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
    /// <para>A single extension for private use.</para>
    /// <para>A single extension for private use.</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("UBLExtensionType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRootAttribute("UBLExtension", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class UblExtensionType
    {
        
        /// <summary>
        /// <para>An identifier for the Extension assigned by the creator of the extension.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ID", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdType Id { get; set; }
        
        /// <summary>
        /// <para>A name for the Extension assigned by the creator of the extension.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("Name", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameType Name { get; set; }
        
        /// <summary>
        /// <para>An agency that maintains one or more Extensions.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExtensionAgencyID")]
        public ExtensionAgencyIdType ExtensionAgencyId { get; set; }
        
        /// <summary>
        /// <para>The name of the agency that maintains the Extension.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExtensionAgencyName")]
        public ExtensionAgencyNameType ExtensionAgencyName { get; set; }
        
        /// <summary>
        /// <para>The version of the Extension.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExtensionVersionID")]
        public ExtensionVersionIdType ExtensionVersionId { get; set; }
        
        /// <summary>
        /// <para>A URI for the Agency that maintains the Extension.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExtensionAgencyURI")]
        public ExtensionAgencyUriType ExtensionAgencyUri { get; set; }
        
        /// <summary>
        /// <para>A URI for the Extension.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExtensionURI")]
        public ExtensionUriType ExtensionUri { get; set; }
        
        /// <summary>
        /// <para>A code for reason the Extension is being included.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExtensionReasonCode")]
        public ExtensionReasonCodeType ExtensionReasonCode { get; set; }
        
        /// <summary>
        /// <para>A description of the reason for the Extension.</para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("ExtensionReason")]
        public ExtensionReasonType ExtensionReason { get; set; }
        
        /// <summary>
        /// <para>The definition of the extension content.</para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("ExtensionContent")]
        public ExtensionContentType ExtensionContent { get; set; }
    }
}
