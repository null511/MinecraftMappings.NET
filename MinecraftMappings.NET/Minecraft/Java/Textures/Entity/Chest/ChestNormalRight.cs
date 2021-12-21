using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class ChestNormalRight : JavaEntityTexture
    {
        public ChestNormalRight() : base("Chest, Normal Right")
        {
            AddVersion("normal_right")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeRight>();
                //.MapsToBedrockEntity<BedrockEntities.ChestNormal>();
        }
    }
}
