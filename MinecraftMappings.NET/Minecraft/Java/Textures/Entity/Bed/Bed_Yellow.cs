using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bed
{
    public class Bed_Yellow : JavaEntityTexture
    {
        public Bed_Yellow() : base("Bed, Yellow")
        {
            AddVersion("yellow")
                .WithPath("entity/bed")
                .WithDefaultModel<Java.Models.Entity.Bed>();
                //.MapsToBedrockEntity<BedrockEntities.Bed>();
        }
    }
}
