using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Strider
{
    public class Strider_Cold : JavaEntityTexture
    {
        public Strider_Cold() : base("Strider, Cold")
        {
            AddVersion("strider_cold")
                .WithPath("entity")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Entity.Strider>();
                //.MapsToBedrockEntity<BedrockEntities.Strider>();
        }
    }
}
