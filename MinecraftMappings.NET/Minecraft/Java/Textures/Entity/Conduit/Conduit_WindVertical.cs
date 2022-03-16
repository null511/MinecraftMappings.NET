using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Conduit
{
    public class Conduit_WindVertical : JavaEntityTexture
    {
        public Conduit_WindVertical() : base("Conduit, Vertical Wind")
        {
            AddVersion("wind_vertical")
                .WithPath("entity/conduit")
                .WithDefaultModel<Java.Models.Entity.Conduit>();
                //.MapsToBedrockEntity<BedrockEntities.ConduitWind_Vertical>();
        }
    }
}
