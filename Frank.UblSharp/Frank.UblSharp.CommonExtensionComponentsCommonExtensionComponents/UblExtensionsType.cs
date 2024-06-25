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
    /// <para>A container for all extensions present in the document.</para>
    /// <para>A container for all extensions present in the document.</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("UBLExtensionsType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    [XmlRootAttribute("UBLExtensions", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2")]
    public partial class UblExtensionsType
    {
        
        [XmlIgnoreAttribute()]
        private List<UblExtensionType> _ublExtension;
        
        /// <summary>
        /// <para>A single extension for private use.</para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("UBLExtension")]
        public List<UblExtensionType> UblExtension
        {
            get
            {
                return _ublExtension;
            }
            set
            {
                _ublExtension = value;
            }
        }
    }
}
