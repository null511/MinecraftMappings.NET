using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_White : JavaEntityTexture
    {
        public Horse_White() : base("Horse, White")
        {
            AddVersion("horse_white")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_White>();
        }
    }
}
