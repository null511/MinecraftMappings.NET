using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Hoglin
{
    public class Zoglin : JavaEntityTexture
    {
        public Zoglin() : base("Zoglin")
        {
            AddVersion("zoglin")
                .WithPath("entity/hoglin")
                .WithDefaultModel<Java.Models.Entity.Zoglin>();
                //.MapsToBedrockEntity<BedrockEntities.Zoglin>();
        }
    }
}
