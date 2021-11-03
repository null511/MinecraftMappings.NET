using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Trident : JavaEntityTexture
    {
        public Trident() : base("Trident")
        {
            AddVersion("trident")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Trident>();
                //.MapsToBedrockEntity<BedrockEntities.Trident>();
        }
    }
}
