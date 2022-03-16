using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Strider
{
    public class Strider : JavaEntityTexture
    {
        public Strider() : base("Strider")
        {
            AddVersion("strider")
                .WithPath("entity")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Entity.Strider>();
                //.MapsToBedrockEntity<BedrockEntities.Strider>();
        }
    }
}
