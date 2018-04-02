using System;
using EnvironmentGenerator.Interfaces;

namespace EnvironmentGenerator.Environment
{
    /// <summary>
    /// Factory class for producing an environment generator object,
    /// according to the specified environment type.
    /// </summary>
    public class EnvironmentGeneratorFactory
    {
        public static IEnvironmentGenerator Create(EnvironmentTypes envType)
        {
            switch (envType)
            {
                case EnvironmentTypes.Future:
                    return new EnvironmentGeneratorFuture();
                case EnvironmentTypes.Medieval:
                    return new EnvironmentGeneratorMedieval();
                default:
                    throw new ArgumentException($"No class corresponding to environment type {envType} is available.");
            }
        }
    }
}