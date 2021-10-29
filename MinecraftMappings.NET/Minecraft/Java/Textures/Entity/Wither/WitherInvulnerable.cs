using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Wither
{
    public class WitherInvulnerable : JavaEntityTexture
    {
        public WitherInvulnerable() : base("Wither Invulnerable")
        {
            AddVersion("wither_invulnerable")
                .WithBaseLayer<Wither>()
                .WithDefaultModel<Java.Models.Entity.Wither>();
                //.MapsToBedrockEntity<BedrockEntities.WitherInvulnerable>();
        }
    }
}
