using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Profession
{
    public class Mason : JavaEntityTexture
    {
        public Mason() : base("Mason")
        {
            AddVersion("mason")
                .WithPath("entity/villager/profession")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Mason>();
        }
    }
}
