using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Minecart : JavaEntityTexture
    {
        public Minecart() : base("Minecart")
        {
            AddVersion("minecart")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Minecart>();
                //.MapsToBedrockEntity<BedrockEntities.Minecart>();
        }
    }
}
