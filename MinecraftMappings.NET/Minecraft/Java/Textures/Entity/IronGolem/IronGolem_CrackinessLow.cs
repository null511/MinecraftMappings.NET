using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.IronGolem
{
    public class IronGolem_CrackinessLow : JavaEntityTexture
    {
        public IronGolem_CrackinessLow() : base("Iron Golem, Crackiness Low")
        {
            AddVersion("iron_golem_crackiness_low")
                .WithPath("entity/iron_golem")
                .WithBaseLayer<IronGolem>()
                .WithDefaultModel<Java.Models.Entity.IronGolem>();
                //.MapsToBedrockEntity<BedrockEntities.IronGolem_CrackinessLow>();
        }
    }
}
