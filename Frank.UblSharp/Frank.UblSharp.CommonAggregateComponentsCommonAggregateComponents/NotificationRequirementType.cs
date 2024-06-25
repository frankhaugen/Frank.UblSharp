namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
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
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Notification Requirement. Details</ccts:DictionaryEntryName><ccts:Definition>A class to describe a notification requirement.</ccts:Definition><ccts:ObjectClass>Notification Requirement</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("NotificationRequirementType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlRootAttribute("NotificationRequirement", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class NotificationRequirementType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Notification Requirement. Notification Type Code. Code</ccts:DictionaryEntryName><ccts:Definition>A code signifying the type of notification (e.g., pickup status).</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Notification Requirement</ccts:ObjectClass><ccts:PropertyTerm>Notification Type Code</ccts:PropertyTerm><ccts:RepresentationTerm>Code</ccts:RepresentationTerm><ccts:DataType>Code. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("NotificationTypeCode", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NotificationTypeCodeType NotificationTypeCode { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Notification Requirement. Post Event Notification Duration. Measure</ccts:DictionaryEntryName><ccts:Definition>The length of time between the occurrence of a given event and the issuance of a notification.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Notification Requirement</ccts:ObjectClass><ccts:PropertyTerm>Post Event Notification Duration</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PostEventNotificationDurationMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PostEventNotificationDurationMeasureType PostEventNotificationDurationMeasure { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Notification Requirement. Pre Event Notification Duration. Measure</ccts:DictionaryEntryName><ccts:Definition>The length of time to elapse between the issuance of a notification and the occurrence of the event it relates to.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Notification Requirement</ccts:ObjectClass><ccts:PropertyTerm>Pre Event Notification Duration</ccts:PropertyTerm><ccts:RepresentationTerm>Measure</ccts:RepresentationTerm><ccts:DataType>Measure. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("PreEventNotificationDurationMeasure", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreEventNotificationDurationMeasureType PreEventNotificationDurationMeasure { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<PartyType> _notifyParty;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Notification Requirement. Notify_ Party. Party</ccts:DictionaryEntryName><ccts:Definition>A party to be notified.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Notification Requirement</ccts:ObjectClass><ccts:PropertyTermQualifier>Notify</ccts:PropertyTermQualifier><ccts:PropertyTerm>Party</ccts:PropertyTerm><ccts:AssociatedObjectClass>Party</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Party</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NotifyParty")]
        public List<PartyType> NotifyParty
        {
            get
            {
                return _notifyParty;
            }
            set
            {
                _notifyParty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NotifyParty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NotifyParty collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NotifyPartySpecified
        {
            get
            {
                return ((this.NotifyParty != null) 
                            && (this.NotifyParty.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<PeriodType> _notificationPeriod;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Notification Requirement. Notification_ Period. Period</ccts:DictionaryEntryName><ccts:Definition>A period during which a notification should be issued.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Notification Requirement</ccts:ObjectClass><ccts:PropertyTermQualifier>Notification</ccts:PropertyTermQualifier><ccts:PropertyTerm>Period</ccts:PropertyTerm><ccts:AssociatedObjectClass>Period</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Period</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NotificationPeriod")]
        public List<PeriodType> NotificationPeriod
        {
            get
            {
                return _notificationPeriod;
            }
            set
            {
                _notificationPeriod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NotificationPeriod-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NotificationPeriod collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NotificationPeriodSpecified
        {
            get
            {
                return ((this.NotificationPeriod != null) 
                            && (this.NotificationPeriod.Count != 0));
            }
        }
        
        [XmlIgnoreAttribute()]
        private List<LocationType> _notificationLocation;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Notification Requirement. Notification_ Location. Location</ccts:DictionaryEntryName><ccts:Definition>A location at which a notification should be issued.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Notification Requirement</ccts:ObjectClass><ccts:PropertyTermQualifier>Notification</ccts:PropertyTermQualifier><ccts:PropertyTerm>Location</ccts:PropertyTerm><ccts:AssociatedObjectClass>Location</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Location</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("NotificationLocation")]
        public List<LocationType> NotificationLocation
        {
            get
            {
                return _notificationLocation;
            }
            set
            {
                _notificationLocation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NotificationLocation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NotificationLocation collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool NotificationLocationSpecified
        {
            get
            {
                return ((this.NotificationLocation != null) 
                            && (this.NotificationLocation.Count != 0));
            }
        }
    }
}
