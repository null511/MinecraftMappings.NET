using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Hoglin
{
    public class Hoglin : JavaEntityTexture
    {
        public Hoglin() : base("Hoglin")
        {
            AddVersion("hoglin")
                .WithPath("entity/hoglin")
                .WithDefaultModel<Java.Models.Entity.Hoglin>();
                //.MapsToBedrockEntity<BedrockEntities.Hoglin>();
        }
    }
}
