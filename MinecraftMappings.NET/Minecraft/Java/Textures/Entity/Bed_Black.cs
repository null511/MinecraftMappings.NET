using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class Bed_Black : JavaEntityTexture
    {
        public Bed_Black() : base("Bed, Black")
        {
            AddVersion("black")
                .WithPath("entity/bed")
                .WithDefaultModel<Java.Models.Entity.Bed>();
                //.MapsToBedrockEntity<BedrockEntities.Bed>();
        }
    }
}
