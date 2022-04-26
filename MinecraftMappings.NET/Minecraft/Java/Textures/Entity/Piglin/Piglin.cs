using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Piglin
{
    public class Piglin : JavaEntityTexture
    {
        public Piglin() : base("Piglin")
        {
            AddVersion("piglin")
                .WithPath("entity/piglin")
                .WithDefaultModel<Java.Models.Entity.Piglin>();
                //.MapsToBedrockEntity<BedrockEntities.Pig>();
        }
    }
}
