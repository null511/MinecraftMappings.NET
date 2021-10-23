using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bed
{
    public class Bed_Gray : JavaEntityTexture
    {
        public Bed_Gray() : base("Bed, Gray")
        {
            AddVersion("gray")
                .WithPath("entity/bed")
                .WithDefaultModel<Java.Models.Entity.Bed>();
                //.MapsToBedrockEntity<BedrockEntities.Bed>();
        }
    }
}
