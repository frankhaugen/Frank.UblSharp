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
    
    
    /// <summary>
    /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007</ccts:UniqueID></para>
    /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">CCT</ccts:CategoryCode></para>
    /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code. Type</ccts:DictionaryEntryName></para>
    /// <para xml:lang="en"><ccts:VersionID xmlns:ccts="urn:un:unece:uncefact:documentation:2">1.0</ccts:VersionID></para>
    /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">A character string (letters, figures, or symbols) that for brevity and/or languange independence may be used to represent or replace a definitive value or text of an attribute together with relevant supplementary information.</ccts:Definition></para>
    /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code</ccts:RepresentationTermName></para>
    /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
    /// <para xml:lang="en"><ccts:UsageRule xmlns:ccts="urn:un:unece:uncefact:documentation:2">Should not be used if the character string identifies an instance of an object class or an object in the real world, in which case the Identifier. Type should be used.</ccts:UsageRule></para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "2.1.1144.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("CodeType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlRootAttribute("CodeType", Namespace="urn:un:unece:uncefact:data:specification:CoreComponentTypeSchemaModule:2")]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountFormatCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountingCostCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AccountTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ActionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ActivityTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AddressFormatCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AddressTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdjustmentReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AdmissionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AllowanceChargeReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ApplicationStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AvailabilityStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardingCriterionTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.AwardingMethodTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CalculationExpressionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CalculationMethodCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CapabilityTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CardChipCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CardTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CargoTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CertificateTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ChannelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CharacterSetCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.UnqualifiedDataTypesUnqualifiedDataTypes.CodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CollaborationPriorityCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CommodityCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyLegalFormCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CompanyLiquidationStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ComparisonDataCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ComparisonDataSourceCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConditionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConstitutionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumerIncentiveTacticTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumersEnergyLevelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumptionLevelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ConsumptionTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContractingSystemCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ContractTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CoordinateSystemCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CorporateRegistrationTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CorrectionTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CountrySubentityCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CreditNoteTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CurrentChargeTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.CustomsStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DataSourceCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DeclarationTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DescriptionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DespatchAdviceTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DirectionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DisplayTacticTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DispositionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentStatusReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DocumentTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.DutyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EmergencyProceduresCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EncodingCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EnvironmentalEmissionTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EvaluationCriterionTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.EvidenceTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExceptionResolutionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExceptionStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExecutionRequirementCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExemptionReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpenseCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ExpressionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonExtensionComponentsCommonExtensionComponents.ExtensionReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FeatureTacticTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FinancingInstrumentCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForecastPurposeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ForecastTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FormatCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FreightRateClassCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FullnessIndicationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.FundingProgramCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GenderCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.GuaranteeTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HandlingCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousCategoryCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HazardousRegulationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.HeatingTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IdentificationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ImportanceCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.IndustryClassificationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InhalationToxicityZoneCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InspectionMethodCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.InvoiceTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ItemClassificationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatestMeterReadingMethodCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LatitudeDirectionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LifeCycleStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LineStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LocaleCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LocationTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LongitudeDirectionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.LossRiskResponsibilityCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MandateTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MathematicOperatorCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MedicalFirstAidGuideCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterConstantCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MeterReadingTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MimeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.MiscellaneousEventTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NameCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NatureCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.NotificationTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OneTimeChargeTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderResponseCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OrderTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.OwnerTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackageLevelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackagingTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackingCriteriaCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PackLevelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ParentDocumentTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PartPresentationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PartyTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentAlternativeCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentChannelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentFrequencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentMeansCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PaymentPurposeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PerformanceMetricTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PositionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreferenceCriterionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousCancellationReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PreviousMeterReadingMethodCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceEvaluationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PriceTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PricingCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PrivacyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcedureCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcessReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcurementSubTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProcurementTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProfileStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PromotionalEventTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ProviderTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.PurposeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QualityControlCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.QuantityDiscrepancyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReceiptAdviceTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReferenceEventCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RejectActionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RejectReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ReminderTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RequestedInvoiceCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResidenceTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResolutionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ResponseCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RetailEventStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RevisionStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.RoleCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SealIssuerTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SealStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SecurityClassificationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ServiceInformationPreferenceCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ServiceTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ShippingPriorityLevelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ShortageActionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SizeTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SourceCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SpecificationTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.StatementTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.StatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.StatusReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubcontractingConditionsCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubmissionMethodCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubscriberTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SubstitutionStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.SupplyChainActivityTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TargetCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TariffClassCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TariffCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxCurrencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxExemptionReasonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxLevelCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TaxTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TelecommunicationsServiceCallCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TelecommunicationsServiceCategoryCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TelecommunicationsSupplyTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderEnvelopeTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TendererRequirementTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TendererRoleCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderResultCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TenderTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ThresholdValueComparisonCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TimeFrequencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TimingComplaintCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TrackingDeviceCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TradeItemPackingLabelingTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TradeServiceCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransitDirectionCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportationStatusTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportAuthorizationCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportEmergencyCardCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportEquipmentTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportEventTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportExecutionStatusCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportHandlingUnitTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportMeansTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportModeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TransportServiceCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.TypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UndgCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UrgencyCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.UtilityStatementTypeCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.ValidationResultCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WeekDayCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WeightingAlgorithmCodeType))]
    [XmlIncludeAttribute(typeof(Frank.UblSharp.CommonBasicComponentsCommonBasicComponents.WorkPhaseCodeType))]
    public partial class CodeType
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft den Text ab oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [XmlTextAttribute()]
        public string Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC2</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The identification of a list of codes.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identification</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("listID")]
        public string ListId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC3</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List. Agency. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">An agency that maintains one or more lists of codes.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Agency</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// <para xml:lang="en"><ccts:UsageRule xmlns:ccts="urn:un:unece:uncefact:documentation:2">Defaults to the UN/EDIFACT data element 3055 code list.</ccts:UsageRule></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("listAgencyID")]
        public string ListAgencyId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC4</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List. Agency Name. Text</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The name of the agency that maintains the list of codes.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Agency Name</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Text</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("listAgencyName")]
        public string ListAgencyName { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC5</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List. Name. Text</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The name of a list of codes.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Name</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Text</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("listName")]
        public string ListName { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC6</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List. Version. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The version of the list of codes.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Version</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("listVersionID")]
        public string ListVersionId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC7</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code. Name. Text</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The textual equivalent of the code content component.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Name</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Text</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC8</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Language. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The identifier of the language used in the code name.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Language</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identification</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("languageID")]
        public string LanguageId { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC9</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List. Uniform Resource. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The Uniform Resource Identifier that identifies where the code list is located.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Uniform Resource Identifier</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("listURI")]
        public string ListUri { get; set; }
        
        /// <summary>
        /// <para xml:lang="en"><ccts:UniqueID xmlns:ccts="urn:un:unece:uncefact:documentation:2">UNDT000007-SC10</ccts:UniqueID></para>
        /// <para xml:lang="en"><ccts:CategoryCode xmlns:ccts="urn:un:unece:uncefact:documentation:2">SC</ccts:CategoryCode></para>
        /// <para xml:lang="en"><ccts:DictionaryEntryName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List Scheme. Uniform Resource. Identifier</ccts:DictionaryEntryName></para>
        /// <para xml:lang="en"><ccts:Definition xmlns:ccts="urn:un:unece:uncefact:documentation:2">The Uniform Resource Identifier that identifies where the code list scheme is located.</ccts:Definition></para>
        /// <para xml:lang="en"><ccts:ObjectClass xmlns:ccts="urn:un:unece:uncefact:documentation:2">Code List Scheme</ccts:ObjectClass></para>
        /// <para xml:lang="en"><ccts:PropertyTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Uniform Resource Identifier</ccts:PropertyTermName></para>
        /// <para xml:lang="en"><ccts:RepresentationTermName xmlns:ccts="urn:un:unece:uncefact:documentation:2">Identifier</ccts:RepresentationTermName></para>
        /// <para xml:lang="en"><ccts:PrimitiveType xmlns:ccts="urn:un:unece:uncefact:documentation:2">string</ccts:PrimitiveType></para>
        /// </summary>
        [AllowNullAttribute()]
        [MaybeNullAttribute()]
        [XmlAttributeAttribute("listSchemeURI")]
        public string ListSchemeUri { get; set; }
    }
}