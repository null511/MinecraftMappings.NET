using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalA_Pattern5 : JavaEntityTexture
    {
        public Fish_TropicalA_Pattern5() : base("Fish, Tropical A; Pattern 5")
        {
            AddVersion("tropical_a_pattern_5")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishA>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalA_Pattern5>();
        }
    }
}
