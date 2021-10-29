using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Type
{
    public class Desert : JavaEntityTexture
    {
        public Desert() : base("Desert")
        {
            AddVersion("desert")
                .WithPath("entity/villager/type")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Desert>();
        }
    }
}
