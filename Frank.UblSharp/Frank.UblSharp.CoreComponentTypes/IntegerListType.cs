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
    [XmlTypeAttribute("IntegerListType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IntegerListType
    {
        
        [XmlIgnoreAttribute()]
        private List<int> _int;
        
        [XmlElementAttribute("int")]
        public List<int> Int
        {
            get
            {
                return _int;
            }
            set
            {
                _int = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Int-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Int collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool IntSpecified
        {
            get
            {
                return ((this.Int != null) 
                            && (this.Int.Count != 0));
            }
        }
    }
}
