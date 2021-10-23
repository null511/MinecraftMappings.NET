using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bear
{
    public class PolarBear : JavaEntityTexture
    {
        public PolarBear() : base("Polar Bear")
        {
            AddVersion("polarbear")
                .WithDefaultModel<Java.Models.Entity.PolarBear>();
                //.MapsToBedrockEntity<BedrockEntities.PolarBear>();
        }
    }
}
