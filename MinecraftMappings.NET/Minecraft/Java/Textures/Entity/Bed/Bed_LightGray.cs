using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bed
{
    public class Bed_LightGray : JavaEntityTexture
    {
        public Bed_LightGray() : base("Bed, Light Gray")
        {
            AddVersion("light_gray")
                .WithPath("entity/bed")
                .WithDefaultModel<Java.Models.Entity.Bed>();
                //.MapsToBedrockEntity<BedrockEntities.Bed>();
        }
    }
}
