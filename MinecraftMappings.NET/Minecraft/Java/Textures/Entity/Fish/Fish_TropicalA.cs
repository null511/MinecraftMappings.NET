using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Fish_TropicalA : JavaEntityTexture
    {
        public Fish_TropicalA() : base("Fish, Tropical A")
        {
            AddVersion("tropical_a")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.TropicalFishA>();
                //.MapsToBedrockEntity<BedrockEntities.Fish_TropicalA>();
        }
    }
}
