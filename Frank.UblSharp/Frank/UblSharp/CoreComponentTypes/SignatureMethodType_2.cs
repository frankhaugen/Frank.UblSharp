//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.CoreComponentTypes
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;


    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("SignatureMethodType", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("SignatureMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureMethodType_2
    {

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }

        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [XmlElementAttribute("HMACOutputLength")]
        public int HmacOutputLengthValue { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HmacOutputLength property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HmacOutputLengthValueSpecified { get; set; }

        [XmlIgnoreAttribute()]
        public Nullable<int> HmacOutputLength
        {
            get
            {
                if (this.HmacOutputLengthValueSpecified)
                {
                    return this.HmacOutputLengthValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HmacOutputLengthValue = value.GetValueOrDefault();
                this.HmacOutputLengthValueSpecified = value.HasValue;
            }
        }

        [XmlAnyElementAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public Collection<System.Xml.Linq.XElement> Any { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool AnySpecified
        {
            get
            {
                return ((this.Any != null)
                            && (this.Any.Count != 0));
            }
        }

        [RequiredAttribute(AllowEmptyStrings = true)]
        [XmlAttributeAttribute("Algorithm")]
        public string Algorithm { get; set; }

        [XmlTextAttribute()]
        public string[] Text { get; set; }
    }
}
