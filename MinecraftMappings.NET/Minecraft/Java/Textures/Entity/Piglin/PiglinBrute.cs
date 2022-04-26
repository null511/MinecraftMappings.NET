using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Piglin
{
    public class PiglinBrute : JavaEntityTexture
    {
        public PiglinBrute() : base("Piglin Brute")
        {
            AddVersion("piglin_brute")
                .WithPath("entity/piglin");
                //.WithDefaultModel<Java.Models.Entity.PiglinBrute>();
                //.MapsToBedrockEntity<BedrockEntities.Pig>();
        }
    }
}
