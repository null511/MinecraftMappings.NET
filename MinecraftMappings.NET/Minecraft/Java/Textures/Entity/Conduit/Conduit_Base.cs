using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Conduit
{
    public class Conduit_Base : JavaEntityTexture
    {
        public Conduit_Base() : base("Conduit, Base")
        {
            AddVersion("base")
                .WithPath("entity/conduit")
                .WithDefaultModel<Java.Models.Entity.Conduit>();
                //.MapsToBedrockEntity<BedrockEntities.ConduitBase>();
        }
    }
}
