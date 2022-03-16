using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fox
{
    public class Fox_Sleep : JavaEntityTexture
    {
        public Fox_Sleep() : base("Fox, Sleep")
        {
            AddVersion("fox_sleep")
                .WithPath("entity/fox")
                .WithDefaultModel<Java.Models.Entity.Fox>();
                //.MapsToBedrockEntity<BedrockEntities.Fox>();
        }
    }
}
