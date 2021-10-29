using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.ProfessionLevel
{
    public class Gold : JavaEntityTexture
    {
        public Gold() : base("Gold")
        {
            AddVersion("gold")
                .WithPath("entity/villager/profession_level")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Gold>();
        }
    }
}
