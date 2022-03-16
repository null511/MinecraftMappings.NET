using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Globe : JavaEntityTexture
    {
        public Banner_Globe() : base("Banner, Globe")
        {
            AddVersion("globe")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Globe>();
        }
    }
}
