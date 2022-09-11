using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Frog
{
    public class ColdFrog : JavaEntityTexture
    {
        public ColdFrog() : base("Frog, Cold")
        {
            AddVersion("cold_frog")
                .WithPath("entity/frog")
                .WithDefaultModel<Java.Models.Entity.Frog>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Black>();
        }
    }
}
