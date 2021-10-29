using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Wither
{
    public class Wither : JavaEntityTexture
    {
        public Wither() : base("Wither")
        {
            AddVersion("wither")
                .WithDefaultModel<Java.Models.Entity.Wither>();
                //.MapsToBedrockEntity<BedrockEntities.Wither>();
        }
    }
}
