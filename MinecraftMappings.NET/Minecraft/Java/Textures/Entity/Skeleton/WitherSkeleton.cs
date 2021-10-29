using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Skeleton
{
    public class WitherSkeleton : JavaEntityTexture
    {
        public WitherSkeleton() : base("Wither Skeleton")
        {
            AddVersion("wither_skeleton")
                .WithDefaultModel<Java.Models.Entity.WitherSkeleton>();
                //.MapsToBedrockEntity<BedrockEntities.WitherSkeleton>();
        }
    }
}
