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
    [XmlTypeAttribute("CertIDListType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("SigningCertificate", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CertIdListType
    {
        
        [XmlIgnoreAttribute()]
        private List<CertIdType> _cert;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Cert")]
        public List<CertIdType> Cert
        {
            get
            {
                return _cert;
            }
            set
            {
                _cert = value;
            }
        }
    }
}
