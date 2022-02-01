using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_Skeleton : JavaEntityTexture
    {
        public Horse_Skeleton() : base("Horse, Skeleton")
        {
            AddVersion("horse_skeleton")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_Skeleton>();
        }
    }
}
