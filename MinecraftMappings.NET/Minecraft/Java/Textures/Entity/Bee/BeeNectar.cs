using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bee
{
    public class BeeNectar : JavaEntityTexture
    {
        public BeeNectar() : base("Bee, Nectar")
        {
            AddVersion("bee_nectar")
                .WithDefaultModel<Java.Models.Entity.Bee>();
                //.MapsToBedrockEntity<BedrockEntities.BeeNectar>();
        }
    }
}
