using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.ProfessionLevel
{
    public class Iron : JavaEntityTexture
    {
        public Iron() : base("Iron")
        {
            AddVersion("iron")
                .WithPath("entity/villager/profession_level")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Iron>();
        }
    }
}
