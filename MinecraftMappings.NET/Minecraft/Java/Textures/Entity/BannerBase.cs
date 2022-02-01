using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class BannerBase : JavaEntityTexture
    {
        public BannerBase() : base("Banner Base")
        {
            AddVersion("banner_base")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Witch>();
        }
    }
}
