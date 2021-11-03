using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Bat : JavaEntityTexture
    {
        public Bat() : base("Bat")
        {
            AddVersion("bat")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Bat>();
                //.MapsToBedrockEntity<BedrockEntities.Bat>();
        }
    }
}
