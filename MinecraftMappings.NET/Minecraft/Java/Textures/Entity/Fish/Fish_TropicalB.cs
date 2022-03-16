using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalB : JavaEntityTexture
    {
        public Fish_TropicalB() : base("Fish, Tropical B")
        {
            AddVersion("tropical_b")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishB>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalB>();
        }
    }
}
