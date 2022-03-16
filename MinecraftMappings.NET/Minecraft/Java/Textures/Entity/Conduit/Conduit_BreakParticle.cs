using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Conduit
{
    public class Conduit_BreakParticle : JavaEntityTexture
    {
        public Conduit_BreakParticle() : base("Conduit, Break Particle")
        {
            AddVersion("break_particle")
                .WithPath("entity/conduit");
                //.MapsToBedrockEntity<BedrockEntities.ConduitBreakParticle>();
        }
    }
}
