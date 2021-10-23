using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Boat
{
    public class AcaciaBoat : JavaEntityTexture
    {
        public AcaciaBoat() : base("Acacia Boat")
        {
            AddVersion("acacia")
                .WithPath("entity/boat")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Entity.Boat>();
                //.MapsToBedrockEntity<BedrockEntities.AcaciaBoat>();
        }
    }
}
