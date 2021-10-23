using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Pig
{
    public class PigSaddle : JavaEntityTexture
    {
        public PigSaddle() : base("Pig Saddle")
        {
            AddVersion("pig_saddle")
                .WithPath("entity/pig")
                .WithBaseLayer<Pig>()
                .WithDefaultModel<Java.Models.Entity.Pig>();
                //.MapsToBedrockEntity<BedrockEntities.PigSaddle>();
        }
    }
}
