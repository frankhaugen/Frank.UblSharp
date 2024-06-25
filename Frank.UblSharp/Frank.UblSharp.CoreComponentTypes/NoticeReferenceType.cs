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
    [XmlTypeAttribute("NoticeReferenceType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class NoticeReferenceType
    {
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("Organization")]
        public string Organization { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<int> _noticeNumbers;
        
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlArrayAttribute("NoticeNumbers")]
        [XmlArrayItemAttribute("int", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<int> NoticeNumbers
        {
            get
            {
                return _noticeNumbers;
            }
            set
            {
                _noticeNumbers = value;
            }
        }
    }
}