using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class ChestNormal : JavaEntityTexture
    {
        public ChestNormal() : base("Chest, Normal")
        {
            AddVersion("normal")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.Chest>();
                //.MapsToBedrockEntity<BedrockEntities.ChestNormal>();
        }
    }
}
