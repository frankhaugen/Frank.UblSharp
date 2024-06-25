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
    
    
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("TaxTotalType", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    [XmlIncludeAttribute(typeof(TaxTotal))]
    [XmlIncludeAttribute(typeof(WithholdingTaxTotal))]
    public partial class TaxTotalType
    {
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tax Total. Tax Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The total tax amount for a particular taxation scheme, e.g., VAT; the sum of the tax subtotals for each tax category within the taxation scheme.</ccts:Definition><ccts:Cardinality>1</ccts:Cardinality><ccts:ObjectClass>Tax Total</ccts:ObjectClass><ccts:PropertyTerm>Tax Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [RequiredAttribute(AllowEmptyStrings=true)]
        [XmlElementAttribute("TaxAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxAmountType TaxAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tax Total. Rounding Amount. Amount</ccts:DictionaryEntryName><ccts:Definition>The rounding amount (positive or negative) added to the calculated tax total to produce the rounded TaxAmount.</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tax Total</ccts:ObjectClass><ccts:PropertyTerm>Rounding Amount</ccts:PropertyTerm><ccts:RepresentationTerm>Amount</ccts:RepresentationTerm><ccts:DataType>Amount. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("RoundingAmount", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RoundingAmountType RoundingAmount { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tax Total. Tax Evidence_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that this total is recognized as legal evidence for taxation purposes (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tax Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Tax Evidence</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType><ccts:Examples>default is negative</ccts:Examples></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TaxEvidenceIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxEvidenceIndicatorType TaxEvidenceIndicator { get; set; }
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>BBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tax Total. Tax Included_ Indicator. Indicator</ccts:DictionaryEntryName><ccts:Definition>An indicator that tax is included in the calculation (true) or not (false).</ccts:Definition><ccts:Cardinality>0..1</ccts:Cardinality><ccts:ObjectClass>Tax Total</ccts:ObjectClass><ccts:PropertyTermQualifier>Tax Included</ccts:PropertyTermQualifier><ccts:PropertyTerm>Indicator</ccts:PropertyTerm><ccts:RepresentationTerm>Indicator</ccts:RepresentationTerm><ccts:DataType>Indicator. Type</ccts:DataType></ccts:Component></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlElementAttribute("TaxIncludedIndicator", Namespace="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxIncludedIndicatorType TaxIncludedIndicator { get; set; }
        
        [XmlIgnoreAttribute()]
        private List<TaxSubtotalType> _taxSubtotal;
        
        /// <summary>
        /// <para><ccts:Component xmlns:ccts="urn:un:unece:uncefact:documentation:2"><ccts:ComponentType>ASBIE</ccts:ComponentType><ccts:DictionaryEntryName>Tax Total. Tax Subtotal</ccts:DictionaryEntryName><ccts:Definition>One of the subtotals the sum of which equals the total tax amount for a particular taxation scheme.</ccts:Definition><ccts:Cardinality>0..n</ccts:Cardinality><ccts:ObjectClass>Tax Total</ccts:ObjectClass><ccts:PropertyTerm>Tax Subtotal</ccts:PropertyTerm><ccts:AssociatedObjectClass>Tax Subtotal</ccts:AssociatedObjectClass><ccts:RepresentationTerm>Tax Subtotal</ccts:RepresentationTerm></ccts:Component></para>
        /// </summary>
        [XmlElementAttribute("TaxSubtotal")]
        public List<TaxSubtotalType> TaxSubtotal
        {
            get
            {
                return _taxSubtotal;
            }
            set
            {
                _taxSubtotal = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TaxSubtotal-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TaxSubtotal collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public bool TaxSubtotalSpecified
        {
            get
            {
                return ((this.TaxSubtotal != null) 
                            && (this.TaxSubtotal.Count != 0));
            }
        }
    }
}
