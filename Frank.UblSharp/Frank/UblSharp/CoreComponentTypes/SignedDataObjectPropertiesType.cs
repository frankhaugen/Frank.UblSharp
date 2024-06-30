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
    [XmlTypeAttribute("SignedDataObjectPropertiesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("SignedDataObjectProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class SignedDataObjectPropertiesType
    {

        [XmlElementAttribute("DataObjectFormat")]
        public Collection<DataObjectFormatType> DataObjectFormat { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the DataObjectFormat collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DataObjectFormatSpecified
        {
            get
            {
                return ((this.DataObjectFormat != null)
                            && (this.DataObjectFormat.Count != 0));
            }
        }

        [XmlElementAttribute("CommitmentTypeIndication")]
        public Collection<CommitmentTypeIndicationType> CommitmentTypeIndication { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the CommitmentTypeIndication collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool CommitmentTypeIndicationSpecified
        {
            get
            {
                return ((this.CommitmentTypeIndication != null)
                            && (this.CommitmentTypeIndication.Count != 0));
            }
        }

        [XmlElementAttribute("AllDataObjectsTimeStamp")]
        public Collection<XAdEsTimeStampType> AllDataObjectsTimeStamp { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the AllDataObjectsTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool AllDataObjectsTimeStampSpecified
        {
            get
            {
                return ((this.AllDataObjectsTimeStamp != null)
                            && (this.AllDataObjectsTimeStamp.Count != 0));
            }
        }

        [XmlElementAttribute("IndividualDataObjectsTimeStamp")]
        public Collection<XAdEsTimeStampType> IndividualDataObjectsTimeStamp { get; set; }

        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the IndividualDataObjectsTimeStamp collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool IndividualDataObjectsTimeStampSpecified
        {
            get
            {
                return ((this.IndividualDataObjectsTimeStamp != null)
                            && (this.IndividualDataObjectsTimeStamp.Count != 0));
            }
        }

        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("Id")]
        [KeyAttribute()]
        public string Id { get; set; }
    }
}
