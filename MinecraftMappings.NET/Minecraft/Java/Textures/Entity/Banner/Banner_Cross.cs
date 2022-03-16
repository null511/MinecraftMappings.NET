using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Cross : JavaEntityTexture
    {
        public Banner_Cross() : base("Banner, Cross")
        {
            AddVersion("cross")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Cross>();
        }
    }
}
