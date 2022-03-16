using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Border : JavaEntityTexture
    {
        public Banner_Border() : base("Banner, Border")
        {
            AddVersion("border")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Border>();
        }
    }
}
