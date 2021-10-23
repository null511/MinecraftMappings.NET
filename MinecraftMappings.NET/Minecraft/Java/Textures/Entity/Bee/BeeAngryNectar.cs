using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bee
{
    public class BeeAngryNectar : JavaEntityTexture
    {
        public BeeAngryNectar() : base("Bee, Angry Nectar")
        {
            AddVersion("bee_angry_nectar")
                .WithDefaultModel<Java.Models.Entity.Bee>();
                //.MapsToBedrockEntity<BedrockEntities.BeeAngryNectar>();
        }
    }
}
