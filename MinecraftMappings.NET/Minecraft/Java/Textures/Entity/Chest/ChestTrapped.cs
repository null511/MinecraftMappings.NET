using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class ChestTrapped : JavaEntityTexture
    {
        public ChestTrapped() : base("Chest, Trapped")
        {
            AddVersion("trapped")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.Chest>();
                //.MapsToBedrockEntity<BedrockEntities.ChestTrapped>();
        }
    }
}
