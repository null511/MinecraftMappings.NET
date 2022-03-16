using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fox
{
    public class SnowFox : JavaEntityTexture
    {
        public SnowFox() : base("Snow Fox")
        {
            AddVersion("snow_fox")
                .WithPath("entity/fox")
                .WithDefaultModel<Java.Models.Entity.Fox>();
                //.MapsToBedrockEntity<BedrockEntities.Fox>();
        }
    }
}
