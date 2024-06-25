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
    [XmlTypeAttribute("SignatureProductionPlaceType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("SignatureProductionPlace", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignatureProductionPlaceType
    {
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("City")]
        public string City { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("StateOrProvince")]
        public string StateOrProvince { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PostalCode")]
        public string PostalCode { get; set; }
        
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("CountryName")]
        public string CountryName { get; set; }
    }
}
