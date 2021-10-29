using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Squid
{
    public class Squid : JavaEntityTexture
    {
        public Squid() : base("Squid")
        {
            AddVersion("squid")
                .WithPath("entity/squid")
                .WithDefaultModel<Java.Models.Entity.Squid>();
                //.MapsToBedrockEntity<BedrockEntities.Squid>();
        }
    }
}
