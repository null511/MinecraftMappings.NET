using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalA_Pattern3 : JavaEntityTexture
    {
        public Fish_TropicalA_Pattern3() : base("Fish, Tropical A; Pattern 3")
        {
            AddVersion("tropical_a_pattern_3")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishA>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalA_Pattern3>();
        }
    }
}
