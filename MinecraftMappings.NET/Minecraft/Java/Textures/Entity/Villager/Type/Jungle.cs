using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Type
{
    public class Jungle : JavaEntityTexture
    {
        public Jungle() : base("Jungle")
        {
            AddVersion("jungle")
                .WithPath("entity/villager/type")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Jungle>();
        }
    }
}
