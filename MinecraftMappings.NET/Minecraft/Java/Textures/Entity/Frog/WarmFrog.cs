using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Frog
{
    public class WarmFrog : JavaEntityTexture
    {
        public WarmFrog() : base("Frog, Warm")
        {
            AddVersion("warm_frog")
                .WithPath("entity/frog")
                .WithDefaultModel<Java.Models.Entity.Frog>();
                //.MapsToBedrockEntity<BedrockEntities.Cat_Black>();
        }
    }
}
