using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Conduit
{
    public class Conduit_ClosedEye : JavaEntityTexture
    {
        public Conduit_ClosedEye() : base("Conduit, Closed Eye")
        {
            AddVersion("closed_eye")
                .WithPath("entity/conduit")
                .WithDefaultModel<Java.Models.Entity.Conduit>();
                //.MapsToBedrockEntity<BedrockEntities.ConduitClosedEye>();
        }
    }
}
