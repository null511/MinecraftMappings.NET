using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bed
{
    public class Bed_Green : JavaEntityTexture
    {
        public Bed_Green() : base("Bed, Green")
        {
            AddVersion("green")
                .WithPath("entity/bed")
                .WithDefaultModel<Java.Models.Entity.Bed>();
                //.MapsToBedrockEntity<BedrockEntities.Bed>();
        }
    }
}
