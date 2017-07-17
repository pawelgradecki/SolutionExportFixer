namespace SolutionExportFixer
{
    public enum SolutionComponentType
    {
        Entity = 1,
        Attribute = 2,
        Relationship = 3,
        /// <summary>
        /// Value of an option set
        /// </summary>
        AttributePicklistValue = 4,
        /// <summary>
        /// Value of a lookup
        /// </summary>
        AttributeLookupValue = 5,
        /// <summary>
        /// Component mapping some special columns for views
        /// </summary>
        ViewAttribute = 6,
        LocalizedLabel = 7,
        /// <summary>
        /// Internal configuration table
        /// </summary>
        RelationshipExtraCondition = 8,
        OptionSet = 9,
        /// <summary>
        /// Replaced by Connections in CRM 2011, still available for legacy reasons
        /// </summary>
        EntityRelationship = 10,
        /// <summary>
        /// Relationship roles were depreciated in CRM 2011, as it intriduced Connections, that were more powerful version of RelationshipRoles
        /// </summary>
        EntityRelationshipRole = 11,
        /// <summary>
        /// Additional information about EntityRelationship. 
        /// </summary>
        EntityRelationshipRelationships = 12,
        ManagedProperty = 13,
        EntityKey = 14,
        Role = 20,
        RolePrivilege = 21,
        DisplayString = 22,
        DisplayStringMap = 23,
        Form = 24,
        Organization = 25,
        SavedQuery = 26,
        Workflow = 29,
        Report = 31,
        ReportEntity = 32,
        ReportCategory = 33,
        ReportVisibility = 34,
        Attachment = 35,
        EmailTemplate = 36,
        ContractTemplate = 37,
        KBArticleTemplate = 38,
        MailMergeTemplate = 39,
        DuplicateRule = 44,
        DuplicateRuleCondition = 45,
        EntityMap = 46,
        AttributeMap = 47,
        RibbonCommand = 48,
        RibbonContextGroup = 49,
        RibbonCustomization = 50,
        RibbonRule = 52,
        RibbonTabToCommandMap = 53,
        RibbonDiff = 55,
        SavedQueryVisualization = 59,
        SystemForm = 60,
        WebResource = 61,
        SiteMap = 62,
        ConnectionRole = 63,
        FieldSecurityProfile = 70,
        FieldPermission = 71,
        PluginType = 90,
        PluginAssembly = 91,
        SdkMessageProcessingStep = 92,
        SdkMessageProcessingStepImage = 93,
        ServiceEndpoint = 95,
        RoutingRule = 150,
        RoutingRuleItem = 151,
        SLA = 152,
        SLAItem = 153,
        ConvertRule = 154,
        ConvertRuleItem = 155,
        HierarchyRule = 65,
        MobileOfflineProfile = 161,
        MobileOfflineProfileItem = 162,
        SimilarityRule = 165,
        CustomControl = 66,
        CustomControlDefaultConfig = 68,
        App = 80
    }
}
