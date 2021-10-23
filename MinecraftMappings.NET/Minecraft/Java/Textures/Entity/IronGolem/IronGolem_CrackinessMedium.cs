using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.IronGolem
{
    public class IronGolem_CrackinessMedium : JavaEntityTexture
    {
        public IronGolem_CrackinessMedium() : base("Iron Golem, Crackiness Medium")
        {
            AddVersion("iron_golem_crackiness_medium")
                .WithPath("entity/iron_golem")
                .WithBaseLayer<IronGolem>()
                .WithDefaultModel<Java.Models.Entity.IronGolem>();
                //.MapsToBedrockEntity<BedrockEntities.IronGolem_CrackinessMedium>();
        }
    }
}
