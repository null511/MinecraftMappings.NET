using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.EnderDragon
{
    public class Dragon_Eyes : JavaEntityTexture
    {
        public Dragon_Eyes() : base("Ender Dragon, Eyes")
        {
            AddVersion("dragon_eyes")
                .WithPath("entity/enderdragon")
                .WithDefaultModel<Java.Models.Entity.Dragon>();
                //.MapsToBedrockEntity<BedrockEntities.Dragon_Eyes>();
        }
    }
}
