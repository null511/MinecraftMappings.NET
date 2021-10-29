using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Type
{
    public class Taiga : JavaEntityTexture
    {
        public Taiga() : base("Taiga")
        {
            AddVersion("taiga")
                .WithPath("entity/villager/type")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Taiga>();
        }
    }
}
