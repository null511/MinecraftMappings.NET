using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fox
{
    public class SnowFox_Sleep : JavaEntityTexture
    {
        public SnowFox_Sleep() : base("Snow Fox, Sleep")
        {
            AddVersion("snow_fox_sleep")
                .WithPath("entity/fox")
                .WithDefaultModel<Java.Models.Entity.Fox>();
                //.MapsToBedrockEntity<BedrockEntities.Fox>();
        }
    }
}
