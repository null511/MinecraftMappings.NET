using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Zombie
{
    public class DrownedOuterLayer : JavaEntityTexture
    {
        public DrownedOuterLayer() : base("Drowned Outer Layer")
        {
            AddVersion("drowned_outer_layer")
                .WithPath("entity/zombie")
                .WithBaseLayer<Drowned>()
                .WithDefaultModel<Java.Models.Entity.Zombie>();
                //.MapsToBedrockEntity<BedrockEntities.Drowned>();
        }
    }
}
