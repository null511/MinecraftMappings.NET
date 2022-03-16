using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Banner
{
    public class Banner_Flower : JavaEntityTexture
    {
        public Banner_Flower() : base("Banner, Flower")
        {
            AddVersion("flower")
                .WithPath("entity/banner")
                .WithDefaultModel<Java.Models.Entity.Banner>();
                //.MapsToBedrockEntity<BedrockEntities.Banner_Flower>();
        }
    }
}
