using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Squid
{
    public class GlowSquid : JavaEntityTexture
    {
        public GlowSquid() : base("Glow Squid")
        {
            AddVersion("glow_squid")
                .WithPath("entity/squid")
                .WithDefaultModel<Java.Models.Entity.Squid>();
                //.MapsToBedrockEntity<BedrockEntities.GlowSquid>();
        }
    }
}
