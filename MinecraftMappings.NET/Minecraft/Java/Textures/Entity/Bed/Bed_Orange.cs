using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bed
{
    public class Bed_Orange : JavaEntityTexture
    {
        public Bed_Orange() : base("Bed, Orange")
        {
            AddVersion("orange")
                .WithPath("entity/bed")
                .WithDefaultModel<Java.Models.Entity.Bed>();
                //.MapsToBedrockEntity<BedrockEntities.Bed>();
        }
    }
}
