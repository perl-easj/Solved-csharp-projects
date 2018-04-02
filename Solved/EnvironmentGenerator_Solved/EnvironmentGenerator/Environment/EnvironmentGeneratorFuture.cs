using EnvironmentGenerator.ImplFuture;

namespace EnvironmentGenerator.Environment
{
    /// <summary>
    /// Implements an Asbtract Factory, which will only 
    /// generate objects from the Future era.
    /// </summary>
    public class EnvironmentGeneratorFuture : EnvironmentGeneratorBase
    {
        public EnvironmentGeneratorFuture() : base(
            new BuildingFactoryFuture(), 
            new CreatureFactoryFuture(), 
            new WeaponFactoryFuture())
        {
        }
    }
}