using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalB_Pattern3 : JavaEntityTexture
    {
        public Fish_TropicalB_Pattern3() : base("Fish, Tropical B; Pattern 3")
        {
            AddVersion("tropical_b_pattern_3")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishB>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalB_Pattern3>();
        }
    }
}
