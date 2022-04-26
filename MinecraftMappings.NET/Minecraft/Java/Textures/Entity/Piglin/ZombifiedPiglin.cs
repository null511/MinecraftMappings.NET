using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Piglin
{
    public class ZombifiedPiglin : JavaEntityTexture
    {
        public ZombifiedPiglin() : base("Zombified Piglin")
        {
            AddVersion("zombified_piglin")
                .WithPath("entity/piglin");
                //.WithDefaultModel<Java.Models.Entity.ZombifiedPiglin>();
                //.MapsToBedrockEntity<BedrockEntities.Pig>();
        }
    }
}
