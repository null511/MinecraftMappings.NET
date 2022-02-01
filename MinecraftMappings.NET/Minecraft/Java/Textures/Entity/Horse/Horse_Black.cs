using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse
{
    public class Horse_Black : JavaEntityTexture
    {
        public Horse_Black() : base("Horse, Black")
        {
            AddVersion("horse_black")
                .WithPath("entity/horse")
                .WithDefaultModel<Java.Models.Entity.Horse>();
                //.MapsToBedrockEntity<BedrockEntities.Horse_Black>();
        }
    }
}
