namespace Frank.UblSharp.CoreComponentTypes
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
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000002</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">CCT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">A set of finite-length sequences of binary octets.</ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">binary</ccts:PrimitiveType></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("BinaryObjectType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlRootAttribute("BinaryObjectType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes.BinaryObjectType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmbeddedDocumentBinaryObjectType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes.GraphicType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes.PictureType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes.SoundType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes.VideoType))]
    public partial class BinaryObjectType
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft den Text ab oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [XmlTextAttribute(DataType="base64Binary")]
        public Byte[] Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000002-SC2</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Format. Text</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The format of the binary content.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Format</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Text</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("format")]
        public string Format { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000002-SC3</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Mime. Code</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The mime type of the binary object.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Mime</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("mimeCode")]
        public string MimeCode { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000002-SC4</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Encoding. Code</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">Specifies the decoding algorithm of the binary object.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Encoding</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("encodingCode")]
        public string EncodingCode { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000002-SC5</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Character Set. Code</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The character set of the binary object if the mime type is text.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Character Set</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("characterSetCode")]
        public string CharacterSetCode { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000002-SC6</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Uniform Resource. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The Uniform Resource Identifier that identifies where the binary object is located.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Uniform Resource Identifier</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("uri")]
        public string Uri { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000002-SC7</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Filename.Text</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The filename of the binary object.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Filename</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Text</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("filename")]
        public string Filename { get; set; }
    }
}
