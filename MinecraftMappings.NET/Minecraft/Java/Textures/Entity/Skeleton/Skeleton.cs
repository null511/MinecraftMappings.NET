using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Skeleton
{
    public class Skeleton : JavaEntityTexture
    {
        public Skeleton() : base("Skeleton")
        {
            AddVersion("skeleton")
                .WithDefaultModel<Java.Models.Entity.Skeleton>();
                //.MapsToBedrockEntity<BedrockEntities.Skeleton>();
        }
    }
}
