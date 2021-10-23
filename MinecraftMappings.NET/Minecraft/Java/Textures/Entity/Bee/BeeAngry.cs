using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bee
{
    public class BeeAngry : JavaEntityTexture
    {
        public BeeAngry() : base("Bee, Angry")
        {
            AddVersion("bee_angry")
                .WithDefaultModel<Java.Models.Entity.Bee>();
                //.MapsToBedrockEntity<BedrockEntities.BeeAngry>();
        }
    }
}
