using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Boat
{
    public class OakBoat : JavaEntityTexture
    {
        public OakBoat() : base("Oak Boat")
        {
            AddVersion("oak")
                .WithPath("entity/boat")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Entity.Boat>();
                //.MapsToBedrockEntity<BedrockEntities.BirchBoat>();
        }
    }
}
