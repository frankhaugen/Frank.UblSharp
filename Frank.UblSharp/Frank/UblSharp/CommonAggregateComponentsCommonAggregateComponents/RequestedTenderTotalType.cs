//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 2.1.1144.0
namespace Frank.UblSharp.CommonAggregateComponentsCommonAggregateComponents
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
    
    
    /// <summary>
    /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Details</ccts:DictionaryEntryName><ccts:Definition>A class defining budgeted monetary amounts.</ccts:Definition><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass></ccts:Component></para>
    /// </summary>
    [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ABIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Details</ccts:DictionaryEntryName><ccts:Definition>A class defining budgeted monetary amounts.</ccts:Definition><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass></ccts:Component>")]
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("RequestedTenderTotalType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [DebuggerStepThroughAttribute()]
    [XmlRootAttribute("RequestedTenderTotal", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public partial class RequestedTenderTotalType
    {
        
        /// <summary>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [DescriptionAttribute("Gets or sets a value uniquely identifying this entity.")]
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Estimated_ Overall Contract. Amount</ccts:DictionaryEntryName><ccts:Definition>The estimated overall monetary amount of a contract.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated</ccts:PropertyTermQualifier><ccts:PropertyTerm>Overall Contract</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Estimated_ Overall Contract. Amount</ccts:DictionaryEntryName><ccts:Definition>The estimated overall monetary amount of a contract.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Estimated</ccts:PropertyTermQualifier><ccts:PropertyTerm>Overall Contract</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("EstimatedOverallContractAmount", Order=0, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EstimatedOverallContractAmountType EstimatedOverallContractAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Total_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount of the total budget including net amount, taxes, and material and instalment costs. </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Total_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The monetary amount of the total budget including net amount, taxes, and material and instalment costs. </ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Total</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TotalAmount", Order=1, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TotalAmountType TotalAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Tax Included_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>Indicates whether the amounts are taxes included (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Tax Included</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Tax Included_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>Indicates whether the amounts are taxes included (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Tax Included</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TaxIncludedIndicator", Order=2, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxIncludedIndicatorType TaxIncludedIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Minimum_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The minimum monetary amount of the budget.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Minimum_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The minimum monetary amount of the budget.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Minimum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MinimumAmount", Order=3, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MinimumAmountType MinimumAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Maximum_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The maximum monetary amount of the budget.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Maximum_ Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The maximum monetary amount of the budget.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Maximum</ccts:PropertyTermQualifier><ccts:PropertyTerm>Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("MaximumAmount", Order=4, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MaximumAmountType MaximumAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MonetaryScopeType> _monetaryScope;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Monetary Scope. Text</ccts:DictionaryEntryName><ccts:Definition>A description of the monetary scope of the budget.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTerm>Monetary Scope</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Monetary Scope. Text</ccts:DictionaryEntryName><ccts:Definition>A description of the monetary scope of the budget.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTerm>Monetary Scope</ccts:PropertyTerm><ccts:RepresentationTerm>Text</ccts:RepresentationTerm><ccts:DataType>Text. Type</ccts:DataType></ccts:Component>")]
        [XmlElementAttribute("MonetaryScope", Order=5, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public List<Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MonetaryScopeType> MonetaryScope
        {
            get
            {
                return _monetaryScope;
            }
            set
            {
                _monetaryScope = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the MonetaryScope collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool MonetaryScopeSpecified
        {
            get
            {
                return ((this.MonetaryScope != null) 
                            && (this.MonetaryScope.Count != 0));
            }
        }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Average_ Subsequent Contract. Amount</ccts:DictionaryEntryName><ccts:Definition>The average monetary amount for the subsequent contracts following this budget amount.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Average</ccts:PropertyTermQualifier><ccts:PropertyTerm>Subsequent Contract</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Average_ Subsequent Contract. Amount</ccts:DictionaryEntryName><ccts:Definition>The average monetary amount for the subsequent contracts following this budget amount.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Average</ccts:PropertyTermQualifier><ccts:PropertyTerm>Subsequent Contract</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component>")]
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("AverageSubsequentContractAmount", Order=6, Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AverageSubsequentContractAmountType AverageSubsequentContractAmount { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TaxCategoryType> _applicableTaxCategory;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Applicable_ Tax Category. Tax Category</ccts:DictionaryEntryName><ccts:Definition>Describes the categories of taxes that apply to the budget amount.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Applicable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tax Category</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Category</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Category</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [DescriptionAttribute(@"<ccts:Component xmlns:ccts=""urn:un:unece:uncefact:documentation:2""><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Requested Tender Total. Applicable_ Tax Category. Tax Category</ccts:DictionaryEntryName><ccts:Definition>Describes the categories of taxes that apply to the budget amount.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Requested Tender Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Applicable</ccts:PropertyTermQualifier><ccts:PropertyTerm>Tax Category</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Category</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Category</ccts:RepresentationTerm></ccts:Component>")]
        [XmlElementAttribute("ApplicableTaxCategory", Order=7)]
        public List<TaxCategoryType> ApplicableTaxCategory
        {
            get
            {
                return _applicableTaxCategory;
            }
            set
            {
                _applicableTaxCategory = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicableTaxCategory collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ApplicableTaxCategorySpecified
        {
            get
            {
                return ((this.ApplicableTaxCategory != null) 
                            && (this.ApplicableTaxCategory.Count != 0));
            }
        }
    }
}
