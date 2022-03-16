using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Goat
{
    public class Goat : JavaEntityTexture
    {
        public Goat() : base("Goat")
        {
            AddVersion("goat")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Goat>();
                //.MapsToBedrockEntity<BedrockEntities.Goat>();
        }
    }
}
