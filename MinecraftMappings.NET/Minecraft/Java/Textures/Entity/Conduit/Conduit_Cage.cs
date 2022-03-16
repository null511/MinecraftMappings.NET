using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Conduit
{
    public class Conduit_Cage : JavaEntityTexture
    {
        public Conduit_Cage() : base("Conduit, Cage")
        {
            AddVersion("cage")
                .WithPath("entity/conduit")
                .WithDefaultModel<Java.Models.Entity.Conduit>();
                //.MapsToBedrockEntity<BedrockEntities.ConduitCage>();
        }
    }
}
