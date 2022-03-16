using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Conduit
{
    public class Conduit_OpenEye : JavaEntityTexture
    {
        public Conduit_OpenEye() : base("Conduit, Open Eye")
        {
            AddVersion("open_eye")
                .WithPath("entity/conduit")
                .WithDefaultModel<Java.Models.Entity.Conduit>();
                //.MapsToBedrockEntity<BedrockEntities.ConduitOpenEye>();
        }
    }
}
