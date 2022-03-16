using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalA_Pattern2 : JavaEntityTexture
    {
        public Fish_TropicalA_Pattern2() : base("Fish, Tropical A; Pattern 2")
        {
            AddVersion("tropical_a_pattern_2")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishA>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalA_Pattern2>();
        }
    }
}
