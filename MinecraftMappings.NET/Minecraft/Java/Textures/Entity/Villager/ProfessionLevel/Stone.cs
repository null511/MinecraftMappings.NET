using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.ProfessionLevel
{
    public class Stone : JavaEntityTexture
    {
        public Stone() : base("Stone")
        {
            AddVersion("stone")
                .WithPath("entity/villager/profession_level")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Stone>();
        }
    }
}
