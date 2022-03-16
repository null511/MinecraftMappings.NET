using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalA_Pattern4 : JavaEntityTexture
    {
        public Fish_TropicalA_Pattern4() : base("Fish, Tropical A; Pattern 4")
        {
            AddVersion("tropical_a_pattern_4")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishA>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalA_Pattern4>();
        }
    }
}
