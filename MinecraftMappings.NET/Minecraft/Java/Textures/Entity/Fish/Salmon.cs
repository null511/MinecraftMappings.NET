using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Salmon : JavaEntityTexture
    {
        public Salmon() : base("Salmon")
        {
            AddVersion("salmon")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.Salmon>();
                //.MapsToBedrockEntity<BedrockEntities.Salmon>();
        }
    }
}
