using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class Chest_NormalRight : JavaEntityTexture
    {
        public Chest_NormalRight() : base("Chest, Normal Right")
        {
            AddVersion("normal_right")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.ChestLargeLeft>();
                //.MapsToBedrockEntity<BedrockEntities.ChestNormal>();
        }
    }
}
