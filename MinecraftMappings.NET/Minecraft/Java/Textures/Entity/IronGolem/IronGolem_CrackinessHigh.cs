using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.IronGolem
{
    public class IronGolem_CrackinessHigh : JavaEntityTexture
    {
        public IronGolem_CrackinessHigh() : base("Iron Golem, Crackiness High")
        {
            AddVersion("iron_golem_crackiness_high")
                .WithPath("entity/iron_golem")
                .WithBaseLayer<IronGolem>()
                .WithDefaultModel<Java.Models.Entity.IronGolem>();
                //.MapsToBedrockEntity<BedrockEntities.IronGolem_CrackinessHigh>();
        }
    }
}
