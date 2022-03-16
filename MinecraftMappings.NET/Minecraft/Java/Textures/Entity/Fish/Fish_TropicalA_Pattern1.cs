using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalA_Pattern1 : JavaEntityTexture
    {
        public Fish_TropicalA_Pattern1() : base("Fish, Tropical A; Pattern 1")
        {
            AddVersion("tropical_a_pattern_1")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishA>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalA_Pattern1>();
        }
    }
}
