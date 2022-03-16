using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalA_Pattern6 : JavaEntityTexture
    {
        public Fish_TropicalA_Pattern6() : base("Fish, Tropical A; Pattern 6")
        {
            AddVersion("tropical_a_pattern_6")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishA>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalA_Pattern6>();
        }
    }
}
