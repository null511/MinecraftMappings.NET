using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.IronGolem
{
    public class IronGolem : JavaEntityTexture
    {
        public IronGolem() : base("Iron Golem")
        {
            AddVersion("iron_golem")
                .WithPath("entity/iron_golem")
                .WithDefaultModel<Java.Models.Entity.IronGolem>();
                //.MapsToBedrockEntity<BedrockEntities.IronGolem>();
        }
    }
}
