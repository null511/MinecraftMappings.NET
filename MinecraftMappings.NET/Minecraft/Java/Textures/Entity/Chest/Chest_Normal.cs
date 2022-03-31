using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class Chest_Normal : JavaEntityTexture
    {
        public Chest_Normal() : base("Chest, Normal")
        {
            AddVersion("normal")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.Chest>()
                .MapsToBedrockEntity<Bedrock.Models.Entities.ChestNormal>();
        }
    }
}
