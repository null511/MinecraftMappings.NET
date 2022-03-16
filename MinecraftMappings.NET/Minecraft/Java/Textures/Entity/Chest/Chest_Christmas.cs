using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Chest
{
    public class Chest_Christmas : JavaEntityTexture
    {
        public Chest_Christmas() : base("Chest, Christmas")
        {
            AddVersion("christmas")
                .WithPath("entity/chest")
                .WithDefaultModel<Java.Models.Entity.Chest>();
                //.MapsToBedrockEntity<BedrockEntities.ChestChristmas>();
        }
    }
}
