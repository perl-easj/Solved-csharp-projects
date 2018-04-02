using EnvironmentGenerator.ImplMedieval;

namespace EnvironmentGenerator.Environment
{
    /// <summary>
    /// Implements an Asbtract Factory, which will only 
    /// generate objects from the Medieval era.
    /// </summary>
    public class EnvironmentGeneratorMedieval : EnvironmentGeneratorBase
    {
        public EnvironmentGeneratorMedieval() : base(
            new BuildingFactoryMedieval(), 
            new CreatureFactoryMedieval(),
            new WeaponFactoryMedieval())
        {
        }
    }
}   