using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_CurlyBorder : JavaEntityTexture
    {
        public Banner_CurlyBorder() : base("Banner, Curly Border")
        {
            AddVersion("curly_border")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_CurlyBorder>();
        }
    }
}
