using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Bed_Blue : JavaEntityTexture
    {
        public Bed_Blue() : base("Bed, Blue")
        {
            AddVersion("blue")
                .WithPath("entity/bed")
                .WithDefaultModel<Java.Models.Entity.Bed>();
                //.MapsToBedrockEntity<BedrockEntities.Bed>();
        }
    }
}
