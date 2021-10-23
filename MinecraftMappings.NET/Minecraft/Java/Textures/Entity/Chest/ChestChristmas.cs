using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class ChestChristmas : JavaEntityTexture
    {
        public ChestChristmas() : base("Chest, Christmas")
        {
            AddVersion("christmas")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.Chest>();
                //.MapsToBedrockEntity<BedrockEntities.ChestChristmas>();
        }
    }
}
