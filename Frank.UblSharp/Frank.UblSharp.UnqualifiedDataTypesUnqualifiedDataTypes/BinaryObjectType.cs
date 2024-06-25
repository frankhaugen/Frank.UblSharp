namespace Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes
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
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UBLUDT000002</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">UDT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">A set of finite-length sequences of binary octets.</ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Binary Object</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">binary</ccts:PrimitiveType></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("BinaryObjectType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    [XmlRootAttribute("BinaryObjectType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:UnqualifiedDataTypes-2")]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmbeddedDocumentBinaryObjectType))]
    public partial class BinaryObjectType : Frank.UblSharp.CoreComponentTypes.BinaryObjectType
    {
    }
}