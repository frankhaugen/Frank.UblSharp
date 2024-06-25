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
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("XAdESTimeStampType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlIncludeAttribute(typeof(AllDataObjectsTimeStamp))]
    [XmlIncludeAttribute(typeof(ArchiveTimeStamp))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CoreComponentTypes.ArchiveTimeStampV2))]
    [XmlIncludeAttribute(typeof(IndividualDataObjectsTimeStamp))]
    [XmlIncludeAttribute(typeof(RefsOnlyTimeStamp))]
    [XmlIncludeAttribute(typeof(SigAndRefsTimeStamp))]
    [XmlIncludeAttribute(typeof(SignatureTimeStamp))]
    [XmlIncludeAttribute(typeof(XAdEsTimeStamp))]
    public partial class XAdEsTimeStampType : GenericTimeStampType
    {
    }
}
