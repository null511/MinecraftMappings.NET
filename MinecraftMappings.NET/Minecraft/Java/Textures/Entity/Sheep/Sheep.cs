using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Sheep
{
    public class Sheep : JavaEntityTexture
    {
        public Sheep() : base("Sheep")
        {
            AddVersion("sheep")
                .WithDefaultModel<Java.Models.Entity.Sheep>();
                //.MapsToBedrockEntity<BedrockEntities.Sheep>();
        }
    }
}
