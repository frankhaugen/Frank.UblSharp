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
    [XmlTypeAttribute("SignerRoleType", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    [XmlRootAttribute("SignerRole", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignerRoleType
    {
        
        [XmlIgnoreAttribute()]
        private List<AnyType> _claimedRoles;
        
        [XmlArrayAttribute("ClaimedRoles")]
        [XmlArrayItemAttribute("ClaimedRole", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<AnyType> ClaimedRoles
        {
            get
            {
                return _claimedRoles;
            }
            set
            {
                _claimedRoles = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ClaimedRoles-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ClaimedRoles collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool ClaimedRolesSpecified
        {
            get
            {
                return ((this.ClaimedRoles != null) 
                            && (this.ClaimedRoles.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<EncapsulatedPkiDataType> _certifiedRoles;
        
        [XmlArrayAttribute("CertifiedRoles")]
        [XmlArrayItemAttribute("CertifiedRole", Namespace="http://uri.etsi.org/01903/v1.3.2#")]
        public List<EncapsulatedPkiDataType> CertifiedRoles
        {
            get
            {
                return _certifiedRoles;
            }
            set
            {
                _certifiedRoles = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CertifiedRoles-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CertifiedRoles collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool CertifiedRolesSpecified
        {
            get
            {
                return ((this.CertifiedRoles != null) 
                            && (this.CertifiedRoles.Count != 0));
            }
        }
    }
}
