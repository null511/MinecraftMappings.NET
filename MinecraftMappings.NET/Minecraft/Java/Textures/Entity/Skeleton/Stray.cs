using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Skeleton
{
    public class Stray : JavaEntityTexture
    {
        public Stray() : base("Stray")
        {
            AddVersion("stray")
                .WithDefaultModel<Java.Models.Entity.Skeleton>();
                //.MapsToBedrockEntity<BedrockEntities.Stray>();
        }
    }
}
