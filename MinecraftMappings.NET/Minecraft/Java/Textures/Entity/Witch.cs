using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Witch : JavaEntityTexture
    {
        public Witch() : base("Witch")
        {
            AddVersion("witch")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Witch>();
                //.MapsToBedrockEntity<BedrockEntities.Witch>();
        }
    }
}
