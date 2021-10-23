using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Blaze : JavaEntityTexture
    {
        public Blaze() : base("Blaze")
        {
            AddVersion("blaze")
                .WithDefaultModel<Java.Models.Entity.Blaze>();
                //.MapsToBedrockEntity<BedrockEntities.Blaze>();
        }
    }
}
