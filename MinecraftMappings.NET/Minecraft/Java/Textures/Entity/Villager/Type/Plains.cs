using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Type
{
    public class Plains : JavaEntityTexture
    {
        public Plains() : base("Plains")
        {
            AddVersion("plains")
                .WithPath("entity/villager/type")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Plains>();
        }
    }
}
