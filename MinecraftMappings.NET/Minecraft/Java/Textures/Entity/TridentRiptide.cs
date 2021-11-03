using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity
{
    public class TridentRiptide : JavaEntityTexture
    {
        public TridentRiptide() : base("Trident Riptide")
        {
            AddVersion("trident_riptide")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.TridentRiptide>();
                //.MapsToBedrockEntity<BedrockEntities.TridentRiptide>();
        }
    }
}
