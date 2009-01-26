using System;

namespace FluentNHibernate.Mapping
{
    public interface IIdentityPart : IMappingPart, IAccessStrategy<IIdentityPart>
    {
        IdentityGenerationStrategyBuilder GeneratedBy { get; }
        Type IdentityType { get; }
        
        /// <summary>
        /// Set the access and naming strategy for this identity.
        /// </summary>
        IIdentityPart SetGeneratorClass(string generator);
        IIdentityPart AddGeneratorParam(string name, string innerXml);

        /// <summary>
        /// Sets the unsaved-value of the identity.
        /// </summary>
        /// <param name="unsavedValue">Value that represents an unsaved value.</param>
        IIdentityPart WithUnsavedValue(object unsavedValue);

        /// <summary>
        /// Sets the column name for the identity field.
        /// </summary>
        /// <param name="columnName">Column name</param>
        IIdentityPart TheColumnNameIs(string columnName);
    }
}