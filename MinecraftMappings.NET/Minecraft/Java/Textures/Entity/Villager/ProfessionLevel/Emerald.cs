using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.ProfessionLevel
{
    public class Emerald : JavaEntityTexture
    {
        public Emerald() : base("Emerald")
        {
            AddVersion("emerald")
                .WithPath("entity/villager/profession_level")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Emerald>();
        }
    }
}
