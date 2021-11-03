using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class GuardianElder : JavaEntityTexture
    {
        public GuardianElder() : base("Guardian Elder")
        {
            AddVersion("guardian_elder")
                .WithDefaultModel<Java.Models.Entity.Guardian>();
                //.MapsToBedrockEntity<BedrockEntities.GuardianElder>();
        }
    }
}
