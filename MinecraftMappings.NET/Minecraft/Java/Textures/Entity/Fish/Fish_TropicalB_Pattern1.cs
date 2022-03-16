using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalB_Pattern1 : JavaEntityTexture
    {
        public Fish_TropicalB_Pattern1() : base("Fish, Tropical B; Pattern 1")
        {
            AddVersion("tropical_b_pattern_1")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishB>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalB_Pattern1>();
        }
    }
}
