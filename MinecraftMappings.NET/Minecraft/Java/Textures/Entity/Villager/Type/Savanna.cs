using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Type
{
    public class Savanna : JavaEntityTexture
    {
        public Savanna() : base("Savanna")
        {
            AddVersion("savanna")
                .WithPath("entity/villager/type")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Savanna>();
        }
    }
}
