using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalB_Pattern6 : JavaEntityTexture
    {
        public Fish_TropicalB_Pattern6() : base("Fish, Tropical B; Pattern 6")
        {
            AddVersion("tropical_b_pattern_6")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishB>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalB_Pattern6>();
        }
    }
}
